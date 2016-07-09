namespace WPF_MVVM.Models
{
    public class Person : ObservableObject
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    // Needed when the Replace button is clicked. Otherwise it changes the Person
                    // Name property in the code, but doesn't reflect in the view's ListBox
                    OnPropertyChanged("Name");
                }
            }
        }

        public Person(string name)
        {
            _name = name;
        }
    }
}
