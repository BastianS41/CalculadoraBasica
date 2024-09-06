using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solAppSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj = new Operaciones();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            if(!obj.IsNumeric(txtNum1.Text)&& !obj.IsNumeric(txtNum2.Text))
            {
                resultado.Text = "Ingrese un valor válido";
            }
            else
            {
                int suma = obj.suma(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                resultado.Text = Convert.ToString(suma);
            }
        }

        private void restaBtn_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtNum1.Text) && !obj.IsNumeric(txtNum2.Text))
            {
                resultado.Text = "Ingrese un valor válido";
            }
            else
            {
                int resta = obj.resta(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                resultado.Text = Convert.ToString(resta);
            }
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtNum1.Text) && !obj.IsNumeric(txtNum2.Text))
            {
                resultado.Text = "Ingrese un valor válido";
            }
            else
            {
                int mult = obj.multiplicar(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                resultado.Text = Convert.ToString(mult);
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtNum1.Text) && !obj.IsNumeric(txtNum2.Text))
            {
                resultado.Text = "Ingrese un valor válido";
            }
            else
            {
                int div = obj.dividir(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                resultado.Text = Convert.ToString(div);
            }
        }
    }
}
