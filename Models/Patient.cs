// Models/Patient.cs
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models 
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string ContactNumber { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public string Symptoms { get; set; } = string.Empty;

        public string Tests { get; set; } = string.Empty;
    }
}
