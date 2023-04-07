using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirportAPI.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int? Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
