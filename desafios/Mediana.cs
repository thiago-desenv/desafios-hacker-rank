namespace desafios_hacker_rank.desafios
{
    public class Mediana
    {
        public static void VerificarMediana()
        {
            List<int> arr = new List<int>() { 2, 1, 3, 6, 5, 4, 7 };

            //Ordenação
            arr.Sort();
            Console.WriteLine("Lista ordenada: ");
            arr.ForEach(n => Console.WriteLine(n));

            //Verifica quantidade da lista
            int count = arr.Count;

            double mediana;

            if(count % 2 == 1)
            {
                Console.WriteLine("A lista tem quantidade ímpar");
                mediana = arr[count / 2];
            }
            else
            {
                Console.WriteLine("A lista tem quantidade par");
                int meio1 = arr[(count / 2) - 1];
                int meio2 = arr[(count / 2)];
                Console.WriteLine("meio1: " + meio1);
                Console.WriteLine("meio1: " + meio2);
                mediana = (meio1 + meio2) / 2.0;
            }

            Console.WriteLine("Mediana é: " + mediana);
        }
    }
}
