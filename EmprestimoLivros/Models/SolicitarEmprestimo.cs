namespace EmprestimoLivros.Models
{
    public class SolicitarEmprestimo
    {
        public int Id { get; set; } //representa o (ID) do empréstimo
        public int LivroId { get; set; }
        public string NomeDoLivro { get; set; }
        public string SolicitanteNome { get; set; }
        public DateTime DataSolicitacao { get; set; } = DateTime.Now;
        public bool Aprovado { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public Emprestimo Emprestimo { get; set; } //status
        
    }
}
