namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        /// <summary>
        /// Method sort an array of int
        /// </summary>
        /// <param name="array"></param>
        /// <returns>sorted array</returns>
        public int[] Sort(int[] items)
        {
            //1. For each value in the array...
            for (int i = 1; i < items.Length; ++i)
            {
                //2. Store the current value in a variable.
                int currentValue = items[i];
                int pointer = i - 1;

                //3. While we are pointing to a valid value...
                //4. If the current value is less than the value we are pointing at...
                while (pointer >= 0 && items[pointer] > currentValue)
                {
                    //5. Then move the pointed-at value up one space, and store the
                    //   current value at the pointed-at position.
                    items[pointer + 1] = items[pointer];
                    pointer = pointer - 1;
                }
                items[pointer + 1] = currentValue;
            }

            return items;
        }
    }
}
