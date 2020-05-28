using UnitTestProject1;

namespace Autofac.Extras.FakeItEasy
{
    public static class AutoFakeExtensions
    {
        public static T Generate<T>(this AutoFake autoFake)
        {
            RelaxedAutoFakeCreator.SUTType = typeof(T);

            return autoFake.Resolve<T>();
        }
    }
}
