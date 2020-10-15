using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code");
            string usersid = Console.ReadLine();
            if (Validate(usersid))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersid);
            }
            else
            {
                Console.WriteLine("Wrong format. Try again!");
            }

        }
        public static bool Validate(string idCode)
        {
            {
                if (idCode.Length == 11)

                {
                    try
                    {
                       long.Parse(idCode);
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
            }
        }
        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            if (firstNum == 1 || firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Hello sir!");
            }else if (firstNum == 2 || firstNum ==4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }
    }
}
