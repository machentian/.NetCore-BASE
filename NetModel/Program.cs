using System;
using static NetModel.Customer;

namespace NetModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

        }
    }
    
    //桥接模式
    ///// <summary>
    ///// 以电视机遥控器的例子来演示桥接模式
    ///// </summary>
    //class Client
    //{
    //    static void Main(string[] args)
    //    {
    //        // 创建一个遥控器
    //        RemoteControl remoteControl = new ConcreteRemote();
    //        // 长虹电视机
    //        remoteControl.Implementor = new ChangHong();
    //        remoteControl.On();
    //        Console.WriteLine();

    //        // 三星牌电视机
    //        remoteControl.Implementor = new Samsung();
    //        remoteControl.On();
    //        Console.Read();
    //    }
    //}
    //public class RemoteControl
    //{
    //    // 字段
    //    private TV implementor;
    //    public TV Implementor
    //    {
    //        get { return implementor; }
    //        set { implementor = value; }
    //    }
    //    /// 开电视机，这里抽象类中不再提供实现了，而是调用实现类中的实现
    //    /// </summary>
    //    public virtual void On()
    //    {
    //        implementor.On();
    //    }
    //}
    ///// <summary>
    ///// 具体遥控器
    ///// </summary>
    //public class ConcreteRemote : RemoteControl
    //{
    //    public override void On()
    //    {
    //        base.On();
    //    }
    //}
    ////长虹牌电视机，重写基类的抽象方法
    //public class ChangHong : TV
    //{
    //    public override void On()
    //    {
    //        Console.WriteLine("长虹牌电视机已经打开了");
    //    }
    //}
    ///// 三星牌电视机，重写基类的抽象方法
    ///// </summary>
    //public class Samsung : TV
    //{
    //    public override void On()
    //    {
    //        Console.WriteLine("三星牌电视机已经打开了");
    //    }    
    //}

    //public abstract class TV
    //{
    //    public abstract void On();
    //}

    //// 类的适配器模式
    ///// <summary>
    ///// 客户端，客户想要把2个孔的插头 转变成三个孔的插头，这个转变交给适配器就好
    ///// 既然适配器需要完成这个功能，所以它必须同时具体2个孔插头和三个孔插头的特征
    ///// </summary>
    //class Client
    //{
    //    static void Main(string[] args)
    //    {
    //        // 现在客户端可以通过电适配要使用2个孔的插头了
    //        IThreeHole threehole = new PowerAdapter();
    //        threehole.Request();
    //        Console.ReadLine();
    //    }
    //}
    //public interface IThreeHole
    //{
    //    void Request();
    //}
    //public abstract class TwoHole
    //{
    //    public void SpecificRequest()
    //    {
    //        Console.WriteLine("我是两个孔的插头");
    //    }
    //}
    //public  class PowerAdapter : TwoHole, IThreeHole
    //{
    //    /// <summary>
    //    /// 实现三个孔插头接口方法
    //    /// </summary>
    //    public void Request()
    //    {
    //        // 调用两个孔插头方法
    //        this.SpecificRequest();
    //    }
    //}



    ////原型模式
    /////火影忍者中鸣人的影分身和孙悟空的变都是原型模式
    //class Client
    //{
    //    static void Main(string[] args)
    //    {
    //        MonkeyKingPrototype prototypeMonkeyKing = new ConcretePrototype("MonkeyKing");
    //        // 变一个
    //        MonkeyKingPrototype cloneMonkeyKing = prototypeMonkeyKing.Clone() as ConcretePrototype;
    //        Console.WriteLine("Cloned1:\t" + cloneMonkeyKing.Id);
    //        // 变两个
    //        MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcretePrototype;
    //        Console.WriteLine("Cloned2:\t" + cloneMonkeyKing2.Id);
    //    }
    //}

    //public abstract class MonkeyKingPrototype
    //{
    //    public string Id { get; set; }
    //    public MonkeyKingPrototype(string id)
    //    {
    //        this.Id = id;
    //    }
    //    // 克隆方法，即孙大圣说“变”
    //    public abstract MonkeyKingPrototype Clone();
    //}

    //public class ConcretePrototype : MonkeyKingPrototype
    //{
    //    public ConcretePrototype(string id)
    //           : base(id)
    //    { }

    //    public override MonkeyKingPrototype Clone()
    //    {
    //        return (MonkeyKingPrototype)this.MemberwiseClone();
    //    }
    //}

    ////抽象工厂模式
    //class Client
    //{
    //    static void Main(string[] args)
    //    {
    //        // 南昌工厂制作南昌的鸭脖和鸭架
    //        AbstractFactory nanChangFactory = new NanChangFactory();
    //        YaBo nanChangYabo = nanChangFactory.CreateYaBo();
    //        nanChangYabo.Print();
    //        YaJia nanChangYajia = nanChangFactory.CreateYaJia();
    //        nanChangYajia.Print();

    //        // 上海工厂制作上海的鸭脖和鸭架
    //        AbstractFactory shangHaiFactory = new ShangHaiFactory();
    //        shangHaiFactory.CreateYaBo().Print();
    //        shangHaiFactory.CreateYaJia().Print();

    //        Console.Read();
    //    }
    //    /// <summary>
    //    /// 南昌绝味工厂负责制作南昌的鸭脖和鸭架
    //    /// </summary>
    //    public class NanChangFactory : AbstractFactory
    //    {
    //        // 制作南昌鸭脖
    //        public override YaBo CreateYaBo()
    //        {
    //            return new NanChangYaBo();
    //        }
    //        // 制作南昌鸭架
    //        public override YaJia CreateYaJia()
    //        {
    //            return new NanChangYaJia();
    //        }
    //    }

    //    /// <summary>
    //    /// 上海绝味工厂负责制作上海的鸭脖和鸭架
    //    /// </summary>
    //    public class ShangHaiFactory : AbstractFactory
    //    {
    //        // 制作上海鸭脖
    //        public override YaBo CreateYaBo()
    //        {
    //            return new ShangHaiYaBo();
    //        }
    //        // 制作上海鸭架
    //        public override YaJia CreateYaJia()
    //        {
    //            return new ShangHaiYaJia();
    //        }
    //    }
    //    /// <summary>
    //    /// 鸭脖抽象类，供每个地方的鸭脖类继承
    //    /// </summary>
    //    public abstract class YaBo
    //    {
    //        /// <summary>
    //        /// 打印方法，用于输出信息
    //        /// </summary>
    //        public abstract void Print();
    //    }

    //    /// <summary>
    //    /// 鸭架抽象类，供每个地方的鸭架类继承
    //    /// </summary>
    //    public abstract class YaJia
    //    {
    //        /// <summary>
    //        /// 打印方法，用于输出信息
    //        /// </summary>
    //        public abstract void Print();
    //    }
    //    /// <summary>
    //    /// 抽象工厂类，提供创建两个不同地方的鸭架和鸭脖的接口
    //    /// </summary>
    //    public abstract class AbstractFactory
    //    {
    //        // 抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了绝味中鸭脖和鸭架的创建接口
    //        public abstract YaBo CreateYaBo();
    //        public abstract YaJia CreateYaJia();
    //    }
    //    /// <summary>
    //    /// 南昌的鸭脖类，因为江西人喜欢吃辣的，所以南昌的鸭脖稍微会比上海做的辣
    //    /// </summary>
    //    public class NanChangYaBo : YaBo
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("南昌的鸭脖");
    //        }
    //    }

    //    /// <summary>
    //    /// 上海的鸭脖没有南昌的鸭脖做的辣
    //    /// </summary>
    //    public class ShangHaiYaBo : YaBo
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("上海的鸭脖");
    //        }
    //    }
    //    /// <summary>
    //    /// 南昌的鸭架
    //    /// </summary>
    //    public class NanChangYaJia : YaJia
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("南昌的鸭架子");
    //        }
    //    }

    //    /// <summary>
    //    /// 上海的鸭架
    //    /// </summary>
    //    public class ShangHaiYaJia : YaJia
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("上海的鸭架子");
    //        }
    //    }
    //}


    ////工厂方法模式
    //public class Customer
    //{
    //    /// <summary>
    //    /// 抽象工厂类
    //    /// </summary>
    //    public abstract class Creator
    //    {
    //        // 工厂方法
    //        public abstract Food CreateFoddFactory();
    //    }

    //    /// <summary>
    //    /// 菜抽象类
    //    /// </summary>
    //    public abstract class Food
    //    {
    //        public abstract void Print();
    //    }
    //    /// <summary>
    //    /// 西红柿炒鸡蛋
    //    /// </summary>
    //    public class TomatoScrambledEggs : Food
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("一份西红柿炒蛋！");
    //        }
    //    }
    //    /// <summary>
    //    /// 西红柿炒蛋工厂类
    //    /// </summary>
    //    public class TomatoScrambledEggsFactory : Creator
    //    {
    //        /// <summary>
    //        /// 负责创建西红柿炒蛋这道菜
    //        /// </summary>
    //        /// <returns></returns>
    //        public override Food CreateFoddFactory()
    //        {
    //            return new TomatoScrambledEggs();
    //        }
    //    }
    //    /// <summary>
    //    /// 土豆肉丝
    //    /// </summary>
    //    public class ShreddedPorkWithPotatoes : Food
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("一份土豆肉丝");
    //        }
    //    }
    //    /// <summary>
    //    /// 土豆肉丝工厂类
    //    /// </summary>
    //    public class ShreddedPorkWithPotatoesFactory : Creator
    //    {
    //        /// <summary>
    //        /// 负责创建土豆肉丝这道菜
    //        /// </summary>
    //        /// <returns></returns>
    //        public override Food CreateFoddFactory()
    //        {
    //            return new ShreddedPorkWithPotatoes();
    //        }
    //    }
    //    static void main(string[] args)
    //    {
    //        // 初始化做菜的两个工厂（）
    //        Creator shreddedPorkWithPotatoesFactory = new ShreddedPorkWithPotatoesFactory();
    //        Creator tomatoScrambledEggsFactory = new TomatoScrambledEggsFactory();

    //        // 开始做西红柿炒蛋
    //        Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoddFactory();
    //        tomatoScrambleEggs.Print();

    //        //开始做土豆肉丝
    //        Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoddFactory();
    //        shreddedPorkWithPotatoes.Print();

    //        Console.Read();
    //    }
    //}



    //简单工厂模式
    //public class Customer
    //{
    //    /// <summary>
    //    /// 菜抽象类
    //    /// </summary>
    //    public abstract class Food
    //    {
    //        public abstract void Print();
    //    }
    //    /// <summary>
    //    /// 西红柿炒鸡蛋
    //    /// </summary>
    //    public class TomatoScrambledEggs : Food
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("一份西红柿炒蛋！");
    //        }
    //    }
    //    /// <summary>
    //    /// 土豆肉丝
    //    /// </summary>
    //    public class ShreddedPorkWithPotatoes : Food
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("一份土豆肉丝");
    //        }
    //    }
    //    static void main(string[] args)
    //    {
    //        // 做西红柿炒蛋
    //        Food food1 = FoodSimpleFactory.CreateFood("西红柿炒蛋");
    //        food1.Print();

    //        Food food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
    //        food2.Print();
    //    }
    //}
    ///// <summary>
    ///// 简单工厂类, 负责 炒菜
    ///// </summary>
    //public class FoodSimpleFactory
    //{
    //    /// <summary>
    //    /// 烧菜方法
    //    /// </summary>
    //    /// <param name="type"></param>
    //    /// <returns></returns>
    //    public static Food CreateFood(string type)
    //    {
    //        Food food = null;
    //        if (type.Equals("西红柿炒蛋"))
    //        {
    //            food = new TomatoScrambledEggs();
    //        }
    //        else if (type.Equals("土豆肉丝"))
    //        {
    //            food = new ShreddedPorkWithPotatoes();
    //        }
    //        return food;
    //    }
    //}




    ////多线程下(双重锁定)
    //public class Singleton
    //{
    //    private static Singleton uniqueInstance;
    //    // 定义一个标识确保线程同步
    //    private static readonly object locker = new object();
    //    private Singleton()
    //    {

    //    }
    //    public static Singleton GetInstance()
    //    {
    //        // 双重锁定
    //        if (uniqueInstance == null)
    //        {
    //            lock (locker)
    //            {
    //                //双重锁定
    //                if (uniqueInstance == null)
    //                {
    //                    uniqueInstance = new Singleton();
    //                }
    //            }
    //        }
    //        return uniqueInstance;
    //    }
    //}


    ////多线程下(性能较差)
    //public class Singleton
    //{
    //    private static Singleton uniqueInstance;
    //    // 定义一个标识确保线程同步
    //    private static readonly object locker = new object();
    //    private Singleton()
    //    {

    //    }
    //    public static Singleton GetInstance()
    //    {
    //        lock (locker)
    //        {   // 如果类的实例不存在则创建，否则直接返回
    //            if (uniqueInstance == null)
    //            {
    //                uniqueInstance = new Singleton();
    //            }
    //        }         
    //        return uniqueInstance;
    //    }
    //}



    ////单线程下
    //public class Singleton
    //{
    //    private static Singleton uniqueInstance;
    //    private Singleton()
    //    {

    //    }
    //    public static Singleton GetInstance()
    //    {
    //        // 如果类的实例不存在则创建，否则直接返回
    //        if (uniqueInstance == null)
    //        {
    //            uniqueInstance = new Singleton();
    //        }
    //        return uniqueInstance;
    //    }
    //}

}
