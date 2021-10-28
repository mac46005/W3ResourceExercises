using ConsoleMVCPattern.Interfaces;
using People.ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_ConsoleUI.Models.Basics.Q1
{
    public class PersonModel : IPerson,IModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public int GenerateId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
