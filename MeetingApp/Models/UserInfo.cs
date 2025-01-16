using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo{

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress]
        public string? Mail { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
    }
}