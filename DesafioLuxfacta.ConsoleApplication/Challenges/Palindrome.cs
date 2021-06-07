using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioLuxfacta.ConsoleApplication.Challenges
{
    public class Palindrome
    {
        /*******************************************************************************
          Uma palíndroma é uma palavra que se lê da mesma forma de trás para frente.

          Escreva o corpo do método isPalindrome que verifica se uma palavra é
          palíndroma. A validação deve desconsiderar diferença entre maiúsculas e
          minúsculas (case insensitive).

          Por exemplo, isPalindrome(“Deleveled”) deve retornar true.
        *******************************************************************************/

        public static bool IsPalindrome(string word)
        {
            /* Definida a palavara para um unico tipo de CamelCase no caso Lower */
            word = word.ToLower();

            /* Definindo os caracteres da palavra */
            char[] caracter = word.ToCharArray();

            /* Verificando se a palavra é palíndroma */

            for (int i = 0, j = caracter.Length - 1; i < j; i++, j--)
            {
                if (caracter[i] != caracter[j])
                    return false;
            }
            return true;
        }
    }
}
