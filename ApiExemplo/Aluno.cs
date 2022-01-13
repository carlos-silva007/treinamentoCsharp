namespace ApiRest.Entidades
{
    public class Aluno 
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public Aluno() {
            Id = 0;
            Nome = "";
            Telefone = "";
        }
    }
}