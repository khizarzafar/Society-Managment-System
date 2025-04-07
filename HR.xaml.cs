using System.Windows;

namespace Society_Managment_System
{
    public partial class HR : Window
    {
        public HR()
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