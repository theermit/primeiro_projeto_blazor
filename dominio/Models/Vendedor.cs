using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dominio.Models
{
    public class Vendedor 
    {
        public Vendedor ()
        {
            this.Id = 0;
            this.Email = "";
            this.Nome = "";
            this.RegiaoId = 0;
            this.Regiao = new Regiao();
        }
        public Vendedor (int Id, string Email, string Nome, int RegiaoId)
        {
            this.Id = Id;
            this.Email = Email;
            this.Nome = Nome;
            this.RegiaoId = RegiaoId;
            this.Regiao = new Regiao();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informar o Email")]
        [EmailAddress(ErrorMessage = "O campo Email não é um endereço de e-mail válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Favor informar o Nome")]
        [MinLength(4, ErrorMessage ="O Nome precisa possuir mais de 3 caracteres")]
        [MaxLength(50, ErrorMessage = "O Nome precisa possuir menos de 51 caracteres")]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Favor informar a Região")]
        public int RegiaoId { get; set; }
        public Regiao Regiao {get;set;}
    }
}