using LeetCodeProjects.Tasks;

using NUnit.Framework;

namespace Easy.Tests.Tasks
{
    [TestFixture]
    public class Task_657_Judge_Route_Circle_Tests
    {
        [Test]
        public void JudgeCircle_Test1()
        {
            var task = new Task_657_Judge_Route_Circle();

            string moves = "UD";

            Assert.AreEqual(true, task.JudgeCircle(moves));
        }

        [Test]
        public void JudgeCircle_Test2()
        {
            var task = new Task_657_Judge_Route_Circle();

            string moves = "LL";

            Assert.AreEqual(false, task.JudgeCircle(moves));
        }
    }
}
