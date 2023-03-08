//using System.ComponentModel.Design;
//using System.Runtime.CompilerServices;

namespace ConsoleApp1
{

    class ContoCorrente
    {
        private bool ilcontoeaperto;
        private decimal saldo;
        private decimal soldi;

        public void Apri(decimal quantoverso)
        {

            quantoverso = saldo;
            if (ilcontoeaperto = true)
            {
                Console.WriteLine("Inserire Nome e Cognome");
                string Nome = Console.ReadLine();
                Console.WriteLine("Versare soldi");
                string Soldi = Console.ReadLine();
                decimal soldi = decimal.Parse(Soldi);
                quantoverso = saldo;

                if (quantoverso < 1000)
                {
                    Console.WriteLine("All'apertura si devono versare almeno 1000euro");
                }
                else 
                {
                    Console.WriteLine("Benvenuto {0}", Nome);
                }
            }
            else
            {
                Console.WriteLine("Il conto è già stato aperto");

            }


        }
        public void Versamento(decimal quantometto)
        {
           
            Console.WriteLine("Quanti soldi vuoi versare?");
            string Versamento = Console.ReadLine();
            decimal versamento = decimal.Parse(Versamento);
            saldo = soldi + quantometto;
            Console.WriteLine("saldo disponniibile dopo versamento: {0}", saldo);

        }


        // versa soldi
        public void prelievo(decimal quantoprelevo)
        {
            if (saldo > quantoprelevo)
            {
                Console.WriteLine("Quanto vuoi prelevare?");
                Console.ReadLine();
                string Prelevo = Console.ReadLine();
                decimal prelevo = decimal.Parse(Prelevo);
                saldo = soldi - quantoprelevo;
                Console.WriteLine("il saldo dopo il prelievo è di: {0}", saldo);
            }
            else
            {
                Console.WriteLine("Credito insufficiente");
            }
        }
        // se il saldo è > quantoprelevo
        //fai prelevare 
        // se no no
    }
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Digita 1 se si vuole aprire un conto, 2 per fare versamenti, 3 per prelevare");
            string scelta = Console.ReadLine();
            int s = int.Parse(scelta);
            ContoCorrente conto = new ContoCorrente();
            if (s == 1)
            {
                conto.Apri(1000);
            }
            else { }
            
            if (s == 2)
            {
                conto.Versamento(200);

            }
            else { }

            if (s==3)
            {
                conto.prelievo(200);
            }
        }
    }
}