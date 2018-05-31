using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class LogEntry
    {
        [Key]
        public int UniqueId { get; set; }
        public int UserId { get; set; }
        public string Message {get; set; }
    }
}
