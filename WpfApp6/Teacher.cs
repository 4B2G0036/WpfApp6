using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    class Teacher
    {
        public string TeacherName { get; set; }

        public ObservableCollection<Course> TeachingCourses { get; set; }
        public Teacher(string teacherName)
        {
            TeacherName = teacherName;
            TeachingCourses = new ObservableCollection<Course>();
        }
    }
}
