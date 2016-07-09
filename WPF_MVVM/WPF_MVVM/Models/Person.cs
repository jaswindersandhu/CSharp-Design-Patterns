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
