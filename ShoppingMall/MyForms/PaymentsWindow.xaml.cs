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
    /// Логика взаимодействия для PaymentsWindow.xaml
    /// </summary>
    public partial class PaymentsWindow : Window
    {
        public PaymentsWindow()
        {
            InitializeComponent();
            Loaded += PaymentsWindow_Loaded;
        }

        private void PaymentsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MySqlContext context = new DB.MySqlContext();
                var payments = context.Payments.ToList();
                dgContentPayments.ItemsSource = payments;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddPayments_Click(object sender, RoutedEventArgs e)
        {
            AddPaymentsWindow addPaymentsWindow = new AddPaymentsWindow();
            addPaymentsWindow.ShowDialog();
            PaymentsWindow_Loaded(sender, e);
        }

        private void btExitInMenu_Click(object sender, RoutedEventArgs e)
        {
            ManuWindow manuWindow = new ManuWindow();
            manuWindow.Show();
            Close();
        }
    }
}
