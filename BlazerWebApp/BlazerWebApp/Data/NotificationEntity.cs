using System.ComponentModel.DataAnnotations;

namespace BlazerWebApp.Data
{
    public class NotificationEntity
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public bool Newsletter { get; set; }
        public bool Theme { get; set; }
    }
}
