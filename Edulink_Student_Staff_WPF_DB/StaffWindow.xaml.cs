using System.Windows;

namespace Edulink_Student_Staff_WPF_DB;

public partial class StaffWindow : Window
{
    public StaffViewModel ViewModel { get; set; }

    public StaffWindow()
    {
        InitializeComponent();
        ViewModel = new StaffViewModel();
        DataContext = ViewModel;
    }

    // Event handling code for the UI buttons
    private void btnRefresh_Click(object sender, RoutedEventArgs e) => ViewModel.LoadData();
    private void btnNew_Click(object sender, RoutedEventArgs e) => ViewModel.PrepareNewStaff();
    private void btnAdd_Click(object sender, RoutedEventArgs e) => ViewModel.AddStaff();
    private void btnUpdate_Click(object sender, RoutedEventArgs e) => ViewModel.UpdateStaff();
    private void btnDelete_Click(object sender, RoutedEventArgs e) => ViewModel.DeleteStaff();
    private void btnFirst_Click(object sender, RoutedEventArgs e) => ViewModel.First();
    private void btnPrevious_Click(object sender, RoutedEventArgs e) => ViewModel.Previous();
    private void btnNext_Click(object sender, RoutedEventArgs e) => ViewModel.Next();
    private void btnLast_Click(object sender, RoutedEventArgs e) => ViewModel.Last();
}