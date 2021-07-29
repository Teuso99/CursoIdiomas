namespace CursoIdiomas.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
