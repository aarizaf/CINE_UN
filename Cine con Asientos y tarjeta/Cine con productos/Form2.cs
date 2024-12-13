using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form2 : Form
    {

        ArchivoSalas archivo = new ArchivoSalas();
        Tipo_Sala sala = new Tipo_Sala();
        List<int> lista = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Image image, string texto, string titulo, string personajes, string tiempo, string genero, string director, string[] hora)
        {
            InitializeComponent();
            image1.Image = image;
            sinopsis.Text = texto;
            nombre.Text = titulo;
            reparto.Text = personajes;
            duracion.Text = tiempo;
            Genero.Text = genero;
            Director.Text = director;

            // horas lunes
            Horapeli1.Text = hora[0];
            Horapeli1A.Text = hora[1];
            Horapeli1B.Text = hora[2];
            Horapeli1C.Text = hora[3];
            Horapeli1D.Text = hora[4];

            // horas martes
            Horapeli2.Text = hora[0];
            Horapeli2A.Text = hora[1];
            Horapeli2B.Text = hora[2];
            Horapeli2C.Text = hora[3];
            Horapeli2D.Text = hora[4];


            // horas miercoles
            Horapeli3.Text = hora[0];
            Horapeli3A.Text = hora[1];
            Horapeli3B.Text = hora[2];
            Horapeli3C.Text = hora[3];
            Horapeli3D.Text = hora[4];

            // horas jueves
            Horapeli4.Text = hora[0];
            Horapeli4A.Text = hora[1];
            Horapeli4B.Text = hora[2];
            Horapeli4C.Text = hora[3];
            Horapeli4D.Text = hora[4];


            // horas viernes
            Horapeli5.Text = hora[0];
            Horapeli5A.Text = hora[1];
            Horapeli5B.Text = hora[2];
            Horapeli5C.Text = hora[3];
            Horapeli5D.Text = hora[4];
            Horapeli5E.Text = hora[5];


            // horas sabado
            Horapeli6.Text = hora[0];
            Horapeli6A.Text = hora[1];
            Horapeli6B.Text = hora[2];
            Horapeli6C.Text = hora[3];
            Horapeli6D.Text = hora[4];
            Horapeli6E.Text = hora[5];
            Horapeli6F.Text = hora[2];


            // horas domingo
            Horapeli7.Text = hora[0];
            Horapeli7A.Text = hora[1];
            Horapeli7B.Text = hora[2];
            Horapeli7C.Text = hora[3];
            Horapeli7D.Text = hora[4];
            Horapeli7E.Text = hora[1];
            Horapeli7F.Text = hora[2];

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private string precio1 = "10000";
        private string precio2 = "15000";
        private string precio3 = "15000";
        private string precio4 = "20000";
        private string precio5 = "28000";

        private void hora1_Click(object sender, EventArgs e)
        {

            lista.Insert(0, 1);
            Reservas reservas = new Reservas(showchairs(), showdata(),precio1, nombre.Text, image1.Image);
            reservas.Show();
            this.Hide();
            
        }

        private void HoraB3d_Click(object sender, EventArgs e)
        {
            lista.Insert(0, 2);
            Reservas reservas = new Reservas(showchairs(), showdata(), precio2, nombre.Text, image1.Image);
            reservas.Show();
            this.Hide();

        }

        private void horavi3_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas(showchairs(), showdata(), precio3, nombre.Text, image1.Image);
            reservas.Show();
            this.Hide();
        }

        private void horavi13d_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas(showchairs(), showdata(), precio4, nombre.Text, image1.Image);
            reservas.Show();
            this.Hide();
        }

        private void horavi14d_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas(showchairs(), showdata(), precio5, nombre.Text, image1.Image);
            reservas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Taquilla fom = new Taquilla();
            fom.Show();
            this.Hide();
        }
        public string[] showchairs()
        {
            if (lista[0] == 1)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli1.Text, sala);

                return sillas;

            }
            else if (lista[0] == 2)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli1A.Text, sala);
                return sillas;
            }
            else if (lista[0] == 3)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli1B.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 4)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli1C.Text, sala);

                return sillas;

            }
            else if (lista[0] == 5)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli1D.Text, sala);
                return sillas;
            }
            else if (lista[0] == 6)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli2.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 7)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli2A.Text, sala);

                return sillas;

            }
            else if (lista[0] == 8)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli2B.Text, sala);
                return sillas;
            }
            else if (lista[0] == 9)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli2C.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 10)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli2D.Text, sala);

                return sillas;

            }
            else if (lista[0] == 11)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli3.Text, sala);
                return sillas;
            }
            else if (lista[0] == 12)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli3A.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 13)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli3C.Text, sala);

                return sillas;

            }
            else if (lista[0] == 14)
            {
                string[] sillas = archivo.findDatachair("prueba2",Horapeli3D.Text, sala);
                return sillas;
            }
            else if (lista[0] == 15)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli4.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 16)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli4A.Text, sala);

                return sillas;

            }
            else if (lista[0] == 17)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli4B.Text, sala);
                return sillas;
            }
            else if (lista[0] == 18)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli4C.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 19)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli4D.Text, sala);

                return sillas;

            }
            else if (lista[0] == 20)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli5.Text, sala);
                return sillas;
            }
            else if (lista[0] == 21)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli5A.Text, sala);
                return sillas;
            }
           
            if (lista[0] == 22)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli5B.Text, sala);

                return sillas;

            }
            else if (lista[0] == 23)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli5C.Text, sala);
                return sillas;
            }
            else if (lista[0] == 24)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli5D.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 25)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli5E.Text, sala);

                return sillas;

            }
            else if (lista[0] == 26)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6.Text, sala);
                return sillas;
            }
            else if (lista[0] == 27)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6A.Text, sala);
                return sillas;
            }
           
            if (lista[0] == 28)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6B.Text, sala);

                return sillas;

            }
            else if (lista[0] == 29)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6C.Text, sala);
                return sillas;
            }
            else if (lista[0] == 30)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6D.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 31)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6E.Text, sala);

                return sillas;

            }
            else if (lista[0] == 32)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli6F.Text, sala);
                return sillas;
            }
            else if (lista[0] == 33)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7.Text, sala);
                return sillas;
            }
           
            if (lista[0] == 34)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7A.Text, sala);

                return sillas;

            }
            else if (lista[0] == 35)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7B.Text, sala);
                return sillas;
            }
            else if (lista[0] == 36)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7C.Text, sala);
                return sillas;
            }
            
            if (lista[0] == 37)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7D.Text, sala);

                return sillas;

            }
            else if (lista[0] == 38)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7E.Text, sala);
                return sillas;
            }
            else if (lista[0] == 39)
            {
                string[] sillas = archivo.findDatachair("prueba2", Horapeli7F.Text, sala);
                return sillas;
            }

            else
            {
                return null;
            }

        }
        public string[] showdata()
        {
            if (lista[0] == 1)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli1.Text, sala);

                return sillas;

            }
            else if (lista[0] == 2)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli1A.Text, sala);
                return sillas;
            }
            else if (lista[0] == 3)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli1B.Text, sala);
                return sillas;
            }

            if (lista[0] == 4)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli1C.Text, sala);

                return sillas;

            }
            else if (lista[0] == 5)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli1D.Text, sala);
                return sillas;
            }
            else if (lista[0] == 6)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli2.Text, sala);
                return sillas;
            }

            if (lista[0] == 7)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli2A.Text, sala);

                return sillas;

            }
            else if (lista[0] == 8)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli2B.Text, sala);
                return sillas;
            }
            else if (lista[0] == 9)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli2C.Text, sala);
                return sillas;
            }

            if (lista[0] == 10)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli2D.Text, sala);

                return sillas;

            }
            else if (lista[0] == 11)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli3.Text, sala);
                return sillas;
            }
            else if (lista[0] == 12)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli3A.Text, sala);
                return sillas;
            }

            if (lista[0] == 13)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli3C.Text, sala);

                return sillas;

            }
            else if (lista[0] == 14)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli3D.Text, sala);
                return sillas;
            }
            else if (lista[0] == 15)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli4.Text, sala);
                return sillas;
            }

            if (lista[0] == 16)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli4A.Text, sala);

                return sillas;

            }
            else if (lista[0] == 17)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli4B.Text, sala);
                return sillas;
            }
            else if (lista[0] == 18)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli4C.Text, sala);
                return sillas;
            }

            if (lista[0] == 19)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli4D.Text, sala);

                return sillas;

            }
            else if (lista[0] == 20)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli5.Text, sala);
                return sillas;
            }
            else if (lista[0] == 21)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli5A.Text, sala);
                return sillas;
            }

            if (lista[0] == 22)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli5B.Text, sala);

                return sillas;

            }
            else if (lista[0] == 23)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli5C.Text, sala);
                return sillas;
            }
            else if (lista[0] == 24)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli5D.Text, sala);
                return sillas;
            }

            if (lista[0] == 25)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli5E.Text, sala);

                return sillas;

            }
            else if (lista[0] == 26)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6.Text, sala);
                return sillas;
            }
            else if (lista[0] == 27)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6A.Text, sala);
                return sillas;
            }

            if (lista[0] == 28)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6B.Text, sala);

                return sillas;

            }
            else if (lista[0] == 29)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6C.Text, sala);
                return sillas;
            }
            else if (lista[0] == 30)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6D.Text, sala);
                return sillas;
            }

            if (lista[0] == 31)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6E.Text, sala);

                return sillas;

            }
            else if (lista[0] == 32)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli6F.Text, sala);
                return sillas;
            }
            else if (lista[0] == 33)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7.Text, sala);
                return sillas;
            }

            if (lista[0] == 34)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7A.Text, sala);

                return sillas;

            }
            else if (lista[0] == 35)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7B.Text, sala);
                return sillas;
            }
            else if (lista[0] == 36)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7C.Text, sala);
                return sillas;
            }

            if (lista[0] == 37)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7D.Text, sala);

                return sillas;

            }
            else if (lista[0] == 38)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7E.Text, sala);
                return sillas;
            }
            else if (lista[0] == 39)
            {
                string[] sillas = archivo.get_room_Data("prueba2", Horapeli7F.Text, sala);
                return sillas;
            }

            else
            {
                return null;
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }

