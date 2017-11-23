using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using VsCodeProOne.Patterns;
//1.创建者模式
using VsCodeProOne.Patterns.FactoryPattern;         //工厂模式
using VsCodeProOne.Patterns.AbstractFactoryPattern; //抽象工厂模式
using VsCodeProOne.Patterns.SingletonPattern;       //单例模式
using VsCodeProOne.Patterns.BuilderPattern;         //建造者模式
using VsCodeProOne.Patterns.PrototypePattern;       //原型模式
//2.结构型模式
using VsCodeProOne.Patterns.AdapterPattern;         //适配器模式
using VsCodeProOne.Patterns.BridgePattern;          //桥接模式
using VsCodeProOne.Patterns.FilterPattern;          //过滤器模式
using VsCodeProOne.Patterns.CompositePattern;       //组合模式
using VsCodeProOne.Patterns.DecoratorPattern;       //装饰器模式
using VsCodeProOne.Patterns.FacadePattern;          //外观模式
using VsCodeProOne.Patterns.FlyWeightPattern;       //享元模式
using VsCodeProOne.Patterns.ProxyPattern;           //代理模式
using VsCodeProOne.Patterns.ChainOfResponsibilityPattern; //责任链模式
using VsCodeProOne.Patterns.CommandPattern;         //命令模式
using VsCodeProOne.Patterns.InterpreterPattern;     //解释器模式
using VsCodeProOne.Patterns.IteratorPattern;        //迭代器模式

namespace VsCodeProOne
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1.创建者模式
            //工厂模式测试
            Patterns.FactoryPattern.ShapeFactory.Test();
            //抽象工厂模式测试
            FactoryProducer.Test();
            //单例模式测试
            Singleton.Test();
            //建造者模式
            FoodPattern.Test();
            //原型模式
            PrototypeDemo.Test();
            #endregion

            #region 2.结构型模式
            //适配器模式
            AdapterPatternDemo.Test();        
            //桥接模式
            BridgePatternDemo.Test();
            //过滤器模式
            FilterPatternDemo.Test();
            //组合模式
            CompositePattern.Test();
            //装饰器模式
            DecoratorPatternDemo.Test();
            //外观模式
            FacadePatternDemo.Test();
            //享元模式
            FlyWeightPatternDemo.Test();
            //代理模式
            ProxyPatternDemo.Test();
            //责任链模式
            ChainPatternDemo.Test();
            //命令模式
            CommandPatternDemo.Test();
            //解释器模式
            InterpreterPatternDemo.Test();
            //迭代器模式
            IteratorPatternDemo.Test();
            #endregion

            Console.ReadLine();
            
        }

    }
}
