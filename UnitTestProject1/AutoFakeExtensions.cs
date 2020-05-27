using Autofac;
using Autofac.Extras.FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core;

namespace UnitTestProject1
{
    public static class RelaxedAutoFakeCreator
    {
        public static AutoFake For<T>(bool strict = false, bool callsBaseMethods = false,
            Action<object> configureFake = null, ContainerBuilder builder = null,
            Action<ContainerBuilder> configureAction = null)
        {
            if (builder == null)
            {
                builder = new ContainerBuilder();
            }

            builder.RegisterSource(new FakeConcreteTypeHandler(strict, callsBaseMethods, configureFake));
            builder.RegisterType<T>();

            return new AutoFake(strict, callsBaseMethods, configureFake, builder);
        }
    }
}