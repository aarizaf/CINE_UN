using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class CentroPago : Form
    {
        string tarjeta_val;
        public string RutaArchivo { get; set; }
        public CentroPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNumr.Text == "")
                {

                    MessageBox.Show("Digita tus credenciales");

                }
                else
                {

                    tarjeta_val = textBoxNumr.Text;
                    StreamReader leer;
                    leer = File.OpenText("datosclientes.txt");
                    string cadena;
                    string[] arreglo = new string[1];
                    char[] separador = { '-' };
                    bool autorizado = false;
                    cadena = leer.ReadLine();
                    while (cadena != null && autorizado == false)
                    {
                        arreglo = cadena.Split(separador);
                        if (arreglo[2].Trim().Equals(tarjeta_val))
                        {
                            MessageBox.Show("Compra realizada");

                            autorizado = true;

                        }
                        else
                        {
                            cadena = leer.ReadLine();

                        }



                    }
                    if (autorizado == false)
                    {
                        MessageBox.Show("Tarjeta incorrecta");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error);

            }


        }

        private void CentroPago_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
