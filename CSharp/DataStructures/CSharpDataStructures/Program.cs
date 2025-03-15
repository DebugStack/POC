using CSharpDataStructures.DataStructures;
using CSharpDataStructures.Tips;

internal class Program
{
    /// <summary>
    /// This the main, using it for nessesary calls  only
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        #region Calling DictionaryAndTuple

        //var dictionaryAndTuple = new DictionaryAndTuple();
        //dictionaryAndTuple.TestDictionaryAndTuple();

        #endregion

        #region TupleAndNamedTuple

        //var info = new TupleAndNamedTuple();

        //var empLostInfo = info.GetEmpInfoUsingTuple();
        //var empId = empLostInfo.Item1; // This is lost id

        //var empInfo = info.GetEmpInfoUsingNamedTuple();
        //var empName = empInfo.name; // Sensible

        #endregion

        #region Yield Return

        // var yld = new YieldKeyword();

        // var res = yld.GetAllHeadCounts();

        // var infinity = yld.InfiniteCounter();

        // foreach (var i in infinity)
        // {
        //     if (i > 5) break;
        //     Console.WriteLine(i);
        // }


        #endregion

        #region Future calls

        #endregion
    }
}