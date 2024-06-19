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
    /// Логика взаимодействия для AddLeaseWindow.xaml
    /// </summary>
    public partial class AddLeaseWindow : Window
    {
        public AddLeaseWindow()
        {
            InitializeComponent();
        }

        private void btAddLease_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumber.Text))
            {
                MessageBox.Show("Введите номер договора");
            }
            if (string.IsNullOrEmpty(tbDateOfConlusion.Text))
            {
                MessageBox.Show(">Введите дату заключения договора");
            }
            if (string.IsNullOrEmpty(tbValidity.Text))
            {
                MessageBox.Show("Введите срок действия договора");
            }
            if (string.IsNullOrEmpty(tbRents.Text))
            {
                MessageBox.Show("Введите арендную ставку договора");
            }
            if (string.IsNullOrEmpty(tbTermsOfPayment.Text))
            {
                MessageBox.Show("Введите условия оплаты договора");
            }
            if (string.IsNullOrEmpty(tbDepositSize.Text))
            {
                MessageBox.Show("Введите размер депозита договора");
            }
            if (string.IsNullOrEmpty(tbPremisesId.Text))
            {
                MessageBox.Show("Введите ID помещения");
            }
            if (string.IsNullOrEmpty(tbTenantsId.Text))
            {
                MessageBox.Show("Введите ID Арендатора");
            }

            DB.LeaseAgreements myNewLease = new DB.LeaseAgreements();

            myNewLease.Number = tbNumber.Text;
            myNewLease.DateOfConlusion = tbDateOfConlusion.Text;
            myNewLease.Validity = tbValidity.Text;
            myNewLease.Rents = tbRents.Text;
            myNewLease.TermsOfPayment = tbTermsOfPayment.Text;
            myNewLease.DepositSize = tbDepositSize.Text;
            myNewLease.PremisesId = tbPremisesId.Text;
            myNewLease.TenantId = tbTenantsId.Text;

            try
            {
                using DB.MySqlContext mySqlContext = new DB.MySqlContext();
                mySqlContext.LeaseAgreements.Add(myNewLease);
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
