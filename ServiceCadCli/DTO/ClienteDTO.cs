using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceCadCli.DTO
{
    public class ClienteDTO
    {
        public string Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string SobreNome { get; set; }
        [Required]
        public string Nacionalidade { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]

        public string Cidade { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
    }
}
