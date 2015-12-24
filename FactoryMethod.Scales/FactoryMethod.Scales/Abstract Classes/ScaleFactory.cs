namespace FactoryMethod.Scales.Abstract_Classes {
    abstract class ScaleFactory {
        public abstract Scale CreateScale(string key);
    }
}
