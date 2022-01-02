using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class Algorithms
    {/*This function does change the original array,
        if you want it to not change the original array itself, you might consider modifying the function*/
        public static List<int> InsertionSort(List<int> input)
        {
            //To hold temporary values while swapping in array
            int tempNumb;
            //The minimum element to be swapped and its position in the searching area
            int min;
            int pos = 0;
            //To know if min variable has changed and needs to be swapped to left
            bool isMinChanged = false;

            for (int i = 0; i < input.Count; i++)
            {
                min = input[i];
                for (int i2 = i + 1; i2 < input.Count; i2++)
                {//Begin from after current position (i + 1) and search the rest of the array to find lowest value
                    if (input[i2] < min)
                    {
                        min = input[i2];
                        pos = i2;
                        isMinChanged = true;
                    }
                }//If a value is found, swap its position with current position
                if (isMinChanged)
                {
                    tempNumb = input[i];
                    input[i] = input[pos];
                    input[pos] = tempNumb;
                    isMinChanged = false;
                }
            }

            return input;
        }


        // **BUBBLE SORT**
        public static List<int> BubbleSort(List<int> input)
        {
            List<int> result = new List<int>(input);
            int totalSwaps = 0;
            int tempNumb = 0;
            for(int i = 0; i < result.Count; i++)
            {
                totalSwaps = 0;

                for(int i2 = 0; i2 < input.Count - 1; i2++)
                {
                    if(result[i2] > result[i2 + 1])
                    {
                        tempNumb = result[i2];
                        result[i2] = result[i2 + 1];
                        result[i2 + 1] = tempNumb;
                        totalSwaps++;
                    }
                }

                if (totalSwaps == 0)
                    break;
            }

            return result;
        }
    }
        
}
