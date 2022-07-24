using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherTester
{
    public partial class frmWeatherTester : Form
    {
        // Variables
        private VolumnRainfall vf;
        private MixingRatio mr;
        private RelativeHumidity rh;
        private WindSpeed ws;
        private WindChill wc;
        private DewPoint dp;
        private VirtualTemperature vt;
        private HeatIndex hi;
        private TemperatureConversion tc;

        public frmWeatherTester()
        {
            InitializeComponent();
        }

        private void btnVolumnRainfall_Click(object sender, EventArgs e)
        {
            vf = new VolumnRainfall();
            vf.Show();
        } // End Volumn

        private void btnMixingRatio_Click(object sender, EventArgs e)
        {
            mr = new MixingRatio();
            mr.Show();
        } // End MixingRatio

        private void btnHumidity_Click(object sender, EventArgs e)
        {
            rh = new RelativeHumidity();
            rh.Show();
        } // End Humidity

        private void btnWindSpeed_Click(object sender, EventArgs e)
        {
            ws = new WindSpeed();
            ws.Show();
        } // End WindSpeed

        private void btnTemp_Click(object sender, EventArgs e)
        {
            tc = new TemperatureConversion();
            tc.Show();
        } // End Temperature Convert

        private void btnVirtualTemp_Click(object sender, EventArgs e)
        {
            vt = new VirtualTemperature();
            vt.Show();
        } // End Virtual Temperature

        private void btnWindChill_Click(object sender, EventArgs e)
        {
            wc = new WindChill();
            wc.Show();
        } // End Wind Chill

        private void btnDew_Click(object sender, EventArgs e)
        {
            dp = new DewPoint();
            dp.Show();
        } // End Dew Point

        private void btnHeatIndex_Click(object sender, EventArgs e)
        {
            hi = new HeatIndex();
            hi.Show();
        } // End Heat Index
    } // End class
} // End namespace
