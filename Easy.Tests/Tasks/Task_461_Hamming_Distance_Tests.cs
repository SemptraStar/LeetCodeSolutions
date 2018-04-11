using LeetCodeProjects.Easy.Tasks;

using NUnit.Framework;

namespace LeetCodeProjects.Easy.Tests.Tasks
{
    [TestFixture]
    public class Task_461_Hamming_Distance_Tests
    {
        [Test]
        public void HammingDistance_Test1()
        {
            var task = new Task_461_Hamming_Distance();

            int x = 1;
            int y = 4;

            Assert.AreEqual(2, task.HammingDistance(x, y));
        }
    }
}
