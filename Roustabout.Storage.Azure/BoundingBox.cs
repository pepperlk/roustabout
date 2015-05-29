﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Storage.Azure
{
    class BoundingBox
    {
        public class MapPoint
        {
            public double Longitude { get; set; } // In Degrees
            public double Latitude { get; set; } // In Degrees
        }

        public class BoundingBoxInfo
        {
            public MapPoint MinPoint { get; set; }
            public MapPoint MaxPoint { get; set; }

            public override string ToString()
            {

                //if (MinPoint.Latitude < MaxPoint.Latitude && MinPoint.Longitude < MaxPoint.Latitude)
                //{
                //    return string.Format("((PartitionKey gt '{0}') and (PartitionKey lt '{1}')) and ((RowKey gt '{2}') and ( RowKey lt '{3}'))", MinPoint.Latitude.ToString().Replace('-', 'N'), MaxPoint.Latitude.ToString().Replace('-', 'N'), MinPoint.Longitude, MaxPoint.Longitude.ToString().Replace('-', 'N'));
                //}
                //else if (MinPoint.Latitude > MaxPoint.Latitude && MinPoint.Longitude < MaxPoint.Latitude)
                //{
                //    return string.Format("((PartitionKey lt '{0}') and (PartitionKey gt '{1}')) and ((RowKey gt '{2}') and ( RowKey lt '{3}'))", MinPoint.Latitude.ToString().Replace('-', 'N'), MaxPoint.Latitude.ToString().Replace('-', 'N'), MinPoint.Longitude, MaxPoint.Longitude.ToString().Replace('-', 'N'));
                //}
                //else if (MinPoint.Latitude < MaxPoint.Latitude && MinPoint.Longitude > MaxPoint.Latitude)
                //{
                //    return string.Format("((PartitionKey gt '{0}') and (PartitionKey lt '{1}')) and ((RowKey lt '{2}') and ( RowKey gt '{3}'))", 
                //        MinPoint.Latitude.ToString().Replace('-', 'N'), MaxPoint.Latitude.ToString().Replace('-', 'N'), MinPoint.Longitude, MaxPoint.Longitude.ToString().Replace('-', 'N'));
                //}
                //else if (MinPoint.Latitude > MaxPoint.Latitude && MinPoint.Longitude > MaxPoint.Latitude)
                //{
                //    return string.Format("((PartitionKey lt '{0}') and (PartitionKey gt '{1}')) and ((RowKey lt '{2}') and ( RowKey gt '{3}'))", 
                //        MinPoint.Latitude.ToString().Replace('-', 'N'), MaxPoint.Latitude.ToString().Replace('-', 'N'), MinPoint.Longitude, MaxPoint.Longitude.ToString().Replace('-', 'N'));
                //}
                //else
                //{

                if(MinPoint.Latitude.ToString().Replace('-', 'N').CompareTo( MaxPoint.Latitude.ToString().Replace('-', 'N')) > 0)
                {
                    var maxlat = MinPoint.Latitude;
                    MinPoint.Latitude = MaxPoint.Latitude;
                    MaxPoint.Latitude = maxlat;
                }


                if (MinPoint.Longitude.ToString().Replace('-', 'N').CompareTo(MaxPoint.Longitude.ToString().Replace('-', 'N')) > 0)
                {
                    var maxlng = MinPoint.Longitude;
                    MinPoint.Longitude = MaxPoint.Longitude;
                    MaxPoint.Longitude = maxlng;
                }



                return string.Format("((PartitionKey gt '{0}') and (PartitionKey lt '{1}') and (RowKey gt '{2}') and ( RowKey lt '{3}'))", 
                        MinPoint.Latitude.ToString().Replace('-', 'N'), 
                        MaxPoint.Latitude.ToString().Replace('-', 'N'), 
                        MinPoint.Longitude.ToString().Replace('-', 'N'), 
                        MaxPoint.Longitude.ToString().Replace('-', 'N'));
                //}
            }

        }

        // Semi-axes of WGS-84 geoidal reference
        private const double WGS84_a = 6378137.0; // Major semiaxis [m]
        private const double WGS84_b = 6356752.3; // Minor semiaxis [m]

        // 'halfSideInKm' is the half length of the bounding box you want in kilometers.
        public static BoundingBoxInfo GetBoundingBox(MapPoint point, double distance )
        {


            var halfSideInKm = (distance * 1.60934) / 2.0;

            // Bounding box surrounding the point at given coordinates,
            // assuming local approximation of Earth surface as a sphere
            // of radius given by WGS84
            var lat = Deg2rad(point.Latitude);
            var lon = Deg2rad(point.Longitude);
            var halfSide = 1000 * halfSideInKm;

            // Radius of Earth at given latitude
            var radius = WGS84EarthRadius(lat);
            // Radius of the parallel at given latitude
            var pradius = radius * Math.Cos(lat);

            var latMin = lat - halfSide / radius;
            var latMax = lat + halfSide / radius;
            var lonMin = lon - halfSide / pradius;
            var lonMax = lon + halfSide / pradius;

            return new BoundingBoxInfo
            {
                MinPoint = new MapPoint { Latitude = Rad2deg(latMin), Longitude = Rad2deg(lonMin) },
                MaxPoint = new MapPoint { Latitude = Rad2deg(latMax), Longitude = Rad2deg(lonMax) }
            };
        }

        // degrees to radians
        private static double Deg2rad(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }

        // radians to degrees
        private static double Rad2deg(double radians)
        {
            return 180.0 * radians / Math.PI;
        }

        // Earth radius at a given latitude, according to the WGS-84 ellipsoid [m]
        private static double WGS84EarthRadius(double lat)
        {
            // http://en.wikipedia.org/wiki/Earth_radius
            var An = WGS84_a * WGS84_a * Math.Cos(lat);
            var Bn = WGS84_b * WGS84_b * Math.Sin(lat);
            var Ad = WGS84_a * Math.Cos(lat);
            var Bd = WGS84_b * Math.Sin(lat);
            return Math.Sqrt((An * An + Bn * Bn) / (Ad * Ad + Bd * Bd));
        }
    }
}
