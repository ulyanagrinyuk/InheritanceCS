//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Policy;
//using System.Security.Principal;
//using System.Text;
//using System.Drawing;
//using System.Threading.Tasks;

//namespace AbstractGeometry
//{
//	internal class Square: Shape
//	{
//		double side_t;
//	}
//	public double SideT
//	{
//		get { return side_t; }
//		set
//		{
//			if (value < MIN_SIZE) value = MIN_SIZE;
//			if (value > MAX_SIZE) value = MAX_SIZE;
//			side_t = value;
//		}
//	}
//	public Square(double side)
//		:base(side_t, start_x, Color color)
//	{
//		Side = side;
//	}
//	public double GetArea()
//	{
//		return side_t * side_t;
//	}
//	public double GetPerimiter()
//	{
//		return side_t * 4;
//	}
//	public override void Draw(PaintEventArgs e)
//	{
//		Pen pen = new Pen(Color, LineWidth);
//		e.Graphics.DrawRecengle(pen, StartX, (int)side);
//		for (int i = 0; i < side_t; i++)
//		{
//			for (int j = 0; j < side_t; j++)
//			{
//				ConsoleWrite('*');
//			}
//		}
//	}
//	public override void Info(PaintEventArgs e)
//	{
//		Console.WriteLine($"Сторона А: {SideA}");
//		Console.WriteLine($"Сторона B: {SideB}");
//		Console.WriteLine($"Диагональ: {GetDiagonal()}");
//		base.Info(e);
//	}
//}
