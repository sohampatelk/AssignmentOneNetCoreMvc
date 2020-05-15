using System;
using System.ComponentModel.DataAnnotations;

namespace AssignmentOneNetCoreMvc.Models
{
    public class CarDetail
    {
        public Guid Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        public bool IsNew { get; set; }
    }
}