
namespace Projetinho1
{
    internal class Passaro : IVoador, ISerVivo
    {

        void IVoador.Cair()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O pássaro caiu.");
            Console.ReadLine();
            Console.WriteLine("O pássaro caiu... Existem altos e baixos na vida, e, agora, o pássaro irá voar como nunca antes.");
            Console.ReadLine();
        }

        void IVoador.Decolar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O pássaro está decolando, uhuuuu!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        void IVoador.Planar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O passarinho está procurando comida...");
            Console.ReadLine();
        }

        void IVoador.Pousar()
        {
            Console.Clear();
            Console.WriteLine("O passarinho pousou e achou uma possível presa, o que ele deve comer ?");
        }
        void ISerVivo.Comer()
        {
            Console.WriteLine("1 - Comer minhoca");
            Console.WriteLine("2 - Incerteza misteriosa");
            Console.WriteLine("escolha um: ");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("INHAM!");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O passarinho ficou com fome! T-T");
                Console.ReadLine();
            }
        }
        void ISerVivo.Beber()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("O passarinho está bebendo uma água deliciosa...");
            Console.ReadLine();
        }

        void ISerVivo.Respirar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O passarinho está respirando seus últimos suspiros, pois, o sistema tem alzheimer e não salvou se o passarinho comeu a minhoca ou não.");
            Console.ReadLine();
            Console.WriteLine("O passarinho está morrendo de fome....");
            Console.ReadLine();
        }
        void ISerVivo.Morrer()
        {
            Console.Clear();
            Console.WriteLine("No céu tem pão!");
            Console.ReadLine();
            Console.WriteLine("E morreu.");
            Console.ReadLine();
        }
    }
    internal class Cachorro : ISerVivo
    {
        void ISerVivo.Beber()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("O cachorro saceia sua cede no riacho..");
            Console.ReadLine();
        }

        void ISerVivo.Comer()
        {
            Console.Clear();
            Console.WriteLine("O cachorro come a picanha que caiu no chão durante o churrasco.");
            Console.ReadLine();
        }

        void ISerVivo.Morrer()
        {
            Console.Clear();
            Console.WriteLine("O cachorro está batendo as botas.");
            Console.ReadLine();
        }

        void ISerVivo.Respirar()
        {
            Console.Clear();
            Console.WriteLine("O cachorro dá seu último suspiro e bate as botas.");
            Console.ReadLine();
        }
    }

    internal class Computador : IMaquina
    {
        void IMaquina.Ligar()
        {
            Console.Clear();
            Console.WriteLine("Ligando, aguarde.");
            Console.ReadLine();
        }

        void IMaquina.Carregar()
        {
            Console.Clear();
            Console.WriteLine("Carregando, por favor, aguarde........");
            Console.ReadLine();
        }

        void IMaquina.ExecutarTarefa()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma tarefa: ");
            Console.WriteLine("1 - Google");
            Console.WriteLine("2 - Bing");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Boa escolha de navegador");
                Console.ReadLine();
            }
            if (option == "2")
            {
                Console.WriteLine("Bah!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não escolher nada também é uma opção");
                Console.ReadLine();
            }

        }

        void IMaquina.Desligar()
        {
            Console.Clear();
            Console.WriteLine("Desligando computador...");
            Console.ReadLine();
        }
    }
        public class BeijaFlo : IPairador, IVoador, ISerVivo
        {
            void IVoador.Cair()
            {
                Console.Clear();
                Console.WriteLine("O beija flor caiu, assim como o passarinho...");
                Console.ReadLine();
            }

            void IVoador.Decolar()
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Decolar" +
                "2 - DECOLAR!!!");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("O Beija flor decola graciosamente....");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O beja flor DECOLA GRACIOSAMENTE!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
            }

            void IVoador.Planar()
            {
                Console.Clear();
                Console.WriteLine("O beja flor plana, procurando uma flor apetitosa.");
                Console.ReadLine();

            }
            void IPairador.Pairar()
            {
                Console.Clear();
                Console.WriteLine("O beja flor paira sob um campo florido, decidindo qual flor sugar.");
                Console.ReadLine();
            }
            void IVoador.Pousar()
            {
                Console.Clear();
                Console.WriteLine("O beija flor Pousa numa rosa.");
                Console.ReadLine();
            }

            void ISerVivo.Comer()
            {
                Console.Clear();
                Console.WriteLine("O bejaflor sugar a rosa.");
                Console.ReadLine();
            }

            void ISerVivo.Respirar()
            {
                Console.Clear();
                Console.WriteLine("O beija flor respira após sugar a rosa.");
                Console.ReadLine();
            }

            void ISerVivo.Beber()
            {
                Console.Clear();
                Console.WriteLine("O beija flor bebe água ao fim do dia.");
                Console.ReadLine();
            }

            void ISerVivo.Morrer()
            {
                Console.Clear();
                Console.WriteLine("O beija flor é comido por uma coruja durante a noite.");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FIM DO PROGRAMA.");
                Console.ReadLine();
            }
        }
}