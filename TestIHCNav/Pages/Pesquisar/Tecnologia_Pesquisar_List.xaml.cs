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
    /// Interaction logic for Tecnologia_Pesquisar_list.xaml
    /// </summary>
    public partial class Tecnologia_Pesquisar_List : UserControl
    {
        public Tecnologia_Pesquisar_List()
        {
            InitializeComponent();
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {
            if (e.Source.OriginalString.EndsWith("Vasco da Gama"))
            {
                var result = (TextBox)this.FindName("salas_textbox");
                result.Text = "1, 2, 3, 4, 5";
            }

            if (e.Source.OriginalString.EndsWith("Algarve Shopping"))
            {
                var result = (TextBox)this.FindName("salas_textbox");
                result.Text = "1, 2, 3, 4, 5, 6, 7";
            }

            if (e.Source.OriginalString.EndsWith("Viana Shopping"))
            {
                var result = (TextBox)this.FindName("salas_textbox");
                result.Text = "1, 2, 3, 4, 5, 6";
            }

            if (e.Source.OriginalString.EndsWith("Glicínias Plaza"))
            {
                var result = (TextBox)this.FindName("salas_textbox");
                result.Text = "1, 2, 3, 4, 5";
            }

            if (e.Source.OriginalString.EndsWith("Leiria Shopping"))
            {
                var result = (TextBox)this.FindName("salas_textbox");
                result.Text = "1, 2, 3, 4, 5, 6";
            }
        }

        private void ModernTab_SelectedSourceChanged2(object sender, SourceEventArgs e)
        {
            var cinemas_list = (ModernTab)this.FindName("cinemas_list");

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Vasco da Gama"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "1, 2";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "3, 4";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "5";

                }
            }

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Algarve Shopping"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "2, 3";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "4";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "5, 6";

                }
            }

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Viana Shopping"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "3";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "4, 5";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "6";

                }
            }

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Glicínias Plaza"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "1";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "2";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "3, 4";

                }
            }

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Leiria Shopping"))
            {
                if (e.Source.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "3, 4";

                }
                if (e.Source.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "5";

                }
                if (e.Source.OriginalString.EndsWith("O Livro da Selva"))
                {
                    var result = (TextBox)this.FindName("salas_textbox");
                    result.Text = "6";

                }
            }
        }

        private void ModernTab_SelectedSourceChanged3(object sender, SourceEventArgs e)
        {
            var cinemas_list = (ModernTab)this.FindName("cinemas_list");
            var filmes_list = (ModernTab)this.FindName("filmes_list");

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Vasco da Gama"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "1";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "2";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "3";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "4";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "5";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Algarve Shopping"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "2";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "3";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "4";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "5";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "6";
                    }
                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Viana Shopping"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "3";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "4";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "4";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "6";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Glicínias Plaza"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "1";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "2";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "3";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "4";
                    }
                }
            }
            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Leiria Shopping"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "3";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "4";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "5";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (e.Source.OriginalString.EndsWith("Normal"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("3D"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "-";
                    }
                    if (e.Source.OriginalString.EndsWith("IMAX"))
                    {
                        var result = (TextBox)this.FindName("salas_textbox");
                        result.Text = "6";
                    }
                }
            }
        }

/*       
        private void ModernTab_SelectedSourceChanged4(object sender, SourceEventArgs e)
        {
            var cinemas_list = (ModernTab)this.FindName("cinemas_list");
            var filmes_list = (ModernTab)this.FindName("filmes_list");
            var tecnologias_list = (ModernTab)this.FindName("tecnologias_list");

            Vasco da Gama

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Vasco da Gama"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
            }

            Algarve Shopping

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Algarve Shopping"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
            }

            Viana Shopping

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Viana Shopping"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
            }

            Glicínias Plaza

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Glicínias Plaza"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
            }

            Leiria Shopping

            if (cinemas_list.SelectedSource.OriginalString.EndsWith("Leiria Shopping"))
            {
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Má Vizinhança 2"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("Um Dia de Mãe"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
                if (filmes_list.SelectedSource.OriginalString.EndsWith("O Livro da Selva"))
                {
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("Normal"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("3D"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                    if (tecnologias_list.SelectedSource.OriginalString.EndsWith("IMAX"))
                    {
                        if (e.Source.OriginalString.EndsWith("1"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("2"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                        if (e.Source.OriginalString.EndsWith("3"))
                        {
                            var result = (TextBox)this.FindName("salas_textbox");
                            result.Text = "Não";
                        }
                    }
                }
            }
        }*/
    }
}                                                                      