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

            Assert.Equal("create table TestCreateTableClassWithoutProperties\r\n(\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithStringProperty>();

            Assert.Equal("create table TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty varchar(255) null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithIntProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>();

            Assert.Equal("create table TestCreateTableClassWithIntProperty\r\n(\r\n    TheIntProperty int not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableIntProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableIntProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableIntProperty\r\n(\r\n    TheNullableIntProperty int null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithLongProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithLongProperty>();

            Assert.Equal("create table TestCreateTableClassWithLongProperty\r\n(\r\n    TheLongProperty bigint not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableLongProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableLongProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableLongProperty\r\n(\r\n    TheNullableLongProperty bigint null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithShortProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithShortProperty>();

            Assert.Equal("create table TestCreateTableClassWithShortProperty\r\n(\r\n    TheShortProperty smallint not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableShortProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableShortProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableShortProperty\r\n(\r\n    TheNullableShortProperty smallint null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithByteProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithByteProperty>();

            Assert.Equal("create table TestCreateTableClassWithByteProperty\r\n(\r\n    TheByteProperty tinyint not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableByteProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableByteProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableByteProperty\r\n(\r\n    TheNullableByteProperty tinyint null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithBoolProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithBoolProperty>();

            Assert.Equal("create table TestCreateTableClassWithBoolProperty\r\n(\r\n    TheBoolProperty bit not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableBoolProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableBoolProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableBoolProperty\r\n(\r\n    TheNullableBoolProperty bit null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithCharProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithCharProperty>();

            Assert.Equal("create table TestCreateTableClassWithCharProperty\r\n(\r\n    TheCharProperty char not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableCharProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableCharProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableCharProperty\r\n(\r\n    TheNullableCharProperty char null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDecimalProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDecimalProperty>();

            Assert.Equal("create table TestCreateTableClassWithDecimalProperty\r\n(\r\n    TheDecimalProperty decimal(19,4) not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDecimalProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDecimalProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableDecimalProperty\r\n(\r\n    TheNullableDecimalProperty decimal(19,4) null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDoubleProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDoubleProperty>();

            Assert.Equal("create table TestCreateTableClassWithDoubleProperty\r\n(\r\n    TheDoubleProperty float not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDoubleProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDoubleProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableDoubleProperty\r\n(\r\n    TheNullableDoubleProperty float null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithFloatProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithFloatProperty>();

            Assert.Equal("create table TestCreateTableClassWithFloatProperty\r\n(\r\n    TheFloatProperty float not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableFloatProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableFloatProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableFloatProperty\r\n(\r\n    TheNullableFloatProperty float null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithGuidProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithGuidProperty>();

            Assert.Equal("create table TestCreateTableClassWithGuidProperty\r\n(\r\n    TheGuidProperty uniqueidentifier not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableGuidProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableGuidProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableGuidProperty\r\n(\r\n    TheNullableGuidProperty uniqueidentifier null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDateTimeProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDateTimeProperty>();

            Assert.Equal("create table TestCreateTableClassWithDateTimeProperty\r\n(\r\n    TheDateTimeProperty datetime2 not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDateTimeProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDateTimeProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableDateTimeProperty\r\n(\r\n    TheNullableDateTimeProperty datetime2 null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithDateTimeOffsetProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDateTimeOffsetProperty>();

            Assert.Equal("create table TestCreateTableClassWithDateTimeOffsetProperty\r\n(\r\n    TheDateTimeOffsetProperty datetimeoffset not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithNullableDateTimeOffsetProperty()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableDateTimeOffsetProperty>();

            Assert.Equal("create table TestCreateTableClassWithNullableDateTimeOffsetProperty\r\n(\r\n    TheNullableDateTimeOffsetProperty datetimeoffset null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithUppercaseSqlSyntax_AndNotNull()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>(new CreateTableOptions {SqlSyntaxIsUppercase = true});

            Assert.Equal("CREATE TABLE TestCreateTableClassWithIntProperty\r\n(\r\n    TheIntProperty INT NOT NULL\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithUppercaseSqlSyntax_AndNull()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithNullableIntProperty>(new CreateTableOptions {SqlSyntaxIsUppercase = true});

            Assert.Equal("CREATE TABLE TestCreateTableClassWithNullableIntProperty\r\n(\r\n    TheNullableIntProperty INT NULL\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithIdentifierDelimiter()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>(new CreateTableOptions {DelimitIdentifiers = true});

            Assert.Equal("create table TestCreateTableClassWithIntProperty\r\n(\r\n    [TheIntProperty] int not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithTypeDelimiter()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>(new CreateTableOptions {DelimitTypes = true});

            Assert.Equal("create table TestCreateTableClassWithIntProperty\r\n(\r\n    TheIntProperty [int] not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithIdentifierDelimiter_AndTypeDelimiter()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithIntProperty>(new CreateTableOptions {DelimitIdentifiers = true, DelimitTypes = true});

            Assert.Equal("create table TestCreateTableClassWithIntProperty\r\n(\r\n    [TheIntProperty] [int] not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty_AndTypeDelimiter_AndDefaultTypeSize()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithStringProperty>(new CreateTableOptions {DelimitTypes = true});

            Assert.Equal("create table TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty [varchar](255) null\r\n)", result);
        }

        [Theory]
        [InlineData(-10, "1")]
        [InlineData(-1, "1")]
        [InlineData(0, "1")]
        [InlineData(1, "1")]
        [InlineData(123, "123")]
        [InlineData(6541, "6541")]
        [InlineData(8000, "8000")]
        [InlineData(8001, "max")]
        [InlineData(9001, "max")]
        [InlineData(int.MaxValue, "max")]
        public void ReturnsCreateTableScript_WithClassWithStringProperty_AndSize(int size, string expectedSize)
        {
            var result = CreateTable.Generate<TestCreateTableClassWithStringProperty>(new CreateTableOptions {VarcharSize = size});

            Assert.Equal($"create table TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty varchar({expectedSize}) null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty_AndSize_AndUppercase()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithStringProperty>(new CreateTableOptions {VarcharSize = 8001, SqlSyntaxIsUppercase = true});

            Assert.Equal("CREATE TABLE TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty VARCHAR(MAX) NULL\r\n)", result);
        }

        // SQL Decimal: Precision 1-38 inclusive, Scale 0-Precision inclusive
        [Theory]
        [InlineData(1, 0, "1,0")]
        [InlineData(1, 1, "1,1")]
        [InlineData(37, 0, "37,0")]
        [InlineData(37, 37, "37,37")]
        [InlineData(38, 0, "38,0")]
        [InlineData(38, 1, "38,1")]
        [InlineData(38, 38, "38,38")]
        [InlineData(39, 0, "38,0")]
        [InlineData(39, 38, "38,38")]
        [InlineData(39, 39, "38,38")]
        [InlineData(12, 16, "12,12")]
        public void ReturnsCreateTableScript_WithClassWithDecimalProperty_AndSize(int precision, int scale, string expectedSize)
        {
            var result = CreateTable.Generate<TestCreateTableClassWithDecimalProperty>(new CreateTableOptions {DecimalPrecision = precision, DecimalScale = scale});

            Assert.Equal($"create table TestCreateTableClassWithDecimalProperty\r\n(\r\n    TheDecimalProperty decimal({expectedSize}) not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithMultipleProperties()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithMultipleProperties>();

            Assert.Equal("create table TestCreateTableClassWithMultipleProperties\r\n(\r\n    TheStringProperty varchar(255) null,\r\n    TheIntProperty int not null,\r\n    TheNullableDecimalProperty decimal(19,4) null,\r\n    TheDateTimeOffsetProperty datetimeoffset not null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty_PassedAsType()
        {
            var result = CreateTable.Generate(typeof(TestCreateTableClassWithStringProperty));

            Assert.Equal("create table TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty varchar(255) null\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithStringProperty_PassedAsType_AndOptions()
        {
            var result = CreateTable.Generate(typeof(TestCreateTableClassWithStringProperty), new CreateTableOptions {SqlSyntaxIsUppercase = true});

            Assert.Equal("CREATE TABLE TestCreateTableClassWithStringProperty\r\n(\r\n    TheStringProperty VARCHAR(255) NULL\r\n)", result);
        }

        [Fact]
        public void ReturnsCreateTableScript_WithClassWithVariousAccessProperties_OnlyPublicPropertiesAppear()
        {
            var result = CreateTable.Generate<TestCreateTableClassWithVariusAccessProperties>();

            Assert.Equal("create table TestCreateTableClassWithVariusAccessProperties\r\n(\r\n    ThePublicProperty varchar(255) null\r\n)", result);
        }

        // private properties don't appear

        // inherited properties

        // how to handle objects or enums?
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

    public class TestCreateTableClassWithMultipleProperties
    {
        public string TheStringProperty { get; set; }
        public int TheIntProperty { get; set; }
        public decimal? TheNullableDecimalProperty { get; set; }
        public DateTimeOffset TheDateTimeOffsetProperty { get; set; }
    }

    public class TestCreateTableClassWithVariusAccessProperties
    {
        public string ThePublicProperty { get; set; }
        private int ThePrivateProperty { get; set; }
        internal DateTime TheInternalProperty { get; set; }
        protected double TheProtectedProperty { get; set; }
    }
}