using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AutolotContext())
            {
                var marksWithT = (from mark in context.Marks
                                 where mark.Name.ToLower().Contains("t")
                                 orderby mark.Name
                                 ascending
                                 select mark).ToList();

                var carsWithU = context
                    .Cars
                    .Where(car => car.Mark.Name.ToLower().Contains("u")).ToList();

                var name = "Ruslan";
                name.GetLettersCount(); // из-за того, что в параметре мы написали this, мы можем вызывать метод на string'e без передачи параметров
            }
        }
    }
}