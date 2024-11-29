namespace CSharpDataStructures.DataStructures
{
    internal class TupleAndNamedTuple
    {
        // Look at the calls made to these methods in Programs.cs

        /// <summary>
        ///     Get EmpInfo Using Un-named Tuple
        /// </summary>
        /// <returns>Un-Named Tuple</returns>
        internal Tuple<int, string, string> GetEmpInfoUsingTuple()
        {
            return new Tuple<int, string, string>(10001, "John", "IT");
        }

        /// <summary>
        ///     Get EmpInfo Using named Tuple
        /// </summary>
        /// <returns>Named Tuple</returns>
        internal (int empId, string name, string department) GetEmpInfoUsingNamedTuple()
        {
            return new(10001, "John", "IT");
        }
    }
}
