using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmotionProyecto.Web.Models
{
    public class EmoPicture
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Path { get; set; }

        // Estos son los detalles
        public virtual  ObservableCollection<EmoFace> Faces { get; set; } //dice que no es un atributo solo un elemento necesario
    }
}