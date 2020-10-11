using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegPortal.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string FNameEng { get; set; }
        public string MNameEng { get; set; }
        public string LNameEng { get; set; }
        public int StudentId { get; set; }
        public int Iin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfWorkRus { get; set; }
        public string PlaceOfWorkKaz { get; set; }
        public string PlaceOfWorkEng { get; set; }
        public string UrlWorkLink { get; set; }
        public bool Payment { get; set; } = false;
        public bool Diploma { get; set; } = false;
        public string DiplomaNumber { get; set; }
        public DateTime DiplomaIssuedDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
