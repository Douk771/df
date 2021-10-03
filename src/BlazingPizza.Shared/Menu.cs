namespace BlazingPizza
{
    public class Menu
    {
        public string ImgUrl { get; }
        public string PageUrl { get; }

        public Menu(string imgUrl, string pageUrl)
        {
            ImgUrl = imgUrl;
            PageUrl = pageUrl;
        }
    }
}