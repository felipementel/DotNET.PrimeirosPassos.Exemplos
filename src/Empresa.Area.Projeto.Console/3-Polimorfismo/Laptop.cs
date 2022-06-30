using Empresa.Area.Projeto.Console._2_Abstracao;

namespace Empresa.Area.Projeto.Console._3_Polimorfismo
{
    public class Laptop : Eletroeletronico
    {
        public Laptop(string fabricante, string modelo, int voltagem) : base(fabricante, modelo, voltagem)
        {
        }

        public Laptop() : base("DELL", "A3742", 220)
        {
        }

        private void VerificarEnergia()
        {

        }

        private void VerificarTeclado()
        {

        }

        private void EntrarNoSO()
        {

        }

        public void EntrarWindows()
        {
            VerificarEnergia();
            VerificarTeclado();

            EntrarNoSO();
        }


        public override void Desligar()
        {
            // fechar todos os programas
        }

        public override void Ligar()
        {
            //
            VerificarEnergia();
            VerificarTeclado();
        }
    }
}
