using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AirportAPI.Entities
{
    public class EnumValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int KeyId { get; set; }
        public EnumKey Key { get; set; }
    }
}
