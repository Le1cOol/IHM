using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicoLexique.Models
{
    public class Settings
    {
        private Boolean micro;

        public Boolean Micro
        {
            get { return micro; }
            set { micro = value; }
        }

        private Boolean sound;

        public Boolean Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        private Boolean modeAveugle;

        public Boolean ModeAveugle
        {
            get { return modeAveugle; }
            set { modeAveugle = value; }
        }



    }
}
