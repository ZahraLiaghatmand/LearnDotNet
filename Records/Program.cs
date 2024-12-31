//Records support with expressions,
//which allow you to create a copy of a record with some properties modified.
/*
var car1 = new Car("Toyota", "Corolla", 2022);
var car2 = car1 with { Year = 2023 };

Console.WriteLine(car1); 
// Output: Car { Make = Toyota, Model = Corolla, Year = 2022 }
//Console.WriteLine(car2);
// Output: Car { Make = Toyota, Model = Corolla, Year = 2023 }
*/

var car1 = new Car_Record("Toyota", "Corolla", 2022);
var car2 = new Car_Record("Toyota", "Corolla", 2022);
Console.WriteLine(car1.Equals(car2)); //true

var car_class1 = new Car_Class("Toyota", "Corolla", 2022);
var car_class2 = new Car_Class("Toyota", "Corolla", 2022);
Console.WriteLine(car_class1.Equals(car_class2)); //false

public record Car_Record(string Make, string Model, int Year);

//what Compiler generates:
public class Car_Class
{
    private readonly string _Make;
    private readonly string _Model;
    private readonly int _Year;
    public Car_Class(string Make, string Model, int Year)
    { _Make = Make; _Model = Model; _Year = Year; }
    public string Make { get => _Make; }
    public string Model { get => _Model; }
    public int Year { get => _Year; }
    //Clone method for nondestructive mutation
    //Equals method for comparing the values of two reference types
}

