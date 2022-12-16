public class dealer
{
    public float Money;
    public string Name;

    public List<Car> Cars;

    public dealer(float mon, string nam)
    {
        Money = mon;
        Name = nam;
        Random rnd = new Random();
        Cars = new List<Car>();
        Cars.Add(new Car("BMW", rnd.Next(25000, 80000)));
        Cars.Add(new Car("Toyota", rnd.Next(10000, 80000)));
        Cars.Add(new Car("Ford", rnd.Next(15000, 80000)));
        Cars.Add(new Car("Mercedes", rnd.Next(20000, 80000)));
        Cars.Add(new Car("Mazda", rnd.Next(10000, 80000)));

        Console.WriteLine(Cars[0].Price.ToString());
    }
    public Car Buy(int id)
    {
        Car bought = Cars[id];
        Cars.RemoveAt(id);
        return bought;

    }

}