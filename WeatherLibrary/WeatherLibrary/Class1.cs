using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class WeatherFunction
    {
        public static double RelativeHumidity(double actVapor, double satVapor)
        {
            return (actVapor / satVapor) * 100;

            // actVapor & satVapor is g/m^3
        }

        public static double VolumnRainfall(double area, double height)
        {
            return area * height;   
            
            //area in m^2 || height in mm || volumn in litre
        }

        public static double MixingRatio(double pressure, double vaporPressure)
        {
            return (0.622 * vaporPressure) / (pressure - vaporPressure);
        }

        public static double knotsToMPH(double knots)   //Wind Speed
        {
            double kConstant = 1.15077944802;
            return knots * kConstant;
        }

        public static double mphToKnots(double mph)     //Wind Speed
        {
            double mConstant = 0.868976241091;
            return mph * mConstant;
        }

        /** Stephans Part
         * --------------------------------------------------**/

        /// <summary>
        /// Converts Celsius to Fahrenheit using the following formula Fahrenheit = (celsius * (9/5)) + 32
        /// </summary>
        /// <param name="celsius">first double</param>
        /// <returns>returns conversion to fahrenheit</returns>
        public static double CelToFahr(double celsius)
        {
            return (celsius * (9 / 5)) + 32;
        }

        /// <summary>
        /// Converts Celsius to Kelvin with the following formula.  kelvin = celsius + 273.15
        /// </summary>      
        /// <param name="celsius">first double</param>
        /// <returns>returns conversion to kelvin</returns>
        public static double CelToKel(double celsius)
        {
            return celsius + 275.15;
        }

        /// <summary>
        /// Converst Fahrenheit to Celsius using the following formula celsius = (fahrenheit - 32) * (5/9)
        /// </summary>
        /// <param name="fahrenheit">first double</param>
        /// <returns>returns conversion to celsius</returns>
        public static double FahrToCel(double fahrenheit)
        {
            return (fahrenheit - 32) * 0.55555556;
        }

        /// <summary>
        /// Converts Fahrenheit to Kelvin using the following formula kelvin = (fahrenheit - 32) * (5/9) + 273.15
        /// </summary>
        /// <param name="fahrenheit">first double</param>
        /// <returns>returns conversion to kelvin</returns>
        public static double FahrToKel(double fahrenheit)
        {

            return (fahrenheit - 32) * 0.55555556 + 273.15;
        }

        /// <summary>
        /// Formula for finding heat index using celsius and relative humidity percent
        /// HI=c1 + (c2 * t) + (c3 * r) + (c4 * t * r) + (c5 * (t*t)) + (c6 * (r*r)) +(c7*(t*t)*r) + (c8*t *(r*r)) + (c9*(t*t)*(r*r);
        /// </summary>
        /// <param name="t">first double</param>
        /// <param name="r">second double</param>
        /// <returns>returns heat index</returns>
        public static double HeatIndex(double t, double r)
        {
            double c1 = -8.78469475556;
            double c2 = 1.61139411;
            double c3 = 2.33854883889;
            double c4 = -0.14611605;
            double c5 = -0.012308094;
            double c6 = -0.0164248277778;
            double c7 = 0.002211732;
            double c8 = 0.00072546;
            double c9 = -0.000003582;
            return c1 + (c2 * t) + (c3 * r) + (c4 * t * r) + (c5 * (t * t)) + (c6 * (r * r)) + (c7 * (t * t) * r) + (c8 * t * (r * r)) + (c9 * (t * t)) * (r * r);
        }

        //T = air Temerature Fahrenheit
        //V = Wind Speed MPH

        //Math.Pow(100.00, 3.00); // 100.00 ^ 3.00

        //formula 35.74 + 0.6215 * T - 35.75(V ^ 0.16) + 0.4275 * T (V ^ 0.16) 

        //double windChill = 35.74 + 0.6215 * T - (35.75 *(Math.POW(V ^ 0.16)) + 0.4275 * T * Math.POW(V , 0.16);

        /// <summary>
        /// Formula to calculate wind chill using 35.74 + 0.6215 * T - 35.75(V ^ 0.16) + 0.4275 * T (V ^ 0.16) 
        /// </summary>
        /// <param name="t">first double</param>
        /// <param name="v">second double</param>
        /// <returns>returns windchill</returns>
        public static double WindChill(double t, double v)
        {
            return 35.74 + 0.6215 * t - (35.75 * (Math.Pow(v, 0.16))) + 0.4275 * t * Math.Pow(v, 0.16);
        }


        /// <summary>
        /// Formula to caculate Virtual Temperature using ((celsius + 273.16) / (1 - 0.378 * (VaporPressure / StationPressure))) - 273.16
        /// </summary>
        /// <param name="c">first double</param>
        /// <param name="vP">second double</param>
        /// <param name="sP">third double</param>
        /// <returns>returns virtual temperature</returns>
        public static double VirtualTemperature(double c, double vP, double sP)
        {
            return ((c + 273.16) / (1 - 0.378 * (vP / sP))) - 273.16;
        }

        /// <summary>
        /// Formula to calculate Dew Point using Tdf= ((((Tf-32)/1.8)-(14.55+0.114*((Tf-32)/1.8))*
        /// (1-(0.01*RH))-((2.5+0.007*((Tf-32)/1.8))*(1-(0.01*RH)))
        /// ^3-(15.9+0.117*((Tf-32)/1.8))*(1-(0.01*RH))^14)*1.8)+32
        /// <param name="t">first double</param>
        /// <param name="r">second double</param>
        /// <returns>returns dewpoint</returns>
        public static double DewPoint(double t, double r)
        {
            double x1 = ((2.5 + 0.007 * ((t - 32) / 1.8)) * (1 - (0.01 * r)));
            double x2 = Math.Pow(x1, 3);
            double y1 = (1 - (0.01 * r));
            double y2 = Math.Pow(y1, 14);
            return ((((t - 32) / 1.8) - (14.55 + 0.114 * ((t - 32) / 1.8)) * (1 - (0.01 * r)) - x2 - (15.9 + 0.117 * ((t - 32) / 1.8)) * y2) * 1.8) + 32;
        }

    } // End class
} // End namespace
