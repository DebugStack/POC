namespace CSharpDataStructures.DataStructures
{
    internal class DictionaryAndTuple
    {
        /// <summary>
        ///     Test Dictionary and Tuple Data structures in C#
        /// </summary>
        internal void TestDictionaryAndTuple()
        {
            // Declare data structure and assign the data
            var books = new Dictionary<string, Tuple<string, string, string>>
            {
                { "DataStructure", Tuple.Create("Java", "C#", "JavbaScript") },
                { "BhagwatGeeta", Tuple.Create("English", "Hindi", "Sanskrit") }
            };

            // Print your data 
            foreach (var book in books)
            {
                Console.WriteLine($"BookName: {book.Key}, " +
                    $"Languages: {book.Value.Item1} , {book.Value.Item2} , {book.Value.Item3}");
            }
        }
    }
}
