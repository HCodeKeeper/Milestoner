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
        int[] _Resolution;
        Drawer _Drawer;
        public Form1()
        {
            _Vector = new Vector(this);
            InitializeComponent();
            _Drawer = new Drawer();
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

        private void SetBackgroundButton_Click(object sender, EventArgs e)
        {
            if (!(_Resolution == null))
            {
                _Drawer.CreateBackground(_Resolution[0], _Resolution[1], _Vector);
            }
        }

        private void SetResolutionButton_Click(object sender, EventArgs e)
        {
            string resolution = this.ResolutionEntry.Text;
            int sepInd = resolution.IndexOf('x');
            if (sepInd == -1 | sepInd == resolution.Length - 1 | sepInd == 0)
            {
                return;
            }

            int resx;
            int.TryParse(resolution.Substring(0, sepInd), out resx);
            int resy;
            int.TryParse(resolution.Substring(sepInd + 1, resolution.Length - sepInd - 1), out resy);

            if (resx == 0 || resy == 0)
            {
                return;
            }
                
            _Resolution = new int[] { resx, resy };
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
