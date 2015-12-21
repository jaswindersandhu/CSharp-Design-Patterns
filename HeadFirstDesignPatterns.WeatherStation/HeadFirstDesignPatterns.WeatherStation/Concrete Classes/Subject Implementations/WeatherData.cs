using System;
using System.Collections.Generic;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations {
    class WeatherData : Subject {
        public IList<Observer> Observers { get; private set; }
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public WeatherData() {
            Observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o) {
            Observers.Add(o);
        }

        public void RemoveObserver(Observer o) {
            Observers.Remove(o); // Simplified this part compared to the book: Remove() calls RemoveAt() anyway
        }

        public void NotifyObservers() { // Changed this compared to the book for better readability
            foreach (Observer o in Observers) {
                o.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurementsChanged() {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
