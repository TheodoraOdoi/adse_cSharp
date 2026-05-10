using System.Windows;

namespace Edulink_Student_Staff_WPF_DB
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

        // Code to handle the OpenStaff button click's event
        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var staffWindow = new StaffWindow { Owner = this };
                staffWindow.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    $"Opening the staff window failed.\n\n{ex}",
                    "Staff Window Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
            }
        }

        // TODO: Code to handle the OpenStudent button click's event
        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var studentWindow = new StudentWindow { Owner = this };
                studentWindow.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    $"Opening the student window failed.\n\n{ex}",
                    "Student Window Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
            }
        }
    }
}