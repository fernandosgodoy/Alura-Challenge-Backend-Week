using AluraFlix.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Xunit;

namespace AluraFlix.Tests
{
    public class DbModelValidateUnitTest
    {
        [Fact]
        public void GivenTheProjectEntities_WhenAfterYouWroteTheClass_ThenCheckTheRulesForTheModel()
        {
            Assert.True(this.CheckHasDefinedPrimaryKey(typeof(Video)), 
                "Entity doesn't implement the correct model rules.");

            Assert.True(this.CheckHasDefinedPrimaryKey(typeof(Category)),
                "Entity doesn't implement the correct model rules.");
        }

        public bool CheckHasDefinedPrimaryKey(Type source)
        {
            return source.GetRuntimeProperties()
                 .Where(pi => pi.PropertyType == typeof(int)
                    && pi.GetCustomAttributes<KeyAttribute>(true).Any()).Any();
        }
    }
}
