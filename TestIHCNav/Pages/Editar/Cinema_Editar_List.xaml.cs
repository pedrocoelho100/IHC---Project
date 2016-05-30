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
    /// Interaction logic for Cinema_Editar_List.xaml
    /// </summary>
    public partial class Cinema_Editar_List : UserControl
    {
        public Cinema_Editar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Algarve Shopping"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "1";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Algarve Shopping";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Shopping Lanka, Lote R, Fracção 3, 8200-417 Guia";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "289 105 500";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Maria Costa";
            }
            if (e.Source.OriginalString.EndsWith("Alvaláxia"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "2";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Alvaláxia";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Rua Francisco Stromp 1600-616 Lisboa";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "16996";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Susana Mendes";
            }
            if (e.Source.OriginalString.EndsWith("Colombo"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "3";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Colombo";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Av. Lusiadas, loja A 203 1500-392 Lisboa";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "16996";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Pedro Dias";
            }
            if (e.Source.OriginalString.EndsWith("Dolce Vita Porto"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "4";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Dolce Vita Porto";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Rua dos Campeões Europeus, 28-198 4350-175 Porto";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "16996";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Miguel Gonçalves";
            }

            if (e.Source.OriginalString.EndsWith("Glicínias Plaza"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "5";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Centro Comercial Glicínias Plaza";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Rua Dom Manuel Barbuda e Vasconcelos, 3810 Aveiro";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "234 891 250";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Ana Dias";
            }

            if (e.Source.OriginalString.EndsWith("Leiria Shopping"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "6";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Leiria Shopping";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Rua do Alto Vieiro, 2400-441 Leiria";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "244 860 780";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "António Correia";
            }

            if (e.Source.OriginalString.EndsWith("Vasco da Gama"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "7";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Centro Vasco da Gama";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Lote05.02, Av. Dom João II 1, 1990-094 Lisboa";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "21 893 0601";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Miguel Cardoso";
            }

            if (e.Source.OriginalString.EndsWith("Viana Shopping"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "8";

                var nome = (TextBox)this.FindName("nome_textbox");
                nome.Text = "Estação Viana Shopping";

                var morada = (TextBox)this.FindName("morada_textbox");
                morada.Text = "Rua Gen. Humberto Delgado 101, 4900-317 Viana do Castelo";

                var telefone = (TextBox)this.FindName("telefone_textbox");
                telefone.Text = "258 100 500";

                var gerente = (TextBox)this.FindName("gerente_textbox");
                gerente.Text = "Nuno Carvalho";
            }
        }

        private void editar_button_Click(object sender, RoutedEventArgs e)
        {
            if (!id_textbox.Text.Equals("") || !nome_textbox.Text.Equals("") || !morada_textbox.Text.Equals("") || !telefone_textbox.Text.Equals("") || !gerente_textbox.Text.Equals(""))
            {
                ModernDialog.ShowMessage("Cinema alterado com sucesso!", "Sucesso!", MessageBoxButton.OK);
                IInputElement target = NavigationHelper.FindFrame("_top", this);
                NavigationCommands.GoToPage.Execute("/Pages/Alterar.xaml", target);
            }
            else
                ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);
        }
    }
}