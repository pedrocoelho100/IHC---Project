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

namespace Projeto_IHC
{
    /// <summary>
    /// Interaction logic for Alterar.xaml
    /// </summary>
    public partial class Alterar : Page
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Cinema_Editar_List.xaml", target);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Distribuidora_Editar_List.xaml", target);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Empregado_Editar_List.xaml", target);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Filme_Editar_List.xaml", target);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Tecnologia_Editar_List.xaml", target);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Sessao_Editar_List.xaml", target);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Sala_Editar_List.xaml", target);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Editar/Preço_Editar_List.xaml", target);
        }
    }
}
