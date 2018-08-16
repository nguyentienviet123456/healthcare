namespace Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SepPageTitle { get; set; }
        string SeoAlias { get; set; }
        string SeoKeywords { get; set; }
        string SeoDescription { get; set; }
    }
}