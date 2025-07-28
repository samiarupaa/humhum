using System;
using System.Collections.Generic;

namespace Association_One_to_Many_
{
    public class Student
    {
        private int studentID;
        private string name;
        private List<Assignment> assignments;

        public int StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Assignment> Assignments
        {
            get { return this.assignments; }
            set { this.assignments = value; }
        }

        public Student()
        {
            assignments = new List<Assignment>();
        }

        public Student(int studentID, string name, List<Assignment> assignments)
        {
            this.studentID = studentID;
            this.name = name;
            this.assignments = assignments ?? new List<Assignment>(); // null-safe
        }

        public void ShowDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Id: " + this.studentID);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Total Assignments: " + this.assignments.Count);

            foreach (Assignment a in this.assignments)
            {
                if (a != null)
                {
                    a.ShowDetails();
                }
            }
        }

        public List<Assignment> GetPendingAssignments()
        {
            List<Assignment> pending = new List<Assignment>();

            foreach (Assignment a in assignments)
            {
                bool isPending = a.DueDate > DateTime.Now;
                if (isPending)
                {
                    pending.Add(a);
                }
            }

            return pending;
        }
    }
}
