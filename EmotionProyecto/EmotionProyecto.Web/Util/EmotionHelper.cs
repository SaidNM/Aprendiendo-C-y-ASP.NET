using EmotionProyecto.Web.Models;
using Microsoft.ProjectOxford.Common.Contract;
using Microsoft.ProjectOxford.Emotion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace EmotionProyecto.Web.Util
{
    public class EmotionHelper
    {
        public EmotionServiceClient emoClient;

        public EmotionHelper(string key)
        {
            emoClient = new EmotionServiceClient(key);     
        }
        public async Task<EmoPicture> DetectAndExtracFacesAsync(Stream imageStream) {
            Emotion[] emotions =await emoClient.RecognizeAsync(imageStream);
            EmoPicture emoPicture = new EmoPicture();
            emoPicture.Faces = ExtractFaces(emotions,emoPicture);

            return emoPicture;
        }

        private ObservableCollection<EmoFace> ExtractFaces(Emotion[] emotions,EmoPicture emoPicture)
        {
           
            var listaFaces = new ObservableCollection<EmoFace>();
            foreach (var emotion in emotions)
            { 
                var emoFace = new EmoFace(){
                    X = emotion.FaceRectangle.Left,
                    Y = emotion.FaceRectangle.Top,
                    Width = emotion.FaceRectangle.Width,
                    Height = emotion.FaceRectangle.Height,
                    Picture = emoPicture
                };
                emoFace.EmoEmotions = ProcessEmotions(emotion.Scores,emoFace);
                listaFaces.Add(emoFace);
            }
            return listaFaces;
        }

        private ObservableCollection<EmoEmotion> ProcessEmotions(EmotionScores scores,EmoFace emoFace)
        {
            var emotype = EmoEmotionEnum.Undetermined;
            var emotionList = new ObservableCollection<EmoEmotion>();
            var properties = scores.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
            var filterProperties = properties.Where(p => p.PropertyType == typeof(float));
            foreach (var prop in filterProperties)
            {
                if (!Enum.TryParse<EmoEmotionEnum>(prop.Name, out emotype))
                    emotype = EmoEmotionEnum.Undetermined;
                
                var emoEmotion = new EmoEmotion();
                emoEmotion.Score = (float)prop.GetValue(scores);
                emoEmotion.EmotionType = emotype;
                emoEmotion.Face = emoFace;
                emotionList.Add(emoEmotion);
            }
            return emotionList;
        }
    }
}