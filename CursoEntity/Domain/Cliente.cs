using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntity.Domain
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Column("Phone")]
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        //public string Email { get; set; }
    }
}

/*
Nova migração:

dotnet ef migrations add AdicionarEmail -p .\CursoEntity\CursoEntity.csproj
dotnet ef database update -p .\CursoEntity\CursoEntity.csproj

Rollback migração:

dotnet ef database update PrimeiraMigracao -p .\CursoEntity\CursoEntity.csproj -v

Remover ultima migração

dotnet ef migrations remove -p .\CursoEntity\CursoEntity.csproj
 */