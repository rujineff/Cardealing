public class dealer{
    public float Money;
    public string Name;

    public List<Car> Cars;

    public dealer(float mon, string nam){
        Money = mon;
        Name = nam;
        Cars = new List<Car>();
        Cars.Add(new Car("BMW"));
        Cars.Add(new Car("Toyota"));
        Cars.Add(new Car("Ford"));
        Cars.Add(new Car("Mercedes"));
        Cars.Add(new Car("Mazda"));
    }

}