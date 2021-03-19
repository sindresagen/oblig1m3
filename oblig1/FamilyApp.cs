using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace oblig1
{
    public class FamilyApp
    {
        public List<Person> People;

        public string WelcomeMessage = @"FamilyApp V4.20.69b
Welcome!";

        public string CommandPrompt = "Please input the person you want to know more about: ";

        public FamilyApp(params Person[] family)
        {
            People = new List<Person>(family);
        }

        


        public string HandleCommand(string command)
        {
            if (command == "hjelp") return ShowHelp();
            else if (command == "liste") return ShowListe();
            else if (command.Contains("vis ")) return ShowPersonById(command);
            else return "Skriv hjelp hvis du står fast.";

        }

        private string ShowPersonById(string command)
        {
            var children = new List<Person>();
            var text = "";
            var searchId = Int32.Parse(command.Substring(4));
            for (var i = 0; i < People.Count; i++)
            {
                if (People[i].Id == searchId)
                {
                    text += People[i].GetDescription() + "\n";
                }

                if (People[i].Father != null)
                {
                    if (People[i].Father.Id == searchId)
                    {
                        children.Add(People[i]);
                    }
                }
                if (People[i].Mother != null)
                {
                    if (People[i].Mother.Id == searchId)
                    {
                        children.Add(People[i]);
                    }
                }
            }

            if (children.Count != 0)
            {
                text += "  Barn:\n";
                for (var i = 0; i < children.Count; i++)
                {
                    text += $"    {children[i].FirstName} (Id={children[i].Id}) Født: {children[i].BirthYear}\n";
                }
            }
            return text;
        }

        private string ShowListe()
        {
            var text = "";
            for (var i = 0; i < People.Count; i++)
            {
                text += People[i].GetDescription() + "\n";
            }
            return text;
        }

        private string ShowHelp()
        {
            return "Help text:\r\nhjelp: Shows all the commands\r\nliste: Lists all people with ID, name, birth year and / or death year, name and ID for parents\r\nvis<id>: Shows the corresponding person with parents, children and ID.";
        }
    }
}
