using System;
using Xunit;

namespace ChrisWood.DevTools.Tests
{
    public class CreateTableTests
    {
        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNoProperties()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithoutProperties>();

            Assert.Equal(
@"CREATE TABLE TestCreateTableClassWithoutProperties
(
)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithStringProperty>();

            Assert.Equal(
@"CREATE TABLE TestCreateTableClassWithStringProperty
(
    TheStringProperty varchar(255)
)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithIntProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>();

            Assert.Equal(
@"CREATE TABLE TestCreateTableClassWithIntProperty
(
    TheIntProperty int
)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithLongProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithLongProperty>();

            Assert.Equal(
@"CREATE TABLE TestCreateTableClassWithLongProperty
(
    TheLongProperty bigint
)", result);
        }

        // generics and types

        // different names for class
    }

    public class TestCreateTableClassWithoutProperties { }

    public class TestCreateTableClassWithStringProperty
    {
        public string TheStringProperty { get; set; }
    }

    public class TestCreateTableClassWithIntProperty
    {
        public int TheIntProperty { get; set; }
    }

    public class TestCreateTableClassWithLongProperty
    {
        public long TheLongProperty { get; set; }
    }
}