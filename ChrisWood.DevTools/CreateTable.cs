using System;
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
                sb.AppendLine($"    {property.Name} varchar(255)");
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}
