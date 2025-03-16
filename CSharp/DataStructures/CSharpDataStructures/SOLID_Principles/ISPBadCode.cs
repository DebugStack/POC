namespace CSharpDataStructures.SOLID_Principles
{
    internal interface IPrinter
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
    }


    //This is a Bad code, because the printer is forced to implement all the methods
    class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Basic Printer is printing");
        }
        public void Scan(string content)
        {
            throw new NotImplementedException("Basic printer doesn't have a scanner");
        }
        public void Fax(string content)
        {
            throw new NotImplementedException("Basic printer doesn't have a Fax");
        }
    }

    class AdvancedPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("HP LaserJet is printing");
        }
        public void Scan(string content)
        {
            Console.WriteLine("HP LaserJet is scanning");
        }
        public void Fax(string content)
        {
            Console.WriteLine("HP LaserJet is faxing");
        }
    }
}
