/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/


using System;
using System.Collections.Generic;
using NGenerics.DataStructures.General.Observable;
using NGenerics.Tests.TestObjects;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.Observable.ObservableHashListTests
{
    [TestFixture]
    public class RemoveValue
    {
        [Test]
        public void Simple()
        {
            var hashList = new ObservableHashList<string, string> { { "foo", "bar" } };

            ObservableCollectionTester.ExpectEvents(hashList, obj => obj.RemoveValue("bar"), "Count", "Item[]", "IsEmpty", "ValueCount", "KeyCount");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionReentrancy()
        {
            var hashList = new ObservableHashList<string, string>();
            new ReentracyTester<ObservableHashList<string, string>>(hashList, obj => obj.AddItem(new KeyValuePair<string, string>("foo", "foo")));
        }
    }

}