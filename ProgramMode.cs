using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeeja_ImageLabeller
{
    internal class ProgramMode
    {
        private static int idCounter = 0;
        private int id = 0;
        private string name;
        private string desc;
        private bool active;

        public ProgramMode(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
            this.active = false;

            id = idCounter++;
        }

        public string getName() => name;
        public string getDesc() => desc;
        public int getId() => id;
        public bool isActive() => active;
        public bool switchActive(bool mode) => active = mode;
    }
}
