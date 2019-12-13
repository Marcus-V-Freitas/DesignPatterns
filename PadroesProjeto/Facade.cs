#undef Simples 
#undef Anonimo
#define Lambda
using PadroesProjeto.Estruturas.ActionFunc;
using PadroesProjeto.Estruturas.Arquivos;
using PadroesProjeto.Estruturas.Delegates;
using PadroesProjeto.Estruturas.DriveInfoTeste;
using PadroesProjeto.Estruturas.MetodoExtensao;
using PadroesProjeto.Estruturas.PassagemParametros;
using PadroesProjeto.Estruturas.WriterReader;
using PadroesProjeto.Estruturas.ZipFileTeste;
using PadroesProjeto.PadroesProjeto.Comportamental.ChainOfResponsability;
using PadroesProjeto.PadroesProjeto.Comportamental.Command;
using PadroesProjeto.PadroesProjeto.Comportamental.Iterator;
using PadroesProjeto.PadroesProjeto.Comportamental.Mediator;
using PadroesProjeto.PadroesProjeto.Comportamental.Memento;
using PadroesProjeto.PadroesProjeto.Comportamental.State;
using PadroesProjeto.PadroesProjeto.Comportamental.Strategy;
using PadroesProjeto.PadroesProjeto.Comportamental.TemplateMethod;
using PadroesProjeto.PadroesProjeto.Comportamental.Visitor;
using PadroesProjeto.PadroesProjeto.Criacional.AbstractFactory;
using PadroesProjeto.PadroesProjeto.Criacional.Builder;
using PadroesProjeto.PadroesProjeto.Criacional.FactoryMethod;
using PadroesProjeto.PadroesProjeto.Criacional.Prototype;
using PadroesProjeto.PadroesProjeto.Criacional.Singleton;
using PadroesProjeto.PadroesProjeto.Estrutural.Adapter;
using PadroesProjeto.PadroesProjeto.Estrutural.Bridger;
using PadroesProjeto.PadroesProjeto.Estrutural.Composite;
using PadroesProjeto.PadroesProjeto.Estrutural.Decorator;
using PadroesProjeto.PadroesProjeto.Estrutural.Flyweight;
using PadroesProjeto.PadroesProjeto.Estrutural.Proxy;
using PadroesProjeto.PadroesProjeto.Outros;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PadroesProjeto.Estruturas.Delegates.Delegates;

namespace PadroesProjeto
{
    public class Facade
    {
        private static List<Action> _list = new List<Action>();

        public Facade()
        {
            _list.Add(()=>AbstractFactory());
            _list.Add(() => Builder());
            _list.Add(() => FactoryMethod());
            _list.Add(() => Prototype());
            _list.Add(() => Singleton());
            _list.Add(() => Adapter());
            _list.Add(() => Bridger());
            _list.Add(() => Composite());
            _list.Add(() => Decorator());
            _list.Add(() => Flyweight());
            _list.Add(() => Proxy());
            _list.Add(() => ChainOfResponsability());
            _list.Add(() => Command());
            _list.Add(() => Iterator());
            _list.Add(() => Mediator());
            _list.Add(() => Memento());
            _list.Add(() => State());
            _list.Add(() => Strategy());
            _list.Add(() => TemplateMethod());
            _list.Add(() => Visitor());
            _list.Add(() => Delegates());
            _list.Add(() => Action());
            _list.Add(() => Func());
            _list.Add(() => Extensao());
            _list.Add(() => WriterReader());
            _list.Add(() => ObjectPool());
            _list.Add(() => DriveInfo());
            _list.Add(() => ZipFile());
            _list.Add(() => Parametros());
            _list.Add(() => Arquivos());

        }

        //Abstract Factory
        public void AbstractFactory()
        {
            AbstractFactory factory = new SqlFactory();
            Connection connection = factory.GetConnection();
            connection.Conectar();
        }

        //Builder
        public void Builder()
        {
            Builder builder = new CarroBuilder("HB20");
            Diretor diretor = new Diretor();
            Veiculo veiculo = diretor.Construtor(builder);
            Console.WriteLine(veiculo.Mostrar());
        }

        //Factory Method
        public void FactoryMethod()
        {
            AbstractFactoryMethod factoryMethod = new ConcreteGoogle();
            Autenticacao autenticacao = factoryMethod.GetAutenticacao();
            autenticacao.Autenticar();
        }

        //Prototype
        public void Prototype()
        {
            Item livro1 = new Livro("Design", 150.0);
            Item livro2 = livro1.Clone() as Livro;

            Console.WriteLine(livro1);
            Console.WriteLine(livro2);
        }

        //Singleton
        public void Singleton()
        {
            ConexaoSin conexao1 = ConexaoSin.Instance;
            ConexaoSin conexao2 = ConexaoSin.Instance;

            Thread thread1 = new Thread(new ThreadStart(conexao1.Count));
            Thread thread2 = new Thread(new ThreadStart(conexao2.Count));
            thread1.Start();
            thread2.Start();
           
        }

        //Adapter
        public void Adapter()
        {
           

            var target = new Adapter();

            target.Request(Directory.GetCurrentDirectory() + "\\log.txt");
        }

        //Bridger
        public void Bridger()
        {
            Forma retangulo = new Retangulo("Retangulo");
            retangulo.Cor = new Azul();
            retangulo.DesenharForma();
        }

        //Composite
        public void Composite()
        {
            Formulario formulario = new Formulario("Inicio");
            formulario.Attach(new Button("Enviar"));
            formulario.Show();
        }

        //Decorator
        public void Decorator()
        {
            PizzaQueijo pizza = new PizzaQueijo();
            Adicionais decorator = new Adicionais(pizza);
            decorator.Chocolate();
            decorator.Calabresa();
            pizza.ValorTotal();

        }

        //Flyweight
        public void Flyweight()
        {
            FactoryFlyweight factory = new FactoryFlyweight();
            Character s1 = factory.GetCharacters("Soldado Leve");
            Character s2 = factory.GetCharacters("Darth Vader");
            s1.Golpe(10);
            s2.Golpe(10);

        }

        //Proxy
        public void Proxy()
        {
            var container = new Container();
            container.UseRepository();
            var calc = container.GetInstance<ICalc>();
            (calc as CalcProxy).setCalcProxy(new CalcSoma());
            Console.WriteLine(calc.Calc(-3,4));

        }

        //Chain Of Responsability
        public void ChainOfResponsability()
        {
            Vendedor vendedor = new Vendedor();
            Gerente gerente = new Gerente();
            vendedor.setAprovador(gerente);
            vendedor.Desconto(6);

        }

        //Command
        public void Command()
        {
            Server server = new Server();
            ConcreteCommand command = new ConcreteCommand(server);
            var formulario = new FormularioServer();
            formulario.setCommand(command);
            formulario.ClickEntrar();
        }

        //Iterator
        public void Iterator()
        {
            Empresa funcionario = new Empresa();
            Iterator iterator = funcionario.CreateIterator();
            for (Funcionario i=(Funcionario)iterator.First(); !iterator.IsDone(); i=(Funcionario)iterator.Next())
            {
                Console.WriteLine((iterator.CurrentItem() as Funcionario));
            }
        }

        //Mediator
        public void Mediator()
        {
            AbstractMediator mediator = new ConcreteMediator();
            Colleague suporte = new Suporte(mediator);
            Colleague usuario = new UsuarioCliente(mediator);
            mediator.Attach(suporte);
            mediator.Attach(usuario);
            usuario.Send("Pifou");
            suporte.Send("Arruma");

        }

        //Memento
        public void Memento()
        {
            Pessoa pessoa1 = new Pessoa(1, "Maria");
            CareTaker care = new CareTaker();
            Console.WriteLine("1:"+pessoa1);
            care.Add(pessoa1);
            pessoa1.setPessoa(2, "Marcus");
            Console.WriteLine("2:" + pessoa1);
            care.Recovery(pessoa1, 0);
            Console.WriteLine("3:" + pessoa1);


        }

        //State
        public void State()
        {
            AbstractConnection Open = new OpenConnection();
            ContextState context = new ContextState();

            context.setConnection(Open);
     
            Console.WriteLine(context);

            context.setConnection(Open);

            Console.WriteLine(context);
        }

        //Strategy
        public void Strategy()
        {
            ContextStrategy context = new ContextStrategy();
            context.setStrategy(new StrategySort());
            List<string> lista = new List<string>();
            lista.Add("Marcus");
            lista.Add("Ernane");
            lista.Add("Carlos");
            context.Ordernar(lista);
            context.setStrategy(new StrategyReverse());
            context.Ordernar(lista);
            lista.ForEach(item => Console.WriteLine(item));

        }

        //Template Method
        public void TemplateMethod()
        {
            AbtractTemplate documento = new DocumentoTexto();
            documento.TemplateMethod();
        }

        //Visitor
        public void Visitor()
        {
            ObjectGuard guard = new ObjectGuard();
            AbstractVisitor visitor = new ConcreteVisitor();

            guard.Attach(new ConcreteElement1());
           guard.Attach(new ConcreteElement2());
            guard.Notify(visitor);
        }

        //Delegates
        public void Delegates()
        {
            Pedido pedido = new Pedido();

            #if Simples
            pedido.Fechar += new FecharNotify(Fechamento);

            #elif Anonimo
            pedido.Fechar += delegate (double valor,double juros)
              {
                  return valor += (valor * juros);
              };

            #elif Lambda
            pedido.Fechar += (valor, juros) => (valor += (valor * juros));
            #endif

            pedido.Pagar(10, 1);
            
        }

        //Action
        public void Action()
        {
            ActionTeste action = new ActionTeste();
            action.action(1, 2);
        }

        //Func
        public void Func()
        {
            FuncTeste func = new FuncTeste();
            Console.WriteLine(func.func(1, 2));
        }

        //Metodo Extensao
        public void Extensao()
        {
            string conexao = "joao";
            conexao.URL();
        }

        //StringWriter e StringReader
        public void WriterReader()
        {
            WriterReader wr = new WriterReader();
            wr.Executar();
        }

        //ObjectPool
        public void ObjectPool()
        {
            try
            {
                var factory = ObjectPool<SqlPool>.Instance;
                var sql1 = factory.GetObject();
                var sql2 = factory.GetObject();
                var sql3 = factory.GetObject();
                //factory.Release(sql3);
                var sql4 = factory.GetObject();
            }catch(PoolException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //DriveInfo
        public void DriveInfo()
        {
            DriveInfoTeste teste = new DriveInfoTeste();
            teste.Executar();
        }

        //ZipFile
        public void ZipFile()
        {
            ZipFileTeste zip = new ZipFileTeste();
            zip.Executar();
        }

        //Passagem Parametros
        public void Parametros()
        {
            Passagem passagem = new Passagem();
            int x = 5;
            //passagem.Out(out x);
            //passagem.Ref(ref x);
            passagem.In(x);
            //Console.WriteLine("Out "+x);
            //Console.WriteLine("Ref " + x);
            Console.WriteLine("In "+x);
        }

        //Arquivo StreamReader e FileReader
        public void Arquivos()
        {
            Arquivos arquivos = new Arquivos();
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(3+ " "+"Lucas");
            //sb.AppendLine(3+ " "+ "Jorge");
            
            arquivos.SalvarArquivo("logs23.txt", "Ola Mundo");
            //arquivos.LerArquivo("logs2.txt");
        }



        public void Metodo(int index)
        {
            Action resultado = (index >= _list.Count) ? _list[0] : _list[index];
            resultado.Invoke();
        }

        public void Show(Type type)
        {
            int i = 0;


            foreach (var item in type.GetMethods())
            {
                if (i < _list.Count())
                {
                    Console.WriteLine(i + ") " + item.Name);
                    i++;
                }

            }
        }
    }
}
