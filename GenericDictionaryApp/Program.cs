using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;


namespace GenericDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool breakFlag = false;
            IDictionary<int, string> studendsNames = new Dictionary<int, string>();
            //
            while (!breakFlag)
            {
                try
                {
                    void GetDictionaryList()
                    {
                        foreach (var kvp in studendsNames)
                            Console.WriteLine("Current Dictionary List Row: Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                    }
                    Console.WriteLine("\nWhat action would you like to take in Dictionary List?\na - Add\nd - Remove\ne - Enumerate\nb - Contains\nc - Clear\nq - Quit");
                    string userActionListiner = Console.ReadLine().ToLower();
                    // -->
                    switch (userActionListiner)
                    {
                        case "a":
                            Console.WriteLine("Set the Key number please:");
                            int keyInput = int.Parse(Console.ReadLine());
                            Console.WriteLine("Set the Student Name please");
                            string? valueInput = Console.ReadLine();
                            studendsNames.Add(keyInput, valueInput);
                            GetDictionaryList();
                            break;
                        //
                        case "d":
                            if (studendsNames.Count > 0)
                            {
                                Console.WriteLine("Which Key Number To Remove?");
                                int numberRomove = int.Parse(Console.ReadLine());
                                studendsNames.Remove(numberRomove);
                                GetDictionaryList();
                            }
                            else
                                Console.WriteLine("No Record In Dictionary List.");
                            break;
                        //
                        case "e":
                            if (studendsNames.Count > 0)
                                GetDictionaryList();
                            else
                                Console.WriteLine("No Record In Dictionary List.");
                            break;
                        //
                        case "b":
                            if (studendsNames.Count > 0)
                            {
                                Console.WriteLine("Please set the key number search input:");
                                int idNumber = int.Parse(Console.ReadLine());
                                if (studendsNames.ContainsKey(idNumber) == true)
                                    Console.WriteLine("The Object is exist in Dictionary List");
                            }
                            else
                                Console.WriteLine("The Object is not exist in Dictionary List");
                            break;
                        //
                        case "c":
                            studendsNames.Clear();
                            Console.WriteLine("Clear operation done!");
                            break;
                        //
                        case "q":
                            breakFlag = true;
                            break;
                        //
                        default:
                            Console.WriteLine("wrong choise, please try again.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The Operation is failure!");
                }
            }
        }
    }
}