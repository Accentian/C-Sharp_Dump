using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructExamples
{
    struct Dog
    {
        public string breed;
        public string hair_type;
        public int avg_age;
    } // End struct

    public partial class frmStructExamples : Form
    {
        // Create list
        private List<Dog> dogList = new List<Dog>();

        public frmStructExamples()
        {
            InitializeComponent();
        }

        // Get data from struct method
        private void GetDogData(ref Dog dog)
        {
            try
            {
                // Get data from textboxes
                dog.breed = txtBreed.Text;
                dog.hair_type = txtHairType.Text;
                dog.avg_age = int.Parse(txtAge.Text);
            } // End try

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            } // End catch


        } // End GetDogData

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create instance
            Dog d = new Dog();

            // Call method to get data from screen
            GetDogData(ref d);

            // Add to my list object
            dogList.Add(d);

            // Clear boxes
            txtBreed.Clear();
            txtHairType.Clear();
            txtAge.Clear();
        } // End btnAdd

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str;
            foreach (Dog d in dogList)
            {
                str = d.breed + " " + d.hair_type + " " + d.avg_age;
                lstDog.Items.Add(str);
            } // End foreach

        } // End btnDisplay


    } // End class
} // End namespace
