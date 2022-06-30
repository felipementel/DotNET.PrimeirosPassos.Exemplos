using Empresa.Area.Projeto.Console._1_Herança;

namespace Empresa.Area.Projeto.Console._5_HerancaEComposicao
{
    public class FuncionarioRegistrado2 : FuncionarioBase
    {
        public string CPF { get; set; }

        public void XPTO()
        {
            var func = new FuncionarioRegistrado2();
            func.
        }
    }

    // Composição no lugar de herança
    public class Cliente
    {
        private readonly FuncionarioBase _pessoa;

        public Cliente(FuncionarioBase pessoa)
        {
            _pessoa = pessoa;

            _pessoa.
        }

    }

    //Exemplo 2

    public interface IRepositorio<T>
    {
        void Adicionar(T objeto);

        void Excluir(T objeto);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(FuncionarioBase objeto);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T objeto)
        {
            // Código para atualizar
        }

        public void Excluir(T objeto)
        {
            // Código para excluir
        }
    }

    public class RepositorioHerancaPessoa : Repositorio<FuncionarioBase>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<FuncionarioBase> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<FuncionarioBase> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(FuncionarioBase objeto)
        {
            _repositorioPessoa.Adicionar(objeto);
        }
    }

    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new FuncionarioBase());
            repoH.Excluir(new FuncionarioBase());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<FuncionarioBase>());
            repoC.Adicionar(new FuncionarioBase());
        }
    }

    //SOLID
    //SRP
    //OCP
    //LSP - prova real da heranca
    //ISP
    //DIP
}
