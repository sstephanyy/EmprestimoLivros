using EmprestimoLivros.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário!!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuário!!")]
        public string Login { get; set;}
        [Required(ErrorMessage = "Digite o email do usuário!!")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Slecione o perfil do usuário!!")]
        public PerfilEnum Perfil { get; set;}
        [Required(ErrorMessage = "Digite a senha do usuário!!")]
        public string Senha { get; set;}
        public DateTime DataCadastro { get; set;}
        public DateTime? DataAlteracaoUsuario { get; set;}
    }
}
