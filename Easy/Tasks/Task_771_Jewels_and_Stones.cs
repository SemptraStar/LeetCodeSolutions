using System.Linq;

namespace LeetCodeProjects.Easy.Tasks
{
    public class Task_771_Jewels_and_Stones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            return stones.Count(x => jewels.Contains(x));
        }
    }
}
