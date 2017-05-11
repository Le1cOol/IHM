using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicoLexique.Models
{
    public class Word
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String definition;

        public String Definition
        {
            get { return definition; }
            set { definition = value; }
        }


    }
}
