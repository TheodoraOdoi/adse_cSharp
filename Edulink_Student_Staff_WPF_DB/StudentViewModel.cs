using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;

namespace Edulink_Student_Staff_WPF_DB;

public class StudentViewModel : INotifyPropertyChanged
{
    private readonly SqlServerStudentRepository _repository = new();

    public ObservableCollection<Student> StudentList { get; set; }

    public ICollectionView StudentView { get; set; }

    private Student _selectedStudent = new();
    public Student SelectedStudent
    {
        get => _selectedStudent;
        set
        {
            _selectedStudent = value;
            OnPropertyChanged(nameof(SelectedStudent));
        }
    }

    private string _searchText = string.Empty;
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            StudentView.Refresh();
            OnPropertyChanged(nameof(SearchText));
        }
    }

    private string _statusMessage = "Loading student records...";
    public string StatusMessage
    {
        get => _statusMessage;
        set
        {
            _statusMessage = value;
            OnPropertyChanged(nameof(StatusMessage));
        }
    }

    public StudentViewModel()
    {
        StudentList = new ObservableCollection<Student>();
        StudentView = CollectionViewSource.GetDefaultView(StudentList);
        StudentView.Filter = FilterStudent;
        StudentView.CurrentChanged += (_, _) => SyncCurrentSelection();
        LoadData();
    }

    private bool FilterStudent(object obj)
    {
        if (string.IsNullOrWhiteSpace(SearchText))
            return true;
        if (obj is not Student student)
            return false;

        return student.Names.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
               student.Course.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase) ||
               student.Nationality.Contains(SearchText, System.StringComparison.OrdinalIgnoreCase);
    }

    private void SyncCurrentSelection()
    {
        if (StudentView.CurrentItem is Student currentStudent)
            SelectedStudent = currentStudent;
    }

    public void LoadData()
    {
        try
        {
            StudentList.Clear();

            foreach (var student in _repository.GetAll())
            {
                StudentList.Add(student);
            }

            SelectedStudent = StudentList.FirstOrDefault() ?? new Student
            {
                BirthDate = System.DateTime.Today
            };

            if (StudentList.Count > 0)
                StudentView.MoveCurrentToFirst();

            StatusMessage = $"Loaded {StudentList.Count} record(s) from the database.";
        }
        catch (System.Exception e)
        {
            SelectedStudent = new Student
            {
                BirthDate = System.DateTime.Today
            };
            StatusMessage = $"Loading student records failed: {e.Message}";
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    // CRUD operation methods
    public void AddStudent()
    {
        if (!HasValidStudent())
        {
            StatusMessage = "Please enter at least a student number and name before adding a record";
            return;
        }
        try
        {
            var name = SelectedStudent.Names;
            _repository.Add(SelectedStudent);
            LoadData();
            StatusMessage = $"Added {name}'s record(s) to the database.";
        }
        catch (Exception e)
        {
            StatusMessage = $"Insert failed: {e.Message}";
        }
    }

    public void UpdateStudent()
    {
        if (!HasValidStudent())
        {
            StatusMessage = "Please select a valid student before updating.";
            return;
        }

        try
        {
            var name = SelectedStudent.Names;
            _repository.Update(SelectedStudent);
            LoadData();
            StatusMessage = $"Updated {name}' record(s) in the database.";
        }
        catch (Exception e)
        {
            StatusMessage = $"Update failed: {e.Message}";
        }
    }

    public void DeleteStudent()
    {
        if (!HasValidStudent())
        {
            StatusMessage = "Please select a valid student before deleting.";
            return;
        }

        try
        {
            var name = SelectedStudent.Names;
            _repository.Delete(SelectedStudent);
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
        StudentView.MoveCurrentToFirst();
        SyncCurrentSelection();
    }

    public void Previous()
    {
        StudentView.MoveCurrentToPrevious();
        SyncCurrentSelection();
    }

    public void Next()
    {
        StudentView.MoveCurrentToNext();
        SyncCurrentSelection();
    }

    public void Last()
    {
        StudentView.MoveCurrentToLast();
        SyncCurrentSelection();
    }

    public void PrepareNewStudent()
    {
        SelectedStudent = new Student
        {
            BirthDate = DateTime.Today,
            CurrentSem = 1
        };

        StatusMessage = "Ready to add a new student";
    }

    // Method to check whether the student no. and name fields have been filled
    private bool HasValidStudent() =>
        !string.IsNullOrWhiteSpace(SelectedStudent.StudentNo) &&
        !string.IsNullOrWhiteSpace(SelectedStudent.Names);
}