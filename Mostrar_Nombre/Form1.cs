using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mostrar_Nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 101 - 1; i++)
            {


                
                dataGridView1.Rows.Add(textBox1.Text);





            }

            i = i + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.Clear();


            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
