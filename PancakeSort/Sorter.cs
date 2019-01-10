namespace PancakeSort
{
    public class Sorter
    {
        Flipper flipper = new Flipper();

        public int[] Sort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    while (arr[i] < arr[j])
                    {
                        arr = MoveToPosition(arr, j, i);
                        j = i - 1;
                    }
                }
            }

            return arr;
        }

        public int[] MoveToPosition(int[] arr, int startPos, int targetPos)
        {
            var flippedToStartPos = flipper.Flip(arr, startPos + 1);
            return flipper.Flip(flippedToStartPos, targetPos + 1);
        }
    }
}