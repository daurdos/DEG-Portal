using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegPortal.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseLanguage { get; set; }
        public string NameRus { get; set; }
        public string NameKaz { get; set; }
        public string NameEng { get; set; }
        public string Cypher { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Student { get; set; }
        public ICollection<Instructor> Instructor { get; set; }
    }
}
