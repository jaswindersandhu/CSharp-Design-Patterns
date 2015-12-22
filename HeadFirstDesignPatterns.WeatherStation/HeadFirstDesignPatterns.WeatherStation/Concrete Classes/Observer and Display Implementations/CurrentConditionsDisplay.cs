using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class CurrentConditionsDisplay : Observer, DisplayElement {
        private Subject weatherData;
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(Subject weatherData) {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(Subject subject) {
            if (subject is WeatherData) {
                WeatherData weatherData = (WeatherData)subject;
                temperature = weatherData.Temperature;
                humidity = weatherData.Humidity;
                Display();
            }
        }

        public void Display() {
            Console.WriteLine("Current conditions: " + temperature
                + "F degrees and " + humidity + "% humidity");
        }
    }
}
