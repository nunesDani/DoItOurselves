using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTech.src.Entities
{
    public static class GamePhase
    {
        public static void Start(){
            InitScreen();
        }
        private static void InitScreen()
        {
            Console.WriteLine("--------TELA INICIAL--------\n\n DIO - Do It Ourselves");
            Console.WriteLine("\n[1] - JOGAR");
            Console.WriteLine("[2] - INSTRUÇÕES");
            Console.WriteLine("[3] - CRÉDITOS");
            Console.WriteLine("[4] - SAIR");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                OnGame();
            }

            else if (input == "2")
            {
                Console.Clear();
                Instructions();
            }

            else if (input == "3")
            {
                Console.Clear();
                Credits();
            }

            else if (input == "4")
            {
                Console.WriteLine("\nPressione [ENTER] para confirmar e sair...");
                Console.ReadLine();
            }

            else{
                Console.WriteLine("Opção inválida! Fechando aplicação...");
                Console.ReadLine();
            }

        }

        private static void OnGame()
        {
            Console.Clear();
            Game newGame = new Game();
            newGame.StartGame();
        }

        private static void Instructions()
        {
            Console.WriteLine("--------INSTRUÇÕES--------\n\n DIO - Do It Ourselves");
            Console.WriteLine("\nA jogabilidade é simples, você só precisa escolher as opções quando for solicitado.");
            Console.WriteLine("Durante os diálogos e estágios será necessário pressionar [ENTER] para prosseguir na história.");

            Console.WriteLine("\nVocê também precisará identificar o momento certo de atacar ou de usar a habilidade de cura.");
            Console.WriteLine("Tanto você quanto o adversário possuem 50% de chance de realizar um ataque com acerto crítico, então depende apenas da sorte.");
            Console.WriteLine("O acerto crítico adicionará uma quantia X ao dano de ataque.");

            Console.WriteLine("\nO seu ataque, vida e poder de cura aumentam por nível, mas o ataque e vida dos inimigos também aumentam por fase.");
            Console.WriteLine("Vale ressaltar que a cura não ultrapassa a sua vida máxima, isso significa que se você estiver de vida cheia e tentar se curar, sua vida não aumentará e isso pode custar a sua vitória.");

            Console.WriteLine("\n[1] - VOLTAR PARA A TELA INICIAL");
            Console.WriteLine("[2] - JOGAR");
            Console.WriteLine("[3] - SAIR");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                InitScreen();
            }

            else if (input == "2")
            {
                Console.Clear();
                OnGame();
            }

            else if (input == "3")
            {
                Console.WriteLine("\nPressione [ENTER] para confirmar e sair...");
                Console.ReadLine();
            }

            else{
                Console.WriteLine("\nOpção inválida! Fechando aplicação...");
                Console.ReadLine();
            }

        }

        private static void Credits()
        {
            Console.WriteLine("--------CRÉDITOS--------\n\n DIO - Do It Ourselves");
            Console.WriteLine("\nFeito por Danielle J Nunes, com o objetivo de passar uma mensagem séria de uma forma divertida.");
            Console.WriteLine("Mostrar que somos protagonista da nossa própria história, e devemos acreditar no nosso valor e potencial!");
            Console.WriteLine("\nGitHub: /nunesDani");
            
            Console.WriteLine("\n[1] - VOLTAR PARA A TELA INICIAL");
            Console.WriteLine("[2] - JOGAR");
            Console.WriteLine("[3] - SAIR");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                InitScreen();
            }

            else if (input == "2")
            {
                Console.Clear();
                OnGame();
            }

            else if (input == "3")
            {
                Console.WriteLine("\nPressione [ENTER] para confirmar e sair...");
                Console.ReadLine();
            }

            else{
                Console.WriteLine("Opção inválida! Fechando aplicação...");
                Console.ReadLine();
            }
        }
    }
}

