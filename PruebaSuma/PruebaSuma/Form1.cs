using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtN1.Text);
                int num2 = Convert.ToInt32(txtN2.Text);

                int suma = num1 + num2;
                txtResultado.Text = suma.ToString();
            }
            catch (FormatException err)
            {
                MessageBox.Show("Lo siento ocurrió un error(s) "+err.Message+"!!");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
