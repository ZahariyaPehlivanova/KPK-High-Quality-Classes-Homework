﻿using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string courseName, string teacherName = null, IList<string> students = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = " + this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
