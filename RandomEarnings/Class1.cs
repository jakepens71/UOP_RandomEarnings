using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEarnings
{
    public class Class1
    {
        double salary  { get; set; }

        public double getSalary()
        {
            Random r = new Random();
            salary = r.Next(10000, 200000);
            return salary;
        }

    }
}
