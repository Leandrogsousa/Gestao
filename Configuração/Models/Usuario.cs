namespace Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string? Nome { get; set; }
        public string? Username { get; set; }
        public string? Passoword { get; set; }
        public string? Email  { get; set; }
        public string? Cpf { get; set; }
        public bool Ativo { get; set; }

        public List <GrupoUsuario> GrupoUsuarios { get; set; }
        public object NomeGrupo { get; set; }
        public object Descricao { get; set; }
    }
}