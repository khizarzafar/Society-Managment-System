using System.Windows;

namespace Society_Managment_System
{
    public partial class FinancePanel : Window
    {
        public FinancePanel()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Handle Accounting or Bell button click
            MessageBox.Show("Accounting or Notification clicked!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Handle Compensation, Records, Reports, or Logout button click
            MessageBox.Show("Button clicked!");
        }
    }
}
