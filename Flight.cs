using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_CDC
{
    public class Flight
    {
        private String airLineName;
        private City originCity;
        private City destinationCity;
        private String flightNumber;

        public Flight()
        {
            airLineName = null;
            originCity = null;
            destinationCity = null;
            flightNumber = null;
        }

        public Flight(String aln, String fn, City o, City d)
        {
            setAirLineName(aln);
            setFlightNumber(fn);
            setOriginCity(o);
            setDestinationCity(d);
        }

        public double calcDistanceToFly()
        {
            double R = 6371000;
            double lat1 = originCity.getLatitude();
            double lat2 = destinationCity.getLatitude();
            double lon1 = originCity.getLongitude();
            double lon2 = destinationCity.getLongitude();

            double lat1Radians = (Math.PI/180)*lat1;
            double lat2Radians = (Math.PI / 180) * lat2;
            double lon1Radians = (Math.PI / 180) * lon1;
            double lon2Radians = (Math.PI / 180) * lon2;

            double deltaLat = (Math.PI/180) * (lat2 - lat1);
            double deltaLon = (Math.PI/180) * (lon2 - lon1);

            double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos(lat1Radians) * Math.Cos(lat2Radians)
            * Math.Pow(Math.Sin(deltaLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = R * c;

            return distance * 0.000621371;
        }

        public String printFlightDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(airLineName + " " + flightNumber + "\n");
            sb.Append(originCity.getName() + " to " + destinationCity.getName() + "\n");
            sb.Append("Distance: " +  this.calcDistanceToFly().ToString("#,###.###") +" miles.\n");

            return sb.ToString();

            //TODO
        }

        public String getAirLineName()
        {
            return airLineName;
        }

        public void setAirLineName(String airLineName)
        {
            this.airLineName = airLineName;
        }

        public String getFlightNumber()
        {
            return flightNumber;
        }

        public void setFlightNumber(String flightNumber)
        {
            this.flightNumber = flightNumber;
        }

        public City getOriginCity()
        {
            return originCity;
        }

        public void setOriginCity(City originCity)
        {
            this.originCity = originCity;
        }

        public City getDestinationCity()
        {
            return destinationCity;
        }

        public void setDestinationCity(City destinationCity)
        {
            this.destinationCity = destinationCity;
        }

        public String toString()
        {
            return "Flight [airLineName=" + airLineName + ", originCity=" + originCity + ", destinationCity="
                    + destinationCity + ", flightNumber=" + flightNumber + "]";
        }
    }
}
