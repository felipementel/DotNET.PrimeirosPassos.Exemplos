namespace Empresa.Area.Projeto.Console._1_Herança
{
    public class FuncionarioBase
    {
        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public bool Ativa { get; set; }

        public void RegistrarEntrada()
        {
            //PacalCase
            //camelCase
        }

        public void RegistrarHoraAlmoco()
        {

        }

        public void RegistrarSaida()
        {

        }
    }










    public class FuncionarioRegistrado : FuncionarioBase
    {
        public string CTPS { get; set; }

        public void XPTO()
        {
            var funcionario = new FuncionarioRegistrado()
            {
                
            };

            funcionario.RegistrarEntrada();
        }
    }
}
