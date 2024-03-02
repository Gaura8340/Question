using System;
using System.Collections;

class Program
{
    static void Main()
    {

        ArrayList arrayList = new ArrayList();

     
        arrayList.Add("Apple");
        arrayList.Add(563);
        arrayList.Add(8.19);
        arrayList.Add(true);

     
        Console.WriteLine("ArrayList elements:");
        DisplayArrayList(arrayList);

       
        arrayList.Insert(1, "Banana");


        Console.WriteLine("\nArrayList elements after insertion:");
        DisplayArrayList(arrayList);

       
        arrayList.Remove(123);

   
        Console.WriteLine("\nArrayList elements after removal:");
        DisplayArrayList(arrayList);

  
        Console.WriteLine("\nDoes 'Banana' exist in the ArrayList? " + arrayList.Contains("Banana"));

 
        Console.WriteLine("Index of '3.14': " + arrayList.IndexOf(3.14));

    
        arrayList.Clear();

     
        Console.WriteLine("\nArrayList elements after clearing:");
        DisplayArrayList(arrayList);
        
        Console.WriteLine("Name:- Gaurav Kumar Rai");
        Console.WriteLine("Roll.no:27 , MCA II A");

    }


    static void DisplayArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
