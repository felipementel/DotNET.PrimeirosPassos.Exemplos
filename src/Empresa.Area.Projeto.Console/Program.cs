// See https://aka.ms/new-console-template for more information
//

namespace Empresa.Area.Projeto;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Built_in_Types();
        
        //Estrutura de dados
        EstruturaDeDados_Pilha();
        EstruturaDeDados_Fila();

        //Estrutura de Repetição
        EstruturaRepeticao_For();
        EstruturaRepeticao_Foreach();
        EstruturaRepeticao_While();
        EstruturaRepeticao_DoWhile();

        //Estrutura de Condição
        EstruturaCondicao_If();
        EstruturaCondicao_IfElse();
        EstruturaCondicao_Switch();
    }


    /// <summary>
    /// //Built-in Types (Tipos Pimitivos)
    /// </summary>
    public static void Built_in_Types()
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types

        short ValorShot = 0;
        int ValorInteiro = 0;
        long ValorLong = 0;

        string Nome = "";
        string Nome2 = string.Empty;

        DateTime dataAtual = DateTime.Now;
        DateTime dataAtual2 = new DateTime(
            DateTime.Now.Year,
            DateTime.Now.Month,
            DateTime.Now.Day);

        Boolean VerdadeiroFalso1 = false;
        bool VerdadeiroFalso2 = true;

        Decimal valorMonetario = 12.90M;
        decimal valorMonetario2 = 12.90M;

        char letra = 'A';
        string palavra = "Felipe";
    }

    /// <summary>
    /// LIFO
    /// </summary>
    public static void EstruturaDeDados_Pilha()
    {
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-6.0

        Stack<Pessoa> pilha = new Stack<Pessoa>();

        pilha.Push(new Pessoa { Id = 1, Name = "Camila", Active = true });
        pilha.Push(new Pessoa { Id = 2, Name = "Paola", Active = true });
        pilha.Push(new Pessoa { Id = 3, Name = "Rafael", Active = true });

        foreach (var item in pilha)
        {
            var itemPessoa = pilha.Pop();
            Console.WriteLine(itemPessoa.Name);
        }
    }

    /// <summary>
    /// FIFO
    /// </summary>
    public static void EstruturaDeDados_Fila()
    {
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.queue?view=net-6.0
        Queue<Pessoa> fila = new Queue<Pessoa>();

        fila.Enqueue(new Pessoa { Id = 1, Name = "Camila", Active = true });
        fila.Enqueue(new Pessoa { Id = 2, Name = "Paola", Active = true });
        fila.Enqueue(new Pessoa { Id = 3, Name = "Rafael", Active = true });

        foreach (var item in fila)
        {
            var itemPessoa = fila.Dequeue();
            Console.WriteLine(itemPessoa.Name);
        }
    }

    public static void EstruturaRepeticao_For()
    {
        var items = ObterArray();
        //var items = ObterLista();

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[0].Name);
        }
    }

    public static void EstruturaRepeticao_Foreach()
    {
        var items = ObterArray();
        //var items = ObterLista();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public static void EstruturaRepeticao_While()
    {
        int numero = 0;

        while (numero < 3)
        {
            Console.Write(numero);
            numero++;
        }
    }

    public static void EstruturaRepeticao_DoWhile()
    {
        int numero = 0;
        do
        {
            Console.Write(numero);
            numero++;

        } while (numero < 5);
    }

    public static void EstruturaCondicao_If()
    {
        int valorRetornado = SomarUm(4);

        if (valorRetornado > 5)
        {
            Console.WriteLine("Valor retornado maior que 5");
        }
    }

    public static void EstruturaCondicao_IfElse()
    {
        int valorRetornado = SomarUm(4);

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
    }

    public static void EstruturaCondicao_Switch()
    {
        int numero = GerarNumeroRandomico(1, 30);

        switch (numero)
        {
            case 1:
                Console.WriteLine("Número é 1");
                break;

            case 2:
                Console.WriteLine("Número é 2");
                break;

            case > 2:
            case <= 30:
                Console.WriteLine("Número esta entre 2 e 30");
                break;

            default:
                Console.WriteLine("Número esta fora do range esperado");
                break;
        }
    }

    //Método
    public static int SomarUm(int Valor)
    {
        return Valor + 1;
    }

    public static int GerarNumeroRandomico(int min, int max)
    {
        return new Random().Next(min, max);
    }

    public static List<Pessoa> ObterLista()
    {
        List<Pessoa> Pessoas = new List<Pessoa>();
        Pessoas.Add(new Pessoa { Id = 1, Name = "Camila", Active = true });
        Pessoas.Add(new Pessoa { Id = 2, Name = "Paola", Active = true });
        Pessoas.Add(new Pessoa { Id = 3, Name = "Rafael", Active = true });

        return Pessoas;
    }

    public static Pessoa[] ObterArray()
    {
        Pessoa[] Pessoas = new Pessoa[3];
        Pessoas[0] = new Pessoa { Id = 1, Name = "Camila", Active = true };
        Pessoas[1] = new Pessoa { Id = 2, Name = "Paola", Active = true };
        Pessoas[3] = new Pessoa { Id = 3, Name = "Rafael", Active = true };

        return Pessoas;
    }

    //Classe
    public class Pessoa
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}