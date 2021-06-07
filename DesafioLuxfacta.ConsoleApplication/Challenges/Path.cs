using DesafioLuxfacta.ConsoleApplication.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioLuxfacta.ConsoleApplication.Challenges
{
    /*******************************************************************************
      A classe “Path” representa um sistema de arquivos abstrato. Escreva o corpo
      do método “cd” (change directory).
      - O diretório raiz é “/”;
      - O separador é “/”;
      - O diretório pai é acessível através de “..”;
      - O nome de um diretório contém apenas letras (A-Za-z);
      - Quando um path for inválido, o método deverá lançar a exceção do tipo InvalidPathException;

      Por exemplo, se o construtor da classe for chamado com o parâmetro “/a/b/c/d”,
      teremos (considerar os comandos chamados em sequencia):
        - “e/f”: deverá retornar “/a/b/c/d/e/f”;
        - “../x”: deverá retornar “a/b/c/d/e/x”;
        - “/d”: deverá retornar “/d”;
        - “/?”: deverá lançar InvalidPathException;
    *******************************************************************************/

    public class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            CurrentPath = path;
        }

        public void Cd(string path)
        {           

            // Verificar e remover a duplicidade de traço
            path = path.Replace("//", "/");

            // Variaveis auxiliares para efetuar as verificações
            string Auxiliar;
            int TamanhoPath = path.Length;

            // Efetua todas as verificaçoes necessarias conforme o enunciado.
            if ((TamanhoPath == 1) && (path.Substring(0, 1) == "/"))
            {
                Auxiliar = path;
            }
            else if ((TamanhoPath == 2) && (path.Substring(0, 2) == ".."))
            {
                Auxiliar = CurrentPath;
            }
            else if ((TamanhoPath > 3) && (path.Substring(0, 3) == "../"))
            {
                int Val = 2;
                for (int i = 3; i < path.Length; i += 3)
                {
                    try
                    {
                        if (path.Substring(i, 3) == "../")
                            Val += 2;
                    }
                    catch { }
                }
                Auxiliar = CurrentPath.Remove(CurrentPath.Length - Val) + path.Substring(Val > 2 ? Val + 1 : Val, 2);
            }
            else if ((path.Substring(0, 2) == "./") || (path.Substring(0, 2) == "/?") || (path.Substring(0, 3) == "..."))
            {
                throw new InvalidPathException();
            }
            else if (CurrentPath.Length == TamanhoPath)
            {
                if (path.Substring(0, 1) == "/")
                    Auxiliar = path;
                else
                    Auxiliar = CurrentPath + path;
            }
            else
            {
                int Val = 0;
                for (int i = 0; i < path.Length; i++)
                {
                    try
                    {
                        if (path.Substring(i, 3) == "../")
                            Val += 2;
                    }
                    catch { }
                }
                if (Val == 2)
                    path = path.Substring(path.Length - 1, 1);
                Auxiliar = CurrentPath + "/" + path;
            }

            CurrentPath = Auxiliar;
        }
    }
}
