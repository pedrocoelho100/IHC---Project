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
    /// Interaction logic for Filmes_Pesquisar_list.xaml
    /// </summary>
    public partial class Filmes_Pesquisar_List : UserControl
    {
        public Filmes_Pesquisar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "1";

                var titulo = (TextBox)this.FindName("titulo_textbox");
                titulo.Text = "Má Vizinhança 2";

                var idade = (TextBox)this.FindName("idade_textbox");
                idade.Text = "14";

                var duracao = (TextBox)this.FindName("duracao_textbox");
                duracao.Text = "93";

                var estreia = (TextBox)this.FindName("estreia_textbox");
                estreia.Text = "12/05/2016";

                var tecnologia = (TextBox)this.FindName("tecnologia_textbox");
                tecnologia.Text = "Digital";

                var distribuidora = (TextBox)this.FindName("distribuidora_textbox");
                distribuidora.Text = "NOS Audiovisuais";

                var cinemas = (TextBox)this.FindName("cinemas_textbox");
                cinemas.Text = "Algarve Shopping, Glicínias Plaza";
            }
            if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "3";

                var titulo = (TextBox)this.FindName("titulo_textbox");
                titulo.Text = "Um Dia de Mãe";

                var idade = (TextBox)this.FindName("idade_textbox");
                idade.Text = "12";

                var duracao = (TextBox)this.FindName("duracao_textbox");
                duracao.Text = "118";

                var estreia = (TextBox)this.FindName("estreia_textbox");
                estreia.Text = "28/04/2016";
                
                var tecnologia = (TextBox)this.FindName("tecnologia_textbox");
                tecnologia.Text = "Digital";

                var distribuidora = (TextBox)this.FindName("distribuidora_textbox");
                distribuidora.Text = "NOS Audiovisuais";

                var cinemas = (TextBox)this.FindName("cinemas_textbox");
                cinemas.Text = "Algarve Shopping, Glicínias Plaza, Leiria Shopping, Viana Shopping";
            }
            if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
            {
                var id = (TextBox)this.FindName("id_textbox");
                id.Text = "2";

                var titulo = (TextBox)this.FindName("titulo_textbox");
                titulo.Text = "O Livro da Selva";

                var idade = (TextBox)this.FindName("idade_textbox");
                idade.Text = "6";

                var duracao = (TextBox)this.FindName("duracao_textbox");
                duracao.Text = "106";

                var estreia = (TextBox)this.FindName("estreia_textbox");
                estreia.Text = "14/04/2016";

                var tecnologia = (TextBox)this.FindName("tecnologia_textbox");
                tecnologia.Text = "Digital, ATMOS";

                var distribuidora = (TextBox)this.FindName("distribuidora_textbox");
                distribuidora.Text = "Castello Lopes Cinemas";

                var cinemas = (TextBox)this.FindName("cinemas_textbox");
                cinemas.Text = "Viana Shopping";
            }
        }
    }
}