using System;

namespace XamarinMessenger.Models
{
    public class Item
    {
        public int id { get; set; }
        public int student_id { get; set; }

        public double gps_lat { get; set; }

        public double gps_long { get; set; }

        public string student_message { get; set; }
    }
}