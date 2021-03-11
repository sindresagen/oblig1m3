using System;
using System.Collections.Generic;
using System.Text;

namespace oblig1
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;
        public string GetDescription()
        {
            string description = "";
            if (FirstName != null)
            {
                description += FirstName + " ";
            }
            if (LastName != null)
            {
                description += LastName + " ";
            }
            if (Id != 0)
            {
                description += "(Id=" + Id + ") ";
            }
            if (BirthYear != 0)
            {
                description += "Født: " + BirthYear;
            } 
            if (DeathYear != 0)
            {
                description += "Død: " + DeathYear;
            }
            if (Father != null)
            {
                if (Father.FirstName != null)
                {
                    description += "Far: " + Father.FirstName + " ";
                }
                if (Father.Id != 0)
                {
                    description += "(Id=" + Father.Id + ") ";
                }
            }
            if (Mother != null)
            {
                if (Mother.FirstName != null)
                {
                    description += "Mor: " + Mother.FirstName + " ";
                }
                if (Mother.Id != 0)
                {
                    description += "(Id=" + Mother.Id + ")";
                }
            }
            return FirstName + " " + LastName + " " + "(Id=" + Id + ") " + "Født: " + BirthYear
            + " " + "Død: " + DeathYear + " " + "Far: " + Father.FirstName + " " + "(Id=" + Father.Id + ") " + "Mor: " + Mother.FirstName + " " + "(Id=" + Mother.Id + ")";
            
        }
    }
}
