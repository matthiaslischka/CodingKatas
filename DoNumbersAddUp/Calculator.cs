namespace DoNumbersAddUp
{
    public class Calculator
    {
        public bool DoNumbersAddUp(int[] numbers, int sum)
        {
            if (numbers == null)
                return false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (numbers[i] + numbers[j] == sum)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}