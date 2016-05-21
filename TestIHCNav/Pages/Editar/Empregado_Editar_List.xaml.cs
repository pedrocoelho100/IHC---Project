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
    /// Interaction logic for Empregado_Editar_List.xaml
    /// </summary>
    public partial class Empregado_Editar_List : UserControl
    {
        public Empregado_Editar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Ana Maria Dias"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "1";

                var cinema = (TextBox)this.FindName("cinema_textbox");
                cinema.Text = "Glicínias Plaza";

                var salario = (TextBox)this.FindName("salario_textbox");
                salario.Text = "1.200€";

                var nif = (TextBox)this.FindName("nif_textbox");
                nif.Text = "238965354";
            }
            if (e.Source.OriginalString.EndsWith("Guilherme Vaz Fonseca"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "2";

                var cinema = (TextBox)this.FindName("cinema_textbox");
                cinema.Text = "Leiria Shopping";

                var salario = (TextBox)this.FindName("salario_textbox");
                salario.Text = "1.400€";

                var nif = (TextBox)this.FindName("nif_textbox");
                nif.Text = "217543955";
            }
            if (e.Source.OriginalString.EndsWith("Jorge Manuel Costa"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "3";

                var cinema = (TextBox)this.FindName("cinema_textbox");
                cinema.Text = "Algarve Shopping";

                var salario = (TextBox)this.FindName("salario_textbox");
                salario.Text = "1.100€";

                var nif = (TextBox)this.FindName("nif_textbox");
                nif.Text = "204570932";
            }
        }

        private void editar_button_Click(object sender, RoutedEventArgs e)
        {
            if (!id_textbox.Text.Equals("") || !cinema_textbox.Text.Equals("") || !salario_textbox.Text.Equals("") || !nif_textbox.Text.Equals(""))
            {
                ModernDialog.ShowMessage("Empregado alterado com sucesso!", "Sucesso!", MessageBoxButton.OK);
                IInputElement target = NavigationHelper.FindFrame("_top", this);
                NavigationCommands.GoToPage.Execute("/Pages/Alterar.xaml", target);
            }
            else
                ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);
        }
    }
}
