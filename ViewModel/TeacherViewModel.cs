using System;
using Common.ViewModel;
using Model;

namespace ViewModel
{
    public class TeacherViewModel : BaseViewModel<Teacher>
    {
        public TeacherViewModel(Teacher teacher):base(teacher)
        {
            Name= teacher.Name;
            Courses = teacher.Courses;
            TotalCredit = teacher.TotalCredit;
        }
        public string Name { get; set; }
        public string Courses { get; set; }
        public double TotalCredit { get; set; }
    }
}
