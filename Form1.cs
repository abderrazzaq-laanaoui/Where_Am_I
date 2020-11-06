using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Device.Location;
using System.Windows.Forms;

namespace Where_Am_I
{
    public partial class Form1 : Form
    {

        private bool markers = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMap(new Location());

        }

        private void costumeBtn_Click(object sender, EventArgs e)
        {
            UpdateMap(new Location(ToLatLng(txtLatitude.Text), ToLatLng(txtLangitude.Text)));
        }


        private void LocateBtn_Click(object sender, EventArgs e)
        {

            var location = new Location();
            var watcher = new GeoCoordinateWatcher();

            //watcher.StatusChanged += (s, ev) =>{};

            watcher.PositionChanged += (s, ev) =>
            {
                if (ev.Position.Location.IsUnknown != true)
                {
                    location.Latitude = ev.Position.Location.Latitude;
                    location.Langitude = ev.Position.Location.Longitude;
                    UpdateMap(location);
                    watcher.Stop();
                }

            };

            watcher.MovementThreshold = 100;
            watcher.Start();

        }

        private void UpdateMap(Location location)
        {

            InitializeMap(location);
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

            if (this.markers)
            {
               
                map.Overlays.RemoveAt(0);
            }
            this.markers = true;

            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new PointLatLng(location.Latitude, location.Langitude),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);


        }
        private void InitializeMap(Location location)
        {


            map.ShowCenter = false;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(location.Latitude, location.Langitude);
            map.Zoom = 20;
            map.MinZoom = 2;
            map.MaxZoom = 40;
            map.DragButton = MouseButtons.Left;
        }

        private double ToLatLng(String text)
        {
            if (text.Contains("."))
                text = text.Replace('.', ',');
            return Double.Parse(text);

        }


    }
}
