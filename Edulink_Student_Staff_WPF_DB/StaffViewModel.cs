using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace Edulink_Student_Staff_WPF_DB;

public class StaffViewModel : INotifyPropertyChanged
{
    private readonly SqlServerStaffRepository _repository = new();

    public ObservableCollection<Staff> StaffList { get; set; }

    public ICollectionView StaffView { get; set; }

    private Staff _selectedStaff = new();
    public Staff SelectedStaff
    {
        get => _selectedStaff;
        set
        {
            _selectedStaff = value;
            OnPropertyChanged(nameof(SelectedStaff));
        }
    }

    private string _searchText = string.Empty;
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            StaffView.Refresh();
            OnPropertyChanged(nameof(SearchText));
        }
    }

    private string _statusMessage = "Loading staff records...";
    public string StatusMessage
    {
        get => _statusMessage;
        set
        {
            _statusMessage = value;
            OnPropertyChanged(nameof(StatusMessage));
        }
    }

    public StaffViewModel()
    {
        StaffList = new ObservableCollection<Staff>();
        StaffView = CollectionViewSource.GetDefaultView(StaffList);

        StaffView.Filter = FilterStaff;
        StaffView.CurrentChanged += (_, _) => SyncCurrentSelection();
        LoadData();
    }

    private bool FilterStaff(object obj)
    {
        if (string.IsNullOrWhiteSpace(SearchText))
            return true;
        if (obj is not Staff staff)
            return false;

        return staff.Names.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
               staff.Designation.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
               staff.PhoneNo.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase);
    }

    private void SyncCurrentSelection()
    {
        if (StaffView.CurrentItem is Staff currentStaff)
            SelectedStaff = currentStaff;
    }

    public void LoadData()
    {
        try
        {
            StaffList.Clear();

            foreach (var staff in _repository.GetAll())
            {
                StaffList.Add(staff);
            }

            SelectedStaff = StaffList.FirstOrDefault() ?? new Staff
            {
                BirthDate = System.DateTime.Today,
                EmployementDate = System.DateTime.Today
            };

            if (StaffList.Count > 0)
                StaffView.MoveCurrentToFirst();

            StatusMessage = $"Loaded {StaffList.Count} record(s) from the database.";
        }
        catch (System.Exception e)
        {
            SelectedStaff = new Staff
            {
                BirthDate = System.DateTime.Today,
                EmployementDate = System.DateTime.Today
            };
            StatusMessage = $"Loading staff records failed: {e.Message}";
        }
    }

    // CRUD operation methods
    public void AddStaff()
    {
        if (!HasValidStaff())
        {
            StatusMessage = "Please enter at least a staff id and name before adding a record";
            return;
        }
        try
        {
            var name = SelectedStaff.Names;
            _repository.Add(SelectedStaff);
            LoadData();
            StatusMessage = $"Added {name}'s record(s) to the database.";
        }
        catch (Exception e)
        {
            StatusMessage = $"Insert failed: {e.Message}";
        }
    }

    public void UpdateStaff()
    {
        if (!HasValidStaff())
        {
            StatusMessage = "Please select a valid staff member before updating.";
            return;
        }

        try
        {
            var name = SelectedStaff.Names;
            _repository.Update(SelectedStaff);
            LoadData();
            StatusMessage = $"Updated {name}'s record(s) in the database.";
        }
        catch (Exception e)
        {
            StatusMessage = $"Update failed: {e.Message}";
        }
    }

    public void DeleteStaff()
    {
        if (!HasValidStaff())
        {
            StatusMessage = "Please select a valid staff member before deleting.";
            return;
        }

        try
        {
            var name = SelectedStaff.Names;
            _repository.Delete(SelectedStaff);
            LoadData();
            StatusMessage = $"Deleted {name}' record(s) in the database.";
        }
        catch (Exception e)
        {
            StatusMessage = $"Delete failed: {e.Message}";
        }
    }

    // Record navigation methods
    public void First()
    {
        StaffView.MoveCurrentToFirst();
        SyncCurrentSelection();
    }

    public void Previous()
    {
        StaffView.MoveCurrentToPrevious();
        SyncCurrentSelection();
    }

    public void Next()
    {
        StaffView.MoveCurrentToNext();
        SyncCurrentSelection();
    }

    public void Last()
    {
        StaffView.MoveCurrentToLast();
        SyncCurrentSelection();
    }

    public void PrepareNewStaff()
    {
        SelectedStaff = new Staff
        {
            BirthDate = DateTime.Today,
            EmployementDate = DateTime.Today
        };

        StatusMessage = "Ready to add a new staff member";
    }

    // Method to check whether the student no. and name fields have been filled
    private bool HasValidStaff() =>
        !string.IsNullOrWhiteSpace(SelectedStaff.StaffID) &&
        !string.IsNullOrWhiteSpace(SelectedStaff.Names);

    // private void SyncCurrentSelection()
    // {
    //     if (StaffView.CurrentItem is Staff currentStaff)
    //         SelectedStaff = currentStaff;
    // }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}