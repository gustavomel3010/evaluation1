using System;
using System.ComponentModel.DataAnnotations;

namespace evaluation.Models
{
    public enum Gender
    {
        male,
        female
    }

    public class evaluation

    {
        [key]
        public int scoreID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public Gender Sex { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
    }
}