using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed; //COMANDO PARA ALTERAR COR DO BACKGROUND
            Console.ForegroundColor = ConsoleColor.Black; //COMANDO PARA ALTERAR A CORA DA FONTE

            Tela();
            Opcoes();

            var opcao = short.Parse(Console.ReadLine());
            HandleMenuOption(opcao);
        }

        public static void Tela()
        {

            cab_rodp();

            for (int lines = 0; lines < 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            cab_rodp();
        }

        public static void cab_rodp()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Opcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EditorHTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short opcao)
        {
            switch (opcao)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }
}