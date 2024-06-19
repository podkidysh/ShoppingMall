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
    /// Логика взаимодействия для ManuWindow.xaml
    /// </summary>
    public partial class ManuWindow : Window
    {
        public ManuWindow()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btPayments_Click(object sender, RoutedEventArgs e)
        {
            PaymentsWindow paymentsWindow = new PaymentsWindow();
            paymentsWindow.Show();
            Close();
        }

        private void btPremises_Click(object sender, RoutedEventArgs e)
        {
            PremisesWindow premisesWindow = new PremisesWindow();
            premisesWindow.Show();
            Close();
        }

        private void btTenants_Click(object sender, RoutedEventArgs e)
        {
            TenantsWindow tenantsWindow = new TenantsWindow();
            tenantsWindow.Show();
            Close();
        }

        private void btLeaseAgreements_Click(object sender, RoutedEventArgs e)
        {
            LeaseAgreementsWindow leaseAgreementsWindow = new LeaseAgreementsWindow();
            leaseAgreementsWindow.Show();
            Close();
        }
    }
}
