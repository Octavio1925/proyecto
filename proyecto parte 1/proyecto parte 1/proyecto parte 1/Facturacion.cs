using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace proyecto_parte_1

{
    
    public partial class Facturacion : Form
    {
        private static void main(string[] args)
        {
            DataTable dttable = new DataTable("Tabla uno");
            dttable.Columns.Add(" Cantidad camaras", typeof(int));
            dttable.Columns.Add("Cantidad DVR ",typeof(int));
            dttable.Columns.Add(" Cantidad de discos duros ",typeof(int));
            dttable.Columns.Add(" Cantidad de balunes ",typeof(int));


            Console.ReadLine();
        }
        public Facturacion()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CbCategoria.Items.Add("Camaras");
            CbCategoria.Items.Add("Grabadores"); 
            CbCategoria.Items.Add("Almacenamiento");
           
            CBProductos.Items.Add("Camara Hilook");
            CBProductos.Items.Add("DVR");
            CBProductos.Items.Add("Disco duro");

            
            
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide ();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
        }  

        private void MessageBox(string v)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string productos, cantidad;
            int nreg;
            decimal precio = 0;
            productos = CBProductos.Text;
            


        }
    }
    }
