using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_GrupoB
{
    public partial class Agregar_articulo : Form
    {
        public Agregar_articulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase_artitulo temporal = new Clase_artitulo();

            if (txtCodigo.Text == "")
            {
                mensaje("Codigo Vacio");
                return;
            }
            else
                try
                {
                    temporal.codigo_barras = int.Parse(txtCodigo.Text);
                }
                catch
                {
                    mensaje("Codigo solo puede contener numeros");
                    return;
                }


            if (txtDescipcion.Text == "")
            {
                mensaje("Descipcion Vacia");
                return;
            }
            else
                temporal.descripcion = txtDescipcion.Text;

            if (cmbClasificacion.Text == "")
            {
                mensaje("Seleccione la clasificacion");
                return;
            }
            else
                temporal.clasificacion = cmbClasificacion.Text;


            if (cmbMedida.Text == "")
            {
                mensaje("Seleccione la  medida");
                return;
            }
            else
                temporal.unidad_medida = cmbMedida.Text;

            if (txtTamaño.Text == "")
            {
                mensaje("Defina el tamaño");
                return;
            }
            else
                temporal.tamaño = txtTamaño.Text;


            if (txtPrecio.Text == "")
            {
                mensaje("Precio vacio");
                return;
            }
            else
                try
                {
                    temporal.precio = int.Parse(txtPrecio.Text);
                }
                catch
                {
                    mensaje("El precio es numerico");
                    return;
                }


            if ((txtFechaDia.Text == "") || (txtFechaMes.Text == "") || (txtFechaAño.Text == ""))
            {
                mensaje("Campos de la fecha vacios");
                return;
            }
            else
                try
                {
                    if (int.Parse(txtFechaMes.Text) > 12)
                    {
                        mensaje("Mes invalido");
                        return;
                    }

                    if (((int.Parse(txtFechaDia.Text) % 4) == 0) && (int.Parse(txtFechaMes.Text) == 2) && (int.Parse(txtFechaDia.Text) > 29))
                    {
                        mensaje("Dia invalido");
                        return;
                    }

                    if (((int.Parse(txtFechaDia.Text) % 4) != 0) && (int.Parse(txtFechaMes.Text) == 2) && (int.Parse(txtFechaDia.Text) > 28))
                    {
                        mensaje("Dia invalido");
                        return;
                    }

                    if ((int.Parse(txtFechaMes.Text) == 1 || int.Parse(txtFechaMes.Text) == 3 || int.Parse(txtFechaMes.Text) == 5 || int.Parse(txtFechaMes.Text) == 7 
                        || int.Parse(txtFechaMes.Text) == 8 || int.Parse(txtFechaMes.Text) == 10 ||int.Parse(txtFechaMes.Text) == 12) && int.Parse(txtFechaDia.Text) > 31)
                    {
                        mensaje("Dia invalido");
                        return;
                    }

                    if ((int.Parse(txtFechaMes.Text) == 4 || int.Parse(txtFechaMes.Text) == 6 || int.Parse(txtFechaMes.Text) == 9 
                        || int.Parse(txtFechaMes.Text) == 11) && int.Parse(txtFechaDia.Text) > 30)
                    {
                        mensaje("Dia invalido");
                        return;
                    }

                    temporal.fecha_vencimiento = txtFechaDia.Text+"/"+txtFechaMes.Text+"/"+txtFechaAño.Text;
                }
                catch
                {
                    mensaje("La fecha es numerica");
                    return;
                }



            if (chkRefrigeracion.Checked)
                temporal.refrigeracion = true;
            else
                temporal.refrigeracion = false;


            if (txtCandidad.Text == "")
            {
                mensaje("Cantidad Vacia");
                return;
            }
            else
                try
                {
                    temporal.candidad_existencia = int.Parse(txtCandidad.Text);
                }
                catch
                {
                    mensaje("La cantidad es numerica");
                    return;
                }


            Lista_articulos.Agregar_nuevo(temporal);

            Close();
        }

        private void mensaje(String texto)
        {
            MessageBox.Show(texto, "Error");
        }
    }
}
