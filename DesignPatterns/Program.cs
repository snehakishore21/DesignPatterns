using DesignPatterns.AbstractFactory;
using DesignPatterns.Decorator;
using DesignPatterns.Observer;
using DesignPatterns.Command;
using DesignPatterns.Proxy;
using DesignPatterns.Momento;
using DesignPatterns.Iterator;
using DesignPatterns.Facade;
using DesignPatterns.Visitor;
using DesignPatterns.Composite;
using DesignPatterns.Interpretor;
using DesignPatterns.Interpretor2;
using DesignPatterns.Singleton;
using DesignPatterns.State;

namespace Declaring_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandPattern();
            StatePattern();
            SingletonDoubleCheckedLocking.GetInstance();
            SingletonEager.GetInstance();
            SingletonLazy.GetInstance();
            SingletonSynchronized.GetInstance();

            ObserverPattern();
            AbstractFactoryPattern();
            DecoratorPattern();
            
            ProxyPattern();
            MomentoPattern();
            IteratorPattern();
            FacadePattern();
            VisitorPattern();
            CompositePattern();
            InterpretorPattern();
            InterpretorPattern2();

            //Topics completed:Visitor,Iterator,Mediator,Builder,Adapter,Strategy,Factory,Singleton,Memento,Prototype,Bridge,Proxy,Facade,Composite,Interpreter
            //Topics left: State,Flyweight
            //Topics for day after day after tomorrow: Single Responsibility, Open closed, Liskov substitution, Interface segregation, Dependency inversion

            //3 major design patterns: Creational, Structural, Behavioral
            //Creational: Singleton, Factory, Abstract Factory, Builder, Prototype
            //Structural: Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy
            //Behavioral: Chain of Responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template, Visitor

            //Asynchronous programming types/concepts
            //1. Asynchronous programming model (APM) - BeginXXX and EndXXX
            //2. Event based asynchronous pattern (EAP) - EventXXX
            //3. Task based asynchronous pattern (TAP) - TaskXXX
            //4. Dataflow pattern - DataflowXXX
            //5. Async/Await pattern - async/await keywords
            //6. Reactive programming - Reactive Extensions (Rx)
            //7. Parallel programming - Parallel Extensions (PLINQ)
            //8. Asynchronous streams - IAsyncEnumerable<T> and IAsyncEnumerator<T>
            //9. Asynchronous disposable - IAsyncDisposable
            //10. Asynchronous sockets - SocketAsyncEventArgs
            //11. Asynchronous file operations - FileStream, StreamReader, StreamWriter, etc.
            //12. Asynchronous database operations - ADO.NET, Entity Framework, etc.
            //13. Asynchronous web operations - HttpClient, ASP.NET, etc.
            //14. Asynchronous UI operations - Windows Forms, WPF, etc.
            //15. Asynchronous streams - IAsyncEnumerable<T> and IAsyncEnumerator<T>
        }

        private static void StatePattern()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddProducts(new List<Product> { new Product(1, "Coke", 10), new Product(2, "Pepsi", 20), new Product(3, "Fanta", 30) });

            VendingMachineActor vendingMachineActor = new VendingMachineActor(vendingMachine);
            vendingMachineActor.PressOn();
            vendingMachineActor.InsertCoin(10);
            vendingMachineActor.SelectProduct(1);
            vendingMachineActor.RefundCancel();
            vendingMachineActor.InsertCoin(20);
            vendingMachineActor.SelectProduct(2);
            vendingMachineActor.GetProduct();
            vendingMachineActor.Change();
        }

        private static void InterpretorPattern2()
        {
            Context2 context = new Context2(1, 2);
            IExpressionInter expression = new AddExpression(new NumberValue(context.Input2), new SubtractExpression(new NumberValue(context.Input2), new NumberValue(context.Input)));
            int val = expression.Evaluate(context);
            Console.WriteLine(val);
        }

        private static void InterpretorPattern()
        {
            Context context = new Context("Hello World", "Lower");
            
            //One way of doing it
            switch (context.Expression)
            {
                case "Lower":
                    IExpressionInterpretor expression = new LowerExpression();
                    Console.WriteLine(expression.Interpret(context));
                    break;
                case "Upper":
                    expression = new UpperExpression();
                    Console.WriteLine(expression.Interpret(context));
                    break;
            }

            //Another way of doing it
            IExpressionInterpretor expression2 = new UpperExpression();
            string result = expression2.Interpret(context);
            Console.WriteLine(result);
        }

        private static void CompositePattern()
        {
            IExpression expression  = new ArithmeticExpression(new Number(5), new Number(10), '+');  
            int n1 =  expression.Evaluate();
            Console.WriteLine(n1);

            expression = new ArithmeticExpression(new ArithmeticExpression(new Number(8), new ArithmeticExpression(new Number(5), new Number(10), '*'),'-'), new Number(10), '+');
            int n2 = expression.Evaluate();
            Console.WriteLine(n2);
        }

        private static void VisitorPattern()
        {
            IVisitor visitor = new RoomPriceVisitor();
            IVisitor visitor2 = new RoomMaintenanceVisitor();
            IRoom room = new RoomDeluxe();
            room.Accept(visitor);
            room.Accept(visitor2);
            Console.WriteLine(room.Price);

            room = new RoomSuite();
            room.Accept(visitor);
            room.Accept(visitor2);
            Console.WriteLine(room.Price);

            room = new RoomEco();
            room.Accept(visitor);
            room.Accept(visitor2);
            Console.WriteLine(room.Price);
        }

        private static void FacadePattern()
        {
            Facade facadePattern = new Facade();
            facadePattern.ChooseProducts();
            facadePattern.PlaceOrder();
            facadePattern.TrackOrder();
        }

        private static void IteratorPattern()
        {
            IAggregate aggregate = new ConcreteAggregate();
            aggregate.Add("item1");
            aggregate.Add("item2");
            aggregate.Add("item3");
            aggregate.Add("item4");
            aggregate.Add("item5");

            IIterator iterator = aggregate.GetIterator();

            string item = iterator.Next();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }

            aggregate.ReverseDirection();
            iterator = aggregate.GetIterator();
            item = iterator.Next();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }
        }

        private static void MomentoPattern()
        {
            Caretaker caretaker = new Caretaker();

            Originator originator = new Originator("state1");
            Momento m1 = originator.CreateMomento();
            caretaker.Add(m1);

            originator.SetState("state2");
            Momento m2 = originator.CreateMomento();
            caretaker.Add(m2);

            originator.SetState("state3");
            Momento m3 = originator.CreateMomento();
            caretaker.Add(m3);

            Momento m = caretaker.Undo();
            Console.WriteLine(m.State);
            m = caretaker.Undo();

            Console.WriteLine(originator.State);
            originator.RestoreMomento(m);
            Console.WriteLine(originator.State);
        }

        private static void ProxyPattern()
        {
            IProxy proxy = new Proxy1();  
            proxy.Create("admin");
            proxy.DoSomething("admin");
            proxy.Get("admin");
        }

        private static void CommandPattern()
        {
            Calculator calculator = new Calculator();   
            double r = calculator.Execute(new AddCommand(90));
            Console.WriteLine(r);
            r = calculator.Execute(new SubCommand(20));
            Console.WriteLine(r);
            r = calculator.Execute(new MulCommand(90));
            Console.WriteLine(r);
            r = calculator.Execute(new DivCommand(90));
            Console.WriteLine(r);

            r = calculator.Undo();
            Console.WriteLine(r);
            r = calculator.Undo();
            Console.WriteLine(r);
            r = calculator.Undo();
            Console.WriteLine(r);
            r = calculator.Undo();
            Console.WriteLine(r);
        }

        private static void DecoratorPattern()
        {
            GetPizzaDetails();
        }

        private static void GetPizzaDetails()
        {
            IPizza pizza = new Farmhouse();
            pizza = new MushroomTopping(pizza);
            pizza = new ExtraCheeseTopping(pizza);
            Console.WriteLine(pizza.GetDetails() + "\nPrice:" + pizza.GetPrice());

            pizza = new ExtraCheeseTopping(pizza);
            Console.WriteLine(pizza.GetDetails() + "\nPrice:" + pizza.GetPrice());
        }

        private static void AbstractFactoryPattern()
        {
            Console.WriteLine("Luxury Vehicles: ");
            GetAvailableVehicleDetails("Luxury");

            Console.WriteLine("Affordable Vehicles: ");
            GetAvailableVehicleDetails("Affordable");
        }

        private static void GetAvailableVehicleDetails(string range)
        {
            VehicleFactoryClient vehicleFactoryClient = new VehicleFactoryClient();

            IVehicleFactory v1 = vehicleFactoryClient.GetVehicleFactory(range);
            vehicleFactoryClient.VehicleFactoryClientTest(v1);
        }

        private static void ObserverPattern()
        {
            Console.WriteLine("Start observer pattern");

            StockObservable iphone = new IphoneObservable();
            StockObservable fridge = new FridgeObservable();

            new EmailNotificationObserver("email", iphone);
            new MobileNotificationObserver("mobile", iphone);


            new EmailNotificationObserver("email2", fridge);
            new MobileNotificationObserver("mobile2", fridge);

            iphone.Setter(1);
            fridge.Setter(0);
        }
    }
}