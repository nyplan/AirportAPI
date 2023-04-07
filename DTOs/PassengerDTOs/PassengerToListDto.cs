using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AirportAPI.DTOs.PassengerDTOs
{
    public record PassengerToListDto
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
    }
}
