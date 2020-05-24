using System;
using System.IO;
using System.Linq;
using System.Text;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    class Utils
    {
        public static void TestSpline(Func<double, double> f, double rangeStart, double rangeEnd)
        {
            // Фиксируем seed для повторяемости тестов
            Random rand = new Random(1000);
            int nPoints = 10; // rand.Next(2, 10);
            Point[] points = new Point[nPoints];
            for (int i = 0; i < nPoints; i++)
            {
                double x = rangeStart + (rangeEnd - rangeStart) * rand.NextDouble();
                points[i] = new Point(x, f(x));
            }

            CubicSpline spline = new CubicSpline(points);

            Point[] sortedPoints = points.OrderBy(p => p.getX()).ToArray();

            // Проверяем что точки функции и сплайна совпадают
            foreach (Point p in points)
            {
                double expected = p.getY();
                double test = spline.f(p.getX());
                Assert.AreEqual(expected, test, Math.Abs(expected * 1e-6));
            }

            // Проверяем совпадение первой и второй производной в точках соединения сплайнов
            for (int i = 1; i < spline.SubRanges.Length; i++)
            {
                // x слева и справа совпадают 
                Assert.AreEqual(spline.SubRanges[i - 1].Item2, spline.SubRanges[i].Item1);
                double x = spline.SubRanges[i].Item1;

                // Первая производная слева и с права совпадают
                double left1 = spline.Splines[i - 1].derivative(1).f(x - spline.SubRanges[i - 1].Item1);
                double right1 = spline.Splines[i].derivative(1).f(0);
                Assert.AreEqual(left1, right1, Math.Min(Math.Abs(left1), Math.Abs(right1)) * 1e-6);

                // Вторая производная слева и с права совпадают
                double left2 = spline.Splines[i - 1].derivative(2).f(x - spline.SubRanges[i - 1].Item1);
                double right2 = spline.Splines[i].derivative(2).f(0);
                Assert.AreEqual(left2, right2, Math.Min(Math.Abs(left2), Math.Abs(right2)) * 1e-6);
            }
        }
    }

    [TestClass]
    public class SplineTests
    {

        [TestMethod]
        public void TestSin()
        {
            Utils.TestSpline(x => Math.Sin(x), -6, 6);
        }

        [TestMethod]
        public void TestPoly()
        {
            Utils.TestSpline(x => 0.2 * x * x + x - 10, 0, 20);
        }

        [TestMethod]
        public void TestRand()
        {
            Random rand = new Random(100);
            for (int i = 0; i < 100; i++)
            {
                double rangeStart = rand.Next(-100, 100);
                double rangeEnd = rangeStart + rand.Next(10, 100);

                Utils.TestSpline(x => rangeStart + (rangeEnd - rangeStart) * rand.NextDouble(), rangeStart, rangeEnd);
            }


        }

    }

    [TestClass]
    public class TestFileInput
    {
        private Point[] readFromStr(string str) 
        {
            byte[] byteArr = Encoding.ASCII.GetBytes(str);
            MemoryStream ms = new MemoryStream(byteArr);
            return Data.Utils.GetPointsFromFile(ms).ToArray();
        }
        [TestMethod]
        public void InputTest() 
        {
            Point[] t = readFromStr("1 2");
            Assert.AreEqual(1, t.Length);
            Assert.AreEqual(1, t[0].getX());
            Assert.AreEqual(2, t[0].getY());
        }
        [TestMethod]
        public void InputTestNegotive()
        {
            Point[] t = readFromStr("+1 -2");
            Assert.AreEqual(1, t.Length);
            Assert.AreEqual(1, t[0].getX());
            Assert.AreEqual(-2, t[0].getY());
        }
        [TestMethod]
        public void InputTestDot()
        {
            Point[] t = readFromStr("1.123 -2.44");
            Assert.AreEqual(1, t.Length);
            Assert.AreEqual(1.123, t[0].getX());
            Assert.AreEqual(-2.44, t[0].getY());
        }
        [TestMethod]
        public void InputTestExp()
        {
            Point[] t = readFromStr("1e+1 1e-2");
            Assert.AreEqual(1, t.Length);
            Assert.AreEqual(10, t[0].getX());
            Assert.AreEqual(0.01, t[0].getY());
        }
        [TestMethod]
        public void InputTestMultyString()
        {
            Point[] t = readFromStr("1.123 -2.44\n2 3\n");
            Assert.AreEqual(2, t.Length);
            Assert.AreEqual(1.123, t[0].getX());
            Assert.AreEqual(-2.44, t[0].getY());
            Assert.AreEqual(2, t[1].getX());
            Assert.AreEqual(3, t[1].getY());
        }
        [TestMethod]
        public void InputTestEmpty()
        {
            Point[] t = readFromStr("");
            Assert.AreEqual(0, t.Length);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IncorectInputTest()
        {
            Point[] t = readFromStr("1 2 3");
            
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void IncorectInputTestNan()
        {
            Point[] t = readFromStr("1 a");
        }
    }
    

}
