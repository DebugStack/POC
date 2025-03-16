namespace CSharpDataStructures.SOLID_Principles
{
    interface IBasicPrinter
    {
        void TurnOnOrOff(bool flag);
        void Print(string content);
    }

    interface IScanner
    {
        void Scan(string content);
    }

    interface IFax
    {
        void Fax(string content);
    }

    //This code is following the Interface Segregation Principle
    class TheBasicPrinter : IBasicPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Basic Printer can Print");
        }

        public void TurnOnOrOff(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("Basic Printer is ON");
            }
            else
            {
                Console.WriteLine("Basic Printer is OFF");
            }
        }
    }

    class TheAdvancedPrinter : IBasicPrinter, IScanner, IFax
    {
        public void Fax(string content)
        {
            Console.WriteLine("Advance Printer can Fax");
        }

        public void Print(string content)
        {
            Console.WriteLine("Advance Printer can Print");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Advance Printer can Scan");
        }

        public void TurnOnOrOff(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("Basic Printer is ON");
            }
            else
            {
                Console.WriteLine("Basic Printer is OFF");
            }
        }
    }
}
