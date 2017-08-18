using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "O campo é Obrigatorio")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //  "Números e caracteres especiais não são permitidos no nome.")]
        public string Name { get; set; }

        public string Descricao { get; set; }

        //[Required]
        //[StringLength(4, ErrorMessage = "O tamanho maximo do codigo é de 4 caracteres")]
        public string Codigo { get; set; }

        //[Range(1, 10, ErrorMessage = "O preço deve ser entre 1 e 10")]
        public decimal Preco { get; set; }

        //[Required(ErrorMessage = "Informe o seu email")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")] //melhor validar email na tela
        public string Email { get; set; }

    }
}