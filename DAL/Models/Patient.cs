using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Patient
    {
        [Key]
        public int UniqueId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int NhsNumber { get; set; }
    }
}
