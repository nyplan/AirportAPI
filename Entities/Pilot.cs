using System.ComponentModel.DataAnnotations;

namespace AirportAPI.Entities
{
    public class Pilot
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
