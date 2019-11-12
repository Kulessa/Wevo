using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WevoCristianRichardKulessa.Application.WebAPI.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string EMail { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
