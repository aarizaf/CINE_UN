using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cine
{
    public partial class Reservas : Form
    {
        string sillas;
        List<string> list = new List<string>();
        ArchivoSalas filexd = new ArchivoSalas();
        Form4 form4 = new Form4();
        private string[] vectorsillas;
        private string[] vectorData;
        public Reservas(string[] vector, string[] vector2, string precio, string nombre, Image imagen)
        {
            InitializeComponent();
            this.vectorsillas = vector;
            this.vectorData = vector2;
            Precios.Text = precio;
            //peliG.Text = nombre;
            //label10.Text = this.vectorData[2];
          
            RandomPicture.Image = imagen;
            showcolors();

        }

        
        private void CONTINUAR_Click(object sender, EventArgs e)
        {
            cafeteria formulario = new cafeteria(peliG.Text, textBox1.Text, total.Text);
            formulario.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);

            if (count < 9)
            {
                count = count + 1;
                textBox1.Text = count.ToString();
                int total1 = int.Parse(Precios.Text) * count;
                total.Text = total1.ToString();
            }

            if (count == 0)
            {
                CONTINUAR.Enabled = false;
            }
            else
            {
                CONTINUAR.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);

            if (count > 0)
            {
                count = count - 1;
                textBox1.Text = count.ToString();
                int total1 = int.Parse(Precios.Text);
                int total2 = int.Parse(total.Text) - total1;
                total.Text = total2.ToString();
            }

            if (count == 0)
            {
                CONTINUAR.Enabled = false;
            }
            else
            {
                CONTINUAR.Enabled = true;
            }
        }


        private void button2A_Click(object sender, EventArgs e)
        {

            if (Int32.Parse(this.vectorsillas[1]) == 0)
            {
                vectorsillas[1] = "1";
                btn2A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[1]) == 1)
                {
                    vectorsillas[1] = "0";
                    btn2A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    btn2A.BackColor = Color.Green;
                }
            }

        }



    



    private void label1_Click(object sender, EventArgs e)
        {
           
           
            }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1A_Click(object sender, EventArgs e)
        {
           
            if (Int32.Parse(this.vectorsillas[0]) == 0)
            {
                vectorsillas[0] = "1";
                btn1A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[0]) == 1)
                {
                    vectorsillas[0] = "0";
                    btn1A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    btn1A.BackColor = Color.Green;
                }
            }

        }

        




        private void button4_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
               

        }

        private void Reservas_Load(object sender, EventArgs e)
        {
           

        }

        private void button65_Click(object sender, EventArgs e)
        {
           
        }
        

       

       

        private void button3A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[2]) == 0)
            {
                vectorsillas[2] = "1";
                button3A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[2]) == 1)
                {
                    vectorsillas[2] = "0";
                    button3A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button3A.BackColor = Color.Green;
                }
            }
        }

        private void button4A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[3]) == 0)
            {
                vectorsillas[3] = "1";
                button4A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[3]) == 1)
                {
                    vectorsillas[3] = "0";
                    button4A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button4A.BackColor = Color.Green;
                }
            }
        }

        private void button5A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[4]) == 0)
            {
                vectorsillas[4] = "1";
                button5A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[4]) == 1)
                {
                    vectorsillas[4] = "0";
                    button5A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button5A.BackColor = Color.Green;
                }
            }
        }

        private void button6A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[5]) == 0)
            {
                vectorsillas[5] = "1";
                button6A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[5]) == 1)
                {
                    vectorsillas[5] = "0";
                    button6A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button6A.BackColor = Color.Green;
                }
            }
        }

        private void button7A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[6]) == 0)
            {
                vectorsillas[6] = "1";
                button7A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[6]) == 1)
                {
                    vectorsillas[6] = "0";
                    button7A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button7A.BackColor = Color.Green;
                }
            }
        }

        private void button8A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[7]) == 0)
            {
                vectorsillas[7] = "1";
                button8A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[7]) == 1)
                {
                    vectorsillas[7] = "0";
                    button8A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button8A.BackColor = Color.Green;
                }
            }
        }
        private void showcolors()
        {
            if (Int32.Parse(this.vectorsillas[0]) == 0)
            {
                btn1A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[0]) == 1)
                {
                    btn1A.BackColor = Color.Red;
                }
                else
                {
                    btn1A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[1]) == 0)
            {
                btn2A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[1]) == 1)
                {
                    btn2A.BackColor = Color.Red;
                }
                else
                {
                    btn2A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[2]) == 0)
            {
                button3A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[2]) == 1)
                {
                    button3A.BackColor = Color.Red;
                }
                else
                {
                    button3A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[3]) == 0)
            {
                button4A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[3]) == 1)
                {
                    button4A.BackColor = Color.Red;
                }
                else
                {
                    button4A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[4]) == 0)
            {
                button5A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[4]) == 1)
                {
                    button5A.BackColor = Color.Red;
                }
                else
                {
                    button5A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[5]) == 0)
            {
                button6A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[5]) == 1)
                {
                    button6A.BackColor = Color.Red;
                }
                else
                {
                    button6A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[6]) == 0)
            {
                button7A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[6]) == 1)
                {
                    button7A.BackColor = Color.Red;
                }
                else
                {
                    button7A.BackColor = Color.Green;
                }

            }

            if (Int32.Parse(this.vectorsillas[7]) == 0)
            {
                button8A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[7]) == 1)
                {
                    button8A.BackColor = Color.Red;
                }
                else
                {
                    button8A.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[8]) == 0)
            {
                button9A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[8]) == 1)
                {
                    button9A.BackColor = Color.Red;
                }
                else
                {
                    button9A.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[9]) == 0)
            {
                button10A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[9]) == 1)
                {
                    button10A.BackColor = Color.Red;
                }
                else
                {
                    button10A.BackColor = Color.Green;
                }
            }

            if (Int32.Parse(this.vectorsillas[10]) == 0)
            {
                button11A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[10]) == 1)
                {
                    button11A.BackColor = Color.Red;
                }
                else
                {
                    button11A.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[11]) == 0)
            {
                button12A.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[11]) == 1)
                {
                    button12A.BackColor = Color.Red;
                }
                else
                {
                    button12A.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[12]) == 0)
            {
                button1B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[12]) == 1)
                {
                    button1B.BackColor = Color.Red;
                }
                else
                {
                    button1B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[13]) == 0)
            {
                button2B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[13]) == 1)
                {
                    button2B.BackColor = Color.Red;
                }
                else
                {
                    button2B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[14]) == 0)
            {
                button3B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[14]) == 1)
                {
                    button3B.BackColor = Color.Red;
                }
                else
                {
                    button3B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[15]) == 0)
            {
                button4B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[15]) == 1)
                {
                    button4B.BackColor = Color.Red;
                }
                else
                {
                    button4B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[16]) == 0)
            {
                button5B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[16]) == 1)
                {
                    button5B.BackColor = Color.Red;
                }
                else
                {
                    button5B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[17]) == 0)
            {
                button6B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[17]) == 1)
                {
                    button6B.BackColor = Color.Red;
                }
                else
                {
                    button6B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[18]) == 0)
            {
                button7B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[18]) == 1)
                {
                    button7B.BackColor = Color.Red;
                }
                else
                {
                    button7B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[19]) == 0)
            {
                button8B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[19]) == 1)
                {
                    button8B.BackColor = Color.Red;
                }
                else
                {
                    button8B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[20]) == 0)
            {
                button9B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[20]) == 1)
                {
                    button9B.BackColor = Color.Red;
                }
                else
                {
                    button9B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[21]) == 0)
            {
                button10B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[21]) == 1)
                {
                    button10B.BackColor = Color.Red;
                }
                else
                {
                    button10B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[22]) == 0)
            {
                button11B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[22]) == 1)
                {
                    button11B.BackColor = Color.Red;
                }
                else
                {
                    button11B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[23]) == 0)
            {
                button12B.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[23]) == 1)
                {
                    button12B.BackColor = Color.Red;
                }
                else
                {
                    button12B.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[24]) == 0)
            {
                button1C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[24]) == 1)
                {
                    button1C.BackColor = Color.Red;
                }
                else
                {
                    button1C.BackColor = Color.Green;
                }
            }
            if (Int32.Parse(this.vectorsillas[25]) == 0)
            {
                button2C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[25]) == 1)
                {
                    button2C.BackColor = Color.Red;
                }
                else
                {
                    button2C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[26]) == 0)
            {
                button3C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[26]) == 1)
                {
                    button3C.BackColor = Color.Red;
                }
                else
                {
                    button3C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[27]) == 0)
            {
                button4C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[27]) == 1)
                {
                    button4C.BackColor = Color.Red;
                }
                else
                {
                    button4C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[28]) == 0)
            {
                button5C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[28]) == 1)
                {
                    button5C.BackColor = Color.Red;
                }
                else
                {
                    button5C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[29]) == 0)
            {
                button6C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[29]) == 1)
                {
                    button6C.BackColor = Color.Red;
                }
                else
                {
                    button6C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[30]) == 0)
            {
                button7C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[30]) == 1)
                {
                    button7C.BackColor = Color.Red;
                }
                else
                {
                    button7C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[31]) == 0)
            {
                button8C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[31]) == 1)
                {
                    button8C.BackColor = Color.Red;
                }
                else
                {
                    button8C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[32]) == 0)
            {
                button9C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[32]) == 1)
                {
                    button9C.BackColor = Color.Red;
                }
                else
                {
                    button9C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[33]) == 0)
            {
                button10C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[33]) == 1)
                {
                    button10C.BackColor = Color.Red;
                }
                else
                {
                    button10C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[34]) == 0)
            {
                button11C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[34]) == 1)
                {
                    button11C.BackColor = Color.Red;
                }
                else
                {
                    button11C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[35]) == 0)
            {
                button12C.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[35]) == 1)
                {
                    button12C.BackColor = Color.Red;
                }
                else
                {
                    button12C.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[36]) == 0)
            {
                button1D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[36]) == 1)
                {
                    button1D.BackColor = Color.Red;
                }
                else
                {
                    button1D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[37]) == 0)
            {
                button2D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[37]) == 1)
                {
                    button2D.BackColor = Color.Red;
                }
                else
                {
                    button2D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[38]) == 0)
            {
                button3D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[38]) == 1)
                {
                    button3D.BackColor = Color.Red;
                }
                else
                {
                    button3D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[39]) == 0)
            {
                button4D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[39]) == 1)
                {
                    button4D.BackColor = Color.Red;
                }
                else
                {
                    button4D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[40]) == 0)
            {
                button5D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[40]) == 1)
                {
                    button5D.BackColor = Color.Red;
                }
                else
                {
                    button5D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[41]) == 0)
            {
                button6D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[41]) == 1)
                {
                    button6D.BackColor = Color.Red;
                }
                else
                {
                    button6D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[42]) == 0)
            {
                button7D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[42]) == 1)
                {
                    button7D.BackColor = Color.Red;
                }
                else
                {
                    button7D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[43]) == 0)
            {
                button8D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[43]) == 1)
                {
                    button8D.BackColor = Color.Red;
                }
                else
                {
                    button8D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[44]) == 0)
            {
                button9D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[44]) == 1)
                {
                    button9D.BackColor = Color.Red;
                }
                else
                {
                    button9D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[45]) == 0)
            {
                button10D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[45]) == 1)
                {
                    button10D.BackColor = Color.Red;
                }
                else
                {
                    button10D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[46]) == 0)
            {
                button11D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[46]) == 1)
                {
                    button11D.BackColor = Color.Red;
                }
                else
                {
                    button11D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[47]) == 0)
            {
                button12D.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[47]) == 1)
                {
                    button12D.BackColor = Color.Red;
                }
                else
                {
                    button12D.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[48]) == 0)
            {
                buttonE1.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[48]) == 1)
                {
                    buttonE1.BackColor = Color.Red;
                }
                else
                {
                    buttonE1.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[49]) == 0)
            {
                buttonE2.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[49]) == 1)
                {
                    buttonE2.BackColor = Color.Red;
                }
                else
                {
                    buttonE2.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[50]) == 0)
            {
                buttonE3.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[50]) == 1)
                {
                    buttonE3.BackColor = Color.Red;
                }
                else
                {
                    buttonE3.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[51]) == 0)
            {
                buttonE4.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[51]) == 1)
                {
                    buttonE4.BackColor = Color.Red;
                }
                else
                {
                    buttonE4.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[52]) == 0)
            {
                buttonE5.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[52]) == 1)
                {
                    buttonE5.BackColor = Color.Red;
                }
                else
                {
                    buttonE5.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[53]) == 0)
            {
                buttonE6.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[53]) == 1)
                {
                    buttonE6.BackColor = Color.Red;
                }
                else
                {
                    buttonE6.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[54]) == 0)
            {
                buttonE7.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[54]) == 1)
                {
                    buttonE7.BackColor = Color.Red;
                }
                else
                {
                    buttonE7.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[55]) == 0)
            {
                buttonE8.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[55]) == 1)
                {
                    buttonE8.BackColor = Color.Red;
                }
                else
                {
                    buttonE8.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[56]) == 0)
            {
                buttonE9.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[56]) == 1)
                {
                    buttonE9.BackColor = Color.Red;
                }
                else
                {
                    buttonE9.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[57]) == 0)
            {
                buttonE10.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[57]) == 1)
                {
                    buttonE10.BackColor = Color.Red;
                }
                else
                {
                    buttonE10.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[58]) == 0)
            {
                buttonE11.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[58]) == 1)
                {
                    buttonE11.BackColor = Color.Red;
                }
                else
                {
                    buttonE11.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[59]) == 0)
            {
                button1F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[59]) == 1)
                {
                    button1F.BackColor = Color.Red;
                }
                else
                {
                    button1F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[60]) == 0)
            {
                button2F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[60]) == 1)
                {
                    button2F.BackColor = Color.Red;
                }
                else
                {
                    button2F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[61]) == 0)
            {
                button3F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[61]) == 1)
                {
                    button3F.BackColor = Color.Red;
                }
                else
                {
                    button3F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[62]) == 0)
            {
                button4F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[62]) == 1)
                {
                    button4F.BackColor = Color.Red;
                }
                else
                {
                    button4F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[63]) == 0)
            {
                button5F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[63]) == 1)
                {
                    button5F.BackColor = Color.Red;
                }
                else
                {
                    button5F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[64]) == 0)
            {
                button6F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[64]) == 1)
                {
                    button6F.BackColor = Color.Red;
                }
                else
                {
                    button6F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[65]) == 0)
            {
                button7F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[65]) == 1)
                {
                    button7F.BackColor = Color.Red;
                }
                else
                {
                    button7F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[66]) == 0)
            {
                button8F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[66]) == 1)
                {
                    button8F.BackColor = Color.Red;
                }
                else
                {
                    button8F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[67]) == 0)
            {
                button9F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[67]) == 1)
                {
                    button9F.BackColor = Color.Red;
                }
                else
                {
                    button9F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[68]) == 0)
            {
                button10F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[68]) == 1)
                {
                    button10F.BackColor = Color.Red;
                }
                else
                {
                    button10F.BackColor = Color.Green;
                }

            }
            if (Int32.Parse(this.vectorsillas[69]) == 0)
            {
                button11F.BackColor = Color.White;
            }
            else
            {
                if (Int32.Parse(this.vectorsillas[69]) == 1)
                {
                    button11F.BackColor = Color.Red;
                }
                else
                {
                    button11F.BackColor = Color.Green;
                }

            }

        }



            private void buttonGuardar_Click_1(object sender, EventArgs e)
         {
            string filepath = "prueba2.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            int sw2 = 0;
            int i = 0;
            string var = "";
            

            while (i < lines.Count && sw2 == 0)
            {
                var = lines[i];
                string[] vector = var.Split('/');
                if (vector[0] == vectorData[0])
                {
                    if (vector[1] == vectorData[1])
                    {
                        if (vector[2] == vectorData[2])
                        {

                            for (int j = 3; j < 76; j++)
                            {
                                if (vectorsillas[j - 3] == "1")
                                {
                                    vectorsillas[j - 3] = "2";
                                }
                                
                                vector[j] = vectorsillas[j - 3];
                            }
                            sw2 = 1;

                        }
                    }
                }

                lines[i] = string.Join("/", vector);
                i++;
            }

            File.WriteAllLines("prueba2.txt", lines);





        }

        private void button9A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[8]) == 0)
            {
                vectorsillas[8] = "1";
                button9A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[8]) == 1)
                {
                    vectorsillas[8] = "0";
                    button9A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button9A.BackColor = Color.Green;
                }
            }
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
            CONTINUAR.Enabled= false;
        }

        private void button10A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[9]) == 0)
            {
                vectorsillas[9] = "1";
                button10A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[9]) == 1)
                {
                    vectorsillas[9] = "0";
                    button10A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button10A.BackColor = Color.Green;
                }
            }
        }

        private void button11A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[10]) == 0)
            {
                vectorsillas[10] = "1";
                button11A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[10]) == 1)
                {
                    vectorsillas[10] = "0";
                    button11A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button11A.BackColor = Color.Green;
                }
            }
        }

        private void button12A_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[11]) == 0)
            {
                vectorsillas[11] = "1";
                button12A.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[11]) == 1)
                {
                    vectorsillas[11] = "0";
                    button12A.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button12A.BackColor = Color.Green;
                }
            }
        }

        private void button1B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[12]) == 0)
            {
                vectorsillas[12] = "1";
                button1B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[12]) == 1)
                {
                    vectorsillas[12] = "0";
                    button1B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button1B.BackColor = Color.Green;
                }
            }
        }

        private void button12B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[23]) == 0)
            {
                vectorsillas[23] = "1";
                button12B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[23]) == 1)
                {
                    vectorsillas[23] = "0";
                    button12B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button12B.BackColor = Color.Green;
                }
            }

        }

        private void button1AA_Click(object sender, EventArgs e)
        {
            

                if (Int32.Parse(this.vectorsillas[0]) == 0)
                {
                    vectorsillas[0] = "1";
                    btn1A.BackColor = Color.Red;


                }
                else
                {
                    if (Int32.Parse(vectorsillas[0]) == 1)
                    {
                        vectorsillas[0] = "0";
                        btn1A.BackColor = Color.White;

                    }
                    else
                    {
                        MessageBox.Show("Silla ya ocupada");
                        btn1A.BackColor = Color.Green;
                    }
                }

            }

        private void button2B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[13]) == 0)
            {
                vectorsillas[13] = "1";
                button2B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[13]) == 1)
                {
                    vectorsillas[13] = "0";
                    button2B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button2B.BackColor = Color.Green;
                }
            }
        }

        private void button3B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[14]) == 0)
            {
                vectorsillas[14] = "1";
                button3B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[14]) == 1)
                {
                    vectorsillas[14] = "0";
                    button3B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button3B.BackColor = Color.Green;
                }
            }
        }

        private void button4B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[15]) == 0)
            {
                vectorsillas[15] = "1";
                button4B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[15]) == 1)
                {
                    vectorsillas[15] = "0";
                    button4B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button4B.BackColor = Color.Green;
                }
            }
        }

        private void button5B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[16]) == 0)
            {
                vectorsillas[16] = "1";
                button5B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[16]) == 1)
                {
                    vectorsillas[16] = "0";
                    button5B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button5B.BackColor = Color.Green;
                }
            }
        }

        private void button6B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[17]) == 0)
            {
                vectorsillas[17] = "1";
                button6B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[17]) == 1)
                {
                    vectorsillas[17] = "0";
                    button6B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button6B.BackColor = Color.Green;
                }
            }
        }

        private void button7B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[18]) == 0)
            {
                vectorsillas[18] = "1";
                button7B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[18]) == 1)
                {
                    vectorsillas[18] = "0";
                    button7B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button7B.BackColor = Color.Green;
                }
            }
        }

        private void button8B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[19]) == 0)
            {
                vectorsillas[19] = "1";
                button8B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[19]) == 1)
                {
                    vectorsillas[19] = "0";
                    button8B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button8B.BackColor = Color.Green;
                }
            }
        }

        private void button9B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[20]) == 0)
            {
                vectorsillas[20] = "1";
                button9B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[20]) == 1)
                {
                    vectorsillas[20] = "0";
                    button9B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button9B.BackColor = Color.Green;
                }
            }
        }

        private void button10B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[21]) == 0)
            {
                vectorsillas[21] = "1";
                button10B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[21]) == 1)
                {
                    vectorsillas[21] = "0";
                    button10B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button10B.BackColor = Color.Green;
                }
            }
        }

        private void button11B_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[22]) == 0)
            {
                vectorsillas[22] = "1";
                button11B.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[22]) == 1)
                {
                    vectorsillas[22] = "0";
                    button11B.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button11B.BackColor = Color.Green;
                }
            }
        }

        private void button1C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[24]) == 0)
            {
                vectorsillas[24] = "1";
                button1C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[24]) == 1)
                {
                    vectorsillas[24] = "0";
                    button1C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button1C.BackColor = Color.Green;
                }
            }
        }

        private void button2C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[25]) == 0)
            {
                vectorsillas[25] = "1";
                button2C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[25]) == 1)
                {
                    vectorsillas[25] = "0";
                    button2C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button2C.BackColor = Color.Green;
                }
            }
        }

        private void button3C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[26]) == 0)
            {
                vectorsillas[26] = "1";
                button3C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[26]) == 1)
                {
                    vectorsillas[26] = "0";
                    button3C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button3C.BackColor = Color.Green;
                }
            }
        }

        private void button4C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[27]) == 0)
            {
                vectorsillas[27] = "1";
                button4C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[27]) == 1)
                {
                    vectorsillas[27] = "0";
                    button4C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button4C.BackColor = Color.Green;
                }
            }
        }

        private void button5C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[28]) == 0)
            {
                vectorsillas[28] = "1";
                button5C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[28]) == 1)
                {
                    vectorsillas[28] = "0";
                    button5C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button5C.BackColor = Color.Green;
                }
            }
        }

        private void button6C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[29]) == 0)
            {
                vectorsillas[29] = "1";
                button6C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[29]) == 1)
                {
                    vectorsillas[29] = "0";
                    button6C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button6C.BackColor = Color.Green;
                }
            }
        }

        private void button7C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[30]) == 0)
            {
                vectorsillas[30] = "1";
                button7C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[30]) == 1)
                {
                    vectorsillas[30] = "0";
                    button7C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button7C.BackColor = Color.Green;
                }
            }
        }

        private void button8C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[31]) == 0)
            {
                vectorsillas[31] = "1";
                button8C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[31]) == 1)
                {
                    vectorsillas[31] = "0";
                    button8C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button8C.BackColor = Color.Green;
                }
            }
        }

        private void button9C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[32]) == 0)
            {
                vectorsillas[32] = "1";
                button9C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[32]) == 1)
                {
                    vectorsillas[32] = "0";
                    button9C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button9C.BackColor = Color.Green;
                }
            }
        }

        private void button10C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[33]) == 0)
            {
                vectorsillas[33] = "1";
                button10C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[33]) == 1)
                {
                    vectorsillas[33] = "0";
                    button10C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button10C.BackColor = Color.Green;
                }
            }
        }

        private void button11C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[34]) == 0)
            {
                vectorsillas[34] = "1";
                button11C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[34]) == 1)
                {
                    vectorsillas[34] = "0";
                    button11C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button11C.BackColor = Color.Green;
                }
            }
        }

        private void button12C_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[35]) == 0)
            {
                vectorsillas[35] = "1";
                button12C.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[35]) == 1)
                {
                    vectorsillas[35] = "0";
                    button12C.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button12C.BackColor = Color.Green;
                }
            }
        }

        private void button1D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[36]) == 0)
            {
                vectorsillas[36] = "1";
                button1D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[36]) == 1)
                {
                    vectorsillas[36] = "0";
                    button1D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button1D.BackColor = Color.Green;
                }
            }
        }

        private void button2D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[37]) == 0)
            {
                vectorsillas[37] = "1";
                button2D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[37]) == 1)
                {
                    vectorsillas[37] = "0";
                    button2D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button2D.BackColor = Color.Green;
                }
            }
        }

        private void button3D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[38]) == 0)
            {
                vectorsillas[38] = "1";
                button3D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[38]) == 1)
                {
                    vectorsillas[38] = "0";
                    button3D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button3D.BackColor = Color.Green;
                }
            }
        }

        private void button4D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[39]) == 0)
            {
                vectorsillas[39] = "1";
                button4D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[39]) == 1)
                {
                    vectorsillas[39] = "0";
                    button4D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button4D.BackColor = Color.Green;
                }
            }
        }

        private void button5D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[40]) == 0)
            {
                vectorsillas[40] = "1";
                button5D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[40]) == 1)
                {
                    vectorsillas[40] = "0";
                    button5D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button5D.BackColor = Color.Green;
                }
            }
        }

        private void button6D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[41]) == 0)
            {
                vectorsillas[41] = "1";
                button6D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[41]) == 1)
                {
                    vectorsillas[41] = "0";
                    button6D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button6D.BackColor = Color.Green;
                }
            }
        }

        private void button7D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[42]) == 0)
            {
                vectorsillas[42] = "1";
                button7D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[42]) == 1)
                {
                    vectorsillas[42] = "0";
                    button7D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button7D.BackColor = Color.Green;
                }
            }
        }

        private void button8D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[43]) == 0)
            {
                vectorsillas[43] = "1";
                button8D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[43]) == 1)
                {
                    vectorsillas[43] = "0";
                    button8D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button8D.BackColor = Color.Green;
                }
            }
        }

        private void button9D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[44]) == 0)
            {
                vectorsillas[44] = "1";
                button9D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[44]) == 1)
                {
                    vectorsillas[44] = "0";
                    button9D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button9D.BackColor = Color.Green;
                }
            }

        }

        private void button10D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[45]) == 0)
            {
                vectorsillas[45] = "1";
                button10D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[45]) == 1)
                {
                    vectorsillas[45] = "0";
                    button10D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button10D.BackColor = Color.Green;
                }
            }

        }

        private void button11D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[46]) == 0)
            {
                vectorsillas[46] = "1";
                button11D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[46]) == 1)
                {
                    vectorsillas[46] = "0";
                    button11D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button11D.BackColor = Color.Green;
                }
            }

        }

        private void button12D_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[47]) == 0)
            {
                vectorsillas[47] = "1";
                button12D.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[47]) == 1)
                {
                    vectorsillas[47] = "0";
                    button12D.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button12D.BackColor = Color.Green;
                }
            }
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[48]) == 0)
            {
                vectorsillas[48] = "1";
                buttonE1.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[48]) == 1)
                {
                    vectorsillas[48] = "0";
                    buttonE1.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE1.BackColor = Color.Green;
                }
            }
        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[49]) == 0)
            {
                vectorsillas[49] = "1";
                buttonE2.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[49]) == 1)
                {
                    vectorsillas[49] = "0";
                    buttonE2.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE2.BackColor = Color.Green;
                }
            }
        }

        private void buttonE3_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[50]) == 0)
            {
                vectorsillas[50] = "1";
                buttonE3.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[50]) == 1)
                {
                    vectorsillas[50] = "0";
                    buttonE3.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE3.BackColor = Color.Green;
                }
            }

        }

        private void buttonE4_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[51]) == 0)
            {
                vectorsillas[51] = "1";
                buttonE4.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[51]) == 1)
                {
                    vectorsillas[51] = "0";
                    buttonE4.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE4.BackColor = Color.Green;
                }
            }
        }

        private void buttonE5_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[52]) == 0)
            {
                vectorsillas[52] = "1";
                buttonE5.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[52]) == 1)
                {
                    vectorsillas[52] = "0";
                    buttonE5.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE5.BackColor = Color.Green;
                }
            }
        }

        private void buttonE6_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[53]) == 0)
            {
                vectorsillas[53] = "1";
                buttonE6.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[53]) == 1)
                {
                    vectorsillas[53] = "0";
                    buttonE6.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE6.BackColor = Color.Green;
                }
            }
        }

        private void buttonE7_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[54]) == 0)
            {
                vectorsillas[54] = "1";
                buttonE7.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[54]) == 1)
                {
                    vectorsillas[54] = "0";
                    buttonE7.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE7.BackColor = Color.Green;
                }
            }
        }

        private void buttonE8_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[55]) == 0)
            {
                vectorsillas[55] = "1";
                buttonE8.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[55]) == 1)
                {
                    vectorsillas[55] = "0";
                    buttonE8.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE8.BackColor = Color.Green;
                }
            }
        }

        private void buttonE9_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[56]) == 0)
            {
                vectorsillas[56] = "1";
                buttonE9.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[56]) == 1)
                {
                    vectorsillas[56] = "0";
                    buttonE9.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE9.BackColor = Color.Green;
                }
            }
        }

        private void buttonE10_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[57]) == 0)
            {
                vectorsillas[57] = "1";
                buttonE10.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[57]) == 1)
                {
                    vectorsillas[57] = "0";
                    buttonE10.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE10.BackColor = Color.Green;
                }
            }
        }

        private void buttonE11_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[58]) == 0)
            {
                vectorsillas[58] = "1";
                buttonE11.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[58]) == 1)
                {
                    vectorsillas[58] = "0";
                    buttonE11.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    buttonE11.BackColor = Color.Green;
                }
            }
        }

        private void button1F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[59]) == 0)
            {
                vectorsillas[59] = "1";
                button1F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[59]) == 1)
                {
                    vectorsillas[59] = "0";
                    button1F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button1F.BackColor = Color.Green;
                }
            }
        }

        private void button2F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[60]) == 0)
            {
                vectorsillas[60] = "1";
                button2F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[60]) == 1)
                {
                    vectorsillas[60] = "0";
                    button2F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button2F.BackColor = Color.Green;
                }
            }
        }

        private void button3F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[61]) == 0)
            {
                vectorsillas[61] = "1";
                button3F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[61]) == 1)
                {
                    vectorsillas[61] = "0";
                    button3F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button3F.BackColor = Color.Green;
                }
            }
        }

        private void button4F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[62]) == 0)
            {
                vectorsillas[62] = "1";
                button4F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[62]) == 1)
                {
                    vectorsillas[62] = "0";
                    button4F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button4F.BackColor = Color.Green;
                }
            }
        }

        private void button5F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[63]) == 0)
            {
                vectorsillas[63] = "1";
                button5F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[63]) == 1)
                {
                    vectorsillas[63] = "0";
                    button5F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button5F.BackColor = Color.Green;
                }
            }
        }

        private void button6F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[64]) == 0)
            {
                vectorsillas[64] = "1";
                button6F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[64]) == 1)
                {
                    vectorsillas[64] = "0";
                    button6F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button6F.BackColor = Color.Green;
                }
            }
        }

        private void button7F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[65]) == 0)
            {
                vectorsillas[65] = "1";
                button7F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[65]) == 1)
                {
                    vectorsillas[65] = "0";
                    button7F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button7F.BackColor = Color.Green;
                }
            }
        }

        private void button8F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[66]) == 0)
            {
                vectorsillas[66] = "1";
                button8F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[66]) == 1)
                {
                    vectorsillas[66] = "0";
                    button8F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button8F.BackColor = Color.Green;
                }
            }
        }

        private void button9F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[67]) == 0)
            {
                vectorsillas[67] = "1";
                button9F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[67]) == 1)
                {
                    vectorsillas[67] = "0";
                    button9F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button1B.BackColor = Color.Green;
                }
            }
        }

        private void button10F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[68]) == 0)
            {
                vectorsillas[68] = "1";
                button10F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[68]) == 1)
                {
                    vectorsillas[68] = "0";
                    button10F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button10F.BackColor = Color.Green;
                }
            }
        }

        private void button11F_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.vectorsillas[69]) == 0)
            {
                vectorsillas[69] = "1";
                button11F.BackColor = Color.Red;


            }
            else
            {
                if (Int32.Parse(vectorsillas[69]) == 1)
                {
                    vectorsillas[69] = "0";
                    button11F.BackColor = Color.White;

                }
                else
                {
                    MessageBox.Show("Silla ya ocupada");
                    button11F.BackColor = Color.Green;
                }
            }
        }

        private void Precios_Click(object sender, EventArgs e)
        {

        }
    }
}
    



