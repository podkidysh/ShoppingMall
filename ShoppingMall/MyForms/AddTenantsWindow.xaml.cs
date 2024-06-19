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
    /// Логика взаимодействия для AddTenantsWindow.xaml
    /// </summary>
    public partial class AddTenantsWindow : Window
    {
        public AddTenantsWindow()
        {
            InitializeComponent();
        }

        private void btAddTentans_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Введите имя");
            }
            if (string.IsNullOrEmpty(tbINN.Text))
            {
                MessageBox.Show("Введите ИНН");
            }
            if (string.IsNullOrEmpty(tbContacts.Text))
            {
                MessageBox.Show("Введите контактные данные");
            }
            if (string.IsNullOrEmpty(tbKindOfActivity.Text))
            {
                MessageBox.Show("Введите вид деятельности арендатора");
            }
            if (string.IsNullOrEmpty(tbCategory.Text))
            {
                MessageBox.Show("Введите категорию арендатора");
            }
            if (string.IsNullOrEmpty(tbRentStartDate.Text))
            {
                MessageBox.Show("Введите дату начала аренды");
            }
            if (string.IsNullOrEmpty(tbRentTerm.Text))
            {
                MessageBox.Show("Введите срок аренды");
            }

            DB.Tenants myNewTenants = new DB.Tenants();

            myNewTenants.Name = tbName.Text;
            myNewTenants.INN = tbINN.Text;
            myNewTenants.ContactDetails = tbContacts.Text;
            myNewTenants.KindOfActivity = tbKindOfActivity.Text;
            myNewTenants.Category = tbCategory.Text;
            myNewTenants.RentStartDate = tbRentStartDate.Text;
            myNewTenants.RentalTerm = tbRentTerm.Text;

            try
            {
                using DB.MySqlContext mySqlContext = new DB.MySqlContext();
                mySqlContext.Tenants.Add(myNewTenants);
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
