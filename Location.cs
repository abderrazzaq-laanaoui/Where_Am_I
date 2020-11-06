using System;
using System.Device.Location;
using System.Windows.Forms;

namespace Where_Am_I
{
    public class Location  
    {
        public double Latitude { get; set; }
        public double Langitude { get; set; }

        public Location()
        {
            this.Langitude = 0;
            this.Latitude = 0;
        }
        public Location(double latitude, double langitude)
        {
            this.Latitude = latitude;
            this.Langitude = langitude;
        }
    }
}
