namespace CSharpDataStructures.SOLID_Principles
{
    interface INotification
    {
        void Send(string message);
    }

    // This code is following the Open-Closed Principle
    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

    class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    // If i need WhatsApp notification, I can just add a new class, will extend but not modify any exsiting class
}
