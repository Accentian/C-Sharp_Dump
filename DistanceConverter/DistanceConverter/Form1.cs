using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double distance = double.Parse(txtEnter.Text);
                double results = 0;

                string convertFrom;
                string convertTo;

                // Both listboxes MUST be selected
                if (lstFrom.SelectedIndex != -1 && lstTo.SelectedIndex != -1)
                {
                    convertFrom = lstFrom.SelectedItem.ToString();
                    convertTo = lstTo.SelectedItem.ToString();

                    // Use switch, nested Switch or Else If statements for calculation?
                    switch (convertFrom)
                    {
                        case "Inches":
                            switch (convertTo)
                            {
                                case "Inches":
                                    results = distance;
                                    break;
                                case "Feet":
                                    results = distance / 12;
                                    break;
                                case "Yards":
                                    results = distance / 36;
                                    break;
                            } // End nested switch
                            break;

                        case "Feet":
                            switch (convertTo)
                            {
                                case "Inches":
                                    results = distance * 12;
                                    break;
                                case "Feet":
                                    results = distance;
                                    break;
                                case "Yards":
                                    results = distance / 3;
                                    break;
                            } // End nested switch
                            break;

                        case "Yards":
                            switch (convertTo)
                            {
                                case "Inches":
                                    results = distance * 36;
                                    break;
                                case "Feet":
                                    results = distance * 3;
                                    break;
                                case "Yards":
                                    results = distance;
                                    break;
                            } // End nested switch
                            break;
                    } // End switch
                } // End if

                else
                {
                    MessageBox.Show("Please select any of the options listed.");
                } // End else

                // Display results
                txtResults.Text = results.ToString();
            } // End try

            catch
            {
                MessageBox.Show("Please enter a number.");
            } // End catch

        } // End btnConvert

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End class
} // End namespace
