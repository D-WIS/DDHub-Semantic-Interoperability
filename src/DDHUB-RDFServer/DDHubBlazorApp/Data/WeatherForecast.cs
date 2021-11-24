using System;

namespace BlazorApp1.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Bit
    {
        public double TFA { get; set; }


        public void MyMethod()
        {
            Bit bit = new Bit();

            bit.TFA = 3.1459;
        }

    }

}
