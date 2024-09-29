namespace _07.RawData
{
    public class Tire
    {
        public float Pressure { get; set; }
        public int Age { get; set; }
        public Tire(float pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}