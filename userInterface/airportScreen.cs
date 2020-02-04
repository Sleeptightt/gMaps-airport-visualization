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
    public partial class airportScreen : Form
    {
        private DataManager manager;
        private List<DataGridViewRow> allRows;

        public airportScreen()
        {
            InitializeComponent();
            allRows = new List<DataGridViewRow>();
            manager = new DataManager();
            
            dataView.DataSource = new DataTable();
            createGridView();
            
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (arrivingOrDepartingFlights.SelectedIndex > -1)
            {
                if (arrivingOrDepartingFlights.Text == "Departing flights")
                {
                    this.dataView.DataSource = null;
                    this.dataView.Rows.Clear();
                    allRows.Clear();
                    List<Flight> flights = manager.getDepartingAirportFlights((String)item.Tag);
                    for (int i = 0; i < flights.Count; i++)
                    {
                        Flight f = flights[i];
                        dataView.Rows.Add(f.AirLineID, f.Origin, f.Destination, f.DepartureTime, f.ArriveTime, f.Date, f.Distance, f.FlightTime, f.IsLate ? "Delayed" : "On time");
                        allRows.Add(dataView.Rows[i]);
                    }
                    if (flights.Count > 0)
                    {
                        filterTextBox.Visible = true;
                        filterComboBox.Visible = true;
                        filterButton.Visible = true;
                    }
                }
                else {
                    this.dataView.DataSource = null;
                    this.dataView.Rows.Clear();
                    allRows.Clear();
                    List<Flight> flights = manager.getArrivingAirportFlights((String)item.Tag);
                    for (int i = 0; i < flights.Count; i++)
                    {
                        Flight f = flights[i];
                        dataView.Rows.Add(f.AirLineID, f.Origin, f.Destination, f.DepartureTime, f.ArriveTime, f.Date, f.Distance, f.FlightTime, f.IsLate ? "Delayed" : "On time");
                        allRows.Add(dataView.Rows[i]);
                    }
                    if (flights.Count > 0)
                    {
                        filterTextBox.Visible = true;
                        filterComboBox.Visible = true;
                        filterButton.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a display option");
            }
        }

        private void gMap1_Load(object sender, EventArgs e)
        {
            gMap1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMap1.ShowCenter = false;
            gMap1.DragButton = MouseButtons.Left;
            gMap1.OnMarkerClick += gmap_OnMarkerClick;
            ISet<string> set =  manager.readInfo();

            GMapOverlay markers = new GMapOverlay("markers");
            foreach (string f in set)
            {
                GeoCoderStatusCode statusCode;
                PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);
                if (pointLatLng1 != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot); marker00.Tag = f;
                    marker00.ToolTipText = f; marker00.ToolTip.Fill = Brushes.Black; marker00.ToolTip.Foreground = Brushes.White;
                    marker00.ToolTip.Stroke = Pens.Black; marker00.ToolTip.TextPadding = new Size(10, 10); marker00.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    markers.Markers.Add(marker00);
                    
                }
            }

            gMap1.Overlays.Add(markers);

        }

        private void createGridView() 
        {
            DataGridViewTextBoxColumn IDCell = new DataGridViewTextBoxColumn();
            IDCell.HeaderText = "AirLine ID";
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
            departureCell.HeaderText = "Departure time";
            departureCell.Width = 75;
            departureCell.ReadOnly = true;

            DataGridViewTextBoxColumn arriveCell = new DataGridViewTextBoxColumn();
            arriveCell.HeaderText = "Arrival time";
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
            isLateCell.HeaderText = "Delayed";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((filterComboBox.SelectedIndex > -1 && !string.IsNullOrEmpty(filterTextBox.Text))||(filterComboBox.SelectedIndex > -1 && filterComboBox.Text == "None"))
            {
                if (filterComboBox.Text == "None")
                {
                    this.dataView.DataSource = null;
                    this.dataView.Rows.Clear();
                    for (int i = 0; i < allRows.Count; i++)
                    {
                        dataView.Rows.Add(allRows[i]);
                    }
                }
                else if (filterComboBox.Text == "Airline ID") {
                    String s = filterTextBox.Text;
                    List<DataGridViewRow> good = new List<DataGridViewRow>();
                    for (int i = 0; i < dataView.Rows.Count; i++)
                    {
                        if ((string)(dataView.Rows[i].Cells[0].Value) == s)
                            good.Add(dataView.Rows[i]);
                    }
                    if (good.Count > 0)
                    {
                        this.dataView.DataSource = null;
                        this.dataView.Rows.Clear();
                        for (int i = 0; i < good.Count; i++)
                        {
                            dataView.Rows.Add(good[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The specified item couldn't be found, please make sure you're filling the information correctly");
                    }
                }
                else if (filterComboBox.Text == "Delay")
                {
                    String s = filterTextBox.Text.ToLower();
                    if (s != "on time" && s != "delayed")
                    {
                        MessageBox.Show("The only valid options are On time or Delayed");
                    }
                    else
                    {
                        List<DataGridViewRow> good = new List<DataGridViewRow>();
                        for (int i = 0; i < dataView.Rows.Count; i++)
                        {
                            if ((string)(dataView.Rows[i].Cells[8].Value) == s)
                                good.Add(dataView.Rows[i]);
                        }
                        if (good.Count > 0)
                        {
                            this.dataView.DataSource = null;
                            this.dataView.Rows.Clear();
                            for (int i = 0; i < good.Count; i++)
                            {
                                dataView.Rows.Add(good[i]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no flight that is currently " + (s=="on time"?"On time":"Delayed"));
                        }
                    }
                }
                else
                {
                    String s = filterTextBox.Text;
                    List<DataGridViewRow> good = new List<DataGridViewRow>();
                    for (int i = 0; i < dataView.Rows.Count; i++)
                    {
                        if ((string)(dataView.Rows[i].Cells[5].Value) == s)
                            good.Add(dataView.Rows[i]);
                    }
                    if (good.Count > 0)
                    {
                        this.dataView.DataSource = null;
                        this.dataView.Rows.Clear();
                        for (int i = 0; i < good.Count; i++)
                        {
                            dataView.Rows.Add(good[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The specified item couldn't be found, please make sure you're filling the information correctly.\nThat is, date in the format yyyy-mm--dd");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the required fields");
            }
        }
    }
}
