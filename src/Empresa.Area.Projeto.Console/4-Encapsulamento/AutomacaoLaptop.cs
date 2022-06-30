using Empresa.Area.Projeto.Console._3_Polimorfismo;

namespace Empresa.Area.Projeto.Console._4_Encapsulamento
{
    public class AutomacaoLaptop
    {
        public void ProcessoPadrao()
        {
            var laptop = new Laptop();
            laptop.Ligar();
            laptop.EntrarWindows();
            laptop.Desligar();
        }
    }
}
