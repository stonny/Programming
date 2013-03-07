using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TestGenericList
{
    static void Main(string[] args)
    {
        // Initializing testArray and testing AddElement Method
        GenericList<int> testArray = new GenericList<int>(2);
        Console.WriteLine("Testing Add Elements");
        Console.WriteLine(new string('-', 25));
        testArray.AddElement(5);
        testArray.AddElement(19);
        testArray.AddElement(20);
        testArray.AddElement(-5);
        Console.WriteLine(testArray);
        Console.WriteLine();

        // Testing remove at index method
        Console.WriteLine("Testing Remove at Index");
        Console.WriteLine(new string('-', 25));
        testArray.RemoveAtIndex(3);
        Console.WriteLine(testArray);
        Console.WriteLine();

        // Testing access by index method
        Console.WriteLine("Testing Acces By Index");
        Console.WriteLine(new string('-', 25));
        Console.WriteLine(testArray.AccessByIndex(2));
        Console.WriteLine();
        

        // Testing Insert element at index
        Console.WriteLine("Test Insert at Index Element");
        Console.WriteLine(new string('-', 25));
        testArray.InsertAtIndex(1, 9);
        testArray.InsertAtIndex(2, 153);
        Console.WriteLine(testArray);
        Console.WriteLine();

        // Testing Find by value element
        Console.WriteLine("Test Find By Value Element");
        Console.WriteLine(new string('-', 25));
        Console.WriteLine(testArray.ElementByValue(9));
        Console.WriteLine(testArray.ElementByValue(123));
        Console.WriteLine();

        // Testing Max and Min method
        Console.WriteLine("Max and Min Methot Test");
        Console.WriteLine(new string('-', 25));
        Console.Write("Max element is: ");
        Console.WriteLine(testArray.GetMax());
        Console.Write("Min element is: ");
        Console.WriteLine(testArray.GetMin());
        Console.WriteLine();
        // Testing Clear List
        Console.WriteLine("Testing Clear List Method");
        Console.WriteLine(new string('-', 25));
        testArray.ClearList();
        Console.WriteLine(testArray);
        Console.WriteLine();

        
        
    }
}

