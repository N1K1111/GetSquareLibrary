using System;

namespace GetSquareLibrary
{
    public class Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double Square { get; private set; }
        public bool ChekRectangularTriangle { get; private set; } = false;

        /// <summary>
        /// Нахождение площади окружности
        /// </summary>
        /// <param name="A">Радиус окружности</param>
        public Shape(double A)
        {
            this.A = A;
            GetSquareCircle(A);
        }

        /// <summary>
        /// Нахождение площади треугольника
        /// </summary>
        /// <param name="A">Сторона А</param>
        /// <param name="B">Сторона B</param>
        /// <param name="C">Сторона C</param>
        public Shape(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            GetSquareTriangle(A, B, C);
        }

        public void GetSquareCircle(double A)
        {
            double radius = A;
            double squareCircle = radius * Math.PI;
            Square = Math.Round(squareCircle,6);
        }

        public void GetSquareTriangle(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            double squareTriangle = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Square = Math.Round(squareTriangle);
            GetRectangularTriangle(A, B, C);
        }

        public bool GetRectangularTriangle(double A, double B, double C)
        {
            if (A * A + B * B == C * C || A * A + C * C == B * B) return ChekRectangularTriangle = true;
            return ChekRectangularTriangle = false;
        }
    }
}
