using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            string str;
            int linhas, colunas;
            float[,] matriz;
            float somaDasMedias _= 0;

            //Pedir ao user nº Linhas de matriz
            Console.Write("Insira nº de Linhas: ");
            str = Console.ReadLine();
            Linhas = int.Parse(str);

            //Pedir o nº  de colunas da matiz
            Console.Write("Insira nº de Colunas: ");
            str = Console.ReadLine();
            Linhas = int.Parse(str);

            //inicializar a matriz
            matriz = new float[linhas, colunas];

            //pedir ao user os valores float para colocar na matriz
            for (int i=0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Insira o valor em ({i},{j}): ");
                    str = Console.WriteLine();
                    maatriz[i, j] = Convert.ToSingle(str);
                }

            //mostrar
            for (int i=0; i < matriz.GetLength(1); j++)
            {
                float soma = 0, media;
                Console.Write("| ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                    Console.WriteLine($"{matriz[i, j], 10:f2} ");
                }
                media =soma /matriz.GetLength(1);
                Console.WriteLine($"| -> {media,10:f3}");
                somaDasMedias += media;
            }

            //Mostrar soma das médias
            Console.WriteLine("Soma das medias: {0,10:f3}", somaDasMedias);


        }
    }
}
