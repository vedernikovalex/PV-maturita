using System;

class Program
{
    public static void Main(String[] args)
    {
        // GENERICKE METODY
        string methodExample = "ahoj";
        var result = GenericMethods.GenericMethod(methodExample);
        Console.WriteLine(result);

        // GEWNERICKA TRIDA
        GenericClassExample<string> genericClassString = new GenericClassExample<string>();
        genericClassString.addToGenericList("Yes sir");

        // ENUM
        EnumExample enumExample = EnumExample.Value2;
        Console.WriteLine(((int)enumExample));
    }

}

// GENERICKE METODY
public class GenericMethods
{
    public static T GenericMethod<T>(T genericParametre)
    {
        Console.WriteLine(typeof(T).FullName);
        return genericParametre;
    }
}

// GENERICKA TRIDA
public class GenericClassExample<T>
{
    List<T> genericList = new List<T>();

    public void addToGenericList(T attribute)
    {
        genericList.Add(attribute);
        Console.WriteLine(attribute);
    }
}

// ENUM
public enum EnumExample
{
    Value1 = 5,
    Value2,
    Value3
}

