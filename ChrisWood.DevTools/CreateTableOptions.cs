namespace ChrisWood.DevTools
{
    public class CreateTableOptions
    {
        public static CreateTableOptions Default => new CreateTableOptions();

        public bool SqlSyntaxIsUppercase { get; set; }
        public bool DelimitIdentifiers { get; set; }
        public bool DelimitTypes { get; set; }
        public int VarcharLength { get; set; } = 255;
    }
}