using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
