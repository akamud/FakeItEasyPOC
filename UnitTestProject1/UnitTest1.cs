using System;
using Autofac;
using Autofac.Extras.FakeItEasy;
using FakeItEasy;
using FakeItEasyConcrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new FakeConcreteTypeHandler(false, false, null));

            var autoFake = new AutoFake(builder: builder);
            var a = autoFake.Generate<Class1>();

            a.DoSomething();

            A.CallTo(() => autoFake.Resolve<FakeClass>().Teste())
                .MustHaveHappenedOnceExactly();
        }
    }
}
