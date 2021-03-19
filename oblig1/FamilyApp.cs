using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace oblig1
{
    class FamilyApp
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
            var searchId = Int32.Parse(command.Substring(4));
            for (var i = 0; i < People.Count; i++)
            {
                if (People[i].Id == searchId)
                {
                    return People[i].GetDescription();
                }
            }
            return "";
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
