namespace HeadFirstDesignPatterns.WeatherStation.Interfaces {
    interface Observer {
        void Update(float temp, float humidity, float pressure);
    }
}
