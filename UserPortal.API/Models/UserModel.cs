using System.ComponentModel.DataAnnotations;

namespace UserPortal.API.Models
{
    public class UserMaster
    {
        [Key]
        public int UserId { get; set; }
        public string PCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }

}
