using System;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;
namespace PhoneListApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Phone> Contacts = new List<Phone>();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                try
                {
                    Console.WriteLine("Please choose what you want to do\n" +
                "1- New Phone Number\n" +
                "2- Show Phone List\n" +
                "3- Delete Name\n" +
                "4- Exit Out", Console.ForegroundColor);
                    int respond = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Please waite proccessing ....");
                    Thread.Sleep(1000);// sleep 

                    if (respond == 4)
                    {
                        Console.WriteLine("exiting .....");
                        Thread.Sleep(1000);// sleep 
                        Console.WriteLine("Good Bay .....");
                        Environment.Exit(1);
                    }
                    else if (respond == 1)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("Please Enter the Name to add to your list:", Console.ForegroundColor);
                            string name = Console.ReadLine();

                            Console.WriteLine("Please Enter the Phone Number:", Console.ForegroundColor);
                            string phNum = Console.ReadLine();
                            if (phNum.Length == 10)
                            {
                                //List<int> myList = new List<int>();
                                for (int j = 0; j < phNum.Length; j++)
                                {
                                    int Num = phNum[j] - '0';
                                    //Console.WriteLine(Num);
                                    if (Num >= 0 && Num <= 9)
                                    {
                                        //myList.Add(Num);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;

                                        Console.WriteLine("Invalid Phone number Check your Info and try again later!!", Console.ForegroundColor);
                                        Console.WriteLine("exiting .....", Console.ForegroundColor);
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Good Bay .....", Console.ForegroundColor);
                                        Environment.Exit(1);
                                    }
                                }
                                Console.WriteLine("Thank you Phone Number Accpted!!");
                                Contacts.Add(new Phone());
                                int numOfIndex = Contacts.Count;
                                int indexList = numOfIndex - 1;
                                Contacts[indexList].Name = name;
                                Contacts[indexList].Id = indexList + 1;
                                Contacts[indexList].PhoneNumber = phNum;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(1000);// sleep
                                Console.WriteLine(" Please waite proccessing ....");
                                Console.WriteLine("Please Check the phone number and try again", Console.ForegroundColor);
                            }
                        }
                    }
                    else if (respond == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Contacts Table", Console.ForegroundColor);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("  Id      Name        Phone Number ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-------------------------------------");
                        foreach (var contact in Contacts)
                        {
                            Console.WriteLine(contact.getData(), Console.ForegroundColor);
                            Console.WriteLine("-------------------------------------");
                        }
                        Console.ResetColor();

                    }
                    else if (respond == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter the number you wish to delete:", Console.ForegroundColor);
                        int idNumber = int.Parse(Console.ReadLine());
                        int indexNum = idNumber - 1;
                        if (indexNum < Contacts.Count)
                        {
                            Contacts.RemoveAt(indexNum);
                            Console.WriteLine($" Record Number ({idNumber}) was deleted ....");
                        }
                        else
                        {
                            Console.WriteLine(" Please waite proccessing ....");
                            Thread.Sleep(1000);// sleep 
                            Console.WriteLine("Invalid Entery Please hit option 2  to see the index you want to Delete");
                        }


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Please waite proccessing ....", Console.ForegroundColor);
                        Thread.Sleep(1000);// sleep 
                        Console.WriteLine("Invald Entery please try correct option .......", Console.ForegroundColor);
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Please waite proccessing ....", Console.ForegroundColor);
                    Thread.Sleep(1000);// sleep 
                    Console.WriteLine(e.Message, Console.ForegroundColor);
                    Console.WriteLine(" Please Try Again .......", Console.ForegroundColor);

                }
            }
            
        }
    }
}
