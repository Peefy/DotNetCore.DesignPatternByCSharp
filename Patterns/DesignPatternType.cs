

namespace VsCodeProOne.Patterns
{
    ///<summary>
    ///开闭原则：实现热插拔，提高扩展性。
    ///里氏代换原则：实现抽象的规范，实现子父类互相替换；
    ///依赖倒转原则：针对接口编程，实现开闭原则的基础；
    ///接口隔离原则：降低耦合度，接口单独设计，互相隔离；
    ///迪米特法则，又称不知道原则：功能模块尽量独立；
    ///合成复用原则：尽量使用聚合，组合，而不是继承；
    ///</summary>
    public enum DesignPatternType
    {
        ///<summary>
        ///工厂模式
        ///</summary>
        FactoryPattern,

        ///<summary>
        ///抽象工厂模式
        ///</summary>
        AbstractFactoryPattern,

        ///<summary>
        ///单例模式
        ///</summary>
        SingletonPattern,

        ///<summary>
        ///建造者模式
        ///</summary>
        BuilderPattern,

        ///<summary>
        ///原型模式
        ///</summary>
        PrototypePattern,

        ///<summary>
        ///适配器模式
        ///</summary>
        AdapterPattern,

        ///<summary>
        ///桥接模式
        ///</summary>
        BridgePattern,

        ///<summary>
        ///过滤器模式
        ///</summary>
        FilterPattern,

        ///<summary>
        ///组合模式
        ///</summary>
        CompositePattern,

        ///<summary>
        ///装饰器模式
        ///</summary>
        DecoratorPattern,

        ///<summary>
        ///外观模式
        ///</summary>
        FacadePattern,

        ///<summary>
        ///享元模式
        ///</summary>
        FlyweightPattern,

        ///<summary>
        ///代理模式
        ///</summary>
        ProxyPattern,

        ///<summary>
        ///责任链模式
        ///</summary>
        ChainOfResponsibilityPattern,

        ///<summary>
        ///命令模式
        ///</summary>
        CommandPattern,

        ///<summary>
        ///解释器模式
        ///</summary>
        InterpreterPattern,

        ///<summary>
        ///迭代器模式
        ///</summary>
        IteraterPattern,

        ///<summary>
        ///中介者模式
        ///</summary>
        MediatorPattern,

        ///<summary>
        ///备忘录模式
        ///</summary>
        MementoPattern,

        ///<summary>
        ///观察者模式
        ///</summary>
        ObserverPattern,

        ///<summary>
        ///状态模式
        ///</summary>
        StatePattern,

        ///<summary>
        ///空对象模式
        ///</summary>
        NullObjectPattern,

        ///<summary>
        ///策略模式
        ///</summary>
        StrategyPattern,

        ///<summary>
        ///模板模式
        ///</summary>
        TemplatePattern,

        ///<summary>
        ///访问者模式
        ///</summary>
        VisitorPattern,

        ///<summary>
        ///MVC模式
        ///</summary>
        MVCPattern,

        ///<summary>
        ///业务代表模式
        ///</summary>
        BusinessDelegatePattern,

        ///<summary>
        ///组合实体模式
        ///</summary>
        CompositeEntityPattern,

        ///<summary>
        ///数据访问对象模式
        ///</summary>
        DataAccessObjectPattern,

        ///<summary>
        ///前端控制器模式
        ///</summary>
        FrontCotrollerPattern,

        ///<summary>
        ///拦截过滤器模式
        ///</summary>
        InterceptingPattern,

        ///<summary>
        ///服务定位器模式
        ///</summary>
        ServiceLocatorPattern,

        ///<summary>
        ///传输对象模式
        ///</summary>
        TransferObjectPattern,
    }
}
