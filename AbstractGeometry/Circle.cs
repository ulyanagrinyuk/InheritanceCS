using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		double radius;
		public double Radius
		{
			get { return radius; }
			set
			{
				if (value < MIN_SIZE) value = MIN_SIZE;
				if (value < MAX_SIZE) value = MAX_SIZE;
				radius = value;
			}
		}
		public Circle
			 (double radius, int start_x, int start_y, int line_width, Color color
				) : base(start_x, start_y, line_width, color)
		{
			radius = radius;
		}
		public override double GetArea()
		{
			return (radius * radius) * 3.14;
		}
		public double GetPerimeter()
		{
			return 2 * 3.14 * radius;
		}
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
			Console.WriteLine($"Радиус: {radius}");
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (int)radius);
		}
	}
}
