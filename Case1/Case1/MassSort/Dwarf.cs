namespace Case1.MassSort
{
    public class Dwarf : ISort
    {
        public int[] SortMass(int[] firstArgument)
        {
            int i = 1;
            int j = 2;
            while (i < firstArgument.Length)
            {
                if (firstArgument[i - 1] <= firstArgument[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int swapValue = firstArgument[i - 1];
                    firstArgument[i - 1] = firstArgument[i];
                    firstArgument[i] = swapValue;
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
            return firstArgument;
        }
    }
}
