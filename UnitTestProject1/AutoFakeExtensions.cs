using System;
using Autofac;
using Autofac.Extras.FakeItEasy;

namespace UnitTestProject1
{
    public static class RelaxedAutoFakeCreator
    {
        public static AutoFake For<T>(bool strict = false, bool callsBaseMethods = false,
            Action<object> configureFake = null)
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new FakeConcreteTypeHandler(strict, callsBaseMethods, configureFake));
            builder.RegisterType<T>();

            return new AutoFake(strict, callsBaseMethods, configureFake, builder);
        }
    }
}