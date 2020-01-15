using System;

namespace Flight_CDC
{
    public class City
    {
        private sealed String name;
        private sealed double latitude;
        private sealed double longitude;

        private City()
        {
            name = "";
            latitude = 0.0;
            longitude = 0.0;
        }

        public City(String name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;

        }

        public String getName()
        {
            return name;
        }

        public double getLatitude()
        {
            return latitude;
        }

        public double getLongitude()
        {
            return longitude;
        }

        public String toString()
        {
            return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
        }
    }//class
}
