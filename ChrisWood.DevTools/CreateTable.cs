using System;
using System.Text;

namespace ChrisWood.DevTools
{
    public static class CreateTable
    {
        public static string Generate<T>()
        {
            var sb = new StringBuilder();

            var tableName = typeof(T).Name;

            sb.Append("CREATE TABLE ");
            sb.AppendLine(tableName);

            sb.AppendLine("(");
            sb.AppendLine("");
            sb.Append(")");

            return sb.ToString();
        }
    }
}
