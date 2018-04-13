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
```

* *桥接模式*

```csharp
```

* *过滤器模式*

```csharp
```

* *组合模式*

```csharp
```

* *装饰器模式*

```csharp
```

* *外观模式*

```csharp
```

* *享元模式*

```csharp
```

* *代理模式*

```csharp
```


### *行为型模式*

* *责任链模式*

```csharp
```

* *命令模式*

```csharp
```

* *解释器模式*

```csharp
```

* *迭代器模式*

```csharp
```

* *中介者模式*

```csharp
```

* *备忘录模式*

```csharp
```

* *观察者模式*

```csharp
```

* *状态模式*

```csharp
```

* *空对象模式*

```csharp
```

* *策略模式*

```csharp
```

* *模板模式*

```csharp
```

* *访问者模式*

```csharp
```

### *J2EE模式*

* *MVC模式*

```csharp
```

* *业务代表模式*

```csharp
```

* *组合实体模式*

```csharp
```

* *数据访问对象模式*

```csharp
```

* *前端控制器模式*

```csharp
```

* *拦截过滤器模式*

```csharp
```

* *服务定位器模式*

```csharp
```

* *传输对象模式*

```csharp
```

[Github Code](https://github.com/Peefy/DotNetCore.DesignPatternByCSharp)

