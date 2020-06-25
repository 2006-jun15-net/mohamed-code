using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Enrollment Enrollment { get; set; }
    }
}
