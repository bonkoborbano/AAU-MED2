using System.Diagnostics;

namespace ClassLibrary1;

public class HashSetMethods
{
    // Method for HashSet Operations
    
    static void Main(string[] args)
    {

        // Section 2: eliminating duplicates from an


        Console.WriteLine("Using HashSet");

        string[] names = new string[]
        {
            "John",
            "Mads",
            "John",
            "Richard",
            "Lars",
            "Jan",
            "Sam"
        };

        Console.WriteLine("Length of Array " + names.Length);
        Console.WriteLine();
        Console.WriteLine("The Data in Array");
        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();

        HashSet<string> hSet = new HashSet<string>(names);

        Console.WriteLine("Count of Data in HashSet " + hSet.Count);
        Console.WriteLine();

        Console.WriteLine("Data in HashSet");
        foreach (var n in hSet)
        {
            Console.WriteLine(n);
        }

        //Section 3: UnionWith() Method
        
        string[] names1 = new string[]
        {
            "John", "Mads", "Richard", "Lars", "Jan", "Sam"
        };

        string[] Names2 = new string[]
        {
            "Sandra", "John", "Paul", "Ronald", "McDonald", "George", "Sam"
        };


        HashSet<string> hSetN1 = new HashSet<string>(names1);
        Console.WriteLine("Data in First HashSet");
        foreach (var n in hSetN1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("__________________");
        HashSet<string> hSetN2 = new HashSet<string>(Names2);
        Console.WriteLine("Data in Second HashSet");
        foreach (var n in hSetN2)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("____________________");

        Console.WriteLine("Data After Union");
        hSetN1.UnionWith(hSetN2);
        foreach (var n in hSetN1)
        {
            Console.WriteLine(n);
        }

        // Section 4: ExceptWith() Method       
        Console.WriteLine();
        Console.WriteLine("_________________________________");
        Console.WriteLine("Data in HashSet before using Except With");
        Console.WriteLine("_________________________________");

        HashSet<string> hSetN3 = new HashSet<string>(names1);
        foreach (var n in hSetN3)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        Console.WriteLine("_________________________________");
        Console.WriteLine("Using Except With");
        Console.WriteLine("_________________________________");
        hSetN3.ExceptWith(hSetN2);
        foreach (var n in hSetN3)
        {
            Console.WriteLine(n);
        }

        // Section 5: SymmetricExceptWith() Method        
        HashSet<string> hSetN4 = new HashSet<string>(names1);
        Console.WriteLine("_________________________________");
        Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
        Console.WriteLine("_________________________________");
        Console.WriteLine("HashSet 1");
        foreach (var n in hSetN4)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("HashSet 2");
        foreach (var n in hSetN2)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("_________________________________");
        Console.WriteLine("Using SymmetricExceptWith");
        Console.WriteLine("_________________________________");
        hSetN4.SymmetricExceptWith(hSetN2);
        foreach (var n in hSetN4)
        {
            Console.WriteLine(n);
        }

        Get_Remove_Performance_HashSet_vs_List();
        Get_Contains_Performance_HashSet_vs_List();
        Get_Add_Performance_HashSet_vs_List();
    }
    
    // Section 6: Performance Test
    
    static string[] names = new string[] {
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis"};
    
   // Performance test for Remove operation 
   static void Get_Remove_Performance_HashSet_vs_List()
   {
   
       Console.WriteLine("____________________________________");
       Console.WriteLine("List Performance while performing Remove item operation");
       Console.WriteLine();
       List< string > lstNames = new List< string >();
       var s2 = Stopwatch.StartNew();
       foreach (string s in names)
       {
           lstNames.Remove(s);
       }
       s2.Stop();
 
       Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));            Console.WriteLine();
       Console.WriteLine("Ends Here");
       Console.WriteLine();
       Console.WriteLine("____________________________________");
       Console.WriteLine("HashSet Performance while performing Remove item operation");
       Console.WriteLine();
 
       HashSet< string > hStringNames = new HashSet< string >(StringComparer.Ordinal);
       var s1 = Stopwatch.StartNew();
       foreach (string s in names)
       {
           hStringNames.Remove(s);
       }
       s1.Stop();
 
       Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));            Console.WriteLine();
       Console.WriteLine("Ends Here");
       Console.WriteLine("____________________________________");
       Console.WriteLine();
 
   }
   
   // Performance test for Contains operation

   static void Get_Contains_Performance_HashSet_vs_List()
   {

       Console.WriteLine("____________________________________");
       Console.WriteLine("List Performance while checking Contains operation");
       Console.WriteLine();
       List<string> lstNames = new List<string>();
       var s2 = Stopwatch.StartNew();
       foreach (string s in names)
       {
           lstNames.Contains(s);
       }

       s2.Stop();

       Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
       Console.WriteLine();
       Console.WriteLine("Ends Here");
       Console.WriteLine();
       Console.WriteLine("____________________________________");
       Console.WriteLine("HashSet Performance while checking Contains operation");
       Console.WriteLine();

       HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
       var s1 = Stopwatch.StartNew();
       foreach (string s in names)
       {
           hStringNames.Contains(s);
       }

       s1.Stop();

       Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
       Console.WriteLine();
       Console.WriteLine("Ends Here");
       Console.WriteLine("____________________________________");
       Console.WriteLine();
   }


    
    
    // Performance test for Add operation

    
    static void Get_Add_Performance_HashSet_vs_List()
    {
     
        Console.WriteLine("____________________________________");
        Console.WriteLine("List Performance while Adding Item");
        Console.WriteLine();
        List< string > lstNames = new List< string >();
        var s2 = Stopwatch.StartNew();
        foreach (string s in names)
        {
            lstNames.Add(s);
        }
        s2.Stop();
 
        Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));            Console.WriteLine();
        Console.WriteLine("Ends Here");
        Console.WriteLine();
        Console.WriteLine("____________________________________");
        Console.WriteLine("HashSet Performance while Adding Item");
        Console.WriteLine();
    
        HashSet< string > hStringNames = new HashSet< string >(StringComparer.Ordinal);
        var s1 = Stopwatch.StartNew();
        foreach (string s in names)
        {
            hStringNames.Add(s);
        }
        s1.Stop();
 
        Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));            Console.WriteLine();
        Console.WriteLine("Ends Here");
        Console.WriteLine("____________________________________");
        Console.WriteLine();
    
    }
    
    /// When adding items to a HashSet vs. a List, the list will perform better.
    /// A HashSet will have to check every item to see if the added item is a match,
    /// to ensure there are no duplicates.
    /// When removing or checking if an item exists in the collection, the HashSet will perform better.
    /// This is becuase when removing or chehcking for an item,
    /// the HashSet will only have to check the hash code of the item.
    
    
}






    
