using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_MVVM.Models;

namespace WPF_MVVM.View_Models
{
    public class PersonViewModel : ObservableObject
    {
        // Private fields
        private readonly ObservableCollection<Person> _people = new ObservableCollection<Person>();
        private Person _selectedPerson;
        private string _currentName;
        private ICommand _addNameCommand;
        private ICommand _deleteNameCommand;
        private ICommand _replaceNameCommand;

        // Public properties
        public ObservableCollection<Person> People
        {
            get
            {
                return _people;
            }
        }

        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                if (_selectedPerson != value)
                {
                    _selectedPerson = value;
                }
            }
        }
        
        public string CurrentName
        {
            get
            {
                return _currentName;
            }
            set
            {
                if (_currentName != value)
                {
                    _currentName = value;
                    // Needed when CurrentName is set to string.Empty in AddName() and ReplaceName()
                    // or else the textbox in the view won't display that empty string for the current name
                    OnPropertyChanged("CurrentName");
                }
            }
        }
        
        // Button commands
        public ICommand AddNameCommand
        {
            get
            {
                if (_addNameCommand == null)
                {
                    _addNameCommand = new RelayCommand(param => AddName(), param => CanAddName());
                }
                return _addNameCommand;
            }
        }

        public ICommand DeleteNameCommand
        {
            get
            {
                if (_deleteNameCommand == null)
                {
                    _deleteNameCommand = new RelayCommand(param => DeleteName(), param => CanDeleteName());
                }
                return _deleteNameCommand;
            }
        }

        public ICommand ReplaceNameCommand
        {
            get
            {
                if (_replaceNameCommand == null)
                {
                    _replaceNameCommand = new RelayCommand(param => ReplaceName(), param => CanReplaceName());
                }
                return _replaceNameCommand;
            }
        }

        // Command methods
        private void AddName()
        {
            People.Add(new Person(CurrentName));
            CurrentName = string.Empty;
        }

        private bool CanAddName()
        {
            return !string.IsNullOrEmpty(CurrentName);
        }

        private void DeleteName()
        {
            People.Remove(SelectedPerson);
        }

        private bool CanDeleteName()
        {
            return SelectedPerson != null;
        }

        private void ReplaceName()
        {
            SelectedPerson.Name = CurrentName;
            CurrentName = string.Empty;
        }

        private bool CanReplaceName()
        {
            return SelectedPerson != null && !string.IsNullOrEmpty(CurrentName);
        }
    }
}