namespace desafios_hacker_rank.desafios
{
    public class InverterBits
    {
        public static void TransformarBits()
        {
            long valor = 4294967294;
            uint valorComBitsInvertido = (uint)~valor;
            Console.WriteLine("valor com os bits invertidos: " + valorComBitsInvertido);
        }
    }
}
