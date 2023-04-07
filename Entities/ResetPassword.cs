using System.ComponentModel.DataAnnotations;

namespace AirportAPI.Entities
{
    public class ResetPassword
    {
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
