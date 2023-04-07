using System.ComponentModel.DataAnnotations;

namespace AirportAPI.DTOs.PassengerDTOs
{
    public record PassengerToUpdateDto
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int? Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
