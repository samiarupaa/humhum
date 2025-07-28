using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Association_One_to_Many_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment a1 = new Assignment("Scenario-1", DateTime.Now.AddDays(3), 0);
            Assignment a2 = new Assignment("Scenario-2", DateTime.Now.AddDays(7), 85);
            Assignment a3 = new Assignment("Scenario-3", DateTime.Now.AddDays(2), 92);
            List<Assignment> assignments = new List<Assignment> { a1, a2, a3 };

            Student s1 = new Student(01,"Samia Akter Rupa",assignments);
            s1.ShowDetails();
            
        }
    }             
}
