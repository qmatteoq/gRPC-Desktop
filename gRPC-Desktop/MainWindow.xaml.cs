using CustomersServiceLibrary;
using CustomersServiceLibrary.Model;
using System.Windows;

namespace gRPCDesktop
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

        private async void OnSaveCustomer(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer
            {
                Name = "John",
                Surname = "Doe",
                Mail = "john.doe@foo.com"
            };

            var client = new CustomersApi();
            var response = await client.SaveCustomerAsync(customer);
            txtCustomerName.Text = response;
        }
    }
}
