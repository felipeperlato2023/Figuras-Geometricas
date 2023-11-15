using Figuras.Classes;
using Figuras.Classes.Enums;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Figura> lista = new List<Figura>();


        Console.WriteLine("Entre com quantidade de figuras ");
        int qtd = int.Parse(Console.ReadLine());

        for(int i = 1; i <= qtd; i++)
        {
            Console.WriteLine("figura " + i) ;
            Console.WriteLine("retangulo ou circulo:(r/c) ?");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Cor (black,blue,red):");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            Console.WriteLine("Cor (black,blue,red):" + color);
         

            if (op == 'r')
            {
                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());

                lista.Add(new Retangulo(largura, altura, color));
            }
            else
            {
                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine());

                lista.Add(new Circulo(raio,color));

            }
        }

        Console.WriteLine("Areas: ");

        foreach (Figura figura in lista)
        {
            Console.WriteLine(figura.Area());
        }
    }
    }
