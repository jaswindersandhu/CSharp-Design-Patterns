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
                    // Needed for when changes to a Person's Name property are made, so
                    // the view can update accordingly, e.g. Replace button click in this VS solution
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
