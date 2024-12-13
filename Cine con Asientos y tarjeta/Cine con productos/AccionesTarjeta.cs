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
    public partial class AccionesTarjeta : Form
    {
        public AccionesTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addCredit = new AddCredit();
            addCredit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goPay = new VerifyAndPay();
            goPay.ShowDialog();
        }

        private void buttonBackFromCreditActions_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
