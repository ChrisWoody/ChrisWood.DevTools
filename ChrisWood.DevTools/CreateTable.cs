﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ChrisWood.DevTools
{
    public static class CreateTable
    {
        public static string Generate<T>()
        {
            return GenerateInternal(typeof(T), CreateTableOptions.Default);
        }

        public static string Generate(Type type)
        {
            return GenerateInternal(type, CreateTableOptions.Default);
        }

        public static string Generate<T>(CreateTableOptions options)
        {
            return GenerateInternal(typeof(T), options);
        }

        public static string Generate(Type type, CreateTableOptions options)
        {
            return GenerateInternal(type, options);
        }

        private static string GenerateInternal(Type type, CreateTableOptions options)
        {
            var sb = new StringBuilder();
            var tableName = type.Name;

            sb.Append("create table ".ChangeCasing(options));
            sb.AppendLine(tableName);
            sb.AppendLine("(");

            var currentProperty = 0;
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var identifier = options.DelimitIdentifiers ? $"[{property.Name}]" : property.Name;

                var sqlType = GetSqlType(options, property);
                var sqlTypeFormatted = options.DelimitTypes ? $"[{sqlType}]" : sqlType;

                var sizeField = GetSizeField(property.PropertyType, options);

                var isNullable = IsTypeNullable(property.PropertyType);
                var nullField = (isNullable ? "null" : "not null").ChangeCasing(options);

                var comma = ++currentProperty < properties.Length || options.IncludePrimaryKeyClusteredConstraint
                    ? ","
                    : "";

                sb.AppendLine($"    {identifier} {sqlTypeFormatted}{sizeField} {nullField}{comma}");
            }

            if (options.IncludePrimaryKeyClusteredConstraint && properties.Any())
            {
                sb.AppendLine("");

                var propertyName = properties[0].Name;
                var identifier = options.DelimitIdentifiers ? $"[{propertyName}]" :  $"{propertyName}";
                var pkIdentifier = options.DelimitIdentifiers ? $"[PK_{propertyName}]" :  $"PK_{propertyName}";

                var constraintFormat = "    constraint {0} primary key clustered".ChangeCasing(options);
                var primaryKeyFormat = "        {0} asc".ChangeCasing(options);

                sb.AppendLine(string.Format(constraintFormat, pkIdentifier));
                sb.AppendLine("    (");
                sb.AppendLine(string.Format(primaryKeyFormat, identifier));
                sb.AppendLine("    )");
            }

            sb.Append(")");

            return sb.ToString();
        }

        private static string GetSqlType(CreateTableOptions options, PropertyInfo property)
        {
            if (property.PropertyType.IsEnum)
            {
                var underlyingEnumType = Enum.GetUnderlyingType(property.PropertyType);
                return EnumTypeToSqlTypeMap[underlyingEnumType];
            }

            if (TypeToSqlTypeMap.TryGetValue(property.PropertyType, out var result))
                return result.ChangeCasing(options);

            return "varchar".ChangeCasing(options);
        }

        private static string GetSizeField(Type type, CreateTableOptions options)
        {
            var actualSize = string.Empty;

            if (type == typeof(string))
            {
                var varcharSize = options.VarcharSize.ToString();

                if (options.VarcharSize < 1)
                    varcharSize = "1";
                else if (options.VarcharSize > 8000)
                    varcharSize = "max".ChangeCasing(options);

                actualSize = $"({varcharSize})";
            }
            else if (type == typeof(decimal) || type == typeof(decimal?))
            {
                var precision = options.DecimalPrecision;
                var scale = options.DecimalScale;

                if (precision < 1)
                    precision = 1;
                if (precision > 38)
                    precision = 38;

                if (scale < 0)
                    scale = 0;
                if (scale > precision)
                    scale = precision;

                actualSize = $"({precision},{scale})";
            }
            else if (!type.IsEnum && !TypeToSqlTypeMap.ContainsKey(type))
            {
                actualSize = "(max)".ChangeCasing(options);
            }

            return actualSize;
        }

        private static bool IsTypeNullable(Type type)
        {
            return !type.IsValueType || Nullable.GetUnderlyingType(type) != null;
        }

        private static readonly Dictionary<Type, string> TypeToSqlTypeMap = new Dictionary<Type, string>
        {
            {typeof(string), "varchar"},
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
            {typeof(decimal), "decimal"},
            {typeof(decimal?), "decimal"},
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

        private static readonly Dictionary<Type, string> EnumTypeToSqlTypeMap = new Dictionary<Type, string>
        {
            {typeof(byte), "tinyint"},
            {typeof(short), "smallint"},
            {typeof(int), "int"},
            {typeof(long), "bigint"},
        };

        private static string ChangeCasing(this string value, CreateTableOptions options)
        {
            return options.SqlSyntaxIsUppercase ? value.ToUpperInvariant() : value.ToLowerInvariant();
        }
    }
}
