using System;
using Xunit;

namespace ChrisWood.DevTools.Tests
{
    public class CreateTableTests
    {
        [Fact]
        public void ReturnsCreateTableScript_WithSimpleClass()
        {
            var result = CreateTable.Generate<TestCreateTableClass>();

            Assert.Equal(
@"CREATE TABLE TestCreateTableClass
(

)", result);
        }

        // generics and types

        // different names for class
    }

    public class TestCreateTableClass { }
}