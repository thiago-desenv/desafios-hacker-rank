namespace desafios_hacker_rank.desafios
{
    public class CalcularDiagonal
    {
        public static void DiferencaDiagonal()
        {
            List<List<int>> matrizQuadrada = new List<List<int>>();
            matrizQuadrada.Add(new List<int>() { 11, 2, 4 });
            matrizQuadrada.Add(new List<int>() { 4, 5, 6 });
            matrizQuadrada.Add(new List<int>() { 10, 8, -12 });

            int somaDiagonalEsquerdaDireita = 0;
            int somaDiagonalDireitaEsquerda = 0;

            for(int i = 0; i < matrizQuadrada.Count; i++)
            {
                somaDiagonalEsquerdaDireita += matrizQuadrada[i][i];
                somaDiagonalDireitaEsquerda += matrizQuadrada[i][matrizQuadrada.Count - i - 1];
            }

            int diferencaAbsoluta = Math.Abs(somaDiagonalEsquerdaDireita - somaDiagonalDireitaEsquerda);
            Console.WriteLine("A diferença absoluta dos diagonais é " + diferencaAbsoluta);
        }
    }
}
