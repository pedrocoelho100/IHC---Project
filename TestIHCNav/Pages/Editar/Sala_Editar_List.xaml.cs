using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
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

namespace TestIHCNav.Pages.Editar
{
    /// <summary>
    /// Interaction logic for Sala_Editar_List.xaml
    /// </summary>
    public partial class Sala_Editar_List : UserControl
    {
        public Sala_Editar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Vasco da Gama"))
            {
                var salas_list = (ModernTab)this.FindName("salas_list");
                // Link[] links = new Link[5]; 
                LinkCollection links = new LinkCollection();

                for (int i = 0; i < 6; i++)
                {
                    Link link = new Link();

                    link.DisplayName = (i + 1) + "";
                    link.Source = new Uri((i + 1) + "", UriKind.Relative);

                    links.Add(link);
                }

                salas_list.Links = links;

                var capacidade = (TextBox)this.FindName("capacidade_textbox");
                capacidade.Text = "102";
            }

            if (e.Source.OriginalString.EndsWith("Algarve Shopping"))
            {
                var salas_list = (ModernTab)this.FindName("salas_list");
                LinkCollection links = new LinkCollection();


                for (int i = 0; i < 3; i++)
                {
                    Link link = new Link();

                    link.DisplayName = (i + 1) + "";
                    link.Source = new Uri((i + 1) + "", UriKind.Relative);

                    links.Add(link);
                }

                salas_list.Links = links;
                var capacidade = (TextBox)this.FindName("capacidade_textbox");
                capacidade.Text = "130";
            }

            if (e.Source.OriginalString.EndsWith("Viana Shopping"))
            {
                var salas_list = (ModernTab)this.FindName("salas_list");
                LinkCollection links = new LinkCollection();


                for (int i = 0; i < 4; i++)
                {
                    Link link = new Link();

                    link.DisplayName = (i + 1) + "";
                    link.Source = new Uri((i + 1) + "", UriKind.Relative);

                    links.Add(link);
                }

                salas_list.Links = links;
                var capacidade = (TextBox)this.FindName("capacidade_textbox");
                capacidade.Text = "140";
            }

            if (e.Source.OriginalString.EndsWith("Glicínias Plaza"))
            {
                var salas_list = (ModernTab)this.FindName("salas_list");
                LinkCollection links = new LinkCollection();


                for (int i = 0; i < 5; i++)
                {
                    Link link = new Link();

                    link.DisplayName = (i + 1) + "";
                    link.Source = new Uri((i + 1) + "", UriKind.Relative);

                    links.Add(link);
                }

                salas_list.Links = links;
                var capacidade = (TextBox)this.FindName("capacidade_textbox");
                capacidade.Text = "170";
            }

            if (e.Source.OriginalString.EndsWith("Leiria Shopping"))
            {
                var salas_list = (ModernTab)this.FindName("salas_list");
                LinkCollection links = new LinkCollection();


                for (int i = 0; i < 5; i++)
                {
                    Link link = new Link();

                    link.DisplayName = (i + 1) + "";
                    link.Source = new Uri((i + 1) + "", UriKind.Relative);

                    links.Add(link);
                }

                salas_list.Links = links;
                var capacidade = (TextBox)this.FindName("capacidade_textbox");
                capacidade.Text = "165";
            }
        }

        private void ModernTab_SelectedSourceChanged2(object sender, SourceEventArgs e)
        {
            var cinema_list = (ModernTab)this.FindName("cinemas_list");

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Vasco da Gama"))
            {
                if (e.Source.OriginalString.EndsWith("1") || e.Source.OriginalString.EndsWith("4") || e.Source.OriginalString.EndsWith("6"))
                {

                    var capacidade = (TextBox)this.FindName("capacidade_textbox");
                    capacidade.Text = "300";
                }
                else
                {
                    var capacidade = (TextBox)this.FindName("capacidade_textbox");
                    capacidade.Text = "150";
                }
            }
        }

        private void editar_button_Click(object sender, RoutedEventArgs e)
        {
            if (!capacidade_textbox.Text.Equals(""))
            {
                ModernDialog.ShowMessage("Sala alterada com sucesso!", "Sucesso!", MessageBoxButton.OK);
                IInputElement target = NavigationHelper.FindFrame("_top", this);
                NavigationCommands.GoToPage.Execute("/Pages/Alterar.xaml", target);
            }
            else
                ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);
        }
    }
}
