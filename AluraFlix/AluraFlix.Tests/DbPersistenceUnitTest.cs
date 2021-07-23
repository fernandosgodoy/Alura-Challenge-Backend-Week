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
                var videoRepositoryMock = new Mock<VideoRepository>(context);
                var inserted = videoRepositoryMock.Object.Add(video);

                Assert.True(inserted,
                    "It wasn't possible to insert the video.");
            }
        }

    }
}
