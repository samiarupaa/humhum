using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Association_One_to_Many_
{
    public class Assignment
    {
        private string title;
        private DateTime dueDate;
        private double score;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public DateTime DueDate
        { get { return this.dueDate; }
            set { this.dueDate = value; }
        }
        public double Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
        public Assignment()
        {

        }
        public Assignment(string title,DateTime dueDate,double score)
        {
            this.title = title;
            this.dueDate = dueDate;
            this.score = score;

        }
        public void ShowDetails()
        {
            Console.WriteLine("Assignement Info:");
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Due Date: " + this.dueDate);
            Console.WriteLine("Score: " + this.score);

        }
    }
}