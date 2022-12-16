/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car

dealer d = new dealer(123,"Jesper");
Car myNewCar = d.Buy(4);
{
    {


        Console.WriteLine("Type 1 for a BMW.\n Type 2 for a Toyota.\n Type 3 for a Ford.\n Type 4 for a Mercedes.\n Type 5 for a Mazda.");
        string input = Console.ReadLine();
        int carId = int.Parse(input);
        Car YouBought = d.Buy(carId);
        Console.WriteLine(YouBought.ToString());
        Console.ReadKey();
    }
}



//En eller anden køber hos JEsper

Console.ReadKey();

//Class definition

#region Door and Tire Classes

#endregion