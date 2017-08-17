namespace WebApi.Model
{
    public class Doc
    {
        public string web_url { get; set; }
        public string snippet { get; set; }
        public Headline headline { get; set; }
        public string pub_date { get; set; }
        public bool isValid { get; set;}
    }
}