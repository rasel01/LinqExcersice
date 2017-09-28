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
                Console.WriteLine("Even Numbers are " + val);
            }
        }

        // Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

        public void GetPositiveNumbers()
        {
            var numberList = new List<int> { -1, -2, -3, 4, 0 };

            var result = numberList.Where(num => num != 0).Where(num => num > 0);
            foreach (var value in result)
            {
                Console.WriteLine("positive numbers are :" + value);
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
                Console.WriteLine(value.number + "sqaure value is  :" + value.sqaureval);

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
                    Console.WriteLine(val.letter + " Occurs : " + val.counter);
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
                Console.WriteLine("Weekend Name: " + val.name + Environment.NewLine);
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
                Console.WriteLine("Matching Output : " + val);

            }


        }


        //Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80
        public void GetSpecificNumber()
        {
            List<int>numberList  = new List<int>
            {
                80,90,75,9,85,90,91,87,18,20
            };
            var result = numberList.Where(x => x > 80);

            foreach (var val in result)
            {
                Console.WriteLine( val);

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


    }
}
