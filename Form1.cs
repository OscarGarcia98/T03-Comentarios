using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrica
{
    public partial class FrmFiguras : Form
    {
        public FrmFiguras()
        {
            InitializeComponent();
        }

        public void BtnIngresar_Click(object sender, EventArgs e)       //Todo lo que esté dentro de este bloque de código se ejecuta al momento de presionar
                                                                        //El botón "Ingresar"
        {
            Figura f = new Figura
            {
                Lado1 = double.Parse(txtLado1.Text),        //El editor me recomendó esta simplificación para asignar valores a las variables
                Lado2 = double.Parse(txtLado2.Text)
            };

            Bienvenida();
            double Area = Calcular(f);
            lblArea.Text = Area.ToString();     //Muestro el resultado en el label "Area"
           
        }

        public void Bienvenida()        //Método para mostrar un mensaje de bienvenida al usuario cada que ejecute el botón "Ingresar"
        {
            MessageBox.Show("Bienvenido a mi programa");
        }

        public double Calcular(Figura Object)       //Método que retorna el resultado de la operación 
        {
            return Object.Lado1 * Object.Lado2;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();       //con este método termina la ejecución del programa mediante ESC, o presionando el botón "Salir"
        }
    }
}
