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

            Assert.Equal("CREATE TABLE TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty varchar(255) null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithIntProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithIntProperty\r\n(\r\n    TheIntProperty int not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableIntProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableIntProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableIntProperty\r\n(\r\n    TheNullableIntProperty int null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithLongProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithLongProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithLongProperty\r\n(\r\n    TheLongProperty bigint not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableLongProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableLongProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableLongProperty\r\n(\r\n    TheNullableLongProperty bigint null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithShortProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithShortProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithShortProperty\r\n(\r\n    TheShortProperty smallint not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableShortProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableShortProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableShortProperty\r\n(\r\n    TheNullableShortProperty smallint null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithByteProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithByteProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithByteProperty\r\n(\r\n    TheByteProperty tinyint not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableByteProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableByteProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableByteProperty\r\n(\r\n    TheNullableByteProperty tinyint null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithBoolProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithBoolProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithBoolProperty\r\n(\r\n    TheBoolProperty bit not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableBoolProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableBoolProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableBoolProperty\r\n(\r\n    TheNullableBoolProperty bit null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithCharProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithCharProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithCharProperty\r\n(\r\n    TheCharProperty char not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableCharProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableCharProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableCharProperty\r\n(\r\n    TheNullableCharProperty char null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDecimalProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDecimalProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDecimalProperty\r\n(\r\n    TheDecimalProperty decimal not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDecimalProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDecimalProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableDecimalProperty\r\n(\r\n    TheNullableDecimalProperty decimal null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDoubleProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDoubleProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDoubleProperty\r\n(\r\n    TheDoubleProperty float not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDoubleProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDoubleProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableDoubleProperty\r\n(\r\n    TheNullableDoubleProperty float null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithFloatProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithFloatProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithFloatProperty\r\n(\r\n    TheFloatProperty float not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableFloatProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableFloatProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableFloatProperty\r\n(\r\n    TheNullableFloatProperty float null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithGuidProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithGuidProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithGuidProperty\r\n(\r\n    TheGuidProperty uniqueidentifier not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableGuidProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableGuidProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableGuidProperty\r\n(\r\n    TheNullableGuidProperty uniqueidentifier null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDateTimeProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDateTimeProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDateTimeProperty\r\n(\r\n    TheDateTimeProperty datetime2 not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDateTimeProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDateTimeProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableDateTimeProperty\r\n(\r\n    TheNullableDateTimeProperty datetime2 null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDateTimeOffsetProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDateTimeOffsetProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithDateTimeOffsetProperty\r\n(\r\n    TheDateTimeOffsetProperty datetimeoffset not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDateTimeOffsetProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDateTimeOffsetProperty>();

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableDateTimeOffsetProperty\r\n(\r\n    TheNullableDateTimeOffsetProperty datetimeoffset null\r\n)", result);
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

    public class TestCreateTableClassWithNullableIntProperty
    {
        public int? TheNullableIntProperty { get; set; }
    }

    public class TestCreateTableClassWithLongProperty
    {
        public long TheLongProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableLongProperty
    {
        public long? TheNullableLongProperty { get; set; }
    }

    public class TestCreateTableClassWithShortProperty
    {
        public short TheShortProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableShortProperty
    {
        public short? TheNullableShortProperty { get; set; }
    }

    public class TestCreateTableClassWithByteProperty
    {
        public byte TheByteProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableByteProperty
    {
        public byte? TheNullableByteProperty { get; set; }
    }

    public class TestCreateTableClassWithBoolProperty
    {
        public bool TheBoolProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableBoolProperty
    {
        public bool? TheNullableBoolProperty { get; set; }
    }

    public class TestCreateTableClassWithCharProperty
    {
        public char TheCharProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableCharProperty
    {
        public char? TheNullableCharProperty { get; set; }
    }

    public class TestCreateTableClassWithDecimalProperty
    {
        public decimal TheDecimalProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableDecimalProperty
    {
        public decimal? TheNullableDecimalProperty { get; set; }
    }

    public class TestCreateTableClassWithDoubleProperty
    {
        public double TheDoubleProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableDoubleProperty
    {
        public double? TheNullableDoubleProperty { get; set; }
    }

    public class TestCreateTableClassWithFloatProperty
    {
        public float TheFloatProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableFloatProperty
    {
        public float? TheNullableFloatProperty { get; set; }
    }

    public class TestCreateTableClassWithGuidProperty
    {
        public Guid TheGuidProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableGuidProperty
    {
        public Guid? TheNullableGuidProperty { get; set; }
    }

    public class TestCreateTableClassWithDateTimeProperty
    {
        public DateTime TheDateTimeProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableDateTimeProperty
    {
        public DateTime? TheNullableDateTimeProperty { get; set; }
    }

    public class TestCreateTableClassWithDateTimeOffsetProperty
    {
        public DateTimeOffset TheDateTimeOffsetProperty { get; set; }
    }

    public class TestCreateTableClassWithNullableDateTimeOffsetProperty
    {
        public DateTimeOffset? TheNullableDateTimeOffsetProperty { get; set; }
    }
}