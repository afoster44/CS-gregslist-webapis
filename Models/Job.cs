using System;

namespace gregslist.Models
{
    public class Job
    {
        public Job(string title, string description, int salary)
        {
            Title = title;
            Description = description;
            Salary = salary;
        }

        public Job() { }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}