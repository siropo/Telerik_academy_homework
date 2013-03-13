using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolScope
{
    public class Disciplines : IComment
    {
        private string name;
        private int lectures;
        private int exercises;
        private string additionalInfo;

        public Disciplines(string name, int lectures, int exsercises) : 
            this (name, lectures, exsercises, null)
        {

        }

        public Disciplines(string name, int lectures, int exercises, string additionalInfo)
        {
            this.name = name;
            this.lectures = lectures;
            this.exercises = exercises;
            this.additionalInfo = additionalInfo;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }
            private set
            {
                this.lectures = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.exercises;
            }
            private set
            {
                this.exercises = value;
            }
        }

        public string AdditionalInfo
        {
            get 
            { 
                return this.additionalInfo; 
            }
            set 
            { 
                this.additionalInfo = value; 
            }
        }

        public override string ToString()
        {
            StringBuilder disciplinesContent = new StringBuilder();

            disciplinesContent.AppendFormat("\nDiscipline: {0} ", this.Name);
            disciplinesContent.AppendFormat("\nLectures: {0} ", this.Lectures);
            disciplinesContent.AppendFormat("\nExercises: {0} ", this.Exercises);
            if (this.additionalInfo != null)
            {
                disciplinesContent.AppendFormat("\nAdditional Info: {0} ", this.additionalInfo);
            }
            
            return disciplinesContent.ToString();
        }
    }
}
