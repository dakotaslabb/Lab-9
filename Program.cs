using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Humans> Students = new List<Humans>();

            Humans s1 = new Humans("Dakota Slabbekoorn", "Kent City", "Pho", "Black");
            Humans s2 = new Humans("Joshua Bultsma", "Grand Rapids", "Cheese Tortellini", "Yellow");
            Humans s3 = new Humans("Tommy Waalkes", "Raleigh NC", "Indian Style Chicken Curry", "Red");
            Humans s4 = new Humans("James Dockery", "Grand Rapids, MI", "Cheeseburger and French Fries", "Orange");
            Humans s5 = new Humans("Maricela Rivera", "Morelia, Mex", "Tacos", "Green");
            //Student s6 = new Student("KimVy Nguyen", "Grand Rapids", "Sushi");

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
            Students.Add(s5);
            Students.Add(new Humans("KimVy Nguyen", "Grand Rapids", "Sushi", "Blue"));

            Humans s;

            Students = Students.OrderBy(a => a.Name).ToList();

            string name = "";
            string firstname = "";
            int idnumber = 0;
            int arraynumber = 0;
            bool keepgoing = true;

            while (keepgoing == true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to our C# class. Would you like to learn about a student or add a student?");
                Console.WriteLine("1) add");
                Console.WriteLine("2) learn");
                bool keepgoing1 = true;
                while (keepgoing1 == true)
                {
                    string answer = Console.ReadLine();
                    if (answer == "add" || answer == "1")
                    {
                        bool keepgoing2 = true;
                        while (keepgoing2 == true)
                        {
                            bool validinput = true;
                            while (validinput = true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please enter student name");
                                string newstudent = Console.ReadLine().Trim().ToLower();
                                if (newstudent == "" || newstudent == " ")
                                {
                                    Console.WriteLine("Invalid input please type a name. Please hit enter to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Please enter students hometown");
                                string newhometown = Console.ReadLine().Trim().ToLower();
                                if (newhometown == "" || newhometown == " ")
                                {
                                    Console.WriteLine("Invalid input please type a hometown. Please hit enter to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Please enter students favorite food");
                                string newfood = Console.ReadLine().Trim().ToLower();
                                if (newfood == "" || newfood == " ")
                                {
                                    Console.WriteLine("Invalid input please type a favoritefood. Please hit enter to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Please enter students favorite color");
                                string newcolor = Console.ReadLine().Trim().ToLower();
                                if (newcolor == "" || newcolor == " ")
                                {
                                    Console.WriteLine("Invalid input please type a color. Please hit enter to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }

                                Humans brandnew = new Humans(newstudent, newhometown, newfood, newcolor);
                                Students.Add(brandnew);
                                validinput = false;
                                break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Would you like to add another Student?");
                            Console.WriteLine("yes/no");

                            string answer1 = Console.ReadLine().Trim().ToLower();

                            if (answer1 == "yes" || answer1 == "y")
                            {
                                keepgoing2 = true;
                                continue;
                            }
                            else if (answer1 == "no" || answer1 == "n")
                            {
                                keepgoing1 = false;
                                keepgoing2 = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please type \"add\" or \"learn\"");
                                continue;
                            }
                        }
                    }
                    else if (answer == "learn" || answer == "2")
                    {
                        bool keepgoing3 = true;
                        while (keepgoing3 == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("What Student Would you like to learn about?");
                            Console.WriteLine();
                            for (int i = 0; i < Students.Count(); i++)
                            {
                                Humans id = Students[i];
                                Console.WriteLine($"{i + 1}) {id.GetName()}.");
                            }

                            try
                            {
                                string input = Console.ReadLine().ToLower().Trim();
                                idnumber = int.Parse(input);
                                arraynumber = (idnumber - 1);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine();
                                Console.WriteLine(e.Message);
                                Console.WriteLine($"Please input a nunmber");
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine();
                                Console.WriteLine(e.Message);
                                Console.WriteLine($"I'm sorry that is not a valid student number please try again");
                            }


                            s = Students[arraynumber];
                            name = s.GetName();
                            string[] first = name.Split();
                            firstname = first[0];


                            bool keepgoing4 = true;
                            while (keepgoing4 == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Student number {idnumber}  is {name}.");
                                Console.WriteLine($"What would you like to learn about {firstname}.");
                                Console.WriteLine("1) Hometown / ht");
                                Console.WriteLine("2) Favorite Food / ff");
                                Console.WriteLine("3) Favorite color / fc");
                                Console.WriteLine("Type \"exit\" to leave this student");

                                string input2 = Console.ReadLine().ToLower().Trim();
                                if (input2 == "hometown" || input2 == "ht" || input2 == "1")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"{firstname}'s home town is {s.GetHomeTown()}.");
                                    continue;
                                }
                                else if (input2 == "favoritefood" || input2 == "ff" || input2 == "2")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"{firstname}'s favorite food is {s.GetFavoriteFood()}.");
                                    continue;
                                }
                                else if (input2 == "favoritecolor" || input2 == "fc" || input2 == "3")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"{firstname}'s favorite color is {s.GetFavoriteColor()}.");
                                    continue;
                                }
                                else if (input2 == "exit")
                                {
                                    keepgoing4 = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Plesase enter eiter \"hometown\", \"favorite food\", \'favorit color\" .");
                                }
                            }

                            bool keepgoing5 = true;
                            while (keepgoing5 == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Is there another student you would like to learn about other than {name}?");
                                Console.WriteLine("Yes or No");
                                string going = Console.ReadLine().ToLower().Trim();

                                if (going == "y" || going == "yes")
                                {
                                    keepgoing5 = false;
                                    break;
                                }
                                else if (going == "n" || going == "no")
                                {
                                    keepgoing3 = false;
                                    keepgoing5 = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Please type yes or no");
                                    continue;
                                }
                            }

                        }

                        bool keepgoing6 = true;
                        while (keepgoing6 == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Would you like to add a new student before you go?");
                            Console.WriteLine("Yes or No");
                            string input3 = Console.ReadLine().Trim().ToLower();

                            if (input3 == "yes" || input3 == "y")
                            {
                                keepgoing6 = false;
                                break;
                            }
                            else if (input3 == "no" || input3 == "n")
                            {
                                keepgoing1 = false;
                                keepgoing6 = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please type in yes or no");
                                keepgoing6 = true;
                                continue;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please type \"add\" or \"learn\"");
                        continue;
                    }

                }
                bool keepgoing7 = true;
                while (keepgoing7 == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to continue using this program? y/n");
                    string input4 = Console.ReadLine().Trim().ToLower();

                    if (input4 == "y" || input4 == "yes")
                    {
                        break;
                    }
                    else if (input4 == "n" || input4 == "no")
                    {
                        keepgoing = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Plese type yes or no");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks have a great day");
        }
    }
}
