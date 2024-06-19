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

namespace ShoppingMall.MyForms
{
    /// <summary>
    /// Логика взаимодействия для TenantsWindow.xaml
    /// </summary>
    public partial class TenantsWindow : Window
    {
        public TenantsWindow()
        {
            InitializeComponent();
            Loaded += TenantsWindow_Loaded;
        }

        private void TenantsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MySqlContext context = new DB.MySqlContext();
                var tenant = context.Tenants.ToList();
                dgContentTenants.ItemsSource = tenant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddTenants_Click(object sender, RoutedEventArgs e)
        {
            AddTenantsWindow addTenantsWindow = new AddTenantsWindow();
            addTenantsWindow.ShowDialog();
            TenantsWindow_Loaded(sender, e);
        }

        private void btExitInMenu_Click(object sender, RoutedEventArgs e)
        {
            ManuWindow manuWindow = new ManuWindow();
            manuWindow.Show();
            Close();
        }
    }
}
