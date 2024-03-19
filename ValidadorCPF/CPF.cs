using System;

namespace ValidadorCPF;

internal class CPF
{
    long cpf;
    public CPF(long _cpf) 
    {
        cpf = _cpf;
    }

    public string ValidarCPF()
    {
        string cpfString = cpf.ToString();
        string resultado = null;

        if(cpfString.Length != 11)
        {
            resultado = "O CPF é invalido, pois nao possui 11 dígitos!";
            return resultado;
        }

        
        
        int.TryParse(cpfString[0].ToString(), out int digito0);
        int.TryParse(cpfString[1].ToString(), out int digito1);
        int.TryParse(cpfString[2].ToString(), out int digito2);
        int.TryParse(cpfString[3].ToString(), out int digito3);
        int.TryParse(cpfString[4].ToString(), out int digito4);
        int.TryParse(cpfString[5].ToString(), out int digito5);
        int.TryParse(cpfString[6].ToString(), out int digito6);
        int.TryParse(cpfString[7].ToString(), out int digito7);
        int.TryParse(cpfString[8].ToString(), out int digito8);
        int.TryParse(cpfString[9].ToString(), out int digito9);
        int.TryParse(cpfString[10].ToString(), out int digito10);

        int[] digitos = {digito0, digito1, digito2, digito3, digito4, digito5, digito6, digito7, digito8,digito9, digito10};

        var calculo1 = (digito0 * 10) + (digito1 * 9) + (digito2 * 8) + (digito3 * 7) + (digito4 * 6) + (digito5 * 5) + (digito6 * 4) + (digito7 * 3) + (digito8 * 2);

        var calculo2 = (calculo1 * 10) % 11;
        if (calculo2 == 10) { calculo2 = 0; }
        if(calculo2 != digito9)
        {
            resultado = "O CPF é invalido!!!";
            return resultado;

        }
        
        var calculo3 = (digito0 * 11) + (digito1 * 10) + (digito2 * 9) + (digito3 * 8) + (digito4 * 7) + (digito5 * 6) + (digito6 * 5) + (digito7 * 4) + (digito8 * 3) + (digito9 * 2);
        var calculo4 = (calculo3 * 10) % 11;
        if (calculo4 != digito10)
        {
            resultado = "O CPF é invalido!!!";
            return resultado;

        }
        // Verificar se todos os numeros sao iguais
        var media = digitos.Average();
        bool todosIguaisMedia = digitos.All(valor => valor == media);

        if(todosIguaisMedia == true)
        {
            resultado = "O CPF é invalido, pois todos os números são iguais!";
            return resultado;
        }

        resultado = "O CPF é valido!";
        return resultado;
        

    }
}
