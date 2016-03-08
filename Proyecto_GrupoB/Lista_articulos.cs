using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_GrupoB
{
    class Lista_articulos
    {
        public static List<Clase_artitulo> Listado = new List<Clase_artitulo>();


        public static void Agregar_nuevo (Clase_artitulo temporal)
        {
            StreamWriter file_articulos = new StreamWriter(@"../../Listadecompras.txt", true);

            Listado.Add(temporal);


            file_articulos.WriteLine(temporal.codigo_barras);
            file_articulos.WriteLine(temporal.descripcion);
            file_articulos.WriteLine(temporal.clasificacion);
            file_articulos.WriteLine(temporal.unidad_medida);
            file_articulos.WriteLine(temporal.tamaño);
            file_articulos.WriteLine(temporal.precio);
            file_articulos.WriteLine(temporal.fecha_vencimiento);
            file_articulos.WriteLine(temporal.refrigeracion);
            file_articulos.WriteLine(temporal.candidad_existencia);

            file_articulos.Close();
        }




    }
}
