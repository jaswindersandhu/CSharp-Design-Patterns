namespace HeadFirstDesignPatterns.WeatherStation.Interfaces {
    interface Subject {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }
}
