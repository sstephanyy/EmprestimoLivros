using EmprestimoLivros.Models;

namespace EmprestimoLivros.Repositorio
{
    public interface IUsuario
    {
        List<UsuarioModel> BuscarUsuarios();

        UsuarioModel BuscarUsuarioPorId(int id);

        UsuarioModel AdicionarUsuario(UsuarioModel usuario);

        UsuarioModel AtualizarUsuario(UsuarioModel usuario);

        bool ApagarUsuario (int id);
    }
}
