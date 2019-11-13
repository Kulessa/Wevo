using System;
using System.ComponentModel.DataAnnotations;

namespace WevoCristianRichardKulessa.Application.WebAPI.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório!")]
        [MinLength(3, ErrorMessage = "Nome aceita no mínimo 3 caracteres")]
        [MaxLength(255, ErrorMessage ="Nome aceita no máximo 255 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório!")]
        [MinLength(11, ErrorMessage = "CPF aceita no mínimo 11 caracteres")]
        [MaxLength(11, ErrorMessage = "CPF aceita no máximo 11 caracteres")]
        [RegularExpression(@"\d{11}", ErrorMessage = "CPF só aceita digitos numéricos")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório!")]
        [EmailAddress(ErrorMessage = "Não é um formato de e-mail válido!")]
        [MaxLength(255, ErrorMessage = "E-mail aceita no máximo 255 caracteres")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Sexo é obrigatório!")]
        [MinLength(1, ErrorMessage = "Sexo aceita no mínimo 1 caracter")]
        [MaxLength(1, ErrorMessage = "Sexo aceita no máximo 1 caracter")]
        [RegularExpression("^M$|^F$|^O$", ErrorMessage = "As opções de Sexo aceitas são M para \"Masculino\",  F para \"Feminino\",  O para \"Outro\"")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Telefone é obrigatório!")]
        [Phone(ErrorMessage = "Não é um formato de telefone válido")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Data de Nascimento é obrigatório!")]
        public DateTime DataNascimento { get; set; }
    }
}
