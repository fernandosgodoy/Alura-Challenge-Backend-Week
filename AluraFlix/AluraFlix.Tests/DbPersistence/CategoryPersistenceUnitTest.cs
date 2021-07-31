using AluraFlix.Domain;
using AluraFlix.EFPersistence.Context;
using AluraFlix.EFPersistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AluraFlix.Tests.DbPersistence
{
    public class CategoryPersistenceUnitTest
    {

        private readonly DbContextOptions _dbContextOptions;

        public CategoryPersistenceUnitTest()
        {
            this._dbContextOptions = new DbContextOptionsBuilder<AluraFlixDbContext>()
                .UseInMemoryDatabase(databaseName: "AluraFlixTests")
                .Options;
        }

        [Fact]
        public void GivenCategoryEntry_WhenYouAreAdding_ThenTryToIncludeTheCategory()
        {
            var category = new Category()
            {
                Title = "Ação",
                Color = "CFCFCF"
            };

            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);

                var videoRepositoryMock = new Mock<CategoryRepository>(context);
                var inserted = videoRepositoryMock.Object.Add(category);

                Assert.True(inserted,
                    "It wasn't possible to insert the category.");
            }
        }

        [Fact]
        public void GivenCategoryUpdateEntry_WhenYouNeedToUpdateInformation_ThenTryToUpdateTheCategory()
        {
            var category = new Category()
            {
                Id = 1,
                Title = "Ação / Action",
            };

            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);
                var categoryRepositoryMock = new Mock<CategoryRepository>(context);
                categoryRepositoryMock.Object.Update(category);
            }
        }

        [Fact]
        public void GivenCategoryId_WhenYouNeedToURemoveIt_ThenTryToDeleteTheCategory()
        {
            var category = new Category()
            {
                Id = 1
            };

            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);
                var categoryRepositoryMock = new Mock<CategoryRepository>(context);
                categoryRepositoryMock.Object.RemoveById(category.Id);
            }
        }

        [Fact]
        public void GivenTheRequestForList_WhenYouAreStarting_ThenTryToRetrieveAllTheCategories()
        {
            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);

                var categoryRepositoryMock = new Mock<CategoryRepository>(context);
                var list = categoryRepositoryMock.Object.GetAll();
                Assert.NotNull(list);
            }
        }

        [Fact]
        public void GivenTheRequestCategory_WhenYouAreConsultingACategory_ThenTryToRetrieveTheCategoryById()
        {
            var categoryId = 1;
            using (var context = new AluraFlixDbContext(this._dbContextOptions))
            {
                Assert.NotNull(context);

                var categoryRepositoryMock = new Mock<CategoryRepository>(context);
                var category = categoryRepositoryMock.Object.GetById(categoryId);
                Assert.NotNull(category);
            }
        }

    }
}
