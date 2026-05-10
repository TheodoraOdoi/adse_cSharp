using System.Windows;

namespace Edulink_Student_Staff_WPF_DB;

public partial class StudentWindow : Window
{
    public StudentViewModel ViewModel { get; set; }
    public StudentWindow()
    {
        InitializeComponent();
        ViewModel = new StudentViewModel();
        DataContext = ViewModel;
    }

    // Event handling code for the UI buttons
    private void btnRefresh_Click(object sender, RoutedEventArgs e) => ViewModel.LoadData();
    private void btnNew_Click(object sender, RoutedEventArgs e) => ViewModel.PrepareNewStudent();
    private void btnAdd_Click(object sender, RoutedEventArgs e) => ViewModel.AddStudent();
    private void btnUpdate_Click(object sender, RoutedEventArgs e) => ViewModel.UpdateStudent();
    private void btnDelete_Click(object sender, RoutedEventArgs e) => ViewModel.DeleteStudent();
    private void btnFirst_Click(object sender, RoutedEventArgs e) => ViewModel.First();
    private void btnPrevious_Click(object sender, RoutedEventArgs e) => ViewModel.Previous();
    private void btnNext_Click(object sender, RoutedEventArgs e) => ViewModel.Next();
    private void btnLast_Click(object sender, RoutedEventArgs e) => ViewModel.Last();
}