using LeetCodeProjects.Tasks;
using static LeetCodeProjects.Tasks.Task_617_Merge_Two_Binary_Trees;

using NUnit.Framework;

namespace Easy.Tests.Tasks
{
    [TestFixture]
    public class Task_617_Merge_Two_Binary_Trees_Tests
    {
        [Test]
        public void MergeTrees_Test()
        {
            var task = new Task_617_Merge_Two_Binary_Trees();

            var tree1 = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(5)
                },
                right = new TreeNode(2)
            };

            var tree2 = new TreeNode(2)
            {
                left = new TreeNode(1)
                {
                    right = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(7)
                }
            };

            var resultTree = new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(4)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(7)
                }
            };

            var mergedTree = task.MergeTrees(tree1, tree2);

            Assert.IsTrue(TreeNode.Equals(resultTree, mergedTree));
        }
    }
}
