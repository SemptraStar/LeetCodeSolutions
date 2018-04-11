using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using LeetCodeProjects.Easy.Tasks;

namespace LeetCodeProjects.Easy.Tests
{
    [TestFixture]
    public class Task_771_Jewels_and_Stones_Test
    {
        [Test]
        public void NumJewelsInStones_Test1()
        {
            var task = new Task_771_Jewels_and_Stones();
            string jewels = "aA";
            string stones = "aAAbbbb";

            Assert.AreEqual(3, task.NumJewelsInStones(jewels, stones));
        }

        [Test]
        public void NumJewelsInStones_Test2()
        {
            var task = new Task_771_Jewels_and_Stones();
            string jewels = "z";
            string stones = "ZZZ";

            Assert.AreEqual(0, task.NumJewelsInStones(jewels, stones));
        }
    }
}
