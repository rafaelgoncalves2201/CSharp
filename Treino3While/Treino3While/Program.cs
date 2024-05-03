using System;
using System.Globalization;

namespace Treino {
    class Program {
        static void Main(string[] args) {

            String email, emailLogin, senha, senhaLogin;
            Console.Write("Resgistre seu email: ");
            email = Console.ReadLine();
            Console.Write("Registre uma senha: ");
            senha = Console.ReadLine();

            Console.WriteLine("Registro feito com sucesso!");

            Console.WriteLine("---------Login------------");

            do {
                Console.Write("Digite seu email: ");
                emailLogin = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                senhaLogin = Console.ReadLine();

                if (email != emailLogin || senha != senhaLogin) {
                    Console.WriteLine("Email ou senha invalido tente novamente!");
                }
            }while(email != emailLogin || senha != senhaLogin);
            Console.WriteLine("Acesso liberado");

        }
    }
}