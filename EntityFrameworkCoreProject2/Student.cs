using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreProject2 {
    class Student {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }

        public Student() { }

    }
}
