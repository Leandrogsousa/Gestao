namespace Models
{
    public class Usuario
    {
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Passoword { get; set; }
        public string? Email  { get; set; }
        public string? Cpf { get; set; }
        public bool Ativo { get; set; }

        public List <GrupoUsuario> GrupoUsuarios { get; set; }



    }
}