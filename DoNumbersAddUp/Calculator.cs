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
                for (int j = i + 1; j < numbers.Length; j++)
                {
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