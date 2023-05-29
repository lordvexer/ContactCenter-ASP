using System.ComponentModel.DataAnnotations.Schema;

namespace ContactCenter.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string? PersonName { get; set; }
        public string? PositionName { get; set; }
        public string? PostOrg { get; set; }
        public string? Phone1 { get; set; }
        public int? Phone2 { get; set; }
        public string? Address { get; set; }
    }
}
