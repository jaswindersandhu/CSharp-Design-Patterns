using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class StatisticsDisplay : Observer, DisplayElement {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData) {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(Subject subject) {
            if (subject is WeatherData) {
                WeatherData weatherData = (WeatherData)subject;
                tempSum += weatherData.Temperature;
                numReadings++;

                if (weatherData.Temperature > maxTemp) {
                    maxTemp = weatherData.Temperature;
                }

                if (weatherData.Temperature < minTemp) {
                    minTemp = weatherData.Temperature;
                }

                Display();
            }
        }

        public void Display() {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp);
        }
    }
}
