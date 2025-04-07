using System.Windows;
using System.Windows.Controls;

namespace Society_Managment_System
{
    public partial class RegistrarPanel : Page
    {
        public RegistrarPanel()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 clicked!");
            // Add your logic here (e.g., for Payroll or bell button)
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 clicked!");
            // Add your logic here (e.g., for Logout, Attendance, Reports, or pic button)
        }
    }
}