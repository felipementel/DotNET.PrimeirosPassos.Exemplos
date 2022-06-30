namespace Empresa.Area.Projeto.Console._2_Abstracao
{
    public abstract class Eletroeletronico
    {
        private readonly string _fabricante;
        private readonly string _modelo;
        private readonly int _voltagem;

        protected Eletroeletronico(
            string fabricante,
            string modelo, 
            int voltagem)
        {
            _fabricante = fabricante;
            _modelo = modelo;
            _voltagem = voltagem;
        }

        public abstract void Ligar();

        public abstract void Desligar();
    }
}
