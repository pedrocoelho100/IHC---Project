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
    /// Interaction logic for Sessao_Editar_List.xaml
    /// </summary>
    public partial class Sessao_Editar_List : UserControl
    {
        public Sessao_Editar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Vasco da Gama"))
            {
                var sessoes = (TextBox)this.FindName("sessoes_textbox");
                sessoes.Text = "14h25, 16h50, 21h10";
            }

            if (e.Source.OriginalString.EndsWith("Algarve Shopping"))
            {
                var sessoes = (TextBox)this.FindName("sessoes_textbox");
                sessoes.Text = "16h30, 21h30, 00h40";
            }

            if (e.Source.OriginalString.EndsWith("Viana Shopping"))
            {
                var sessoes = (TextBox)this.FindName("sessoes_textbox");
                sessoes.Text = "14h30, 16h20, 21h50";
            }

            if (e.Source.OriginalString.EndsWith("Glicínias Plaza"))
            {
                var sessoes = (TextBox)this.FindName("sessoes_textbox");
                sessoes.Text = "14h30, 16h10, 21h20";
            }

            if (e.Source.OriginalString.EndsWith("Leiria Shopping"))
            {
                var sessoes = (TextBox)this.FindName("sessoes_textbox");
                sessoes.Text = "21h10, 00h20";
            }
        }

        private void ModernTab_SelectedSourceChanged2(object sender, SourceEventArgs e)
        {
            var cinemas_list = (ModernTab)this.FindName("cinemas_list");

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Vasco da Gama"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h25, 16h50, 21h10";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "16h50, 21h10";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h25, 16h50";

                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Algarve Shopping"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "21h30, 00h40";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "16h30, 21h30";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "16h30, 21h30";

                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Viana Shopping"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "16h20, 21h50";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h30, 16h20, 21h50";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h30, 21h50";

                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Glicínias Plaza"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h30, 16h10, 21h20";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h30, 16h10";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "14h30, 16h10, 21h20";

                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Leiria Shopping"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "21h10, 00h20";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "21h10, 00h20";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var sessoes = (TextBox)this.FindName("sessoes_textbox");
                    sessoes.Text = "21h10";

                }
            }
        }

        private void editar_button_Click(object sender, RoutedEventArgs e)
        {
            if (!sessoes_textbox.Text.Equals(""))
            {
                ModernDialog.ShowMessage("Sessão alterada com sucesso!", "Sucesso!", MessageBoxButton.OK);
                IInputElement target = NavigationHelper.FindFrame("_top", this);
                NavigationCommands.GoToPage.Execute("/Pages/Alterar.xaml", target);
            }
            else
                ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);
        }
    }
}
