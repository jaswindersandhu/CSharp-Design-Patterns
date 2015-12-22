using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class HeatIndexDisplay : Observer, DisplayElement {
        private Subject subject;
        private float heatIndex = 0.0f;
        
        public HeatIndexDisplay(Subject subject) {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Update(Subject subject) {
            if (subject is WeatherData) {
                WeatherData weatherData = (WeatherData)subject;
                heatIndex = computeHeatIndex(weatherData.Temperature, weatherData.Humidity);
                Display();
            }
        }

        private float computeHeatIndex(float t, float rh) {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public void Display() {
            Console.WriteLine("Heat index is: " + heatIndex);
        }
    }
}
