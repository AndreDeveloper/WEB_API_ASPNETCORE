using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstWebAPI.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public String userName { get; set; }
        public String passWord { get; set; }

        public Usuario()
        {

        }

        public Usuario(String userName, String passWord )
        {
            this.userName = userName;
            this.passWord = passWord;
        }
    }
}