using System;
using System.Collections.Generic;

public class DrinkList<T>
{
    private List<T> drinks = new List<T>();


    public void AddDrink(T i)
    {
        drinks.Add(i);
    }

    public void ShowDrinks()
    {
        Console.WriteLine("Drinks: ");
        foreach (T i in drinks)
        {
            Console.WriteLine(i);
        }
    }
}

