using SQLite;
using Xamarin.Forms.Maps;

namespace XamarinMessenger.Models
{
    [Table("item")]
    public class Item
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public int student_id { get; set; }

        public double gps_lat { get; set; }

        public double gps_long { get; set; }

        public string student_message { get; set; }

        [Ignore] /* Property used to display a PIN on Map, shall not be stored in DB*/
        public Position student_position { get; set; }

        public void SetStudentPosition() {
            student_position = new Position(gps_lat, gps_long);
        }

        public Position GetStudentPosition()
        {
            return new Position(gps_lat, gps_long);
        }

    }
}