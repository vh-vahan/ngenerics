/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.AutoKeyDictionaryTests
{
    [TestFixture]
    public class InternalRemove
    {
        [Test]
        public void Simple()
        {
            var target = new AutoKeyDictionary<string, int>(x => x.ToString()) { 2 };
            Assert.IsTrue(target.ContainsKey("2"));
            Assert.IsTrue(target.InternalRemove("2"));
            Assert.IsFalse(target.ContainsKey("2"));
        }

        [Test]
        public void ExceptionNullKey()
        {
            var target = new AutoKeyDictionary<string, int>(x => x.ToString());
            Assert.Throws<ArgumentNullException>(() => target.InternalRemove(null));
        }
    }
}