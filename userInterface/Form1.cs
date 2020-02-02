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

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MessageBox.Show(String.Format("Marker {0} was clicked.", item.Tag));
        }

        private void gMap1_Load(object sender, EventArgs e)
        {
            gMap1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMap1.ShowCenter = false;
            gMap1.DragButton = MouseButtons.Left;
            gMap1.OnMarkerClick += gmap_OnMarkerClick;

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(35.213889, -80.943056), GMarkerGoogleType.blue_dot); marker1.Tag = "CLT";
            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(26.0725, -80.152778), GMarkerGoogleType.blue_dot); marker2.Tag = "FLL";
            GMapMarker marker3 = new GMarkerGoogle(new PointLatLng(26.536111, -81.755278), GMarkerGoogleType.blue_dot); marker3.Tag = "RSW";
            GMapMarker marker4 = new GMarkerGoogle(new PointLatLng(33.434167, -112.011667), GMarkerGoogleType.blue_dot); marker4.Tag = "PHX";
            GMapMarker marker5 = new GMarkerGoogle(new PointLatLng(33.636667, -84.428056), GMarkerGoogleType.blue_dot); marker5.Tag = "ATL";
            GMapMarker marker6 = new GMarkerGoogle(new PointLatLng(42.2125, -83.353333), GMarkerGoogleType.blue_dot); marker6.Tag = "DTW";
            GMapMarker marker7 = new GMarkerGoogle(new PointLatLng(26.6832, -80.0956), GMarkerGoogleType.blue_dot); marker7.Tag = "PBI";
            GMapMarker marker8 = new GMarkerGoogle(new PointLatLng(40.4882, -80.2263), GMarkerGoogleType.blue_dot); marker8.Tag = "PIT";
            GMapMarker marker9 = new GMarkerGoogle(new PointLatLng(39.871944, -75.241111), GMarkerGoogleType.blue_dot); marker9.Tag = "PHL";
            GMapMarker marker10 = new GMarkerGoogle(new PointLatLng(27.975556, -82.533333), GMarkerGoogleType.blue_dot); marker10.Tag = "TPA";
            GMapMarker marker11 = new GMarkerGoogle(new PointLatLng(25.793333, -80.290556), GMarkerGoogleType.blue_dot); marker11.Tag = "MIA";
            GMapMarker marker12 = new GMarkerGoogle(new PointLatLng(33.9425, -118.408056), GMarkerGoogleType.blue_dot); marker12.Tag = "LAX";
            GMapMarker marker13 = new GMarkerGoogle(new PointLatLng(32.847222, -96.851667), GMarkerGoogleType.blue_dot); marker13.Tag = "DAL";
            GMapMarker marker14 = new GMarkerGoogle(new PointLatLng(39.499167, -119.768056), GMarkerGoogleType.blue_dot); marker14.Tag = "RNO";
            GMapMarker marker15 = new GMarkerGoogle(new PointLatLng(36.08, -115.152222), GMarkerGoogleType.blue_dot); marker15.Tag = "LAS";
            GMapMarker marker16 = new GMarkerGoogle(new PointLatLng(39.861667, -104.673056), GMarkerGoogleType.blue_dot); marker16.Tag = "DEN";
            GMapMarker marker17 = new GMarkerGoogle(new PointLatLng(40.788333, -111.977778), GMarkerGoogleType.blue_dot); marker17.Tag = "SLC";
            GMapMarker marker18 = new GMarkerGoogle(new PointLatLng(44.881944, -93.221667), GMarkerGoogleType.blue_dot); marker18.Tag = "MSP";
            GMapMarker marker19 = new GMarkerGoogle(new PointLatLng(38.944444, -77.455833), GMarkerGoogleType.blue_dot); marker19.Tag = "IAD";
            GMapMarker marker20 = new GMarkerGoogle(new PointLatLng(28.429444, -81.308889), GMarkerGoogleType.blue_dot); marker20.Tag = "MCO";
            GMapMarker marker21 = new GMarkerGoogle(new PointLatLng(41.411667, -81.849722), GMarkerGoogleType.blue_dot); marker21.Tag = "CLE";
            GMapMarker marker22 = new GMarkerGoogle(new PointLatLng(43.564444, -116.222778), GMarkerGoogleType.blue_dot); marker22.Tag = "BOI";
            GMapMarker marker23 = new GMarkerGoogle(new PointLatLng(41.978611, -87.904724), GMarkerGoogleType.blue_dot); marker23.Tag = "ORD";
            GMapMarker marker24 = new GMarkerGoogle(new PointLatLng(32.109666228, -110.937996248), GMarkerGoogleType.blue_dot); marker24.Tag = "TUS";
            GMapMarker marker25 = new GMarkerGoogle(new PointLatLng(64.808996764, -147.853829918), GMarkerGoogleType.blue_dot); marker25.Tag = "FAI"; 
            GMapMarker marker26 = new GMarkerGoogle(new PointLatLng(37.6432974268, -97.426498294), GMarkerGoogleType.blue_dot); marker26.Tag = "ICT";
            GMapMarker marker27 = new GMarkerGoogle(new PointLatLng(35.436077, -82.541298), GMarkerGoogleType.blue_dot); marker27.Tag = "AVL";
            GMapMarker marker28 = new GMarkerGoogle(new PointLatLng(39.053276, -84.663017), GMarkerGoogleType.blue_dot); marker28.Tag = "CVG";
            GMapMarker marker29 = new GMarkerGoogle(new PointLatLng(55.35333192, -131.7083305), GMarkerGoogleType.blue_dot); marker29.Tag = "KTN";
            GMapMarker marker30 = new GMarkerGoogle(new PointLatLng(42.7738469046, -84.5850476598), GMarkerGoogleType.blue_dot); marker30.Tag = "LAN";
            GMapMarker marker31 = new GMarkerGoogle(new PointLatLng(35.040031, -89.981873), GMarkerGoogleType.blue_dot); marker31.Tag = "MEM";
            GMapMarker marker32 = new GMarkerGoogle(new PointLatLng(33.656384, -101.821861), GMarkerGoogleType.blue_dot); marker32.Tag = "LBB";
            GMapMarker marker33 = new GMarkerGoogle(new PointLatLng(40.50889, -122.29333), GMarkerGoogleType.blue_dot); marker33.Tag = "RDD";
            GMapMarker marker34 = new GMarkerGoogle(new PointLatLng(43.128002, -77.665474), GMarkerGoogleType.blue_dot); marker34.Tag = "ROC";
            GMapMarker marker35 = new GMarkerGoogle(new PointLatLng(57.0496, -135.361), GMarkerGoogleType.blue_dot); marker35.Tag = "SIT";
            GMapMarker marker36 = new GMarkerGoogle(new PointLatLng(32.731770, -117.197624), GMarkerGoogleType.blue_dot); marker36.Tag = "SAN";
            GMapMarker marker37 = new GMarkerGoogle(new PointLatLng(32.656582000000, -114.605972000000), GMarkerGoogleType.blue_dot); marker37.Tag = "YUM";
            GMapMarker marker38 = new GMarkerGoogle(new PointLatLng(36.131687, -86.668823), GMarkerGoogleType.blue_dot); marker38.Tag = "BNA";
            GMapMarker marker39 = new GMarkerGoogle(new PointLatLng(42.481806000000, -114.487750000000), GMarkerGoogleType.blue_dot); marker39.Tag = "TWF";
            GMapMarker marker40 = new GMarkerGoogle(new PointLatLng(40.652941, -75.436502), GMarkerGoogleType.blue_dot); marker40.Tag = "ABE";
            GMapMarker marker41 = new GMarkerGoogle(new PointLatLng(46.909829694, -114.087666316), GMarkerGoogleType.blue_dot); marker41.Tag = "MSO";
            GMapMarker marker42 = new GMarkerGoogle(new PointLatLng(35.617500, -106.088333), GMarkerGoogleType.blue_dot); marker42.Tag = "SAF";

            marker1.ToolTipText = "Charlotte Douglas \nInternational Airport\nCharlotte, NC"; marker1.ToolTip.Fill = Brushes.Black;  marker1.ToolTip.Foreground = Brushes.White;
            marker1.ToolTip.Stroke = Pens.Black; marker1.ToolTip.TextPadding = new Size(10, 10); marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker2.ToolTipText = "Fort Lauderdale-Hollywood \nInternational Airport\nFort Lauderdale, FL"; marker2.ToolTip.Fill = Brushes.Black; marker2.ToolTip.Foreground = Brushes.White;
            marker2.ToolTip.Stroke = Pens.Black; marker2.ToolTip.TextPadding = new Size(10, 10); marker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker3.ToolTipText = "Southwest Florida \nInternational Airport\nFort Myers, FL"; marker3.ToolTip.Fill = Brushes.Black; marker3.ToolTip.Foreground = Brushes.White;
            marker3.ToolTip.Stroke = Pens.Black; marker3.ToolTip.TextPadding = new Size(10, 10); marker3.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker4.ToolTipText = "Phoenix Sky Harbor \nInternational Airport\nPhoenix, AZ"; marker4.ToolTip.Fill = Brushes.Black; marker4.ToolTip.Foreground = Brushes.White;
            marker4.ToolTip.Stroke = Pens.Black; marker4.ToolTip.TextPadding = new Size(10, 10); marker4.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker5.ToolTipText = "Hartsfield-Jackson Atlanta \nInternational Airport\nAtlanta, GA"; marker5.ToolTip.Fill = Brushes.Black; marker5.ToolTip.Foreground = Brushes.White;
            marker5.ToolTip.Stroke = Pens.Black; marker5.ToolTip.TextPadding = new Size(10, 10); marker5.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker6.ToolTipText = "Detroit Metropolitan Wayne \nCounty Airport\nDetroit, MI"; marker6.ToolTip.Fill = Brushes.Black; marker6.ToolTip.Foreground = Brushes.White;
            marker6.ToolTip.Stroke = Pens.Black; marker6.ToolTip.TextPadding = new Size(10, 10); marker6.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker7.ToolTipText = "Palm Beach \nInternational Airport\nWest Palm Beach, FL"; marker7.ToolTip.Fill = Brushes.Black; marker7.ToolTip.Foreground = Brushes.White;
            marker7.ToolTip.Stroke = Pens.Black; marker7.ToolTip.TextPadding = new Size(10, 10); marker7.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker8.ToolTipText = "Pittsburgh \nInternational Airport\nPittsburgh, PA"; marker8.ToolTip.Fill = Brushes.Black; marker8.ToolTip.Foreground = Brushes.White;
            marker8.ToolTip.Stroke = Pens.Black; marker8.ToolTip.TextPadding = new Size(10, 10); marker8.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker9.ToolTipText = "Philadelphia \nInternational Airport\nPhiladelphia, PA"; marker9.ToolTip.Fill = Brushes.Black; marker9.ToolTip.Foreground = Brushes.White;
            marker9.ToolTip.Stroke = Pens.Black; marker9.ToolTip.TextPadding = new Size(10, 10); marker9.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker10.ToolTipText = "Tampa \nInternational Airport\nTampa, FL"; marker10.ToolTip.Fill = Brushes.Black; marker10.ToolTip.Foreground = Brushes.White;
            marker10.ToolTip.Stroke = Pens.Black; marker10.ToolTip.TextPadding = new Size(10, 10); marker10.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker11.ToolTipText = "Miami \nInternational Airport\nMiami, FL"; marker11.ToolTip.Fill = Brushes.Black; marker11.ToolTip.Foreground = Brushes.White;
            marker11.ToolTip.Stroke = Pens.Black; marker11.ToolTip.TextPadding = new Size(10, 10); marker11.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker12.ToolTipText = "Los Angeles \nInternational Airport\nLos Angeles, CA"; marker12.ToolTip.Fill = Brushes.Black; marker12.ToolTip.Foreground = Brushes.White;
            marker12.ToolTip.Stroke = Pens.Black; marker12.ToolTip.TextPadding = new Size(10, 10); marker12.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker13.ToolTipText = "Dallas Love \nField Airport\nDallas, TX"; marker13.ToolTip.Fill = Brushes.Black; marker13.ToolTip.Foreground = Brushes.White;
            marker13.ToolTip.Stroke = Pens.Black; marker13.ToolTip.TextPadding = new Size(10, 10); marker13.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker14.ToolTipText = "Reno-Tahoe \nInternational Airport\nReno, NV"; marker14.ToolTip.Fill = Brushes.Black; marker14.ToolTip.Foreground = Brushes.White;
            marker14.ToolTip.Stroke = Pens.Black; marker14.ToolTip.TextPadding = new Size(10, 10); marker14.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker15.ToolTipText = "McCarran \nInternational Airport\nLas Vegas, NV"; marker15.ToolTip.Fill = Brushes.Black; marker15.ToolTip.Foreground = Brushes.White;
            marker15.ToolTip.Stroke = Pens.Black; marker15.ToolTip.TextPadding = new Size(10, 10); marker15.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker16.ToolTipText = "Denver \nInternational Airport\nDenver, CO"; marker16.ToolTip.Fill = Brushes.Black; marker16.ToolTip.Foreground = Brushes.White;
            marker16.ToolTip.Stroke = Pens.Black; marker16.ToolTip.TextPadding = new Size(10, 10); marker16.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker17.ToolTipText = "Salt Lake City \nInternational Airport\nSalt Lake City, UT"; marker17.ToolTip.Fill = Brushes.Black; marker17.ToolTip.Foreground = Brushes.White;
            marker17.ToolTip.Stroke = Pens.Black; marker17.ToolTip.TextPadding = new Size(10, 10); marker17.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker18.ToolTipText = "Minneapolis-Saint Paul \nInternational Airport\nMinneapolis, MN"; marker18.ToolTip.Fill = Brushes.Black; marker18.ToolTip.Foreground = Brushes.White;
            marker18.ToolTip.Stroke = Pens.Black; marker18.ToolTip.TextPadding = new Size(10, 10); marker18.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker19.ToolTipText = "Dulles \nInternational Airport\nDulles, VA"; marker19.ToolTip.Fill = Brushes.Black; marker19.ToolTip.Foreground = Brushes.White;
            marker19.ToolTip.Stroke = Pens.Black; marker19.ToolTip.TextPadding = new Size(10, 10); marker19.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker20.ToolTipText = "Orlando \nInternational Airport\nOrlando, FL"; marker20.ToolTip.Fill = Brushes.Black; marker20.ToolTip.Foreground = Brushes.White;
            marker20.ToolTip.Stroke = Pens.Black; marker20.ToolTip.TextPadding = new Size(10, 10); marker20.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker21.ToolTipText = "Cleveland Hopkins \nInternational Airport\nCleveland, OH"; marker21.ToolTip.Fill = Brushes.Black; marker21.ToolTip.Foreground = Brushes.White;
            marker21.ToolTip.Stroke = Pens.Black; marker21.ToolTip.TextPadding = new Size(10, 10); marker21.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker22.ToolTipText = "Boise \nAirport\nBoise, ID"; marker22.ToolTip.Fill = Brushes.Black; marker22.ToolTip.Foreground = Brushes.White;
            marker22.ToolTip.Stroke = Pens.Black; marker22.ToolTip.TextPadding = new Size(10, 10); marker22.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker23.ToolTipText = "O'Hare \nInternational Airport\nChicago, IL"; marker23.ToolTip.Fill = Brushes.Black; marker23.ToolTip.Foreground = Brushes.White;
            marker23.ToolTip.Stroke = Pens.Black; marker23.ToolTip.TextPadding = new Size(10, 10); marker23.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker24.ToolTipText = "Tucson \nInternational Airport\nTucson, AZ"; marker24.ToolTip.Fill = Brushes.Black; marker24.ToolTip.Foreground = Brushes.White;
            marker24.ToolTip.Stroke = Pens.Black; marker24.ToolTip.TextPadding = new Size(10, 10); marker24.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker25.ToolTipText = "Fairbanks \nInternational Airport\nFairbanks, AK"; marker25.ToolTip.Fill = Brushes.Black; marker25.ToolTip.Foreground = Brushes.White;
            marker25.ToolTip.Stroke = Pens.Black; marker25.ToolTip.TextPadding = new Size(10, 10); marker25.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker26.ToolTipText = "Wichita Dwight D. Eisenhower \nNational Airport\nWichita, KS"; marker26.ToolTip.Fill = Brushes.Black; marker26.ToolTip.Foreground = Brushes.White;
            marker26.ToolTip.Stroke = Pens.Black; marker26.ToolTip.TextPadding = new Size(10, 10); marker26.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker27.ToolTipText = "Asheville \nRegional Airport\nFletcher, NC"; marker27.ToolTip.Fill = Brushes.Black; marker27.ToolTip.Foreground = Brushes.White;
            marker27.ToolTip.Stroke = Pens.Black; marker27.ToolTip.TextPadding = new Size(10, 10); marker27.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker28.ToolTipText = "Cincinnati/Northern Kentucky\nInternational airport\n Hebron, KY"; marker28.ToolTip.Fill = Brushes.Black; marker28.ToolTip.Foreground = Brushes.White;
            marker28.ToolTip.Stroke = Pens.Black; marker28.ToolTip.TextPadding = new Size(10, 10); marker28.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker29.ToolTipText = "Ketchikan \nInternational Airport\nKetchikan, AK"; marker29.ToolTip.Fill = Brushes.Black; marker29.ToolTip.Foreground = Brushes.White;
            marker29.ToolTip.Stroke = Pens.Black; marker29.ToolTip.TextPadding = new Size(10, 10); marker29.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker30.ToolTipText = "Capital Region \nInternational Airport\nClinton County, MI"; marker30.ToolTip.Fill = Brushes.Black; marker30.ToolTip.Foreground = Brushes.White;
            marker30.ToolTip.Stroke = Pens.Black; marker30.ToolTip.TextPadding = new Size(10, 10); marker30.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker31.ToolTipText = "Memphis \nInternational Airport\nMemphis, TN"; marker31.ToolTip.Fill = Brushes.Black; marker31.ToolTip.Foreground = Brushes.White;
            marker31.ToolTip.Stroke = Pens.Black; marker31.ToolTip.TextPadding = new Size(10, 10); marker31.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker32.ToolTipText = "Lubbock Preston Smith \nInternational Airport\nLubbock, TX"; marker32.ToolTip.Fill = Brushes.Black; marker32.ToolTip.Foreground = Brushes.White;
            marker32.ToolTip.Stroke = Pens.Black; marker32.ToolTip.TextPadding = new Size(10, 10); marker32.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker33.ToolTipText = "Redding Municipal \nAirport\nRedding, CA"; marker33.ToolTip.Fill = Brushes.Black; marker33.ToolTip.Foreground = Brushes.White;
            marker33.ToolTip.Stroke = Pens.Black; marker33.ToolTip.TextPadding = new Size(10, 10); marker33.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker34.ToolTipText = "Greater Rochester \nInternational Airport\nRochester, NY"; marker34.ToolTip.Fill = Brushes.Black; marker34.ToolTip.Foreground = Brushes.White;
            marker34.ToolTip.Stroke = Pens.Black; marker34.ToolTip.TextPadding = new Size(10, 10); marker34.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker35.ToolTipText = "Sitka Rocky Gutierrez \nAirport\nSitka, AK"; marker35.ToolTip.Fill = Brushes.Black; marker35.ToolTip.Foreground = Brushes.White;
            marker35.ToolTip.Stroke = Pens.Black; marker35.ToolTip.TextPadding = new Size(10, 10); marker35.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker36.ToolTipText = "San Diego \nInternational Airport\nSan Diego, CA"; marker36.ToolTip.Fill = Brushes.Black; marker36.ToolTip.Foreground = Brushes.White;
            marker36.ToolTip.Stroke = Pens.Black; marker36.ToolTip.TextPadding = new Size(10, 10); marker36.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker37.ToolTipText = "Yuma \nInternational Airport\nYuma, AZ"; marker37.ToolTip.Fill = Brushes.Black; marker37.ToolTip.Foreground = Brushes.White;
            marker37.ToolTip.Stroke = Pens.Black; marker37.ToolTip.TextPadding = new Size(10, 10); marker37.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker38.ToolTipText = "Nashville \nInternational Airport\nNashville, TN"; marker38.ToolTip.Fill = Brushes.Black; marker38.ToolTip.Foreground = Brushes.White;
            marker38.ToolTip.Stroke = Pens.Black; marker38.ToolTip.TextPadding = new Size(10, 10); marker38.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker39.ToolTipText = "Magic Valley\nRegional Airport\nTwin Falls, ID"; marker39.ToolTip.Fill = Brushes.Black; marker39.ToolTip.Foreground = Brushes.White;
            marker39.ToolTip.Stroke = Pens.Black; marker39.ToolTip.TextPadding = new Size(10, 10); marker39.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker40.ToolTipText = "Lehigh Valley \nInternational Airport\nAllentown, PA"; marker40.ToolTip.Fill = Brushes.Black; marker40.ToolTip.Foreground = Brushes.White;
            marker40.ToolTip.Stroke = Pens.Black; marker40.ToolTip.TextPadding = new Size(10, 10); marker40.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker41.ToolTipText = "Missoula \nInternational Airport\nMissoula, MT"; marker41.ToolTip.Fill = Brushes.Black; marker41.ToolTip.Foreground = Brushes.White;
            marker41.ToolTip.Stroke = Pens.Black; marker41.ToolTip.TextPadding = new Size(10, 10); marker41.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker42.ToolTipText = "Santa Fe \nRegional Airport\nSanta Fe, NM"; marker42.ToolTip.Fill = Brushes.Black; marker42.ToolTip.Foreground = Brushes.White;
            marker42.ToolTip.Stroke = Pens.Black; marker42.ToolTip.TextPadding = new Size(10, 10); marker42.ToolTipMode = MarkerTooltipMode.OnMouseOver;

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
            markers.Markers.Add(marker23);
            markers.Markers.Add(marker24);
            markers.Markers.Add(marker25);
            markers.Markers.Add(marker26);
            markers.Markers.Add(marker27);
            markers.Markers.Add(marker28);
            markers.Markers.Add(marker29);
            markers.Markers.Add(marker30);
            markers.Markers.Add(marker31);
            markers.Markers.Add(marker32);
            markers.Markers.Add(marker33);
            markers.Markers.Add(marker34);
            markers.Markers.Add(marker35);
            markers.Markers.Add(marker36);
            markers.Markers.Add(marker37);
            markers.Markers.Add(marker38);
            markers.Markers.Add(marker39);
            markers.Markers.Add(marker40);
            markers.Markers.Add(marker41);
            markers.Markers.Add(marker42);

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
