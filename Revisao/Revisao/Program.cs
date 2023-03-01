namespace Revisao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string nome;
            string ativo;
            string cpf;
            string opcao;

            Console.WriteLine("Informe o nome do usuário:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do usuário:");
            cpf = Console.ReadLine();
            Console.WriteLine("O usuário está ativo? (S) ou (N)");
            opcao = Console.ReadLine();

            ativo = opcao == "S";

        }
    }
}