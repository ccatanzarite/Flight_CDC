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

            double lat1Radians = Math.Radians(lat1);
        }

        public String printFlightDetails()
        {
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
