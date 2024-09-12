namespace desafios_hacker_rank.desafios
{
    public class AvaliacaoAlunos
    {
        public static void ArredondarNotas()
        {
            Console.WriteLine("Notas originais: ");
            List<int> notas = new List<int>() { 73, 67, 38, 33 };
            notas.ForEach(nota => Console.WriteLine(nota));
            List<int> notasArredondas = new List<int>();

            for(int i = 0; i < notas.Count; i++)
            {
                if(notas[i] >= 38)
                {
                    int valorAredondadoMultimoDeCinco = ((notas[i] / 5) + 1) * 5;
                    if(valorAredondadoMultimoDeCinco - notas[i] < 3)
                    {
                        notas[i] = valorAredondadoMultimoDeCinco;
                    }
                }
            }

            Console.WriteLine("Notas arredondas: ");
            notas.ForEach(nota => Console.WriteLine(nota));
        }
    }
}
