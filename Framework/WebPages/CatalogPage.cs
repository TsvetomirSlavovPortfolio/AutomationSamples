namespace Framework.WebPages
{
    public class CatalogPage
    {
        public bool IsTopic(string topic)
        {
            return Browser.Title.Contains(topic);
        }
    }
}