using Xunit;
using Moq.AutoMock;
using AluraFlix.EFPersistence.Repositories;
using AluraFlix.Domain;
using AluraFlix.EFPersistence.Context;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace AluraFlix.Tests
{
    public class DbPersistenceUnitTest
    {

        private readonly DbContextOptions _dbContextOptions;

        public DbPersistenceUnitTest()
        {
            this._dbContextOptions = new DbContextOptionsBuilder<AluraFlixDbContext>()
                .UseInMemoryDatabase(databaseName: "AluraFlixTests")
                .Options;
        }

        [Fact]
        public void GivenVideoEntry_WhenYouAreAdding_ThenTryToIncludeTheVideo()
        {
            var video = new Video()
            {
                Title = "Star Wars - A Ascensão Skywalker",
                Description = "Em Star Wars: A Ascensão Skywalker, com o retorno do Imperador Palpatine (Ian McDiarmid), todos voltam a temer seu poder. Assim, a Resistência toma a frente da batalha que ditará os rumos da galáxia.",
                Url = "https://www.youtube.com/watch?v=W0squnw6Jp8"
            };

            using(var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);

                var videoRepositoryMock = new Mock<VideoRepository>(context);
                var inserted = videoRepositoryMock.Object.Add(video);

                Assert.True(inserted,
                    "It wasn't possible to insert the video.");
            }
        }

        [Fact]
        public void GivenVideoUpdateEntry_WhenYouNeedToUpdateInformation_ThenTryToUpdateTheVideo()
        {
            var video = new Video()
            {
                Id = 1,
                Title = "Star Wars: A Ascensão Skywalker",
            };

            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);
                var videoRepositoryMock = new Mock<VideoRepository>(context);
                videoRepositoryMock.Object.Update(video);
            }
        }

        [Fact]
        public void GivenVideoId_WhenYouNeedToURemoveIt_ThenTryToDeleteTheVideo()
        {
            var video = new Video()
            {
                Id = 1
            };

            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);
                var videoRepositoryMock = new Mock<VideoRepository>(context);
                videoRepositoryMock.Object.RemoveById(video.Id);
            }
        }

        [Fact]
        public void GivenTheRequestForList_WhenYouAreStarting_ThenTryToRetrieveAllTheVideos()
        {
            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);

                var videoRepositoryMock = new Mock<VideoRepository>(context);
                var list = videoRepositoryMock.Object.GetAll();
                Assert.NotNull(list);
            }
        }

        [Fact]
        public void GivenTheRequestVideo_WhenYouAreConsultingAVideo_ThenTryToRetrieveTheVideoById()
        {
            var videoId = 1;
            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);

                var videoRepositoryMock = new Mock<VideoRepository>(context);
                var video = videoRepositoryMock.Object.GetById(videoId);
                Assert.NotNull(video);
            }
        }

    }
}
