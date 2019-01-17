namespace Homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int Id { get; set; }

        [Column("Account")]
        [Required]
        [StringLength(50)]
        public string Account1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
