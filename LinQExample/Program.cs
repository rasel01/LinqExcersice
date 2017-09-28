using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExample
{
    class Program
    {
        static void Main(string[] args)
        {


            var ef = new ExcersiceFile();
            ef.GetEvenNumbers();

            ef.GetPositiveNumbers();

            ef.GetSqaureNumbers();

            //ef.GetCharactersCount();

            //var output = result.GroupBy(x => x).
            //    Select(p => new {counter = p.Count(), letter = p.Key}).
            //    GroupBy(p=>p.counter,p=>p.letter).
            //    OrderByDescending(p=>p.Key).First();

            ef.GetWeekNames();

            ef.GetSpecificWord();

            ef.GetSpecificNumber();

            Console.ReadKey();
        }
    }
}
