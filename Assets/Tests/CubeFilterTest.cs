using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            //Assert.IsTrue(false);

            int[] input = { 1, 3, 5, 7, 9 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729 };

            //foreach (var o in output)
            //{
            //    Debug.Log(o);
            //}

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
