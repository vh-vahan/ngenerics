/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class IdentityMatrix
    {

        [Test]
        public void Simple()
        {
            var matrix = Matrix.IdentityMatrix(10, 10);
            MatrixTest.TestDiagonalValues(matrix, 10, 10, 1);

            matrix = Matrix.IdentityMatrix(4, 7);
            MatrixTest.TestDiagonalValues(matrix, 4, 7, 1);
        }

        [Test]
        public void ExceptionInvalidRow1()
        {
            Assert.Throws<ArgumentException>(() => Matrix.IdentityMatrix(-1, 10));
        }

        [Test]
        public void ExceptionInvalidColumn1()
        {
            Assert.Throws<ArgumentException>(() => Matrix.IdentityMatrix(10, -1));
        }

        [Test]
        public void ExceptionInvalidRow2()
        {
            Assert.Throws<ArgumentException>(() => Matrix.IdentityMatrix(0, 10));
        }

        [Test]
        public void ExceptionInvalidColumn2()
        {
            Assert.Throws<ArgumentException>(() => Matrix.IdentityMatrix(10, 0));
        }
    }
}