namespace LeetCodeProjects.Tasks
{
    public class Task_617_Merge_Two_Binary_Trees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            return t1 == null && t2 == null ? null : 
                new TreeNode((t1?.val ?? 0) + (t2?.val ?? 0))
                {
                    left = MergeTrees(t1?.left, t2?.left),
                    right = MergeTrees(t1?.right, t2?.right)
                };
        }

        public class TreeNode
        {
            public int val;

            public TreeNode left;

            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }

            public static bool Equals(TreeNode node1, TreeNode node2)
            {
                if (node1 == null && node2 == null)
                    return true;

                if (node1?.val != node2?.val)
                {
                    return false;
                }

                return Equals(node1?.left, node2?.left) && Equals(node1?.right, node2?.right);
            }
        }
    }   
}
