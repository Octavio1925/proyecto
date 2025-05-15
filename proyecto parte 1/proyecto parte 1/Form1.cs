using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_parte_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            this.Hide();
            facturacion.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();   

            this.Hide();

            inventario.ShowDialog();    

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingresodeinventario ingresoinv = new Ingresodeinventario();    
            this.Hide();
            ingresoinv.ShowDialog();
            this.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
