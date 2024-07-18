using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Menu
    {
        public static void MenuSelect(string choixDeMenu)
        {
            switch (choixDeMenu)
            {
                #region Principale
                case "main":
                    Console.Clear();
                    Console.Write("====|Section|====\n\n" +
                        "[1] table Culture\n" +
                        "[2] table Date_enregistrer\n" +
                        "[3] table Element_chimique\n" +
                        "[4] table Engrais  \n" +
                        "[5] table Epandre  \n" +
                        "[6] table Parcelle  \n" +
                        "[7] table Posseder  \n" +
                        "[8] table Production  \n" +
                        "[9] table Unite  \n" +
                        "-------------------------\nEntry:");
                    break;
                    #endregion
            }
        }
    }
}
