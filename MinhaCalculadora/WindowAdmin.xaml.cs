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
using System.Windows.Shapes;

namespace MinhaCalculadora
{
    /// <summary>
    /// Lógica interna para WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_criarUsuario_Click(object sender, RoutedEventArgs e)
        {
            CriarUsuarioWindow objCriarUsuarioWindow = new CriarUsuarioWindow();
            this.Visibility = Visibility.Hidden;
            objCriarUsuarioWindow.Show();
        }
    }
}
