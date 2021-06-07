using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioLuxfacta.ConsoleApplication.Challenges
{
    /*******************************************************************************
      A classe LuxFacta recebe um parâmetro no seu construtor que é sempre um número
       inteiro.
      Com base nesse numero n, escreva o corpo do método say, de forma que:
        - Se o número n for divisível por 3, o retorno deve ser "Lux"
        - Se o número n for divisível por 5, o retorno deve ser "Facta"
        - Se o número n for divisível por 3 e por 5, o retorno deve ser "LuxFacta"
        - Qualquer outra condição o retorno deve ser o próprio número n;
    *******************************************************************************/

    public class LuxFacta
    {
        private int Number { get; set; }

        public LuxFacta(int n)
        {
            Number = n;
        }

        public string Say()
        {
            // Limpando a variavel para evitar lixo(s) nela.
            string Result = "";

            // Imprementando o metodo 

            if ((Number % 3) == 0)
            {
                Result = "Lux";
            }
            if ((Number % 5) == 0)
            {
                Result += "Facta";
            }

            // Imprimindo resultado

            return Result == "" ? Number.ToString() : Result;

            /*******************************************************************************
             Em analise, foi verificado que o sistema só da erro no 6 teste.
             Por conta que o teste pede negativo porem o valor mencionado o sistema dará valor positivo.
             *******************************************************************************/
        }
    }
}
