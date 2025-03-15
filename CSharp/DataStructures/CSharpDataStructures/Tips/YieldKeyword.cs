namespace CSharpDataStructures.Tips
{
    internal class YieldKeyword
    {
        /*
            What is yield return in C#?yield return in C# is a way to lazily produce a sequence of values, 
            one at a time, without storing them all in memory at once. It allows you to create iterators that 
            return each value only when it's needed, which is useful for performance and memory efficiency. 
         */

        /// <summary>
        ///  Return without yield will retuern you all data in memmory
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<int> GetAllHeadCounts()
        {
            var count = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                count.Add(i);
            }
            return count;
        }

        /// <summary>
        ///     Yield Return: Think of yield return like a pause button. Each time the yield return statement runs, 
        ///     it sends a value back to the caller and pauses the function. When the caller asks for the next value, 
        ///     the function picks up where it left off.
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<int> GetHeadCountsOnDemand()
        {
            for (int i = 0; i < 1000; i++)
            {
                yield return i;
            }
        }


        // This will suck your memory, if you return a list here 
        internal IEnumerable<int> InfiniteCounter()
        {
            List<int> count = new List<int>();
            int i = 0;
            while (true)
            {
                Console.WriteLine(i++);
                count.Add(i++);
                // yield return i++;  // Return the current value and increment.
            }
        }


        // This is the solution  
        internal IEnumerable<int> InfiniteCounterSolution()
        {
            List<int> count = new List<int>();
            int i = 0;
            while (true)
            {
                Console.WriteLine(i++);
                yield return i++;  // Return the current value and increment.
            }
        }
    }
}
