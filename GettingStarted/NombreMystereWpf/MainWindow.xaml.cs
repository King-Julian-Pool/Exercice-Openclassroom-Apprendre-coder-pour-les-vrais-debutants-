using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NombreMystereWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int NumMys;
        int NombreEssais;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            int PropNum = ChoisirUnNombre();
            if (PropNum > 0)
            {
                if (PropNum != NumMys)
                {
                    PropNum = TryAgain(PropNum);
                }
                else
                {
                    YouWin();
                }
            }
        }

        private void btnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }


        void NouvellePartie()
        {
            NumMys = GenereNombreAleatoire();
            TextBlockInfo.Text = "";
            TextBoxEssai.Text = "";
            NombreEssais = 0;
            UpdateTry();
        }
        void UpdateTry()
        {
            TextBlockNombreEssais.Text = "Nombre d'essais: " + NombreEssais;
        }
        int GenereNombreAleatoire()
        {
            return new Random().Next(1, 20);
        }
        int ChoisirUnNombre()
        {
            string Prop = TextBoxEssai.Text;
            int PropNum;

            if (int.TryParse(Prop, out PropNum) == false)
            {
                TextBlockInfo.Text = "Ce n'est pas un nombre. Try again";
            }
            else
            {
                TextBlockInfo.Text = "";
            }
            return PropNum;
        }
        int TryAgain(int PropNum)
        {
            if (PropNum < NumMys)
            {
                TextBlockInfo.Text = "C'est plus";
            }
            else if (PropNum > NumMys)
            {
                TextBlockInfo.Text = "C'est moins";
            }

            NombreEssais = NombreEssais + 1;
            UpdateTry();

            return PropNum;
        }
        void YouWin()
        {
            TextBlockInfo.Text = "Bravo tu as gagné !";
        }
    }
}
