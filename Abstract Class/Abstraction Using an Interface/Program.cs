
interface IVehicle
{
    void Start();
    void Stop();
}
class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is Starting...");
    }
    public void Stop()
    {
        Console.WriteLine("Car is Stoping...");
    }
}
class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike is starting...");
    }
    public void Stop()
    {
        Console.WriteLine("Bike is stoping...");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IVehicle myCar = new Car();
        IVehicle myBike = new Bike();

        myCar.Start();
        myCar.Stop();
        myBike.Start();
        myBike.Stop();
    }
}