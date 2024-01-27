using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmprestimoLivros.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(190)
                .IsRequired();

            
            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Perfil)
                .HasColumnName("Perfil");

            builder.Property(x => x.DataCadastro)
                .HasColumnName("DataCadastro");

            builder.Property(x => x.DataAlteracaoUsuario)
                .HasColumnName("DataAlteracaoUsuario");


        }
    }
}
