using System.ComponentModel.DataAnnotations;

namespace SammysAuto.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}