using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public partial class Course
    {
        public Course()
        {
            Trainees = new HashSet<Trainee>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CourseDuration { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
