using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class ForecastDisplay : Observer, DisplayElement {
        private Subject weatherData; // In the Head First code offered on the website, the declared type is WeatherData..that's bad!
        private float currentPressure = 29.2f;
        private float lastPressure;

        public ForecastDisplay(Subject weatherData) {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(Subject subject) {
            if (subject is WeatherData) {
                WeatherData weatherData = (WeatherData)subject;
                lastPressure = currentPressure;
                currentPressure = weatherData.Pressure;
                Display();
            }
        }

        public void Display() {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure) {
                Console.WriteLine("Improving weather on the way!");
            } else if (currentPressure == lastPressure) {
                Console.WriteLine("More of the same");
            } else {
                Console.WriteLine("Watch out for cooler, rainy weather!");
            }
        }
    }
}
