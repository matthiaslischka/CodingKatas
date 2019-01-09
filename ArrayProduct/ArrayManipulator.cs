namespace ArrayProduct
{
    public class ArrayManipulator
    {
        public int[] GenerateArrayProducts(int[] input)
        {
            if (input == null)
                return new int[] { };

            var result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int? tmpProduct = null;
                for (int j = 0; j < input.Length; j++)
                {
                    if (j == i)
                        continue;

                    if (tmpProduct == null)
                        tmpProduct = input[j];
                    else
                        tmpProduct *= input[j];
                }

                result[i] = tmpProduct ?? 0;
            }

            return result;
        }
    }
}