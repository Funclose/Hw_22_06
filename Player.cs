using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22_06
{
    internal class Player
    {
        public string Name {  get; set; }
        public string Number { get; set; }

        public Player(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}, number: {Number}";
        }
    }
}
