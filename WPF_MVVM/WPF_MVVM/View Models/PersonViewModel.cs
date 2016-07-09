using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WPF_MVVM.View_Models
{
    public class PersonViewModel : ObservableObject
    {
        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();  // Readonly
        public Person SelectedPerson { get; set; }
        private string _currentName;
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
                    OnPropertyChanged("CurrentName");
                }
            }
        }
        
        // Button commands
        public ICommand AddNameCommand { get { return new RelayCommand(param => AddName(), param => CanAddName()); } }
        public ICommand DeleteNameCommand { get { return new RelayCommand(param => DeleteName(), param => CanDeleteName()); } }
        public ICommand ReplaceNameCommand { get { return new RelayCommand(param => ReplaceName(), param => CanReplaceName()); } }

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
        }

        private bool CanReplaceName()
        {
            return SelectedPerson != null && !string.IsNullOrEmpty(CurrentName);
        }
    }
}
