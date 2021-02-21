using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab8.CMD;
namespace lab8.CMD.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod]
        public void Sum()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] array2 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Matrix expected = new Matrix(new double[3, 3] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } });
            Matrix actual = new Matrix(array1) + new Matrix(array2);

            Assert.IsTrue(actual.EqualTo(expected));
        }
        [TestMethod]
        public void Sub()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] array2 = new double[3, 3] { { 5, 6, -1 }, { 0, 6, 1 }, { 2, 6, 3 } };

            Matrix expected = new Matrix(new double[3, 3] { { -4, -4, 4 }, { 4, -1, 5 }, { 5, 2, 6 } });
            Matrix actual = new Matrix(array1) - new Matrix(array2);

            Assert.IsTrue(actual.EqualTo(expected));
        }
        [TestMethod]
        public void Mul()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] array2 = new double[3, 3] { { 1, 5, 4 }, { 2, 1, 5 }, { 6, 3, 9 } };

            Matrix expected = new Matrix(new double[3, 3] { { 23, 16, 41 }, { 50, 43, 95 }, { 77, 70, 149 } });
            Matrix actual = new Matrix(array1) * new Matrix(array2);

            Assert.IsTrue(actual.EqualTo(expected));
        }
    }
}