using ShoppingMall.MyForms;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingMall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text == "Admin")
            {
                if (pbPass.Password == "Admin")
                {
                    ManuWindow manuMiwdow = new ManuWindow();
                    manuMiwdow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль, попробуйте еще раз", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверный логин", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btShowPass_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pbPass.Password, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}