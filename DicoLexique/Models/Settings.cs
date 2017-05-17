using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace DicoLexique.Models
{
    public class Settings
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private Boolean modeAveugle;
        private Boolean sound;
        private Boolean micro;
        #endregion

        #region Properties
        public Boolean Micro
        {
            get { return micro; }
            set { micro = value; }
        }

        public Boolean Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public Boolean ModeAveugle
        {
            get { return modeAveugle; }
            set { modeAveugle = value; }
        }
        #endregion

        #region Constructors
        public Settings()
        {

        }
        public Settings( bool modeAveugle, bool micro, bool sound)
        {
            this.modeAveugle = modeAveugle;
            this.micro = micro;
            this.sound = sound;
        }

 
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion



    }
}
