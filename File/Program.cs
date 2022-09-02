// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System;
//using System.IO;

//1.Write a program in C# Sharp to create and read the last line of a file.
//class file
//{
//	static void Main()
//	{
//		string fileName = @"mytest.txt";
//		string[] ArrLines;
//		int n, i;

//		Console.WriteLine(" Create and read the last line of a file  :");

//		if (File.Exists(fileName))
//		{
//			File.Delete(fileName);
//		}
//		Console.Write(" Input number of lines to write in the file  :");
//		n = Convert.ToInt32(Console.ReadLine());
//		ArrLines = new string[n];
//		Console.Write(" Input {0} strings below :\n", n);
//		for (i = 0; i < n; i++)
//		{
//			Console.Write(" Input line {0} : ", i + 1);
//			ArrLines[i] = Console.ReadLine();
//		}
//		System.IO.File.WriteAllLines(fileName, ArrLines);
//		Console.Write("\n The content of the last line of the file {0} is  :\n", fileName);
//		if (File.Exists(fileName))
//		{
//			string[] lines = File.ReadAllLines(fileName);
//			Console.WriteLine(" {0}", lines[n - 1]);
//		}
//		Console.WriteLine();
//	}
//}
//2.Write a program to calculate all files and directories count in a given directory
//class Program
//{
//    static void Main(string[] args)
//    {
//        DirectoryInfo d = new DirectoryInfo(@"C:\Intel\gp");
//        FileInfo[] f = d.GetFiles("*", SearchOption.AllDirectories);
//        Console.WriteLine(f.Length.ToString());
//    }
//}
//3.Please remove the item with the key 'Han' from the dictionary:
using System.Collections.Generic;
//public class Program
//{
//    public static void Main()
//    {
//        Dictionary<string, bool> characters = new Dictionary<string, bool>()
//{
//{ "Luke", true },
//{ "Han", false },
//{ "Chewbacca", false }
//};

//       foreach(KeyValuePair<string, bool> pair in characters)
//        {
//            Console.WriteLine(pair.Key);
//        }
//        Console.WriteLine();
//        characters.Remove("Han");
//        foreach (KeyValuePair<string, bool> pair in characters)
//        {
//            Console.WriteLine(pair.Key);
//        }
//    }
//}
//4.Create new MyList class from scratch
// which work mostly as List. It hsould have void Add(T item),
//void Remove(T item), void Clear(), bool Contains(T item) methods and Count poperty. 
//We also can iterate this collection via foreach
//class Months
//{
//    static void Main()
//    {
//        List<string> months = new List<string>();
//        months.Add("Jaunary");
//        months.Add("February");
//        months.Add("March");
//        months.Add("April");
//        foreach (string i in months)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//        if (months.Contains("January"))
//        {
//            Console.WriteLine("This month contain January:");
//        }
//        Console.WriteLine();
//        months.Remove("Jaunary");
//        foreach (string i in months)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//        Console.WriteLine("Count: {0}", months.Count);
//        months.Clear();
//        foreach (string i in months)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//    }
//}
//5.
// static List<string> ProcessToKill(List<string> process)
//{
//    List<string> processToKill = new List<string>(3);
//    Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));

//    Console.WriteLine(string.Format("Count {0}", processToKill.Count));

//    foreach (var p in process) 
//    { if (!p.Equals("Explorer.exe")) { processToKill.Add(p); } }

//     foreach (var p in processToKill)
//    {
//        Console.WriteLine(p);
//    }
//    return processToKill;
//}
