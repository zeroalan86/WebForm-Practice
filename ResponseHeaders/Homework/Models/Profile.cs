namespace Homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profile")]
    public partial class Profile
    {
        public int Id { get; set; }

        public int AccountID { get; set; }

        [Required]
        [StringLength(500)]
        public string ProfileContent { get; set; }
    }
}
