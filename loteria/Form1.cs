using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Random a = new Random();
        public int n1, n2, n3, n4, n5;
        public double dinero;
        public double dinero1;
        public double dinero2;
        public double dinero3;

        private void txtpremio3_TextChanged(object sender, EventArgs e)
        {

        }

        public double numero;



        private void bntejecutar_Click(object sender, EventArgs e)

        {
            numero = Convert.ToDouble(txtnumero.Text);
            dinero = Convert.ToDouble(txtdinero.Text);

            n1 = a.Next(0, 100);
            n2 = a.Next(0, 99);
            n3 = a.Next(0, 99);
            n4 = a.Next(0, 99);
            n5 = a.Next(0, 99);

            txt1.Text = n1.ToString();
            txt2.Text = n2.ToString();
            txt3.Text = n3.ToString();


            dinero1 = dinero * 40;
            txtpremio1.Text = dinero1.ToString();

            dinero2 = dinero * 20;
            txtpremio2.Text = dinero2.ToString();

            dinero3 = dinero * 10;
            txtpremio3.Text = dinero3.ToString();
             

            if(numero > 100)
            {
                MessageBox.Show("El numero debe de ser de 0 y 100");
            }


            if (numero == n1)
            {
                MessageBox.Show("Ganador del primer lugar");
            }

            if
            (numero == n2)
            {
                MessageBox.Show("Ganador del segundo lugar");
            }

            if
            (numero == n3)
            {

                MessageBox.Show("Ganador del tercer lugar");
            }
            MessageBox.Show("Perdiste");

        }

    }
}
