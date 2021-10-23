using CodeHollow.FeedReader;

namespace MovieAlert
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var feed = await FeedReader.ReadAsync("https://hd-source.to/feed");

            Console.WriteLine("Feed Title: " + feed.Title);
            Console.WriteLine("Feed Description: " + feed.Description);
            Console.WriteLine("Feed Image: " + feed.ImageUrl);
            // ...
            foreach (var item in feed.Items)
            {
                Console.WriteLine(item.Title + " - " + item.Link);
            }
        }
    }
}