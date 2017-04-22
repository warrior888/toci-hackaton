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
            DoSomething((IBaseType<AGenericType>)parameter);
        }
    }

    interface AGenericType { }

    interface BGenericType : AGenericType { }

    class BaseWhatever : IBaseType<AGenericType> { }


    class AnotherWhatever : IBaseType<BGenericType> { }

    interface IBaseType<TResult> { }

}