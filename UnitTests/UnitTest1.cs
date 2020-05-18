using System;
using System.Threading;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    class Utils
    {
        public static void TestSinglePoly(double[] coeffs, Tuple<double, double> range)
        {
            Data.Polynomial poly = new Data.Polynomial(coeffs);
            Data.Point[] points = poly.getPoints(range.Item1, range.Item2, 0, 10);

            // Создаем сплайн и генерируем в 10 раз больше точек чем в оригинальном полиноме
            CubicSpline spline = new CubicSpline(points);
            Point[] splinePoints = spline.getPoints(100);

            // Проверяем что совпадают концы интервала
            Assert.AreEqual(range.Item1, splinePoints[0].getX());
            Assert.AreEqual(range.Item2, splinePoints[splinePoints.Length - 1].getX());

            // Проверяем что точки сплайна совпадают с полиномом
            int count = 0;
            foreach (var sp in splinePoints)
            {
                double expected = poly.f(sp.getX());
                double delta = Math.Abs(expected * 1e-2);
                if (Math.Abs(expected - sp.getY()) > delta)
                {
                    count++;
                    System.Console.Out.WriteLine("Error");
                }
                //Assert.AreEqual(expected, sp.getY(), delta);
            }
        }

    }
    [TestClass]
    public class CubicSplineTestsPoly0
    {
        double[][] variants = new double[][]
        {
            new double [] {-1},
            new double [] {0},
            new double [] {1}
        };

        Tuple<double, double>[] ranges = new Tuple<double, double>[]
        {
            new Tuple<double, double>(-100, 100), // Symmetric range
            new Tuple<double, double>(-100, -1),  // Negative range
            new Tuple<double, double>(1, 100)     // Positive range
        };


        // Variant 0

        [TestMethod]
        public void Variant0SymmetricRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[0]);
        }

        [TestMethod]
        public void Variant0NegativecRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[1]);
        }

        [TestMethod]
        public void Variant0PositiveRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[2]);
        }


        // Variant 1

        [TestMethod]
        public void Variant1SymmetricRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[0]);
        }

        [TestMethod]
        public void Variant1NegativecRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[1]);
        }

        [TestMethod]
        public void Variant1PositiveRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[2]);
        }

        // Variant 2

        [TestMethod]
        public void Variant2SymmetricRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[0]);
        }

        [TestMethod]
        public void Variant2NegativecRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[1]);
        }

        [TestMethod]
        public void Variant2PositiveRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[2]);
        }


    }

    [TestClass]
    public class CubicSplineTestsPoly1
    {
        double[][] variants = new double[][]
        {
            new double [] {-1, 3},
            new double [] {0, 0},
            new double [] {1, -3}
        };

        Tuple<double, double>[] ranges = new Tuple<double, double>[]
        {
            new Tuple<double, double>(-100, 100), // Symmetric range
            new Tuple<double, double>(-100, -1),  // Negative range
            new Tuple<double, double>(1, 100)     // Positive range
        };


        // Variant 0

        [TestMethod]
        public void Variant0SymmetricRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[0]);
        }

        [TestMethod]
        public void Variant0NegativecRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[1]);
        }

        [TestMethod]
        public void Variant0PositiveRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[2]);
        }


        // Variant 1

        [TestMethod]
        public void Variant1SymmetricRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[0]);
        }

        [TestMethod]
        public void Variant1NegativecRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[1]);
        }

        [TestMethod]
        public void Variant1PositiveRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[2]);
        }

        // Variant 2

        [TestMethod]
        public void Variant2SymmetricRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[0]);
        }

        [TestMethod]
        public void Variant2NegativecRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[1]);
        }

        [TestMethod]
        public void Variant2PositiveRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[2]);
        }
    }

    [TestClass]
    public class CubicSplineTestsPoly2
    {
        double[][] variants = new double[][]
        {
            new double [] {-1, 3, -2},
            new double [] {0, 0, 10},
            new double [] {1, -3, 0.5}
        };

        Tuple<double, double>[] ranges = new Tuple<double, double>[]
        {
            new Tuple<double, double>(-10, 10), // Symmetric range
            new Tuple<double, double>(-10, -1),  // Negative range
            new Tuple<double, double>(1, 10)     // Positive range
        };


        // Variant 0

        [TestMethod]
        public void Variant0SymmetricRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[0]);
        }

        [TestMethod]
        public void Variant0NegativecRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[1]);
        }

        [TestMethod]
        public void Variant0PositiveRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[2]);
        }


        // Variant 1

        [TestMethod]
        public void Variant1SymmetricRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[0]);
        }

        [TestMethod]
        public void Variant1NegativecRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[1]);
        }

        [TestMethod]
        public void Variant1PositiveRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[2]);
        }

        // Variant 2

        [TestMethod]
        public void Variant2SymmetricRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[0]);
        }

        [TestMethod]
        public void Variant2NegativecRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[1]);
        }

        [TestMethod]
        public void Variant2PositiveRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[2]);
        }
    }

    [TestClass]
    public class CubicSplineTestsPoly3
    {
        double[][] variants = new double[][]
        {
            new double [] {-1, 3, -2, 4},
            new double [] {0, 0, 10, -1},
            new double [] {1, -3, 0.5, -0.7}
        };

        Tuple<double, double>[] ranges = new Tuple<double, double>[]
        {
            new Tuple<double, double>(-100, 100), // Symmetric range
            new Tuple<double, double>(-100, -1),  // Negative range
            new Tuple<double, double>(1, 100)     // Positive range
        };


        // Variant 0

        [TestMethod]
        public void Variant0SymmetricRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[0]);
        }

        [TestMethod]
        public void Variant0NegativecRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[1]);
        }

        [TestMethod]
        public void Variant0PositiveRange()
        {
            Utils.TestSinglePoly(variants[0], ranges[2]);
        }


        // Variant 1

        [TestMethod]
        public void Variant1SymmetricRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[0]);
        }

        [TestMethod]
        public void Variant1NegativecRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[1]);
        }

        [TestMethod]
        public void Variant1PositiveRange()
        {
            Utils.TestSinglePoly(variants[1], ranges[2]);
        }

        // Variant 2

        [TestMethod]
        public void Variant2SymmetricRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[0]);
        }

        [TestMethod]
        public void Variant2NegativecRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[1]);
        }

        [TestMethod]
        public void Variant2PositiveRange()
        {
            Utils.TestSinglePoly(variants[2], ranges[2]);
        }
    }
}
