interface INotification
{
    void SendNotification(string messege);
}

class SMSNotification : INotification
{
    public void SendNotification(string messege)
    {
        Console.WriteLine($"Sending SMS: {messege}");
    }
}
class EmailNotification : INotification
{
    public void SendNotification(string messege)
    {
        Console.WriteLine($"Sending Email: {messege}");
    }
}
class PushNotification: INotification
{
    public void SendNotification(string messege)
    {
        Console.WriteLine($"Sending Push Notification: {messege}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        INotification newSMS = new SMSNotification();
        INotification newEmail = new EmailNotification();
        INotification newPush = new PushNotification();

        newSMS.SendNotification("Your order has been shipped!");
        newEmail.SendNotification("Welcome to our service!");
        newPush.SendNotification("You have new messege!");
    }
}

