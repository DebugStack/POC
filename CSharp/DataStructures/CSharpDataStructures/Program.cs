using CSharpDataStructures.DataStructures;

internal class Program
{
    /// <summary>
    /// This the main, using it for nessesary calls  only
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        #region Calling DictionaryAndTuple
        var dictionaryAndTuple = new DictionaryAndTuple();
        dictionaryAndTuple.TestDictionaryAndTuple();
        #endregion

        #region TupleAndNamedTuple

        var info = new TupleAndNamedTuple();

        var empLostInfo = info.GetEmpInfoUsingTuple();
        var empId = empLostInfo.Item1; // This is lost id

        var empInfo = info.GetEmpInfoUsingNamedTuple();
        var empName = empInfo.name; // Sensible

        #endregion

        #region Future calls

        #endregion
    }
}