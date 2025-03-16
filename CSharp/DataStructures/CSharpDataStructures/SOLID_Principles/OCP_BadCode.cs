namespace CSharpDataStructures.SOLID_Principles
{
    // Bad example of Open -Closed Principle
    // Every time you add a new notification type (e.g., WhatsApp, Push), you will need to modify this class.
    class Notification
    {
        public void SendNotification(string type, string message)
        {
            if (type == "Email")
            {
                Console.WriteLine("Sending Email: " + message);
            }
            else if (type == "SMS")
            {
                Console.WriteLine("Sending SMS: " + message);
            }
            // What if, I want to add WhatsApp notification now...????
        }
    }
}
