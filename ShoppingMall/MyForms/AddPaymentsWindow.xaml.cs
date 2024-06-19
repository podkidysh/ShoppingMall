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
    /// Логика взаимодействия для AddPaymentsWindow.xaml
    /// </summary>
    public partial class AddPaymentsWindow : Window
    {
        public AddPaymentsWindow()
        {
            InitializeComponent();
        }

        private void btAddPayments_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDate.Text))
            {
                MessageBox.Show("Введите дату аренды");
            }
            if (string.IsNullOrEmpty(tbSum.Text))
            {
                MessageBox.Show("Введите сумму платежа");
            }
            if (string.IsNullOrEmpty(tbPurpose.Text))
            {
                MessageBox.Show("Введите назначение платежа");
            }
            if (string.IsNullOrEmpty(tbStatus.Text))
            {
                MessageBox.Show("Введите статус платежа");
            }
            if (string.IsNullOrEmpty(tbLeaseId.Text))
            {
                MessageBox.Show("Введите ID договора аренды");
            }
            if (string.IsNullOrEmpty(tbTenantsId.Text))
            {
                MessageBox.Show("Введите ID Арендатора");
            }

            DB.Payments myNewPayments= new DB.Payments();

            myNewPayments.Date = tbDate.Text;
            myNewPayments.Sum = tbSum.Text;
            myNewPayments.Purpose = tbPurpose.Text;
            myNewPayments.Status = tbStatus.Text;
            myNewPayments.LeaseId = tbLeaseId.Text;
            myNewPayments.TenantsId = tbTenantsId.Text;
            myNewPayments.Status = tbStatus.Text;

            try
            {
                using DB.MySqlContext mySqlContext = new DB.MySqlContext();
                mySqlContext.Payments.Add(myNewPayments);
                mySqlContext.SaveChanges();
                MessageBox.Show("Вы успешно добавили запись");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
