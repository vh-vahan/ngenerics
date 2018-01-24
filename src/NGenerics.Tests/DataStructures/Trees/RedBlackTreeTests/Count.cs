/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NGenerics.DataStructures.Trees;
using NGenerics.Extensions;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.RedBlackTreeTests
{
    [TestFixture]
    public class Count : RedBlackTreeTest
    {

        [Test]
        public void Simple()
        {
            var redBlackTree = GetTestTree();
            Assert.IsFalse(redBlackTree.IsEmpty());

            redBlackTree.Clear();
            Assert.IsTrue(redBlackTree.IsEmpty());

            redBlackTree = new RedBlackTree<int, string>();
            Assert.IsTrue(redBlackTree.IsEmpty());
        }

    }
}