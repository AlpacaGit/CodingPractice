using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace Alpaca.Notes.Web.Models
{


    [Table("UserCertificationInfo")]
    public class UserCertificationInfo
    {
        [Key]
        [Column(Order = 0)]
        [DisplayName("ユーザID")]
        public string UserID { get; set; }

        /// <summary>
        /// ソルト値
        /// </summary>
        public string SoltValue { get; set; }

        /// <summary>
        /// ハッシュ値
        /// </summary>
        public string HashValue { get; set; }

    }
}