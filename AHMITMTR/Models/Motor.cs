using System.ComponentModel.DataAnnotations;

namespace AHMITMTR.Models
{
    public class Motor
    {
        // Primary Key
        [Key] 
        public int NID { get; set; }

        // Nama Motor
        [Required(ErrorMessage = "Nama Motor wajib diisi")] 
        public string VNAMAMOTOR { get; set; } = string.Empty;

        public string VJENIS { get; set; } = string.Empty;
    }
}