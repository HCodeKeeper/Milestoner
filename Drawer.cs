using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Milestoner
{
    public class Drawer
    {
        string _DefaultPath = Directory.GetCurrentDirectory();
        Vector _Vector;
        string picID = "0";
        
        public void CreateBackground(int resx, int resy, Vector vector)
        {
            string path = _DefaultPath + "bg" + picID + ".jpeg";
            _Vector = vector;
            Bitmap bitmap = new Bitmap(resx, resy, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Draw(bitmap);
            bitmap.Save(path);
            BackgroundSetter.SetWallpaper(path);
            UpdatePicID();

        }

        private void UpdatePicID()
        {
            picID = $"{int.Parse(picID) + 1}";
        }

        private void Draw(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            int thicknessRatio = 50;
            int vectorPadding = 30;
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.White, bitmap.Height / thicknessRatio);
            // Calculations are wrong
            //upper part of arrow
            graphics.DrawLine(pen, width - vectorPadding*2, height / 2 - thicknessRatio*2, width - vectorPadding, height / 2 - thicknessRatio);
            Console.WriteLine(height / 2 - thicknessRatio * 2);
            //line
            graphics.DrawLine(pen, vectorPadding, height / 2 - thicknessRatio, width - vectorPadding, height / 2 - thicknessRatio);
            //bottom part of arrow
            graphics.DrawLine(pen, width - vectorPadding * 2, height / 2, width - vectorPadding, height / 2 - thicknessRatio);

            int pointCount = _Vector.Count();
            Font font = new Font("Helvetica", 20);

            graphics.DrawString("Start", font, Brushes.Yellow, 50, height / 2 - thicknessRatio - 50);
            foreach (Point point in _Vector.GetPoint())
            {
                graphics.DrawString(point.GetName(), font, Brushes.Yellow, width / (pointCount + 1) * point.GetOrder(), height / 2 - thicknessRatio - 50);
            }
            graphics.DrawString("End", font, Brushes.Yellow, width - 70 - vectorPadding, height / 2 - thicknessRatio - 50);
        }
    }
}
