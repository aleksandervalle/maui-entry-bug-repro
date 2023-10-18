namespace MauiEntryBugRepro
{

    public partial class MainPage : ContentPage
    {
        public string MyText { get; set; }

        public MainPage()
        {
            InitializeComponent();

            MyEntry.SizeChanged += MyEntry_SizeChanged;
        }

        private void MyEntry_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Size changed...");
        }
    }
}
