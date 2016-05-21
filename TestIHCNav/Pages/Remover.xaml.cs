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
    /// Interaction logic for Remover.xaml
    /// </summary>
    public partial class Remover : Page
    {
        public Remover()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Cinema_Remover_List.xaml", target);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Distribuidora_Remover_List.xaml", target);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Empregado_Remover_List.xaml", target);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Filme_Remover_List.xaml", target);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Tecnologia_Remover_List.xaml", target);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Sessao_Remover_List.xaml", target);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Sala_Remover_List.xaml", target);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover/Preço_Remover_List.xaml", target);
        }
    }
}
