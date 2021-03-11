using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NombreMystereUniversal
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int Randomed;
        int NbEssais;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void btValider_Click(object sender, RoutedEventArgs e)
        {
            int pickedNum = PickANumber();

            if (pickedNum >= 0)
            {
                // A vous : Tant qu’on n’a pas trouvé on recommence
                // Trouvez la condition qui permet de refaire un essai de devinette
                if (pickedNum != Randomed)
                {
                    TryAgain(pickedNum);
                }
                else
                {
                    YouWin();
                }
            }
        }

        int PickANumber()
        {
            string picked = tbEssai.Text;

            // Vérifier la validité de la saisie avec TryParse
            int pickedNum;
            bool isNumeric = int.TryParse(picked, out pickedNum);
            if (isNumeric == false)
            {
                // A VOUS : Trouvez le code à écrire ici
                tbInfo.Text = "Ceci n'est pas un nombre... ";
                pickedNum = -1;
            }
            else
            {
                tbInfo.Text = "";

            }
            tbEssai.Text = "";

            return pickedNum;
        }

        private void btNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        void NouvellePartie()
        {
            Randomed = GenereNombreAleatoire();
            tbInfo.Text = "";
            tbEssai.Text = "";
            NbEssais = 0;
            UpdateTry();
            btValider.IsEnabled = true;

        }

        void TryAgain(int pickedNum)
        {
            if ((pickedNum < 1) || (pickedNum > 20))
            {
                tbInfo.Text = "Ce nombre n'est pas valide : il doit être entre 1 et 20";
            }
            else
            {
                // A Vous : On aide l’utilisateur : on lui indique si c’est plus ou moins
                if (pickedNum > Randomed)
                {
                    tbInfo.Text = "C'est moins";
                }
                else
                {
                    tbInfo.Text = "C'est plus";
                }

                NbEssais = NbEssais + 1;
                UpdateTry();

            }
        }

        void UpdateTry()
        {
            tbNbEssais.Text = "Nb Essai : " + NbEssais;
        }

        void YouWin()
        {
            tbInfo.Text = "C'est gagné ! Bravo !";
            btValider.IsEnabled = false;

        }

        int GenereNombreAleatoire()
        {
            return new Random().Next(1, 21);
        }

    }
}
