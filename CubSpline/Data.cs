﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WindowsFormsApp1;

namespace Data
{


    public class Point
    {
        double x;
        double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double getX() { return x; }
        public double getY() { return y; }
    }
    class Utils
    {
        public static List<Point> getPointsFromFile(System.IO.Stream stream)
        {
            List<Point> points = new List<Point>();
            using (StreamReader reader = new StreamReader(stream))
            {
                string l;

                while ((l = reader.ReadLine()) != null)
                {
                    string[] parts = l.Split(new char[] { ',' });
                    double x = Double.Parse(parts[0]);
                    double y = Double.Parse(parts[1]);
                    points.Add(new Point(x, y));
                }
            }

            return points;
        }
    };
    public class Polynomial
    {
        private double[] coefficients;
        public Polynomial(double[] coefficients)
        {
            this.coefficients = coefficients;
        }
        public double f(double x)
        {
            double res = 0;
            double xx = 1;
            foreach (double c in coefficients)
            {
                res += c * xx;
                xx *= x;
            }
            return res;
        }

        public Point[] getPoints(double start, double end, double xOffset = 0, int numberOfPoints = 100)
        {
            Point[] res = new Point[numberOfPoints];
            double step = (end - start) / numberOfPoints;
            for (int i = 0; i < numberOfPoints; i++)
            {
                double x;
                if (i == numberOfPoints - 1)
                    x = end;
                else
                    x = start + i * step;
                res[i] = new Point(x, f(x - xOffset));
            }

            return res;
        }


        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("f(x) = ");
            bool hasPreceding = false;
            for (int i = coefficients.Length - 1; i >= 0; i--)
            {
                double coeff = coefficients[i];

                if (coeff == 0)
                    continue;

                if (coeff >= 0)
                {
                    if (hasPreceding)
                        sb.Append(" + ");
                }
                else
                    sb.Append(" - ");
                hasPreceding = true;
                sb.Append(Math.Abs(coeff).ToString("0.0"));
                if (i != 0)
                    sb.Append("*x^").Append(i);
            }

            return sb.ToString();
        }
    }

    class TriDiagonaMatrixElement
    {
        // |c b 0 0|
        // |a c b 0|
        // |0 a c b|
        // |0 0 a c|
        public double a; // Элементы под главной диагональю
        public double b; // Элементы над главной диагональю
        public double c; // Элементы на главной диагонали
        public TriDiagonaMatrixElement()
        {
            a = 0;
            b = 0;
            c = 0;
        }
    }

    class TriDiagonalMatrix
    {
        private TriDiagonaMatrixElement[] elements;
        public TriDiagonalMatrix(int n)
        {
            elements = new TriDiagonaMatrixElement[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = new TriDiagonaMatrixElement();
            }
        }
        public TriDiagonaMatrixElement this[int i]
        {
            get => elements[i];
        }

        public int Length
        {
            get => elements.Length;
        }

        // Решение методом прогонки
        public double[] solve(double[] F)
        {
            // Размер матрицы должен совпадать
            // с размером вектора свободных коэффициентов
            if (F.Length != elements.Length)
                throw new IndexOutOfRangeException();

            double[] x = new double[F.Length];
            double[] alpha = new double[F.Length];
            double[] beta = new double[F.Length];
            alpha[1] = -elements[0].b / elements[0].c;
            beta[1] = F[0] / elements[0].c;
            for (int i = 1; i < F.Length - 1; i++)
            {
                double t = elements[i].a * alpha[i] + elements[i].c;
                alpha[i + 1] = -elements[i].b / t;
                beta[i + 1] = (F[i] - elements[i].a * beta[i]) / t;
            }

            int N = x.Length - 1;
            x[N] = (F[N] - elements[N].a * beta[N]) / (elements[N].c + elements[N].a * alpha[N]);
            for (int i = N - 1; i >= 0; i--)
            {
                x[i] = alpha[i + 1] * x[i + 1] + beta[i + 1];
            }
            return x;
        }
    }

    public class FirstDerivative
    {
        Point[] points;

        public FirstDerivative(Point[] inputPoints)
        {
            // Сортируем точки по х
            points = inputPoints.OrderBy(p => p.getX()).ToArray();
        }

        public Point[] GetPoints()
        {
            Point[] res = new Point[points.Length - 1];
            for (int i = 0; i < points.Length - 1; i++)
            {

                double dx = (points[i + 1].getY() - points[i].getY()) / (points[i + 1].getX() - points[i].getX());
                res[i] = new Point(points[i].getX(), dx);
            }
            return res;
        }
    }

    public class SecondDerivative
    {
        Point[] points;

        public SecondDerivative(Point[] inputPoints)
        {
            // Сортируем точки по х
            points = inputPoints.OrderBy(p => p.getX()).ToArray();
        }

        public Point[] GetPoints()
        {
            Point[] res = new Point[points.Length - 5];
            for (int i = 2; i < points.Length - 3; i++)
            {
                double y = (points[i + 2].getY() - 2 * points[i].getY() + points[i - 2].getY());
                double t = (points[i + 2].getX() - points[i].getX());
                double dx2 = y / (t*t);
                res[i-2] = new Point(points[i].getX(), dx2);
            }
            return res;
        }
    }

    public class CubicSpline
    {
        private double start;
        private double end;
        private Tuple<double, double>[] ranges;
        private Point[] points;
        private Polynomial[] splines;
        public CubicSpline(Point[] inputPoints)
        {
            buildRanges(inputPoints);
            splines = new Polynomial[ranges.Length];
            double[] h = new double[points.Length];
            for (int i = 1; i < points.Length; i++)
            {
                h[i] = points[i].getX() - points[i - 1].getX();
            }

            TriDiagonalMatrix matrix = new TriDiagonalMatrix(points.Length - 2);
            double[] F = new double[points.Length - 2];
            // Построение системы динейных уравнений относительно coeff_c[i],  коэффициент при x^2

            for (int i = 2; i < points.Length; i++)
            {
                matrix[i - 2].a = h[i - 1];
                matrix[i - 2].c = 2 * (h[i] + h[i - 1]);
                matrix[i - 2].b = h[i];
                F[i - 2] = 3 * ((points[i].getY() - points[i - 1].getY()) / h[i] -
                    (points[i - 1].getY() - points[i - 2].getY()) / h[i - 1]);
            }
            matrix[0].a = 0;
            matrix[matrix.Length - 1].b = 0;

            // Находим коэффициенты 'с'
            double[] c = new double[points.Length + 1];
            c[0] = 0;
            c[1] = 0;
            double[] t = matrix.solve(F);
            Array.Copy(t, 0, c, 2, t.Length);
            c[c.Length - 1] = 0;




            // Вычисляем оставшмеся коэффициетны и создаем сплайны
            for (int i = 1; i < c.Length - 1; i++)
            {
                double a = points[i - 1].getY(); // свободный коэффициент
                double d = (c[i + 1] - c[i]) / (3 * h[i]); // коэффициент при x^3
                double b = (points[i].getY() - points[i - 1].getY()) / h[i] - (2 * c[i] + c[i + 1]) * h[i] / 3; // коэффициент при x^1
                splines[i - 1] = new Polynomial(new double[] { a, b, c[i], d });
            }
        }

        // Строим интервалы между точками
        private void buildRanges(Point[] pts)
        {
            // Исключаем повторяющуеся точки
            Dictionary<double, double> dict = new Dictionary<double, double>();
            for (int i = 0; i < pts.Length; i++)
            {
                if (dict.ContainsKey(pts[i].getX()))
                {
                    // Проверяем если точка дубликат одной из обработаных
                    // Если дубликат то пропускаем
                    if (dict[pts[i].getX()] == pts[i].getY())
                        continue;

                    // Для одного и того же X существует 2 точки с различными Y 
                    throw new Exception();
                }
                // Добавляем точку в словарь
                dict[pts[i].getX()] = pts[i].getY();
            }

            // Преобразуем словарь в список и сортируем по убыванию X
            List<Point> sorted = dict.Select(x => new Point(x.Key, x.Value)).OrderBy(p => p.getX()).ToList();
            //sorted.OrderBy(p=>p.getX()).Sort((a, b) => a.getX().CompareTo(b.getY()));

            // Преобразуем список в массив и строим интервалы
            points = sorted.ToArray();
            ranges = new Tuple<double, double>[points.Length - 1];
            for (int i = 0; i < points.Length - 1; i++)
            {
                ranges[i] = new Tuple<double, double>(points[i].getX(), points[i + 1].getX());
            }

            start = points[0].getX();
            end = points[points.Length - 1].getX();
        }

        int findRange(double X)
        {
            for (int i = 0; i < ranges.Length; i++)
            {
                if (X >= ranges[i].Item1 && X <= ranges[i].Item2)
                    return i;
            }
            return -1;
        }

        public Point[] getPoints(int numberOfPoints = 100)
        {
            double step = (end - start) / numberOfPoints;
            Point[] res = new Point[numberOfPoints];
            for (int i = 0; i < numberOfPoints; i++)
            {
                double x = start + i * step;
                if (i == numberOfPoints - 1)
                    x = end;
                int iRange = findRange(x);
                if (splines[iRange] == null)
                {
                    res[i] = new Point(x, 1);
                    continue;
                }
                double y = splines[iRange].f(x - ranges[iRange].Item1);
                res[i] = new Point(x, y);
            }
            return res;
        }
    }

}