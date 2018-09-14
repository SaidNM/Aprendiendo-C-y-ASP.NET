
$(document).ready(function () {

    vaciarTabla();
    var datos = {
        tipo: 1
    }
    //peticion_llenar_ASCDESC_PAR(1, 1);


    document.getElementById("btnAscendente").onclick = function () {
        var parametro = $('input:radio[name=radios]:checked').val();
        peticion_llenar_ASCDESC_PAR(parametro, 1)
    };
    document.getElementById("btnDescencente").onclick = function () {
        var parametro = $('input:radio[name=radios]:checked').val();
        peticion_llenar_ASCDESC_PAR(parametro, 0)
    };

});

function peticion_llenar_ASCDESC_PAR(parametro,orden) {
    vaciarTabla();
    var datosEnviar = {
        tipo: parametro,
        ord : orden
    }
    $.ajax({
        url: '/PortalWebMethods.asmx/cargarTodo',
        data: datosEnviar,
        contentType: "application/json",
        type: 'GET',
        dataType: 'json',
        success: function (filas) {
            // Crea las celdas
            var arreglo = filas['d'];
            for (var i in arreglo) {
                // Crea las hileras de la tabla

                var fila = document.createElement("tr");
                var datos = filas['d'][i].split(",");

                for (var j in datos) {
                    // Crea un elemento <td> y un nodo de texto, haz que el nodo de
                    // texto sea el contenido de <td>, ubica el elemento <td> al final
                    // de la hilera de la tabla
                    var celda = document.createElement("td");
                    var textoCelda = document.createTextNode(datos[j]);
                    celda.appendChild(textoCelda);
                    fila.appendChild(celda);
                }
                var tblBody = document.getElementById("ResultadoProductos");
                // agrega la hilera al final de la tabla (al final del elemento tblbody)
                tblBody.appendChild(fila);
            }
        },
        error: function (xhr, status) {
            alert('Disculpe, existió un problema');
        }
    });
}




function peticion_llenar(datosEnviar) {
    $.ajax({
        url: '/PortalWebMethods.asmx/cargarTodo',
        data: datosEnviar,
        contentType: "application/json",
        type: 'GET',
        dataType: 'json',
        success: function (filas) {
            // Crea las celdas
            console.log(filas);
            var arreglo = filas['d'];
            console.log(arreglo);
            for (var i in arreglo) {
                // Crea las hileras de la tabla
                
                var fila = document.createElement("tr");
                var datos = filas['d'][i].split(",");
               
                for (var j in datos) {
                    console.log(j)
                    // Crea un elemento <td> y un nodo de texto, haz que el nodo de
                    // texto sea el contenido de <td>, ubica el elemento <td> al final
                    // de la hilera de la tabla
                    var celda = document.createElement("td");
                    var textoCelda = document.createTextNode(datos[j]);
                    celda.appendChild(textoCelda);
                    fila.appendChild(celda);
                }
                var tblBody = document.getElementById("ResultadoProductos");
                // agrega la hilera al final de la tabla (al final del elemento tblbody)
                tblBody.appendChild(fila);
            }
        },
        error: function (xhr, status) {
            alert('Disculpe, existió un problema');
        }
    });


}