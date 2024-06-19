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
    /// Логика взаимодействия для LeaseAgreementsWindow.xaml
    /// </summary>
    public partial class LeaseAgreementsWindow : Window
    {
        public LeaseAgreementsWindow()
        {
            InitializeComponent();
            Loaded += LeaseAgreementsWindow_Loaded;
        }

        private void LeaseAgreementsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MySqlContext context = new DB.MySqlContext();
                var lease = context.LeaseAgreements.ToList();
                dgContentLease.DataContext = lease;
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            } 
        }

        private void btAddLease_Click(object sender, RoutedEventArgs e)
        {
            AddLeaseWindow addLeaseWindow = new AddLeaseWindow();
            addLeaseWindow.ShowDialog();
            LeaseAgreementsWindow_Loaded(sender, e);
        }

        private void btExitInMenu_Click(object sender, RoutedEventArgs e)
        {
            ManuWindow manuWindow = new ManuWindow();
            manuWindow.Show();
            Close();
        }
    }
}
