namespace LeetCodeProjects.Easy.Tasks
{
    public class Task_461_Hamming_Distance
    {
        public int HammingDistance(int x, int y)
        {
            return BitsCount(x ^ y);
        }

        private int BitsCount(int number)
        {
            int numberOfSetBits;

            for (numberOfSetBits = 0; number > 0; numberOfSetBits++)
            {
                number &= number - 1;
            }

            return numberOfSetBits;
        }
    }
}
