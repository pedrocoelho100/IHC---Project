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
    /// Interaction logic for Preço_Editar_List.xaml
    /// </summary>
    public partial class Preço_Editar_List : UserControl
    {
        public Preço_Editar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Normal"))
            {
                var adulto = (TextBox)this.FindName("adulto_textbox");
                adulto.Text = "6€";

                var criança = (TextBox)this.FindName("criança_textbox");
                criança.Text = "4,5€";

                var senior = (TextBox)this.FindName("senior_textbox");
                senior.Text = "4,5€";

                var segunda_feira = (TextBox)this.FindName("segunda_feira_textbox");
                segunda_feira.Text = "4,5€";

                var cartao = (TextBox)this.FindName("cartao_textbox");
                cartao.Text = "3€";
            }
            if (e.Source.OriginalString.EndsWith("3D"))
            {
                var adulto = (TextBox)this.FindName("adulto_textbox");
                adulto.Text = "15€";

                var criança = (TextBox)this.FindName("criança_textbox");
                criança.Text = "8,5€";

                var senior = (TextBox)this.FindName("senior_textbox");
                senior.Text = "8,5€";

                var segunda_feira = (TextBox)this.FindName("segunda_feira_textbox");
                segunda_feira.Text = "8,5€";

                var cartao = (TextBox)this.FindName("cartao_textbox");
                cartao.Text = "5€";
            }
            if (e.Source.OriginalString.EndsWith("IMAX"))
            {
                var adulto = (TextBox)this.FindName("adulto_textbox");
                adulto.Text = "8€";

                var criança = (TextBox)this.FindName("criança_textbox");
                criança.Text = "6€";

                var senior = (TextBox)this.FindName("senior_textbox");
                senior.Text = "6,5€";

                var segunda_feira = (TextBox)this.FindName("segunda_feira_textbox");
                segunda_feira.Text = "6,5€";

                var cartao = (TextBox)this.FindName("cartao_textbox");
                cartao.Text = "3€";
            }
        }

        private void editar_button_Click(object sender, RoutedEventArgs e)
        {
            if (!adulto_textbox.Text.Equals("") || !criança_textbox.Text.Equals("") || !senior_textbox.Text.Equals("") || !segunda_feira_textbox.Text.Equals("") || !cartao_textbox.Text.Equals(""))
            {
                ModernDialog.ShowMessage("Preço alterado com sucesso!", "Sucesso!", MessageBoxButton.OK);
                IInputElement target = NavigationHelper.FindFrame("_top", this);
                NavigationCommands.GoToPage.Execute("/Pages/Alterar.xaml", target);
            }
            else
                ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);
        }
    }
}
