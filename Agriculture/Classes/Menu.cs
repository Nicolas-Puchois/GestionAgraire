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
                        "====|Afficher les entrées|====\n" +
                        "\n[1]  Afficher table Culture\n" +
                        "[2]  Afficher table Date_enregistrer\n" +
                        "[3]  Afficher table Element_chimique\n" +
                        "[4]  Afficher table Engrais  \n" +
                        "[5]  Afficher table Epandre  \n" +
                        "[6]  Afficher table Parcelle  \n" +
                        "[7]  Afficher table Posseder  \n" +
                        "[8]  Afficher table Production  \n" +
                        "[9]  Afficher table Unite  \n" +
                        "[0]  Sortir  \n" +
                        "\n====|Modifier / créer des entrées|====\n" +
                        "\n[10] Modifier table Culture\n" +
                        "[11] Modifier table Date_enregistrer\n" +
                        "[12] Modifier table Element_chimique\n" +
                        "[13] Modifier table Engrais  \n" +
                        "[14] Modifier table Epandre  \n" +
                        "[15] Modifier table Parcelle  \n" +
                        "[16] Modifier table Posseder  \n" +
                        "[17] Modifier table Production  \n" +
                        "[18] Modifier table Unite  \n" +
                        "[19] Test connection BDD  \n" +
                        "[0]  Sortir  \n" +
                        "-------------------------\nEntry:");
                    break;
                    #endregion
            }
        }
    }
}
