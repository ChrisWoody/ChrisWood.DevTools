namespace ChrisWood.DevTools
{
    public class CreateTableOptions
    {
        public static CreateTableOptions Default => new CreateTableOptions();

        public bool SqlSyntaxIsUppercase { get; set; }
        public bool DelimitIdentifiers { get; set; }
        public bool DelimitTypes { get; set; }
        public int VarcharSize { get; set; } = 255;
        public int DecimalPrecision { get; set; } = 19;
        public int DecimalScale { get; set; } = 4;
        public bool IncludePrimaryKeyClusteredConstraint { get; set; }
    }
}