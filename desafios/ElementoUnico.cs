namespace desafios_hacker_rank.desafios
{
    public class ElementoUnico
    {
        public static void EncontrarValorUnico()
        {
            List<int> valores = new List<int> { 1, 1, 2, 2, 10 };

            Dictionary<int, int> chavesValores = new Dictionary<int, int>();
            int valorUnico = 0;

            foreach(int item in valores)
            {
                if(chavesValores.ContainsKey(item))
                {
                    chavesValores[item]++;
                }
                else
                {
                    chavesValores[item] = 1;
                }
            }

            foreach(var chaveValor in chavesValores)
            {
                if(chaveValor.Value == 1)
                {
                    valorUnico = chaveValor.Key;
                }
            }

            Console.WriteLine($"Valor único: {valorUnico}");
        }
    }
}
