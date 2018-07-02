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

            Assert.Equal("CREATE TABLE TestCreateTableClassWithoutProperties\r\n(\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithStringProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty varchar(255)\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithIntProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithIntProperty\r\n(\r\n    TheIntProperty int\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithLongProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithLongProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithLongProperty\r\n(\r\n    TheLongProperty bigint\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithShortProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithShortProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithShortProperty\r\n(\r\n    TheShortProperty smallint\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithByteProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithByteProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithByteProperty\r\n(\r\n    TheByteProperty tinyint\r\n)", result);
        }

        // generics and types

        // private properties don't appear

        // inherited properties

        // how to handle objects or enums
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

    public class TestCreateTableClassWithShortProperty
    {
        public short TheShortProperty { get; set; }
    }

    public class TestCreateTableClassWithByteProperty
    {
        public byte TheByteProperty { get; set; }
    }
}