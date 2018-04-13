---
layout: post
title: "用C#实现设计模式"
description: "用C# 和 .NET CORE 框架实现设计模式"
categories: [C#]
tags: [C#]
redirect_from:
  - /2018/04/11/
---

## 用C# 和 .NET CORE 框架实现设计模式

>以下是使用*C# dotnet core*编写的设计模式

## Requirement

*确保已经安装了netcore sdk*  [.NET Core](https://dotnet.github.io/)

>git clone https://github.com/Peefy/DotNetCore.DesignPatternByCSharp

>cd DotNetCore.DesignPatternByCSharp

>dotnet run

## 分类

### *创建者模式*

* *工厂模式*

```csharp

    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public Circle()
        {
            Console.WriteLine($"{nameof(Circle) } construtor");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Circle) } call draw");
        }
    } 

    public class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine($"{nameof(Rectangle) } construtor");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Rectangle) } call draw");
        }
    }

    public class Square : IShape
    {
        public Square()
        {
            Console.WriteLine($"{nameof(Square) } construtor");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Square) } call draw");
        }
    }

    public class ShapeFactory
    {
        public ShapeFactory()
        {
        }

        public IShape GetShape(string shapeName)
        {
            if(string.IsNullOrEmpty(shapeName) == true)
                throw new NullReferenceException(nameof(shapeName));
            switch(shapeName)
            {
                case nameof(Square) : 
                    return new Square();
                case nameof(Rectangle): 
                    return new Rectangle();
                case nameof(Circle): 
                    return new Circle();
                default: return null;
            }
        }

        public static void Test()
        {
            var factory = new ShapeFactory();
            var circle = factory.GetShape(nameof(Circle));
            circle.Draw();
            var rec = factory.GetShape(nameof(Rectangle));
            rec.Draw();
            var square = factory.GetShape(nameof(Square));
            square.Draw();
        }

    }

```

* *抽象工厂模式*

```csharp

    public interface IColor
    {
        void Fill();
    }

    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::blue::fill() method");
        }
    }

    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::green::fill() method");
        }
    }

    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside::red::fill() method");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }

    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            switch(choice)
            {
                case "Color" : return new ColorFactory();
                case "Shape" : return new ShapeFactory();
                default : return null;
            }
        }

        public static void Test()
        {
            var producer = GetFactory("Color");
            producer.GetColor(nameof(Red)).Fill();
            producer.GetColor(nameof(Green)).Fill();
            producer.GetColor(nameof(Blue)).Fill();
        }

    }

    public class ShapeFactory : AbstractFactory
    {
        public ShapeFactory()
        {
        }

        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }

```

* *单例模式*

```csharp

    public class SingleObject
    {
        private SingleObject()
        {

        }
        private static SingleObject _instance;

        public static SingleObject Instance =>
            _instance ?? (_instance = new SingleObject());

        public void ShowMessage()
        {
            Console.WriteLine("SingletonPattern test");
        }

    }

```

* *建造者模式*

```csharp

    public interface IPacking
    {
        string Pack();
    }

    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }

    public class Bottle : IPacking
    {
        public string Pack()
        {
           return "Bottle";
        }
    }

    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }

    public class VegBurger : Burger
    {
        public override float Price()
        {
            return 25.0f;
        }

        public override string Name()
        {
            return "Veg Burger";
        }

    }

    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return nameof(ChickenBurger);
        }

        public override float Price()
        {
            return 50.5f;
        }
    }

    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();

    }

    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return nameof(Coke);
        }

        public override float Price()
        {
            return 23.2f;
        }
    }

    public class Meal
    {
        private List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public float Cost
        {
            get
            {
                var cost = 0.0f;
                foreach(var item in _items)
                {
                    cost += item.Price();
                }
                return cost;
            }
        }

        public void ShowItems()
        {
            foreach(var item in _items)
            {
                Console.Write("Item :" + item.Name());
                Console.Write(",Packing : " + item.Packing().Pack());
                Console.WriteLine(",Price : " + item.Price());
            }
        }

    }

    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }

    }

    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return nameof(Pepsi);
        }

        public override float Price()
        {
            return 35.0f;
        }
    }

```

* *原型模式*

```csharp

    public class ShapeCache
    {
        private static Dictionary<string,IShape> _shapeMap
            = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeId)
        {
            if(_shapeMap.TryGetValue(shapeId,out var shape) == true)
                return shape;
            return null;
        }

        public static void LoadCache()
        {
            _shapeMap.Add(nameof(Circle),new Circle());
            _shapeMap.Add(nameof(Rectangle),new Rectangle());
            _shapeMap.Add(nameof(Square),new Square());
        }

    }

    public static class PrototypeDemo
    {
        public static void Test()
        {
            Console.WriteLine("原型模式测试");
            ShapeCache.LoadCache();
            Console.WriteLine("Shape: " + 
                ShapeCache.GetShape(nameof(Circle)).GetType());
            Console.WriteLine("Shape: " + 
                ShapeCache.GetShape(nameof(Rectangle)).GetType());
            Console.WriteLine("Shape: " + 
                ShapeCache.GetShape(nameof(Square)).GetType());
            Console.WriteLine("");
        }
    }

```

### *结构型模式*

* *适配器模式*

```csharp

    ///<summary>
    /// 适配器模式使得原本由于接口
    /// 不兼容而不能一起工作的那些类可以一起工作。
    ///</summary>
    public interface IMediaPlayer
    {
        void Play(string audioType,string fileName);
    }

    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }

    public static class AdapterPatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("适配器模式测试...");
            var audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3","beyond the horizon.mp3");
            audioPlayer.Play("mp4","alone.mp4");
            audioPlayer.Play("vlc","far far away.vlc");
            audioPlayer.Play("avi","mind me.avi");
            Console.WriteLine("");
        }
    }

    public class AudioPlayer : IMediaPlayer
    {
        public void Play(string audioType, string fileName)
        {
            if(audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if(audioType == "vlc" || audioType == "mp4")
            {
                var mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType,fileName);
            }
            else
            {
                Console.WriteLine("Invalid media type!" + audioType 
                    + " type is not supported");
            }
        }
    }

    public class MediaAdapter : IMediaPlayer
    {

        IAdvancedMediaPlayer _advanceMediaPlayer;

        public MediaAdapter(string audioType)
        {          
            switch(audioType)
            {
                case "vlc": 
                    _advanceMediaPlayer = new VlcPlayer();
                    break;
                case "mp4": 
                    _advanceMediaPlayer = new Mp4Player();
                    break;
                default :
                    throw new Exception(audioType + "is not find");
            }
        }

        public void Play(string audioType, string fileName)
        {
            if(string.IsNullOrEmpty(audioType) 
                && string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException();
            }
            if(_advanceMediaPlayer == null)
                throw new ArgumentNullException();
            switch(audioType)
            {
                case "vlc": 
                    _advanceMediaPlayer.PlayVlc(fileName);
                    break;
                case "mp4": 
                    _advanceMediaPlayer.PlayMp4(fileName);
                    break;
                default :
                    throw new Exception(audioType + "is not find");
            }
        }
    }

    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name: {fileName}");
        }
    }

    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 file. Name: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
            
        }
    }

```

* *桥接模式*

```csharp

    public interface IDrawApi
    {
        void DrawCircle(int radius, int x,int y);
    }

    public class RedCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + 
                + radius +", x: " + x +", "+ y + "]");
        }
    }

    public class GreenCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + 
                + radius +", x: " + x +", "+ y + "]");
        }
    }

    public abstract class Shape
    {
        protected IDrawApi _drawApi;
        protected Shape(IDrawApi drawApi)
        {
            this._drawApi = drawApi;
        }
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        private int _x, _y, _radius;
        public Circle(int x, int y, int radius, IDrawApi drawApi) : base(drawApi)
        {
            this._x = x;
            this._y = y;
            this._radius = radius;
        }

        public override void Draw()
        {
            this._drawApi.DrawCircle(_radius, _x, _y);
        }
    }

    public static class BridgePatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("桥接模式测试");
            var redCircle = new Circle(100,101,10,new RedCircle());
            var greenCircle = new Circle(100,101,10,new GreenCircle());
            redCircle.Draw();
            greenCircle.Draw();
            Console.WriteLine("");
        }
    }

```

* *过滤器模式*

```csharp

    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }

    public class AndCriteria : ICriteria
    {

        ICriteria _criteria;
        ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this._criteria = criteria;
            this._otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaPersons = _criteria.MeetCriteria(persons);
            return _otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }

    public class CriteriaFemale : ICriteria
    {

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var femalePersons = new List<Person>();
            foreach(var person in persons)
            {
                if(person.Gender == "Female")
                    femalePersons.Add(person);
            }
            return femalePersons;
        }
    }

    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var malePersons = new List<Person>();
            foreach(var person in persons)
            {
                if(person.Gender == "Male")
                    malePersons.Add(person);
            }
            return malePersons;
        }
    }

    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var singlePersons = new List<Person>();
            foreach(var person in persons)
            {
                if(person.Gender == "Single")
                    singlePersons.Add(person);
            }
            return singlePersons;
        }
    }

    public partial class OrCriteria : ICriteria
    {

        ICriteria _criteria;
        ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this._criteria = criteria;
            this._otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaItems = _criteria.MeetCriteria(persons);
            var otherCriteriaItems = _otherCriteria.MeetCriteria(persons);
            foreach(var person in otherCriteriaItems)
            {
                if(!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }

    }

    public class Person
    {
        string _name = "";
        string _gender = "";
        string _maritialStatus = "";

        public Person(string name, string gender, string maritialStatus)
        {
            _name = name;
            _gender = gender;
            _maritialStatus = maritialStatus;
        }

        public string Name => _name;
        public string Gender => _gender;
        public string MaritialStatus => _maritialStatus;

    }

    public static class FilterPatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("滤波器模式测试...");
            var persons = new List<Person>();
            persons.Add(new Person("Rebort","Male","Single"));
            persons.Add(new Person("John","Male","Married"));
            persons.Add(new Person("Laura","Female","Single"));
            persons.Add(new Person("Rebort","Female","Single"));
            persons.Add(new Person("Mike","Male","Single"));
            persons.Add(new Person("Bobby","Male","Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            PrintPersons(male.MeetCriteria(persons));
            Console.WriteLine("Females: ");
            PrintPersons(female.MeetCriteria(persons));
            Console.WriteLine("Single Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));
            Console.WriteLine("Single Or Females");
            PrintPersons(singleOrFemale.MeetCriteria(persons));
            Console.WriteLine("");
        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach(var person in persons)
            {
                 Console.WriteLine("Person : [ Name : " + person.Name
                    +", Gender : " + person.Gender 
                    +", Marital Status : " + person.MaritialStatus
                    +" ]");
            }
        }

    }

```

* *组合模式*

```csharp

    public class Employee
    {
        string _name = "";
        string _dept = "";
        int _salary;
        List<Employee> _subordinates;

        public Employee(string name, string dept, int sal)
        {
            _name = name;
            _dept = dept;
            _salary = sal;
            _subordinates = new List<Employee>();
        }

        public void Add(Employee e) => _subordinates.Add(e);

        public void Remove(Employee e) => _subordinates.Remove(e);

        public List<Employee> Subordinates => _subordinates;

        public override string ToString()
        {
            return ("Employee :[ Name : " + _name
                + ", dept : " + _dept + ", salary :"
                + _salary + " ]");
        }

    }

    public static class CompositePattern
    {
        public static void Test()
        {
            Console.WriteLine("组合模式测试");
            var CEO = new Employee("DuGu","CEO",30000);
            var headSales = new Employee("Robert","Head Sales", 20000);
            var headMarket = new Employee("John", "Head Sales", 20000);
            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);
            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);
            CEO.Add(headSales);
            CEO.Add(headMarket);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarket.Add(clerk1);
            headMarket.Add(clerk2);

            headMarket.Add(clerk1);
            headMarket.Add(clerk2);

            Console.WriteLine(CEO);

            foreach(var headEmployee in CEO.Subordinates)
            {
                Console.WriteLine(headEmployee);
                foreach(var employee in headEmployee.Subordinates)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("");
        }
    }

```

* *装饰器模式*

```csharp

    public interface IShape
    {
        void Draw();
    }

    public abstract class ShapeDecorator : IShape
    {

        protected IShape _decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            this._decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            _decoratedShape.Draw();

        }

    }

    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        { }

        public override void Draw()
        {
            base.Draw();
            this.SetRedBorder(_decoratedShape);
        }

        public void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }

    }

    public static class DecoratorPatternDemo
    {
        public static void Test()
        {
            var circle = new Circle();
            var redCircle = new RedShapeDecorator(circle);
            var redRectangle = new RedShapeDecorator(new Rectangle());
            circle.Draw();
            redCircle.Draw();
            redRectangle.Draw();
        }

    }

```

* *外观模式*

```csharp

    public class ShapeMaker
    {
        private IShape _circle;
        private IShape _rectangle;
        private IShape _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle() 
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }

    }

    public static class FacadePatternDemo
    {
        public static void Test()
        {
            var shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }

```

* *享元模式*

```csharp

    public static class FlyWeightPatternDemo
    {

        static string[] colors = { "red", "green", "blue", "white" };

        static string RandomColor => colors[(int)(new Random().Next(0,colors.Length))];

        static int RandomX => (int)(new Random().Next(0,100));
        static int RandomY => (int)(new Random().Next(0,100));

        public static void Test()
        {
            Console.WriteLine("享元模式测试...");
            for (var i = 0; i < 20; ++i)
            {
                var circle = ShapeFactory.GetCircle(RandomColor) as RadiusCircle;
                circle.SetX(RandomX);
                circle.SetY(RandomY);
                circle.SetRadius(100);
                circle.Draw();
            }
            Console.WriteLine("");
        }
    }

    public class RadiusCircle : Circle
    {

        string _color = "";
        int _x;
        int _y;
        int _radius;

        public RadiusCircle()
        {
        }
        public RadiusCircle(string color)
        {
            _color = color;
        }

        public void SetX(int x) => _x = x;
        public void SetY(int y) => _y = y;
        public void SetRadius(int radius) => _radius = radius;

        public override void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + _color
                + ", x : " + _x + ", y :" + _y + ", radius :" + _radius);
        }

    }

    public class ShapeFactory
    {
        static Dictionary<string, IShape> _circleMap =
            new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            if (_circleMap.TryGetValue(color, out var shape) == true)
            {
                return shape;
            }
            var circle = new RadiusCircle(color);
            _circleMap.Add(color, circle);
            Console.WriteLine("Creating circle of color : " + color);
            return circle;
        }

    }

```

* *代理模式*

```csharp

    public interface IImage
    {
        void Display();
    }

    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            this._fileName = fileName;
        }

        public void Display()
        {
            if(_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }

    public class RealImage : IImage
    {
        private string _fileName = "";

        public RealImage(string fileName)
        {
            this._fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Display " + _fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }

    public static class ProxyPatternDemo 
    {
        public static void Test()
        {
            Console.WriteLine("代理模式测试...");
            var image = new ProxyImage("temp.jpg");
            image.Display();
            Console.WriteLine("");
            image.Display();
            Console.WriteLine("");
        }
    }

```


### *行为型模式*

* *责任链模式*

```csharp

    public abstract class AbstractLogger
    {
        public const int Info = 1;
        public const int Debug = 2;

        public const int Error = 3;

        protected int _level;

        protected AbstractLogger _nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            _nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if(_level <= level)
            {
                Write(message);
            }
            if(_nextLogger != null)
            {
                _nextLogger.LogMessage(level, message);
            }
        }

        public abstract void Write(string message);

    }

    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this._level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("Stadard Console::Logger: " + message);
        }
    }

    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this._level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }

    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this._level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }

    public static class ChainPatternDemo
    {

        private static AbstractLogger ChainOfLoggers
        {
            get
            {
                var errorLogger = new ErrorLogger(AbstractLogger.Error);
                var fileLogger = new FileLogger(AbstractLogger.Debug);
                var consoleLogger = new ConsoleLogger(AbstractLogger.Info);
                errorLogger.SetNextLogger(fileLogger);
                fileLogger.SetNextLogger(consoleLogger);
                return errorLogger;
            }
        }

        public static void Test()
        {
            Console.WriteLine("责任链模式测试...");
            var loggerChain = ChainOfLoggers;
            loggerChain.LogMessage(AbstractLogger.Info, "this is an info");
            loggerChain.LogMessage(AbstractLogger.Debug, "this is an debug info");
            loggerChain.LogMessage(AbstractLogger.Error, "this is an error info");
            Console.WriteLine("");
        }
    }

```

* *命令模式*

```csharp

    public class Broker
    {
        private List<IOrder> _orderList = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            _orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(var order in _orderList)
            {
                order.Execute();
            }
            _orderList.Clear();
        }

    }

    public interface IOrder
    {
        void Execute();
    }

    public class BuyStock : IOrder
    {
        private Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            this._abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }

    public class SellStock : IOrder
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            this._abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }

    public class Stock
    {
        private string _name = "ABC";
        private int _quantity = 10;
        public void Buy()
        {
            Console.WriteLine($"Stock [ Name : {_name} , Quantity: {_quantity} ]"
               + " bought");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock [ Name : {_name} , Quantity: {_quantity} ]"
               + " sold");
        }

    }

    public static class CommandPatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("命令模式测试...");
            var abcStock = new Stock();
            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);
            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);
            broker.PlaceOrders();
            Console.WriteLine(""); 
        }
    }

```

* *解释器模式*

```csharp

    public interface IExpression
    {
        bool Interpret(string context);
    }

    public static class InterpreterPatternDemo
    {
        static IExpression MaleExpression
        {
            get
            {
                IExpression robert = new TerminalExpression("Robert");
                IExpression john = new TerminalExpression("John");
                return new OrExpression(robert, john);
            }
        }

        static IExpression MarriedWomanExpression
        {
            get
            {
                var julie = new TerminalExpression("Julie");
                var married = new TerminalExpression("Married");
                return new AndExpression(julie, married);
            }
        }

        public static void Test()
        {
            Console.WriteLine("解释器模式测试");
            var isMale = MaleExpression;
            var isMarriedWoman = MarriedWomanExpression;
            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is married women? " 
                + isMarriedWoman.Interpret("Married Julie"));
            Console.WriteLine("");
        }

    }

    public class AndExpression : IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public bool Interpret(string context) => _expr1.Interpret(context) &&
                _expr2.Interpret(context);
    }

    public class OrExpression : IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public bool Interpret(string context) => _expr1.Interpret(context) ||
                _expr2.Interpret(context);
    }

    public class TerminalExpression : IExpression
    {
        string _data = "";

        public TerminalExpression(string data)
        {
            this._data = data;
        }

        public bool Interpret(string context) => context.Contains(_data);
    }

```

* *迭代器模式*

```csharp

    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    public interface IContainer
    {
        IIterator Iterator {get;}
    }

    public class NameRepository : IContainer , IIterator
    {
        int _index;
        public string[] Names = {"Rebort", "John", "Julie", "Lora"};

        public IIterator Iterator => this;

        public bool HasNext() => _index < Names.Length;

        public object Next() => HasNext() ? Names[_index++] : null;
    }

    public static class IteratorPatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("迭代器模式测试...");
            InternalTest();
            Console.WriteLine("");
        }

        private static void InternalTest()
        {
            var nameRepository = new NameRepository();
            for (var iterator = nameRepository.Iterator; iterator.HasNext();)
            {
                var name = iterator.Next() as string;
                Console.WriteLine("Name : " + name);
            }
        }
    }

```

* *中介者模式*

```csharp

    public class User
    {
        public string Name {get;set;} = "";
        public User(string name) => Name = name;

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }

    }

    public class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine(DateTime.Now + $"[{user.Name}] : {message}");
        }
    }

    public static class MediatorPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("中介者模式测试...");
            InternalRun();
            Console.WriteLine("");
        }

        private static void InternalRun()
        {
            var dugu = new User("dugu");
            var john = new User("John");
            dugu.SendMessage("Hello .NET Core!");
            john.SendMessage("Hello Mono C#!");
        }
    }

```

* *备忘录模式*

```csharp

    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }

    }

    public class Memento
    {
        public string State {get;}
        public Memento(string state)
        {
            State = state;
        }
    }

    public class Originator
    {
        public string State {get;set;}

        public Memento SaveStateToMemento() => new Memento(State);

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.State;
        }

    }

    public static class MementoPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("备忘录模式测试...");
            var originator = new Originator();
            var cakeTaker = new CareTaker();
            originator.State = "State #1";
            originator.State = "State #2";
            cakeTaker.Add(originator.SaveStateToMemento());
            originator.State = "State #3";
            cakeTaker.Add(originator.SaveStateToMemento());
            originator.State = "State #4";

            Console.WriteLine("Current State: " + originator.State);
            originator.GetStateFromMemento(cakeTaker.Get(0));
            Console.WriteLine("First Saved State: " + originator.State);
            originator.GetStateFromMemento(cakeTaker.Get(1));
            Console.WriteLine("Second saved State: " + originator.State);
            Console.WriteLine("");
        }
    }

```

* *观察者模式*

```csharp

    public abstract class Observer
    {
        protected Subject _subject;
        public abstract void Update(); 
    }

    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + 
                _subject.State.ToString());
        }
    }

    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + 
                _subject.State.ToString("X2"));
        }
    }

    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + 
                _subject.State.ToString());
        }
    }

    public class Subject
    {
        List<Observer> _observers = new List<Observer>();

        private int _state;
        public int State 
        {
            get => _state;
            set 
            {
                this._state = value;
                NotifyAllObservers();
            }
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Update();
            }
        }

    }

    public static class ObserverPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("观察者模式测试...");
            var subject = new Subject();
            var hex = new HexaObserver(subject);
            var oct = new OctalObserver(subject);
            var bin = new BinaryObserver(subject);

            Console.WriteLine("Fisrt State Change: 15");
            subject.State = 15;
            Console.WriteLine("Second State Change: 10");
            subject.State = 10;
            Console.WriteLine("");
        }
    }

```

* *状态模式*

```csharp

    public interface IBaseState
    {
        void DoAction(Context context);
    }

    public class Context
    {
        private IBaseState _state;

        public Context()
        {
            _state = null;
        }

        public void SetState(IBaseState state)
        {
            _state = state;
        }

        public IBaseState GetState()
        {
            return _state;
        }

    }

    public class StartState : IBaseState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return nameof(StartState);
        }

    }

    public class StopState : IBaseState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.SetState(this);    
        }

        public override string ToString()
        {
            return nameof(StopState);
        }

    }

    public static class StatePatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("状态模式测试...");
            var context = new Context();
            var startState = new StartState();
            startState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());
            var stopState = new StopState();
            stopState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());
            Console.WriteLine("");
        }
    }

```

* *空对象模式*

```csharp

    public abstract class AbstractCustomer
    {
        protected string _name;
        public abstract bool IsNil();

        public abstract string GetName();

    }

    public class CustomerFactory
    {
        public static string[] Names = {"Rob", "Joe", "Julie"};

        public static AbstractCustomer GetCustomer(string name)
        {
            for(var i = 0;i < Names.Length;i++)
            {
                if(name == Names[i])
                    return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }

    public class NullCustomer : AbstractCustomer
    {
        public NullCustomer()
        {
        }

        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNil()
        {
            return true;
        }
    }

    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this._name = name;
        }

        public override string GetName()
        {
           return _name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }

    public static class NullObjectPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("空对象模式测试...");
            var customer1 = CustomerFactory.GetCustomer("Rob");
            var customer2 = CustomerFactory.GetCustomer("Joe");
            var customer3 = CustomerFactory.GetCustomer("Julie");
            var customer4 = CustomerFactory.GetCustomer("DuGu");
            Console.WriteLine("Customers");
            Console.WriteLine("customer1 : " + customer1.GetName());
            Console.WriteLine("customer2 : " + customer2.GetName());
            Console.WriteLine("customer3 : " + customer3.GetName());
            Console.WriteLine("customer4 : " + customer4.GetName());
            Console.WriteLine("");
        }
    }

```

* *策略模式*

```csharp

    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }

    public class Context
    {
        IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int ExcuteStrategy(int num1, int num2)
        {
            return this._strategy.DoOperation(num1, num2);
        }

    }

    public class OperationAdd : IStrategy
    {

        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class OperationMultiply : IStrategy
    {

        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class OperationSubstract : IStrategy
    {

        public int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    public static class StrategyPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("策略模式测试...");
            var context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExcuteStrategy(10, 5));
            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.ExcuteStrategy(10, 5));
            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExcuteStrategy(10, 5));
            Console.WriteLine("");
        }
    }

```

* *模板模式*

```csharp

    public class Cricket : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine($"{nameof(Cricket)} Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine($"{nameof(Cricket)} Game Init! Start Playing");
        }

        public override void StartPlay()
        {
            Console.WriteLine($"{nameof(Cricket)} Game Started! Enjoy the game!");
        }
    }

    public class Football : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine($"{nameof(Football)} Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine($"{nameof(Football)} Game Init! Start Playing");
        }

        public override void StartPlay()
        {
            Console.WriteLine($"{nameof(Football)} Game Started! Enjoy the game!");
        }
    }

    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        public virtual void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }

    }

    public static class TemplatePatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("模板模式测试...");
            Game game = new Cricket();
            game.Play();
            Console.WriteLine("");
            game = new Football();
            game.Play();
            Console.WriteLine("");
        }
    }

```

* *访问者模式*

```csharp

    public interface IComputerPart
    {
        void Accept(IComputerVisitor computerVisitor);
    }

    public interface IComputerVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }

    public class Computer : IComputerPart
    {

        IComputerPart[] _parts = 
        {
            new Mouse(), 
            new Keyboard(), 
            new Monitor()
        };

        public Computer()
        {
           
        }

        public void Accept(IComputerVisitor computerVisitor)
        {
            foreach(var part in _parts)
            {
                part.Accept(computerVisitor);
            }
            computerVisitor.Visit(this);
        }
    }

    public class ComputerDisplayVisitor : IComputerVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying " + nameof(Computer));
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying " + nameof(Mouse));
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying " + nameof(Keyboard));
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying " + nameof(Monitor));
        }
    }

    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }

    public class Monitor : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }

    public class Mouse : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }

    public static class VisitorPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("访问者模式测试...");
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerDisplayVisitor());
            Console.WriteLine("");
        }
    }

```

### *J2EE模式*

* *MVC模式*

```csharp

    public class Student
    {
        public string RollNo {get;set;} = "";
        public string Name {get;set;} = "";

    }

    public class StudentController
    {
        Student _model;
        StudentView _view;

        public StudentController(Student model, StudentView view)
        {
            this._model = model;
            this._view = view;
        }

        public string StudentName
        {
            get => _model.Name;
            set => _model.Name = value;
        }

        public string StudentRollNo
        {
            get => _model.RollNo;
            set => _model.RollNo = value;
        }

        public void UpdateView()
        {
            _view.PrintStudentDetails(_model.Name, _model.RollNo);
        }

    }

    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name : " + studentName);
            Console.WriteLine("Roll No : " + studentRollNo);
        }
    }

    public static class MVCPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("MVC模式测试...");
            var model = RetriveStudentFromDatabase();
            var view = new StudentView();
            var controller = new StudentController(model, view);
            controller.UpdateView();
            controller.StudentName = "John";
            controller.StudentRollNo = "12";
            controller.UpdateView();
            Console.WriteLine("MVC模式测试结束...");
        }

        private static Student RetriveStudentFromDatabase()
        {
            return new Student()
            {
                Name = "DuGu",
                RollNo = "10"
            };
        }
    }

```

* *业务代表模式*

```csharp

    public class BusinessDelegate
    {
        private BusinessLookUp _lookUpService = new BusinessLookUp();
        private IBusinessService _businessService;
        public string ServiceType {private get;set;}

        public void DoTask()
        {
            _businessService = _lookUpService.GetBusinessService(ServiceType);
            _businessService.DoProcessing();
        }

    }

    public class BusinessLookUp
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            if(string.IsNullOrEmpty(serviceType) == true)
                return null;
            if(serviceType == "EJB")
                return new EJBService();
            else
                return new JMSService();
        }
    }

    public class Client
    {
        BusinessDelegate _businessService;

        public Client(BusinessDelegate businessService)
        {
            this._businessService = businessService;
        }

        public void DoTask()
        {
            _businessService.DoTask();
        }
    }

    public class EJBService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("processing task by invoking EJB Service");
        }
    }

    public interface IBusinessService
    {
        void DoProcessing();
    }

    public class JMSService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("processing task by invoking JMS Service");
        }
    }

    public static class BusinessDelegatePatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("业务代表模式测试...");
            var businessDelegate = new BusinessDelegate();
            businessDelegate.ServiceType = "EJB";
            var client = new Client(businessDelegate);
            client.DoTask();
            businessDelegate.ServiceType = "JMS";
            client.DoTask();
            Console.WriteLine("业务代表模式测试结束");
        }
    }

```

* *组合实体模式*

```csharp

    public class Client
    {
        CompositeEntity compositeEntity = new CompositeEntity();

        public void PrintData()
        {
            for(int i = 0;i < compositeEntity.GetData().Length ; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.GetData()[i]);
            }
        }

        public void SetData(string data1, string data2)
        {
            compositeEntity.SetData(data1, data2);
        }

    }

    public class CoarseGrainedObject
    {
        DependencyObject1 do1 = new DependencyObject1();
        DependencyObject2 do2 = new DependencyObject2();

        public void SetData(string data1, string data2)
        {
            do1.Data = data1;
            do2.Data = data2;
        }

        public string[] GetData() => new string[]
            {
                do1.Data,
                do2.Data
            };

    }

    public class CompositeEntity
    {
        CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void SetData(string data1, string data2) => cgo.SetData(data1, data2);

        public string[] GetData() => cgo.GetData();

    }

    public class DependencyObject1
    {
        public string Data {get;set;}
    }

    public class DependencyObject2
    {
        public string Data {get;set;}
    }

    public static class CompositeEntityPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("组合实体模式测试...");
            var client = new Client();
            client.SetData("Test", "John");
            client.PrintData();
            client.SetData("Second Test", "Data1");
            client.PrintData();
            Console.WriteLine("组合实体模式测试结束...");
        }
    }

```

* *数据访问对象模式*

```csharp



    public interface IStudentDao
    {
        List<Student> GetAllStudents();
    }

    public class Student
    {
        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }

        public string Name {get;set;}
        public int RollNo {get;set;}
    }

    public class StudentDaoImp1 : IStudentDao
    {

        List<Student> students;

        public StudentDaoImp1()
        {
            students = new List<Student>();
            var student1 = new Student("Robert", 0);
            var student2 = new Student("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(Student student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine("Student: Roll No " + student.RollNo + 
                ", deleted from database");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(Student student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo + 
                ", updated from database");
        }
    }

    public static class DataAccessObjectPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("数据访问对象模式测试...");
            var studentDao = new StudentDaoImp1();
            foreach(var student in studentDao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + 
                    student.RollNo + ", Name : " + student.Name + " ]");
            }
            var student0 = studentDao.GetAllStudents()[0];
            student0.Name = "DuGu";
            studentDao.UpdateStudent(student0);

            var student1 = studentDao.GetStudent(0);
            Console.WriteLine("Student: [RollNo : "
                +student1.RollNo +", Name : "+student1.Name +" ]"); 

            Console.WriteLine("数据访问对象模式测试结束");
        }
    }

```

* *前端控制器模式*

```csharp

    public interface IViewAction
    {
        void Show();
    }

    public abstract class BaseView : IViewAction
    {
        public abstract void Show();
    }

    public class Dispatcher
    {
        StudentView studentView;
        HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if(string.Equals(request, "Student", 
                StringComparison.OrdinalIgnoreCase))
            {
                studentView.Show();
            }
            else
                homeView.Show();
        }

    }    

    public class FrontController
    {
        Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool IsAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        public void TrackRequest(string request)
        {
            Console.WriteLine("Page requested: " + request);
        }

        public void DispatchRequest(string request)
        {
            TrackRequest(request);
            if(IsAuthenticUser())
            {
                dispatcher.Dispatch(request);
            }
        }

    }

    public class HomeView : BaseView
    {

        public override void Show()
        {
            Console.WriteLine("Displaying Home Page");
        }
    }

    public class StudentView : BaseView
    {
        public override void Show()
        {
            Console.WriteLine("Displaying Student Page");
        }
    }

    public class FrontControllerPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("前端控制器模式测试...");
            var frontController = new FrontController();
            frontController.DispatchRequest("Home");
            frontController.DispatchRequest("Student");
            Console.WriteLine("前端控制器模式测试结束");
        }
    }

```

* *拦截过滤器模式*

```csharp

    public interface IFilter
    {
        void Excute(string request);
    }

    public class AuthenticationFilter : IFilter
    {
        public void Excute(string request)
        {
            Console.WriteLine("Authenticating request: " + request);
        }
    }

    public class Client
    {
        FilterManager filterManager;

        public void SetFilterManager(FilterManager filterManager) => 
            this.filterManager = filterManager;

        public void SendRequest(string request)
        {
            filterManager.filterRequest(request);
        }

    }

    public class DebugFilter : IFilter
    {
        public void Excute(string request)
        {
            Console.WriteLine("request log: " + request);
        }
    }

    public class Target : IFilter
    {
        public void Excute(string request)
        {
            Console.WriteLine("Executing request: " + request);
        }
    }

    public class FilterChain
    {
        List<IFilter> filters = new List<IFilter>();
        Target target;

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Excute(string request)
        {
            foreach(var filter in filters)
            {
                filter.Excute(request);
            }
            target?.Excute(request);
        }

        public void SetTarget(Target target)
        {
            this.target = target;
        }

    }

   public class FilterManager
    {
        FilterChain filterChain;

        public FilterManager(Target target)
        {
            filterChain = new FilterChain();
            filterChain.SetTarget(target);
        }

        public void SetFilter(IFilter filter)
        {
            filterChain.AddFilter(filter);
        }

        public void filterRequest(string request)
        {
            filterChain.Excute(request);
        }

    }

    public class InterceptingFilterPatternDemo
    {
        public static void Run()
        {
            var filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());
            var client = new Client();
            client.SetFilterManager(filterManager);
            client.SendRequest("Home");
        }
    }

```

* *服务定位器模式*

```csharp

    public class InitialContext
    {
        public object Lookup(string jndiName)
        {
            if(string.Equals(jndiName, nameof(Service1), 
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else if(string.Equals(jndiName, nameof(Service2), 
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }

    public interface IService
    {
        string GetName();
        void Execute();
    }

    public class Service1 : IService
    { 
        public void Execute()
        {
            Console.WriteLine($"Executing {nameof(Service1)}");
        }

        public string GetName()
        {
            return nameof(Service1);
        }
    }

    public class Service2 : IService
    {
        public void Execute()
        {
            Console.WriteLine($"Executing {nameof(Service2)}");
        }

        public string GetName()
        {
            return nameof(Service2);
        }
    }

    public class ServiceCache
    {
        List<IService> services;

        public ServiceCache()
        {
            services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach(var service in services)
            {
                if(string.Equals(service.GetName(), serviceName, 
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Return cached " + serviceName +
                        "object");
                    return service;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            bool isExist = false;
            foreach(var service in services)
            {
                if(string.Equals(service.GetName(), newService.GetName(), 
                    StringComparison.OrdinalIgnoreCase))
                {
                    isExist = true;
                }
            }
            if(!isExist)
                services.Add(newService);
        }

    }

    public class ServiceLocator
    {
        private static ServiceCache cache = new ServiceCache();

        public static IService GetService(string jndiName)
        {
            var service = cache.GetService(jndiName);
            if(service != null)
                return service;
            var context = new InitialContext();
            var service1 = context.Lookup(jndiName) as IService;
            cache.AddService(service1);
            return service1;
        }

    }

    public static class ServiceLocatorPatternDemo
    {
        public static void Run()
        {
            var service = ServiceLocator.
                GetService(nameof(Service1));
            service.Execute();
            service = ServiceLocator.
                GetService(nameof(Service2));
            service.Execute();
            service = ServiceLocator.
                GetService(nameof(Service1));
            service.Execute();
            service = ServiceLocator.
                GetService(nameof(Service2));
            service.Execute();
        }
    }

```

* *传输对象模式*

```csharp

    public class StudentBO
    {
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            var student1 = new StudentVO("DuGu", 0);
            var student2 = new StudentVO("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(StudentVO student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine("Student: Roll No " 
                + student.RollNo +", deleted from database");
        }

        public List<StudentVO> GetAllStudents()
        {
            return students;
        }

        public StudentVO GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(StudentVO student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " 
                + student.RollNo +", updated in the database");
        }

    }

    public class StudentVO
    {
        public StudentVO(string name, int roolNo)
        {
            Name = name;
            RollNo = roolNo;
        }

        public string Name {get;set;}
        public int RollNo {get;set;}
    }

    public static class TransferObjectPatternDemo
    {
        public static void Run()
        {
            var studentBusinessObject = new StudentBO();
            foreach(var student in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
                    + student.RollNo+", Name : "+student.Name+" ]");
            }

            var student0 = studentBusinessObject.GetAllStudents()[0];
            student0.Name = "Michedl";
            studentBusinessObject.UpdateStudent(student0);
            student0 = studentBusinessObject.GetStudent(0);
            Console.WriteLine("Student: [RollNo : "
                    + student0.RollNo+", Name : "+student0.Name+" ]");
        }
    }

```

[Github Code](https://github.com/Peefy/DotNetCore.DesignPatternByCSharp)

