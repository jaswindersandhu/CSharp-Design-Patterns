using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class CurrentConditionsDisplay : Observer, DisplayElement {
        private Subject weatherData;
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(Subject weatherData) {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display() {
            Console.WriteLine("Current conditions: " + temperature
                + "F degrees and " + humidity + "% humidity");
        }
    }
}
