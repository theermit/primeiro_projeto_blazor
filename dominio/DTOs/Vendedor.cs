using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dominio.DTOs
{
    public class VendedorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
    }
}