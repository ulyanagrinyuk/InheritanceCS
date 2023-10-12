using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class Triangle : Shape
	{
		double side_w;
		double side_s;
		double side_d;
		public double SideW
		{
			get { return side_w; }
			set
			{
				if (value < MIN_SIZE) value = MIN_SIZE;
				if (value > MAX_SIZE) value = MAX_SIZE;
				side_w = value;
			}
		}
		public double SideS
		{
			get { return side_s; }
			set
			{
				if (value < MIN_SIZE) value = MIN_SIZE;
				if (value > MAX_SIZE) value = MAX_SIZE;
				side_s = value;
			}
		}
			public double SideD
		{
			get { return side_d; }
			set
			{
				if (value < MIN_SIZE) value = MIN_SIZE;
				if (value > MAX_SIZE) value = MAX_SIZE;
				side_d = value;
			}
		}
		public Triangle
			(double side_w, double side_s, double side_d, int start_x, int start_y, int line_width, Color color
				) : base(start_x, start_y, line_width, color)
		{
			SideW = side_w;
			SideS = side_s;
			SideD = side_d;
		}
		public override double GetArea()
		{
			return (side_w * side_s) / 2;
		}
		public override double GetPerimiter()
		{
			return side_w + side_s + side_d;
		}
		public double Height()
		{
			return 2 * GetPerimiter() / side_w;
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Сторона А: {SideW}");
			Console.WriteLine($"Сторона B: {SideS}");
			Console.WriteLine($"Сторона C: {SideD}");
			base.Info(e);
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] point = new Point[]
			{
				new Point(StartX, StartY),
				new Point(StartX, StartY + (int)SideW),
				new Point(StartX + (int)SideW, StartX)
			};
			e.Graphics.DrawPolygon(pen, point);
		}
	}
}
