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
    public partial class Form1 : Form, Milestoner.IGui
    {
        Milestoner.Vector _Vector;
        public Form1()
        {
            _Vector = new Vector(this);
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
            int order = int.Parse(this.OrderEntry.Text);
            string name = this.NameEntry.Text;
            _Vector.AddPoint(name, order);
        }

        public void DataUpdate(SortedSet<Milestoner.Point> points)
        {
            int itemsQuantity = PointsBox.Items.Count;
            for(int i = 0; i < itemsQuantity; i++)
            {
                PointsBox.Items.RemoveAt(0);
            }
            SortedSet<Milestoner.Point> reversedPoints = new SortedSet<Milestoner.Point>(points, new ReversedPointComparator());
            foreach (Milestoner.Point point in reversedPoints)
            {
                PointsBox.Items.Add(point.GetName());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Vector.ChangePoint(PointsBox.Text, int.Parse(OrderEntry.Text));
        }
    }
}
