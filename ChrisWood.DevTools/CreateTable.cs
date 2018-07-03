using System;
using System.Collections.Generic;
using System.Text;

namespace ChrisWood.DevTools
{
    public static class CreateTable
    {
        public static string Generate<T>()
        {
            var sb = new StringBuilder();
            var type = typeof(T);
            var tableName = typeof(T).Name;

            sb.Append("CREATE TABLE ");
            sb.AppendLine(tableName);
            sb.AppendLine("(");

            foreach (var property in type.GetProperties())
            {
                var sqlType = TypeToSqlTypeMap[property.PropertyType];

                sb.AppendLine($"    {property.Name} {sqlType}");
            }

            sb.Append(")");

            return sb.ToString();
        }

        private static readonly Dictionary<Type, string> TypeToSqlTypeMap = new Dictionary<Type, string>
        {
            {typeof(string), "varchar(255)"},
            {typeof(int), "int"},
            {typeof(long), "bigint"},
            {typeof(short), "smallint"},
            {typeof(byte), "tinyint"},
            {typeof(bool), "bit"},
            {typeof(char), "char"},
            {typeof(decimal), "decimal"},
            {typeof(double), "float"},
            {typeof(float), "float"},
            {typeof(Guid), "uniqueidentifier"},
            {typeof(DateTime), "datetime2"},
            {typeof(DateTimeOffset), "datetimeoffset"},
        };
    }
}
