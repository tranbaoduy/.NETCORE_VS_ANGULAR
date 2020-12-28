using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Model.PhanQuyen
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("userId")]
        public int userId { get; set; }

        [Column("userName")]
        [StringLength(200)]
        public string userName { get; set; }

        [Column("passWord")]
        [StringLength(200)]
        public string passWord { get; set; }

        [Column("fullName")]
        [StringLength(200)]
        public string fullName { get; set; }

        [Column("sdt")]
        [StringLength(200)]
        public string sdt { get; set; }
    }
}
