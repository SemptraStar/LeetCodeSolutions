namespace LeetCodeProjects.Tasks
{
    public class Task_657_Judge_Route_Circle
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            foreach(var move in moves)
            {
                switch (move)
                {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'R':
                        x++;
                        break;
                    case 'L':
                        x--;
                        break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
