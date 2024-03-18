using System.Security.Cryptography.X509Certificates;

namespace ValidadorCPF;
class Program
{
    static void Main(string[] args)
    {
        ExibirOpcoesDoMenu();
    }

    private static void ExibirOpcoesDoMenu()
    {
        var _validadorDeCPFTitulo = new Titulo("VALIDADOR DE CPF");
        _validadorDeCPFTitulo.MostrarTitulo();
        Console.WriteLine("");
        Console.Write("Digite o CPF a ser validado: ");
        var _cpf = long.Parse(Console.ReadLine());

        CPF cpf = new(_cpf);
        var resultado = cpf.ValidarCPF();
        Console.WriteLine(resultado);
        Console.WriteLine("Aperte qualquer tecla para realizar uma nova consulta.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
