using CodeHollow.FeedReader;

namespace MovieAlert
{
    public partial class FrmMain : Form
    {
        private readonly List<MovieItem> movieItems = new List<MovieItem>();

        public FrmMain()
        {
            this.InitializeComponent();            
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddIfMissing(MovieItem item)
        {
            foreach (var movieItem in movieItems)
            {
                if (movieItem.Id == item.Id)
                {
                    return;
                }
            }

            this.movieItems.Add((MovieItem)item);
        }

        private void ShowItems()
        {
            this.listView1.Items.Clear();
            foreach (var item in this.movieItems)
            {
                var listviewitem = new ListViewItem(item.PublishingDate.ToString());
                listviewitem.Font = new Font("Segui UI", 10, FontStyle.Bold);
                listviewitem.SubItems.Add(item.Title);
                this.listView1.Items.Add(listviewitem);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var feed = await FeedReader.ReadAsync("https://hd-source.to/feed");

            foreach (var item in feed.Items)
            {
                if (!item.Title.Contains("720p"))
                {
                    continue;
                }

                this.AddIfMissing(new MovieItem(item));
            }

            this.ShowItems();
        }
    }
}