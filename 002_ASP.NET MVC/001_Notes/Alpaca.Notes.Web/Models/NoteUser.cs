namespace Alpaca.Notes.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoteUser")]
    public partial class NoteUser
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UserID { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserRole { get; set; }

        [Column(Order = 2)]
        public DateTime RecDateTime { get; set; }

        [Column(Order = 3)]
        public DateTime UpdateDateTime { get; set; }
    }
}
