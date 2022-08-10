namespace Alpaca.Notes.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    [Table("NoteUser")]
    public partial class NoteUser
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        [DisplayName("ユーザID")]
        public string UserID { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        [DisplayName("ユーザ名")]
        public string UserName { get; set; }

        [StringLength(50)]
        [DisplayName("権限")]
        public string UserRole { get; set; }

        [Column(Order = 2)]
        [DisplayName("登録日時")]
        public DateTime RecDateTime { get; set; }

        [DisplayName("更新日時")]
        [Column(Order = 3)]
        public DateTime UpdateDateTime { get; set; }
    }
}
