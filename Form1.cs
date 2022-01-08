using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milestoner;

namespace MilestonerApp
{
    public partial class Form1 : Form
    {
        Milestoner.Vector _Vector;
        public Form1()
        {
            _Vector = new Vector();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.OrderEntry.Text);
            int order = int.Parse(this.OrderEntry.Text);
            string name = this.NameEntry.Text;
            _Vector.AddPoint(name, order);
            PointsBox.Items.Add(this.NameEntry.Text); //Need to add observerance
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
