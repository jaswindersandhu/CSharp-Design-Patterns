using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class CurrentConditionsDisplay : Observer, DisplayElement {
        private Subject subject;
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(Subject subject) {
            this.subject = subject;  // This assignment is useful in case later I want to remove this Display from the IList that sends out data.
            this.subject.RegisterObserver(this);
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
