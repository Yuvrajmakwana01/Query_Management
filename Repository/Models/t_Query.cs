using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{

    public class t_Query
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int c_QueryId { get; set; }

        [Required]
        public int c_UserId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string c_Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string c_Description { get; set; }

        [Required]
        public DateOnly c_QueryDate { get; set; }

        public int? c_EmpId { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [RegularExpression("Open|In Progress|Solved", ErrorMessage = "Invalid status")]
        public string c_Status { get; set; }

        [StringLength(500, ErrorMessage = "Comments cannot exceed 500 characters")]
        public string? c_Comment { get; set; }
    }

}