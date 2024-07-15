using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.biding
{
    
        internal class emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int? Age { get; set; }
            public void GetStatus()
            {
                Console.WriteLine($"I'm Employee");
            }
            public virtual void GetInfo()
            {
                Console.WriteLine($"Id : {Id}\nName : {Name} \nAge : {Age}");
            }

        }

        class FullTimeEmployee : emp
    {
            public decimal Salary { get; set; }

            public new void GetStatus()
            {
                Console.WriteLine("I'm full time Employee");
            }
            public override void GetInfo()
            {
                Console.WriteLine($"Full time employee :\n ID = {Id}\nName = {Name}\nAge = {Age} \nsalary = {Salary:c}");
            }
        }

        class PartTimeEmployee : emp
    {
            public decimal HourRate { get; set; }

            public new void GetStatus()
            {
                Console.WriteLine("I'm part time Employee");
            }
            public override void GetInfo()
            {
                Console.WriteLine($"part time employee n ID = {Id} \nName = {Name}\nAge = {Age}\nHour Rate = {HourRate:c}");
            }
        }
    
}
