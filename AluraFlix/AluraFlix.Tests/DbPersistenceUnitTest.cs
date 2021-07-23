using Xunit;
using Moq.AutoMock;

namespace AluraFlix.Tests
{
    public class DbPersistenceUnitTest
    {

        [Fact]
        public void GivenVideoEntries_WhenYouAreAdding_ThenTryToIncludeTheVideo()
        {
            var autoMock = new AutoMocker();
            //autoMock.CreateInstance<VideoRepository>();
            //Assert.True(this.CheckHasDefinedPrimaryKey(typeof(Video)),
            //    "Entity doesn't implement the correct model rules.");
        }

    }
}
