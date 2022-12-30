/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car

dealer d = new dealer(123, "Jesper");
Car myNewCar = d.Buy(4);
Person p = new Person();

Console.WriteLine("Car Dealer: Hello welcome to my car shop.\nDo you want to see what i have in store?");

Console.WriteLine("Type 0 for a BMW.\nType 1 for a Toyota.\nType 2 for a Ford.\nType 3 for a Mercedes.\nType 4 for a Mazda.");
string input = Console.ReadLine();
int carId = int.Parse(input);
Car YouBought = d.Buy(carId);
Console.WriteLine(YouBought.ToString());
Console.ReadKey();

Console.WriteLine("Do you want to buy the car?");

Car MySoldCar = d.sell(4);

Console.WriteLine("Do you want to sell your car?\nPress 0");
input = Console.ReadLine();
carId = int.Parse(input);
Car YouBought2 = d.Buy(carId);

p.MyCars.Add(YouBought2);
p.MyCars.Add(YouBought);

Console.WriteLine(YouBought.ToString());
Console.ReadKey();


//En eller anden køber hos JEsper

Console.ReadKey();

//Class definition

#region Door and Tire Classes

#endregion