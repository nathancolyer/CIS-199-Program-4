// Program 4
// CIS 199-01
// Due: 4/25/17
// A1212

// File: GroundPackage.cs
// This file creates a GroundPackage class that can track the origin zip, destination zip, height, weight, length, and width of package
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class GroundPackage //class
    {
        //const
        public const int DEFAULT_ORIGZIP = 40202; // origin zip default
        public const int DEFAULT_DESTZIP = 90210; // destination zip default
        public const double DEFAULT_MEASUREMENT = 1.0; // default height, weight, length, width

        //backing fields
        private int _origZip; // origin zip of package
        private int _destZip; // destination zip of package
        private double _height; // height of package
        private double _width; // width of package
        private double _length; // length of package
        private double _weight; // weight of package

        // Precondtion: zip codes must be between 00000 && 99999, measurements must be greater than 0
        //Postcondition: The package has been intialized with values
        public GroundPackage(int origZip, int destZip, double height, double width, double length, double weight)
        {
            //use properties to set in case invalid data sent
            OrigZip = origZip;
            DestZip = destZip;
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
        }

        public int OrigZip
        {
            //Pre: none
            //Post: orig zip has been return
            get
            {
                return _origZip;
            }
            // pre: 00000<= value <= 99999
            //post: orig zip set to specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                    _origZip = value;
                else
                    _origZip = DEFAULT_ORIGZIP;
            }
        }

        public int DestZip
        {
            //Pre: none
            //Post: dest zip has been return
            get
            {
                return _destZip;
            }
            //Pre: 00000<= value <= 99999
            //Post: dest zip set to value
            set
            {
                if (value >= 00000 && value <= 99999)
                    _destZip = value;
                else
                    _destZip = DEFAULT_DESTZIP;
            }
        }

        public double Length
        {
            //pre: none
            //Post: length has been return
            get
            {
                return _length;
            }
            //Pre: value must not be greater than 0.
            //Post:length has been set to value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = DEFAULT_MEASUREMENT;
            }
        }

        public double Width
        {
            //pre: none
            //Post: width has been return
            get
            {
                return _width;
            }
            //Pre: value must not be greater than 0.
            //Post:width has been set to value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = DEFAULT_MEASUREMENT;
            }
        }

        public double Height
        {
            //pre: none
            //Post: height has been return
            get
            {
                return _height;
            }
            //Pre: value must not be greater than 0.
            //Post:Height has been set to value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = DEFAULT_MEASUREMENT;
            }
        }

        public double Weight
        {
            //pre: none
            //Post: weight has been return
            get
            {
                return _weight;
            }
            //Pre: value must not be greater than 0.
            //Post:Weight has been set to value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = DEFAULT_MEASUREMENT;               
            }
        }

        public int ZoneDistance // calculates the distance between two zips
        {
            //Pre: orig and dest zip must be valid
            //Post: return positive number
            get
            {
                return Math.Abs(OrigZip / 10000 - DestZip / 10000);
            }
        }
        //Calculates the cost to ship package
        // Post: returns cost
        public double CalcCost()
        {
            double cost;
            double measurementFactor = 0.2;
            double weightFactor = 0.5;

            cost = measurementFactor * (Length + Width + Height) + weightFactor * (ZoneDistance + 1) * (Weight);
            return cost;
        }

        //Pre: none
        // Postcondition: string is return displaying all values of package
        public override string ToString()
        {
            return "Original Zip: " + OrigZip.ToString("D5") + System.Environment.NewLine + "Destination Zip: " + DestZip.ToString("D5") + System.Environment.NewLine + "Height: " + Height.ToString() + System.Environment.NewLine
                + "Length: " + Length.ToString() + System.Environment.NewLine + "Width: " + Width.ToString() + System.Environment.NewLine + "Weight: " + Weight.ToString();
        }
    }
    }
