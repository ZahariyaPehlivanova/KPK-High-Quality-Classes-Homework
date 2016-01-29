﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string courseName, string teacherName = null, IList<string> students = null)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = " + this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
