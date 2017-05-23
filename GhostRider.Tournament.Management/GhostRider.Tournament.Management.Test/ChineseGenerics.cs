using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euvic.Generator.Core.Test.Poc
{
    [TestClass]
    public class ChineseGenerics
    {
        [TestMethod]
        public void Test()
        {
            BusinessLogic bl = new BusinessLogic();

            bl.DoSomething(new AnotherWhatever()); //BaseWhatever
            bl.DoSomething(new BaseWhatever()); //BaseWhatever
        }
    }

    abstract class BusinessLogicBase
    {
        public virtual void DoSomething(IBaseType<AGenericType> parameter)
        {

        }
    }

    class BusinessLogic : BusinessLogicBase
    {
        public void DoSomething(IBaseType<BGenericType> parameter)
        {
            IBaseType<AGenericType> w1 = new BaseWhatever();

            w1.Field = parameter.Field; // automapper

            DoSomething(w1);
        }
    }

    interface AGenericType { }

    interface BGenericType : AGenericType { }

    class BaseWhatever : IBaseType<AGenericType>
    {
        public string Field { get; set; }
    }


    class AnotherWhatever : IBaseType<BGenericType> {
        public string Field { get; set; }
    }

    interface IBaseType<TResult>
    {
        string Field { get; set; }
    }




    static class A { }
    abstract class B {
        //private abstract void test();
    }
}