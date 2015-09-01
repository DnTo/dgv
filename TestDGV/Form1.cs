using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDGV
{
    public partial class Form1 : Form
    {
        public int RowIndex { get; set; }
        public Form1()
        {
            RowIndex = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Add(RowIndex, "name"+RowIndex.ToString());
            RowIndex++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = Int32.Parse(textBox1.Text);
            string newText = textBox2.Text;

            //busco el row para modificar el nombre

            dataGridView1.Rows[row].Cells[1].Value = newText;

        }
    }
}
