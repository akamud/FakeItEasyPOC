using Autofac.Extras.FakeItEasy;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class TesteBase<T>
    {
        protected AutoFake _autoFake;

        [SetUp]
        public void SetUp()
        {
            _autoFake = RelaxedAutoFakeCreator.For<T>();
        }

        [TearDown]
        public void TearDown()
        {
            _autoFake.Dispose();
        }
    }

    public class TesteBase
    {
        protected AutoFake _autoFake;

        [SetUp]
        public void SetUp()
        {
            _autoFake = RelaxedAutoFakeCreator.Create();
        }

        [TearDown]
        public void TearDown()
        {
            _autoFake.Dispose();
        }
    }
}
