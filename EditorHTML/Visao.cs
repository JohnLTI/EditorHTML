using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{

    public class View
    {
        public static void Show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------------------");
            Replace(texto);
            Console.WriteLine("------------------------");
            Console.ReadKey();
            Menu.Show;
        }

        public static void Replace(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); //CONVERTE UM TEXTO NO QUE VOCÊ INFORMAR
            Console.WriteLine(strong);
        }
    }
}