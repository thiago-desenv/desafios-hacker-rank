namespace desafios_hacker_rank.desafios
{
    public class ContadorVales
    {
        public static void ContarPassos()
        {
            int passos = 8;
            string caminho = "UDDDUDUU";

            if(caminho.Length != passos)
            {
                throw new ArgumentException("Número de passos não corresponde ao caminho percorrido");
            }

            int nivelDoMar = 0;
            int qtdVales = 0;

            foreach(char passo in caminho)
            {
                if(passo == 'U')
                {
                    nivelDoMar++;

                    if(nivelDoMar == 0)
                    {
                        qtdVales++;
                    }
                }
                else if(passo == 'D')
                {
                    nivelDoMar--;
                }
            }

            Console.WriteLine($"Quantidade de vales percorridos: {qtdVales}");
        }
    }
}
