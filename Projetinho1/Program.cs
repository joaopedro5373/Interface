using Projetinho1;

class Program
{
    static void Main(string[] args)
    {
        Passaro passaro = new Passaro();
        IVoador voador = passaro;
        ISerVivo serVivoPassaro = passaro;

        voador.Cair();
        voador.Decolar();
        voador.Planar();
        voador.Pousar();
        serVivoPassaro.Comer();
        serVivoPassaro.Beber();
        serVivoPassaro.Respirar();
        serVivoPassaro.Morrer();

        Cachorro cachorro = new Cachorro();
        ISerVivo serVivoCachorro = cachorro;

        serVivoCachorro.Beber();
        serVivoCachorro.Respirar();
        serVivoCachorro.Morrer();
        serVivoCachorro.Respirar();

        Computador computador = new Computador();
        IMaquina maquinaComputador = computador;

        maquinaComputador.Ligar();
        maquinaComputador.Carregar();
        maquinaComputador.ExecutarTarefa();
        maquinaComputador.Desligar();

        BeijaFlo beijaflo = new BeijaFlo();
        ISerVivo serVivo = beijaflo;
        IPairador pairador = beijaflo;
        IVoador voador2 = beijaflo;

        voador2.Cair();
        voador2.Decolar();
        voador2.Planar();
        pairador.Pairar();
        voador2.Planar();
        voador2.Pousar();
        serVivo.Comer();
        serVivo.Beber();
        serVivo.Respirar();
        serVivo.Morrer();
    }
}