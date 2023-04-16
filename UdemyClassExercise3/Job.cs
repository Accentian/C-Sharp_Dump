using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyClassExercise3
{
    internal class Job
    {
        private string jobDesc;
        private double timeToComplete;
        private double hourlyRate;
        private double totalFee;

        // Let's use a constructor this time
        public Job(string jobDesc, double timeToComplete, double hourlyRate)
        {
            JobDesc = jobDesc;
            TimeToComplete = timeToComplete;
            HourlyRate = hourlyRate;
        }

        public string JobDesc 
        { 
            get { return jobDesc; }
            set { jobDesc = value; }
        }

        public double TimeToComplete
        {
            get { return timeToComplete; }
            set { timeToComplete = value; }
        }
        public double HourlyRate
        {
            get { return hourlyRate; }
            set 
            { 
                hourlyRate = value; 
                CalcTotalFee();
            }
        }

        // READ ONLY
        public double TotalFee
        {
            get { return totalFee; }
        }

        public static Job operator +(Job j1, Job j2)
        {
            string newDesc = j1.JobDesc + " and " + j2.JobDesc;
            double newTotalHours = j1.TimeToComplete + j2.TimeToComplete;
            double newHourlyRate = (j1.HourlyRate + j2.HourlyRate) / 2;

            Job addedJob = new Job(newDesc, newTotalHours, newHourlyRate);
            return addedJob;
        }

        private void CalcTotalFee()
        {
            totalFee = hourlyRate * timeToComplete;
        }
    }
}
