using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using model;

namespace userInterface
{
    public partial class Form1 : Form
    {
        private DataManager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new DataManager();
            
            manager.readInfo();
            createGridView();
            
        }

        private void gMap1_Load(object sender, EventArgs e)
        {
            gMap1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(35.213889, -80.943056), GMarkerGoogleType.blue_dot);
            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(26.0725, -80.152778), GMarkerGoogleType.blue_dot);
            GMapMarker marker3 = new GMarkerGoogle(new PointLatLng(26.536111, -81.755278), GMarkerGoogleType.blue_dot);
            GMapMarker marker4 = new GMarkerGoogle(new PointLatLng(33.434167, -112.011667), GMarkerGoogleType.blue_dot);
            GMapMarker marker5 = new GMarkerGoogle(new PointLatLng(33.636667, -84.428056), GMarkerGoogleType.blue_dot);
            GMapMarker marker6 = new GMarkerGoogle(new PointLatLng(42.2125, -83.353333), GMarkerGoogleType.blue_dot);
            GMapMarker marker7 = new GMarkerGoogle(new PointLatLng(26.6832, -80.0956), GMarkerGoogleType.blue_dot);
            GMapMarker marker8 = new GMarkerGoogle(new PointLatLng(40.495997, -80.256693), GMarkerGoogleType.blue_dot);
            GMapMarker marker9 = new GMarkerGoogle(new PointLatLng(39.871944, -75.241111), GMarkerGoogleType.blue_dot);
            GMapMarker marker10 = new GMarkerGoogle(new PointLatLng(27.975556, -82.533333), GMarkerGoogleType.blue_dot);
            GMapMarker marker11 = new GMarkerGoogle(new PointLatLng(25.793333, -80.290556), GMarkerGoogleType.blue_dot);
            GMapMarker marker12 = new GMarkerGoogle(new PointLatLng(33.9425, -118.408056), GMarkerGoogleType.blue_dot);
            GMapMarker marker13 = new GMarkerGoogle(new PointLatLng(32.847222, -96.851667), GMarkerGoogleType.blue_dot);
            GMapMarker marker14 = new GMarkerGoogle(new PointLatLng(39.499167, -119.768056), GMarkerGoogleType.blue_dot);
            GMapMarker marker15 = new GMarkerGoogle(new PointLatLng(36.08, -115.152222), GMarkerGoogleType.blue_dot);
            GMapMarker marker16 = new GMarkerGoogle(new PointLatLng(39.861667, -104.673056), GMarkerGoogleType.blue_dot);
            GMapMarker marker17 = new GMarkerGoogle(new PointLatLng(40.788333, -111.977778), GMarkerGoogleType.blue_dot);
            GMapMarker marker18 = new GMarkerGoogle(new PointLatLng(44.881944, -93.221667), GMarkerGoogleType.blue_dot);
            GMapMarker marker19 = new GMarkerGoogle(new PointLatLng(38.944444, -77.455833), GMarkerGoogleType.blue_dot);
            GMapMarker marker20 = new GMarkerGoogle(new PointLatLng(28.429444, -81.308889), GMarkerGoogleType.blue_dot);
            GMapMarker marker21 = new GMarkerGoogle(new PointLatLng(41.411667, -81.849722), GMarkerGoogleType.blue_dot);
            GMapMarker marker22 = new GMarkerGoogle(new PointLatLng(43.564444, -116.222778), GMarkerGoogleType.blue_dot);


            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            markers.Markers.Add(marker3);
            markers.Markers.Add(marker4);
            markers.Markers.Add(marker5);
            markers.Markers.Add(marker6);
            markers.Markers.Add(marker7);
            markers.Markers.Add(marker8);
            markers.Markers.Add(marker9);
            markers.Markers.Add(marker10);
            markers.Markers.Add(marker11);
            markers.Markers.Add(marker12);
            markers.Markers.Add(marker13);
            markers.Markers.Add(marker14);
            markers.Markers.Add(marker15);
            markers.Markers.Add(marker16);
            markers.Markers.Add(marker17);
            markers.Markers.Add(marker18);
            markers.Markers.Add(marker19);
            markers.Markers.Add(marker20);
            markers.Markers.Add(marker21);
            markers.Markers.Add(marker22);

            gMap1.Overlays.Add(markers);
        }

        private void createGridView() 
        {
            DataGridViewTextBoxColumn IDCell = new DataGridViewTextBoxColumn();
            IDCell.HeaderText = "AirLineID";
            IDCell.Width = 75;
            IDCell.ReadOnly = true;

            DataGridViewTextBoxColumn originCell = new DataGridViewTextBoxColumn();
            originCell.HeaderText = "Origin";
            originCell.Width = 75;
            originCell.ReadOnly = true;

            DataGridViewTextBoxColumn destinationCell = new DataGridViewTextBoxColumn();
            destinationCell.HeaderText = "Destination";
            destinationCell.Width = 75;
            destinationCell.ReadOnly = true;

            DataGridViewTextBoxColumn departureCell = new DataGridViewTextBoxColumn();
            departureCell.HeaderText = "Departure";
            departureCell.Width = 75;
            departureCell.ReadOnly = true;

            DataGridViewTextBoxColumn arriveCell = new DataGridViewTextBoxColumn();
            arriveCell.HeaderText = "Arrive";
            arriveCell.Width = 75;
            arriveCell.ReadOnly = true;

            DataGridViewTextBoxColumn dateCell = new DataGridViewTextBoxColumn();
            dateCell.HeaderText = "Date";
            dateCell.Width = 75;
            dateCell.ReadOnly = true;

            DataGridViewTextBoxColumn distanceCell = new DataGridViewTextBoxColumn();
            distanceCell.HeaderText = "Distance";
            distanceCell.Width = 75;
            distanceCell.ReadOnly = true;

            DataGridViewTextBoxColumn timeCell = new DataGridViewTextBoxColumn();
            timeCell.HeaderText = "Duration";
            timeCell.Width = 75;
            timeCell.ReadOnly = true;

            DataGridViewTextBoxColumn isLateCell = new DataGridViewTextBoxColumn();
            isLateCell.HeaderText = "Late";
            isLateCell.Width = 75;
            isLateCell.ReadOnly = true;


            dataView.Columns.Add(IDCell);
            dataView.Columns.Add(originCell);
            dataView.Columns.Add(destinationCell);
            dataView.Columns.Add(departureCell);
            dataView.Columns.Add(arriveCell);
            dataView.Columns.Add(dateCell);
            dataView.Columns.Add(distanceCell);
            dataView.Columns.Add(timeCell);
            dataView.Columns.Add(isLateCell);

        }








        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
