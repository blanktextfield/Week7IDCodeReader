using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace YearValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthyear");
            string birthyear = Console.ReadLine();
            if (Validate(birthyear))
            {
                Console.WriteLine("Welcome!");
                
            }
            else
            {
                Console.WriteLine("Wrong format. Try again!");
            }

        }
        public static bool Validate(string yearinput)
        {
            {
                if (yearinput.Length == 4)

                {
                    try
                    {
                        long.Parse(yearinput);
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Wrong format; {e}");
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                 Public static void CalculateAge(yearInput)
                {
                    DateTime now = DateTime.Now;
                    string currentYear = now.Year.ToString();
                    int yearNow = Int32.Parse(currentYear);
                    int age = yearNow - yearNow;
                    Console.WriteLine($"You`re {age} years old");
                }
                
            } 

        }
    }   }
