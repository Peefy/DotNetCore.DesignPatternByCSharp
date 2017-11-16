using System;
using System.IO;
using System.Collections.Generic;
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
//过滤器模式

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
            #endregion
            Console.ReadLine();
            
        }

    }
}
