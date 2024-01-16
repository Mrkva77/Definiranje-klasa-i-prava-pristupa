using System;

public class FoodType
{
    private string name;
    private int protein;
    private int carbs;
    private int fat;
    private static int counter = 0;

    public FoodType(string name, int protein, int carbs, int fat)
    {
        this.name = name;
        this.protein = protein;
        this.carbs = carbs;
        this.fat = fat;
        counter++;
    }

    public string Name
    {
        get { return name; }
    }

    public int Protein
    {
        get { return protein; }
    }

    public int Carbs
    {
        get { return carbs; }
    }

    public int Fat
    {
        get { return fat; }
    }

    public static int NumberOfCreatedInstances
    {
        get { return counter; }
    }

    public override string ToString()
    {
        return $"{name}: p - {protein}%, c - {carbs}%, f - {fat}%";
    }
}

public class Food
{
    private FoodType type;
    private int weight;

    public Food(FoodType type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public FoodType Type
    {
        get { return type; }
    }

    public int Weight
    {
        get { return weight; }
    }

    public double Protein
    {
        get { return type.Protein * weight / 100.0; }
    }

    public double Carbs
    {
        get { return type.Carbs * weight / 100.0; }
    }

    public double Fat
    {
        get { return type.Fat * weight / 100.0; }
    }

    public override string ToString()
    {
        return $"{type.ToString()}, w – {weight}g";
    }

    public string ToStringInGrams()
    {
        return $"{type.Name}: p – {Protein:F1}g, c – {Carbs:F1}g, f – {Fat:F1}g, w – {weight}g";
    }
}

class Program
{
    static void Main()
    {
        FoodType foodType = new FoodType("banana", 4, 93, 3);
        Food food = new Food(foodType, 110);

        Console.WriteLine(food.ToString());
        Console.WriteLine($"Number of created instances: {FoodType.NumberOfCreatedInstances}");

        Console.WriteLine($"\nProtein: {food.Protein}g");
        Console.WriteLine($"Carbs: {food.Carbs}g");
        Console.WriteLine($"Fat: {food.Fat}g");

        Console.WriteLine($"\n{food.ToStringInGrams()}");
    }
}