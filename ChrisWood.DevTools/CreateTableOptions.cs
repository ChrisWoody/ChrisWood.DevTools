namespace ChrisWood.DevTools
{
    public class CreateTableOptions
    {
        public bool SqlSyntaxIsUppercase { get; set; }

        public static CreateTableOptions Default => new CreateTableOptions();
    }
}