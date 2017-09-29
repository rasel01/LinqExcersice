using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinQExample
{
    public class ExcersiceFile
    {

        //Write a program in C# Sharp to shows how the three parts of a query operation execute

        public void GetEvenNumbers()
        {
            List<int> list = new List<int>
            {
                1,2,3,4,5,6
            };

            var result = list.Where(x => x % 2 == 0);
            foreach (int val in result)
            {
                Console.WriteLine(@" Even Numbers are " + val);
            }
        }

        // Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

        public void GetPositiveNumbers()
        {
            var numberList = new List<int> { -1, -2, -3, 4, 0 };

            var result = numberList.Where(num => num != 0).Where(num => num > 0);
            foreach (var value in result)
            {
                Console.WriteLine(@" positive numbers are :" + value);
            }

        }


        // Write a program in C# Sharp to find the number of an array and the square of each number.

        public void GetSqaureNumbers()
        {
            var numberList = new List<int> { -1, -2, -3, 4, 0 };

            var sqaureList = numberList.Select(num => new
            {
                number = num,
                sqaureval = num * num
            });

            foreach (var value in sqaureList)
            {
                Console.WriteLine(value.number + @" sqaure value is  :" + value.sqaureval);

            }

            Console.WriteLine(Environment.NewLine);

        }


        //Write a program in C# Sharp to display the characters and frequency of character from giving string.


        public void GetCharactersCount()
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                string result = input.Trim();
                var output = result.GroupBy(x => x).
                    Select(p => new { counter = p.Count(), letter = p.Key });


                //Find the most occurrence of a character in string C#?: 

                //var output = result.GroupBy(x => x).
                //    Select(p => new {counter = p.Count(), letter = p.Key}).
                //    GroupBy(p=>p.counter,p=>p.letter).
                //    OrderByDescending(p=>p.Key).First();





                foreach (var val in output)
                {
                    Console.WriteLine(val.letter + @" Occurs : " + val.counter);
                }
                //Console.WriteLine(output);
            }

        }


        public void GetWeekNames()
        {
            List<string> list = new List<string>
            {
                "Sunday","Monday","Tuesday","Wednessday","Thrusday","Friday","Saturday"
            };

            var result = list.Select(x => new { name = x });

            foreach (var val in result)
            {
                Console.WriteLine(@"Weekend Name: " + val.name + Environment.NewLine);
            }
        }

        //Write a program in C# Sharp to find the string which starts and ends with a specific character. 
        //Sample: A ,M
        public void GetSpecificWord()
        {
            List<string> wordList = new List<string>
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS","Rasel"
            };
            var result = wordList.Where(x => x.FirstOrDefault() == 'R' && x.LastOrDefault() == 'l');

            foreach (var val in result)
            {
                Console.WriteLine(@"Matching Output : " + val);

            }


        }


        //Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80
        public void GetSpecificNumber()
        {
            List<int> numberList = new List<int>
            {
                80,90,75,9,85,90,91,87,18,20
            };
            var result = numberList.Where(x => x > 80);

            foreach (var val in result)
            {
                Console.WriteLine(val);

            }


        }
        //Write a program in C# Sharp to Accept the members of a list through the keyboard and display the members more than a specific value
        public void GetUserNumber()
        {
            List<int> numberList = new List<int>
            {
                80,90,75,9,85,90,91,87,18,20
            };
            int input = Console.Read();
            var result = numberList.FindAll(x => x > input);

            foreach (var val in result)
            {
                Console.WriteLine(val);

            }




        }


        //Write a program in C# Sharp to Accept the members of a list through the keyboard and display the members more than a specific value

        public void GetSpecificMember()
        {
            List<int> numberList = new List<int>
            {
                 10, 48, 52,94,63
            };
            Console.WriteLine(@"Take a memeber Number : 10, 48, 52,94,63 ");
            int input = Console.Read();
            var result = numberList.Where(x => x > input).Select((n, i) => new { value = n, Index = i });
            Console.WriteLine(@"output :" + Environment.NewLine);
            foreach (var val in result)
            {
                Console.WriteLine(@"Member: " + val.Index + @" Value: " + val.value);

            }




        }

        //Write a program in C# Sharp to display the top n-th records

        public void GetTopNtimesNumber()
        {
            List<int> numberList = new List<int>
            {
                5, 7, 13, 24,6,9,8,7

            };
            Console.WriteLine(@"How many Numbers to print from  : 5, 7, 13, 24,6,9,8,7 ");
            int input = Convert.ToInt32(Console.ReadLine());
            var result = numberList.OrderByDescending(x => x).Take(3);
            Console.WriteLine(@"output :" + Environment.NewLine);
            foreach (var val in result)
            {
                Console.WriteLine(val);

            }




        }

        //Write a program in C# Sharp to find the uppercase words in a string.

        public void GetUpperWord()
        {


            string input = Console.ReadLine();
            if (input != null)
            {
                var result = input.Select(x => x.ToString().ToUpper());
                Console.WriteLine(@"output :" + Environment.NewLine);
                foreach (var val in result)
                {
                    Console.Write(val);

                }
            }
        }

        // Write a program in C# Sharp to convert a string array to a string. 

        public void GetArrayToString()
        {
            string[] aStrings = { "rasel", "ifte", "musta", "olid" };
            var result = String.Join(",", aStrings.Select(x => x.ToString()).ToArray());
            Console.WriteLine(result);

        }


        //Write a program in C# Sharp to find the n-th Maximum grade point achieved by the students from the list of students.

        public void GetMaximumMarker()
        {
            List<StdList> list = new List<StdList>
            {
                new StdList {ID = 1,Marks = 750,Name = "xx",Grade = 3},
                new StdList {ID = 2,Marks = 350,Name = "yy",Grade = 2},
                new StdList {ID = 2,Marks = 100,Name = "xyy",Grade = 2},
                new StdList {ID = 3,Marks = 100,Name = "zz",Grade = 1},
                new StdList {ID = 4,Marks = 750,Name = "xxx",Grade = 3}
            };
            Console.WriteLine(@"Enter Grade Number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            var result = list.Where(x => x.Grade == input).ToList();
            foreach (var val in result.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(val.ID.ToString(), val.Name, val.Marks.ToString(), val.Grade.ToString());
            }

            //var result = list.Where()
            //Console.WriteLine(result);

        }





    }
    public class StdList
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Marks { get; set; }
        public int Grade { get; set; }
    }
}
