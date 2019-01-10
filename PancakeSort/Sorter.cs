using System;
using System.Linq;

namespace PancakeSort
{
    public class Sorter
    {
        Flipper flipper = new Flipper();

        public int[] SortFromBackToFront(int[] arr)
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

        public int[] SortWithMax(int[] arr)
        {
            if (arr.Length < 2)
                return arr;

            int currentLenght = arr.Length;
            var currentMax = arr.Take(currentLenght).Max();

            while(currentLenght>1)
            {
                for (int i = 0; i < currentLenght - 1; i++)
                {
                    if (arr[i] == currentMax)
                    {
                        arr = MoveToPosition(arr, i, currentLenght - 1);
                        break;
                    }
                }
                currentLenght--;
                currentMax = arr.Take(currentLenght).Max();
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