using EmprestimoLivros.Models;

namespace EmprestimoLivros.Repositorio
{
    public interface IUsuario
    {
        List<Usuario> BuscarUsuarios();

        Usuario BuscarUsuarioPorId(string id);

        Usuario AdicionarUsuario(Usuario usuario);

        Usuario AtualizarUsuario(Usuario usuario);

        bool ApagarUsuario (string id);
    }
}
