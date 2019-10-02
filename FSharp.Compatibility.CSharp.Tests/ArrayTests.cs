using System;
using NUnit.Framework;
using FSharp.Compatibility.CSharp;

namespace FSharpx.CSharpTests {
    [TestFixture]
    public class ArrayTests {
        [Test]
        public void Does_not_conflict_with_System_Array() {
            var a = new[] {1,2,3};
            Array.Clear(a, 0, 0);
        }
    }
}
