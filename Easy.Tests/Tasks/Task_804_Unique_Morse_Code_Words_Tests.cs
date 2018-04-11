using LeetCodeProjects.Easy.Tasks;

using NUnit.Framework;

namespace Easy.Tests.Tasks
{
    [TestFixture]
    public class Task_804_Unique_Morse_Code_Words_Tests
    {
        [Test]
        public void UniqueMorseRepresentations_Test1()
        {
            var task = new Task_804_Unique_Morse_Code_Words();

            string[] words = { "gin", "zen", "gig", "msg" };

            Assert.AreEqual(2, task.UniqueMorseRepresentations(words));
        }
    }
}
