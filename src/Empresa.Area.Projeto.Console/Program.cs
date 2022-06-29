// See https://aka.ms/new-console-template for more information
//

namespace Empresa.Area.Projeto;

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");

        //Built-in Types (Tipos Pimitivos)

        short ValorShot = 0;
        int ValorInteiro = 0;
        long ValorLong = 0;

        Int16 ValorInt16 = 0;
        Int32 ValorInt32 = 0;
        Int64 Valor1 = 0;

        Boolean flag = false;

        int valorRetornado = SomarUm(4);

        // Estrutura de condição

        if (valorRetornado > 5)
        {
            Console.WriteLine("Valor retornado maior que 5");
        }
        else if (valorRetornado < 5)
        {
            Console.WriteLine("Valor retornado menor que 5");
        }
        else
        {
            //Só vai entrar se a variável for igual a 5
        }

        // Estrutura de repetição

        //for, foreach, do while, while do

        Queue<Pessoa> fila = new Queue<Pessoa>();

        Stack<Pessoa> pilha = new Stack<Pessoa>();

        IEnumerable<Pessoa> lista = new List<Pessoa>(6);
        Pessoa[] pessoa55 = new Pessoa[5];
        pessoa55[0] = new Pessoa { Id = 1, Name = "Camila", Active = true };


        List<Pessoa> Pessoas = new List<Pessoa>();
        Pessoas.Add(new Pessoa { Id = 1, Name = "Camila", Active = true });
        Pessoas.Add(new Pessoa { Id = 2, Name = "Paola", Active = true });
        Pessoas.Add(new Pessoa { Id = 3, Name = "Rafael", Active = true });

        foreach (var item in Pessoas)
        {
            Console.WriteLine("Nome:" + item.Name);
            Console.WriteLine($"Statu: {item.Active}");
        }

        

        

        

    }

    public static void EstruturaRepeticao_For()
    {
        for (int i = 0; i < length; i++)
        {

        }
    }

    public static void EstruturaRepeticao_Foreach()
    {

    }

    public static void EstruturaRepeticao_While()
    {
        while (true)
        {

        }
    }

    public static void EstruturaRepeticao_DoWhile()
    {
        do
        {

        } while (true);
    }

    public static void EstruturaCondicao_If()
    {

    }

    public static void EstruturaCondicao_IfElse()
    {

    }

    public static void EstruturaCondicao_Switch()
    {

    }


    public static int SomarUm(int Valor)
    {
        return Valor + 1;
    }

    public class Pessoa
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}