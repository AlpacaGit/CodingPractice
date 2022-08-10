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
        [DisplayName("���[�UID")]
        public string UserID { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        [DisplayName("���[�U��")]
        public string UserName { get; set; }

        [StringLength(50)]
        [DisplayName("����")]
        public string UserRole { get; set; }

        [Column(Order = 2)]
        [DisplayName("�o�^����")]
        public DateTime RecDateTime { get; set; }

        [DisplayName("�X�V����")]
        [Column(Order = 3)]
        public DateTime UpdateDateTime { get; set; }
    }
}
