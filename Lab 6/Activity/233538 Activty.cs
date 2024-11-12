
/*
using System;
using System.Collections.Generic;

class GenericListActivity
{
    static void Main()
    {

       List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);

        Console.WriteLine("Original list");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        numbers.Remove(3);
        Console.WriteLine("List after removal");
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }

        numbers.Sort();
        Console.WriteLine("List after Sorted");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}
*/

// Activity 2
/*
using System;
using System.Collections.Generic;

class DictionaryActivity
{
    static void Main()
    {
        Dictionary<string,string> countries = new Dictionary<string,string>();

        countries["USA"] = "Wishigtion ,D.c";
        countries["France"] = "Paris ";
        countries["Japan"] = "Tokyo";
        countries["India"] = "New Delhi";

        Console.WriteLine("Countries and Capiotals");
        foreach (var pair in countries)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        Console.WriteLine($"\n Capital of Japan is: {countries["Japan"]}");

        countries.Remove("France");

        Console.WriteLine("Update: ");
        foreach(var pair in countries)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}
*/
/*
// Activity 3
using System;
using System.Collections;

class NonGenericActivity
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();

        arrayList.Add(10);
        arrayList.Add("Hello");
        arrayList.Add(20.5);
        arrayList.Add("World");


        Console.WriteLine("Array list HAve" );
        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }

        arrayList.Remove("Hello");

        Console.WriteLine("Updated Array list HAve");
        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
class StudentManagementSystem
{
    static void Main()
    {
        Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
        students["Alice"] = new List<int> { 85, 88, 98 };
        students["Bob"] = new List<int> { 70, 60, 75 };
        students["Charli"] = new List<int> { 95, 94, 92 };
        students["Dairy"] = new List<int> { 56, 60, 58 };
        Console.WriteLine("Students Average");
        foreach (var student in students)
        {
            double average = student.Value.Average();
            Console.WriteLine($" {student.Key} {average:F2}");

        }
        var topStudent = students.OrderByDescending(students => students.Value.Average()).First();
        var lowStudent = students.OrderBy(students => students.Value.Average()).First();
        Console.WriteLine($"Top performing Student : {topStudent.Key} with average of {topStudent.Value.Average():F2}");
        Console.WriteLine($"Top performing Student : {lowStudent.Key} with average of {lowStudent.Value.Average():F2}");
        var failstudent = students.Where(s => s.Value.Average() < 60).Select(s=>s.Key).ToList();
        foreach (var student in failstudent) { students.Remove(student); }

        Console.WriteLine("Data ");
        foreach (var student in students)
        {
            Console.WriteLine(student.Key);
        }

    }
}*/
/*using System;
using System.Collections.Generic;
class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> countries = new Dictionary<string, string>();


    }
}*/
/*
using System;
using System.Collections;
class nongenerActivity
{
    static void Main()
    {
        ArrayList arraylist = new ArrayList();
        arraylist.Add(1);
        arraylist.Add("hello");   
        arraylist.Add(30.3);
        arraylist.Add("world");
        Console.WriteLine("Array list have");
        foreach (var i in arraylist) { Console.WriteLine(i);}
        Console.WriteLine("Updated List ");
        arraylist.Remove(1);
        Console.WriteLine("updated list ");
        foreach(var i in arraylist) { Console.WriteLine(i);}
    }
}*/