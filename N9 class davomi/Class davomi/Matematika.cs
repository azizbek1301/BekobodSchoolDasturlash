namespace Class_davomi
{
    public static class Matematika
    {
        public static int Summa(params int[] sonlar)
        {
            int summ = 0;
            for (int i = 0; i < sonlar.Length; i++)
            {
                summ += sonlar[i];
            }
            return summ;
        }

        public static void EkrangaChiqar(params object[] malumotlar)
        {
            foreach (var soz in malumotlar)
            {
                Console.WriteLine(soz);
            }
        }

       
    }
}
