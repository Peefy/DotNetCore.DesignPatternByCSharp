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
//3.行为型模式
using VsCodeProOne.Patterns.ChainOfResponsibilityPattern; //责任链模式
using VsCodeProOne.Patterns.CommandPattern;          //命令模式
using VsCodeProOne.Patterns.InterpreterPattern;      //解释器模式
using VsCodeProOne.Patterns.IteratorPattern;         //迭代器模式
using VsCodeProOne.Patterns.MediatorPattern;         //中介者模式
using VsCodeProOne.Patterns.MementoPattern;          //备忘录模式
using VsCodeProOne.Patterns.ObserverPattern;         //观察者模式
using VsCodeProOne.Patterns.StatePattern;            //状态模式
using VsCodeProOne.Patterns.NullObjectPattern;       //空对象模式
using VsCodeProOne.Patterns.StrategyPattern;         //策略模式
using VsCodeProOne.Patterns.TemplatePattern;         //模板模式
using VsCodeProOne.Patterns.VisitorPattern;          //访问者模式
//4.J2EE模式
using VsCodeProOne.Patterns.MVCPattern;              //MVC模式
using VsCodeProOne.Patterns.BusinessDelegatePattern; //业务代表模式
using VsCodeProOne.Patterns.CompositeEntityPattern;  //组合实体模式
using VsCodeProOne.Patterns.DataAccessObjectPattern; //数据访问对象模式
using VsCodeProOne.Patterns.FrontControllerPattern;  //前端控制器模式
//拦截过滤器模式
//服务定位器模式
//传输对象模式

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
            #endregion

            #region 3.行为型模式
            //责任链模式
            ChainPatternDemo.Test();
            //命令模式
            CommandPatternDemo.Test();
            //解释器模式
            InterpreterPatternDemo.Test();
            //迭代器模式
            IteratorPatternDemo.Test();
            //中介者模式
            MediatorPatternDemo.Run();
            //备忘录模式
            MementoPatternDemo.Run();
            //观察者模式
            ObserverPatternDemo.Run();
            //状态模式
            StatePatternDemo.Run();
            //空对象模式
            NullObjectPatternDemo.Run();
            //策略模式
            StrategyPatternDemo.Run();
            //模板模式
            TemplatePatternDemo.Run();
            //访问者模式
            VisitorPatternDemo.Run();
            #endregion

            #region 4.J2EE模式
            //MVC模式
            MVCPatternDemo.Run();
            //业务代表模式
            BusinessDelegatePatternDemo.Run();
            //组合实体模式
            CompositeEntityPatternDemo.Run();
            //数据访问对象模式
            DataAccessObjectPatternDemo.Run();
            //前端控制器模式
            FrontControllerPatternDemo.Run();
            //拦截过滤器模式
            //服务定位器模式
            //传输对象模式
            #endregion

            Console.ReadLine();
            
        }

    }
}
