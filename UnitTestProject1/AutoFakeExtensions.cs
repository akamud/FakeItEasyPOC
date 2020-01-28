using Autofac;
using Autofac.Extras.FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public static class AutoFakeExtensions
    {
        public static Type Xablau = null;

        public static T Generate<T>(this AutoFake autoFake)
        {
            Xablau = typeof(T);
            return autoFake.Container.Resolve<T>();
        }
    }
}
