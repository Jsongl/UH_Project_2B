using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GrupoB
{
    class Clase_artitulo
    {
        public int codigo_barras;
        public String descripcion;
        public String clasificacion; //abarrotes, frescos, limpieza, hogar, otros
        public String unidad_medida; //kg, grm, unidades, litro
        public string tamaño;
        public double precio;
        public String fecha_vencimiento; //MM/dd/aaaa
        public Boolean refrigeracion;
        public int candidad_existencia;
    }
}
