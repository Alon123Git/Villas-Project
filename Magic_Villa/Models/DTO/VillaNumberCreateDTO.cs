using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Magic_Villa.Models.DTO
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNum { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}