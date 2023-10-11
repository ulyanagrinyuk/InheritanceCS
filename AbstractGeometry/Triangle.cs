//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Policy;
//using System.Text;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Threading.Tasks;

//namespace AbstractGeometry
//{
//	internal class Triangle : Shape
//	{
//		double side_w;
//		double side_s;
//		double side_d;
//	}
//	public double side_w
//	{
//		get { return side_w; }
//		set
//		{
//			if (value < MIN_SIZE) value = MIN_SIZE;
//			if (value > MAX_SIZE) value = MAX_SIZE;
//			side_w = value;
//		}
//	}
//	public double side_s
//	{
//		get { return side_s; }
//		set
//		{
//			if (value < MIN_SIZE) value = MIN_SIZE;
//			if (value > MAX_SIZE) value = MAX_SIZE;
//			side_s = value;
//		}
//	}
//	public double side_d
//	{
//		get { return side_d; }
//		set
//		{
//			if (value < MIN_SIDE) value = MIN_SIZE;
//			if (value > MAX_SIZE) value = MAX_SIZE;
//			side_d = value;
//		}
//	}
//	public Triangle
//		(double side_w, double side_s, double side_d,int start_x, int start_y, int line_width, Color color
//            ) :base (start_x, start_y, line_width, color)
//	{
//		Side_w = side_w;
//		Side_s = side_s;
//		Side_d = side_d;
//	}
//	public override double GetArea()
//	{
//		return (side_w * side_s) / 2;
//	}
//	public override double GetPerimiter()
//	{
//		return side_w + side_s + side_d;
//	}
//	public override void Info(PaintEventArgs e)
//	{
//		Console.WriteLine($"Сторона А: {SideA}");
//		Console.WriteLine($"Сторона B: {SideB}");
//		Console.WriteLine($"Сторона C: {SideB}");
//		Console.WriteLine($"Диагональ: {GetDiagonal()}");
//		base.Info(e);
//	}
//}
