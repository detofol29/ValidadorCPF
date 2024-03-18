using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCPF;

internal class Titulo
{
    public string titulo { get; set; }
    public int tamanhoTitulo;
    public Titulo(string titulo)
    {
        this.titulo = titulo;
        tamanhoTitulo = titulo.Length;
    }

    public void MostrarTitulo()
    {
        for (int i = 0; i < tamanhoTitulo -1 ; i++)
        {
            Console.Write("*");
            
        }

        Console.WriteLine("*");

        Console.WriteLine(titulo);
        
        for (int i = 0; i < tamanhoTitulo; i++)
        {
            Console.Write("*");
        }
    }

}
