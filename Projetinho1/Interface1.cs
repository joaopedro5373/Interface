namespace Projetinho1
{
    internal interface IVoador
    {
        public void Decolar();
        public void Planar();
        public void Pousar();
        public void Cair();
    }

    internal interface ISerVivo
    {
        public void Comer();
        public void Respirar();
        public void Beber();
        public void Morrer(); 

    }

    internal interface IMaquina
    {
        public void Carregar();
        public void Ligar();
        public void Desligar();
        public void ExecutarTarefa();

    }

    internal interface IPairador
    {
        public void Pairar();

    }

}
