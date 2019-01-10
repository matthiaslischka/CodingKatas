namespace PancakeSort
{
    public class Flipper
    {
        public int[] Flip(int[] arr, int k)
        {
            if (arr.Length < 2 || k < 2)
                return arr;

            for (int i = 0; i < k / 2; i++)
            {
                var flipWithIndex = k - 1 - i;
                int tmpI = arr[flipWithIndex];
                arr[flipWithIndex] = arr[i];
                arr[i] = tmpI;
            }
            return arr;
        }
    }
}