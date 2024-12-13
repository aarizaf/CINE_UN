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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Taquilla fom1= new Taquilla();
            fom1.ShowDialog();
            this.Hide();
              
           
        }

        

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        

        

        
    }
}
