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

            if (FirstName == null && LastName == null && BirthYear == 0 && DeathYear == 0 && Father == null && Mother == null)
            {
                return description = string.Format("(Id={0})", Id);
            }

            
            else if (FirstName != null)
            {
                description += FirstName + " ";
            }
                if (LastName != null)
                {
                    description += LastName + " ";
                }
                if (Id != 0)
                {
                    description += "(Id=" + Id + ")";
                }
                if (BirthYear != 0)
                {
                    description += " " + "Født: " + BirthYear + " ";
                } 
                if (DeathYear != 0)
                {
                    description += "Død: " + DeathYear + " ";
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
            //    else
            //{
            //    description += string.Format("{0} {1} (Id={2}) Født: {3} Død: {4} Far: {5} (Id={6}) Mor: {7} (Id={8}",
            //        FirstName, LastName, Id, BirthYear, DeathYear, Father.FirstName, Father.Id, Mother.FirstName, Mother.Id);
            //}
            var text = description.Trim();
              return text;

            
        }

       
    }
}
