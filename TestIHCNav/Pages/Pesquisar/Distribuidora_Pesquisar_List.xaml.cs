using FirstFloor.ModernUI.Windows.Controls;
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

namespace TestIHCNav.Pages.Pesquisar
{
    /// <summary>
    /// Interaction logic for Distribuidora_Pesquisar_list.xaml
    /// </summary>
    public partial class Distribuidora_Pesquisar_List : UserControl
    {
        public Distribuidora_Pesquisar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Castello Lopes Cinemas"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "1";

                var pagamento = (TextBox)this.FindName("pagamento_textbox");
                pagamento.Text = "75.000€";

                var comissao = (TextBox)this.FindName("comissao_textbox");
                comissao.Text = "10%";
            }
            if (e.Source.OriginalString.EndsWith("NOS Audiovisuais"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "2";

                var pagamento = (TextBox)this.FindName("pagamento_textbox");
                pagamento.Text = "50.000€";

                var comissao = (TextBox)this.FindName("comissao_textbox");
                comissao.Text = "5%";
            }
        }
    }
}
