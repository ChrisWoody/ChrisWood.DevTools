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

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithBoolProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithBoolProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithBoolProperty\r\n(\r\n    TheBoolProperty bit\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithCharProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithCharProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithCharProperty\r\n(\r\n    TheCharProperty char\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDecimalProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDecimalProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDecimalProperty\r\n(\r\n    TheDecimalProperty decimal\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDoubleProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDoubleProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDoubleProperty\r\n(\r\n    TheDoubleProperty float\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithFloatProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithFloatProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithFloatProperty\r\n(\r\n    TheFloatProperty float\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithGuidProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithGuidProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithGuidProperty\r\n(\r\n    TheGuidProperty uniqueidentifier\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDateTimeProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDateTimeProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDateTimeProperty\r\n(\r\n    TheDateTimeProperty datetime2\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDateTimeOffsetProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDateTimeOffsetProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDateTimeOffsetProperty\r\n(\r\n    TheDateTimeOffsetProperty datetimeoffset\r\n)", result);
        }

        // generics and types

        // private properties don't appear

        // inherited properties
        
        // how to handle internal?

        // how to handle objects or enums?
        
        // nullable/notnullable
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

    public class TestCreateTableClassWithBoolProperty
    {
        public bool TheBoolProperty { get; set; }
    }

    public class TestCreateTableClassWithCharProperty
    {
        public char TheCharProperty { get; set; }
    }

    public class TestCreateTableClassWithDecimalProperty
    {
        public decimal TheDecimalProperty { get; set; }
    }

    public class TestCreateTableClassWithDoubleProperty
    {
        public double TheDoubleProperty { get; set; }
    }

    public class TestCreateTableClassWithFloatProperty
    {
        public float TheFloatProperty { get; set; }
    }

    public class TestCreateTableClassWithGuidProperty
    {
        public Guid TheGuidProperty { get; set; }
    }

    public class TestCreateTableClassWithDateTimeProperty
    {
        public DateTime TheDateTimeProperty { get; set; }
    }

    public class TestCreateTableClassWithDateTimeOffsetProperty
    {
        public DateTimeOffset TheDateTimeOffsetProperty { get; set; }
    }
}