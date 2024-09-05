using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public partial class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? CellphoneNo { get; set; }
        public string? ContactAddress { get; set; }
        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }
    }
}
