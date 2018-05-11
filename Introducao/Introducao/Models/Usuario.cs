using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required (ErrorMessage = "O Campo 'Nome' é de preenchimento obrigatório")]
        public string Nome { get; set; }

        [Range(18,70, ErrorMessage ="A idade deve estar entre 18 e 70 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O Campo 'E-mail' é de preenchimento obrigatório")]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo 'Login' é de preenchimento obrigatório")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "O campo 'Login' deve ser preenchido somente com letras e com minimo de 5 a 15 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Campo 'Senha' é de preenchimento obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O Campo 'Confirma Senha' é de preenchimento obrigatório")]
        [Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        public string ConfirmaSenha { get; set; }

        [Required(ErrorMessage = "O Campo 'Observações' é de preenchimento obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "As infomações devem ter máximo 50 caracteres e minimo de 5 caracteres")]
        public string Observacoes { get; set; }
    }
}