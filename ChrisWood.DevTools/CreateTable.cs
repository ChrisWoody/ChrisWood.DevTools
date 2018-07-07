using System;
using System.Collections.Generic;
using System.Text;

namespace ChrisWood.DevTools
{
    public static class CreateTable
    {
        public static string Generate<T>()
        {
            return Generate<T>(CreateTableOptions.Default);
        }

        public static string Generate<T>(CreateTableOptions options)
        {
            var sb = new StringBuilder();
            var type = typeof(T);
            var tableName = typeof(T).Name;

            sb.Append("create table ".ChangeCasing(options));
            sb.AppendLine(tableName);
            sb.AppendLine("(");

            foreach (var property in type.GetProperties())
            {
                var identifier = options.DelimitIdentifiers ? $"[{property.Name}]" : property.Name;

                var sqlType = TypeToSqlTypeMap[property.PropertyType].ChangeCasing(options);
                var sqlTypeFormatted = options.DelimitTypes ? $"[{sqlType}]" : sqlType;

                var isNullable = IsTypeNullable(property.PropertyType);
                var nullField = (isNullable ? "null" : "not null").ChangeCasing(options);

                sb.AppendLine($"    {identifier} {sqlTypeFormatted} {nullField}");
            }

            sb.Append(")");

            return sb.ToString();
        }

        private static bool IsTypeNullable(Type type)
        {
            return !type.IsValueType || Nullable.GetUnderlyingType(type) != null;
        }

        private static readonly Dictionary<Type, string> TypeToSqlTypeMap = new Dictionary<Type, string>
        {
            {typeof(string), "varchar(255)"},
            {typeof(int), "int"},
            {typeof(int?), "int"},
            {typeof(long), "bigint"},
            {typeof(long?), "bigint"},
            {typeof(short), "smallint"},
            {typeof(short?), "smallint"},
            {typeof(byte), "tinyint"},
            {typeof(byte?), "tinyint"},
            {typeof(bool), "bit"},
            {typeof(bool?), "bit"},
            {typeof(char), "char"},
            {typeof(char?), "char"},
            {typeof(decimal), "decimal(19,4)"},
            {typeof(decimal?), "decimal(19,4)"},
            {typeof(double), "float"},
            {typeof(double?), "float"},
            {typeof(float), "float"},
            {typeof(float?), "float"},
            {typeof(Guid), "uniqueidentifier"},
            {typeof(Guid?), "uniqueidentifier"},
            {typeof(DateTime), "datetime2"},
            {typeof(DateTime?), "datetime2"},
            {typeof(DateTimeOffset), "datetimeoffset"},
            {typeof(DateTimeOffset?), "datetimeoffset"},
        };

        private static string ChangeCasing(this string value, CreateTableOptions options)
        {
            return options.SqlSyntaxIsUppercase ? value.ToUpperInvariant() : value.ToLowerInvariant();
        }
    }
}
