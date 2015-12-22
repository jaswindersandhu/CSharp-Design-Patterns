using System;
using ObserverPattern.WeatherStation.Interfaces;
using ObserverPattern.WeatherStation.Concrete_Classes.Subject_Implementations;

namespace ObserverPattern.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class StatisticsDisplay : Observer, DisplayElement {
        private Subject subject;
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        
        public StatisticsDisplay(Subject subject) {
            this.subject = subject;
            this.subject.RegisterObserver(this);
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
