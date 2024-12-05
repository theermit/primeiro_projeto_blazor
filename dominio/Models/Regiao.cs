using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dominio.Models
{
    public class Regiao
    {
        public Regiao() 
        {
            this.Id = 0;
            this.Nome = "";
        }
        public Regiao(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
        
        [Key]
        public int Id {get; set;}
        [Required(ErrorMessage = "Favor informar a Região")]
        [MinLength(2, ErrorMessage ="A Região precisa possuir mais de 1 caracteres")]
        [MaxLength(20, ErrorMessage = "A Região precisa possuir menos de 21 caracteres")]
        public string Nome {get;set;} = string.Empty;

    }
}