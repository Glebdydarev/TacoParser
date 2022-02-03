using System;

namespace LoggingKata
{
    public struct Point
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public static implicit operator Point(double v)
        {
            throw new NotImplementedException();
        }
    }
}