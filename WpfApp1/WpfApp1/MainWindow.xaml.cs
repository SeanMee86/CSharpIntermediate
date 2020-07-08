using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string TextContent { get; set; }
        public DataSet customerOrders = new DataSet("Customer Orders");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            if(button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
                var newTable = new DataTable("Today's Orders");
                newTable.NewRow();
                customerOrders.Tables.Add();
            }

            MessageBox.Show("Hello World");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TextContent);

        }

        private void textChangedHandler(object sender, TextChangedEventArgs args)
        {
            var textContent = sender as TextBox;
            TextContent = textContent.Text;
        }
    }
}
