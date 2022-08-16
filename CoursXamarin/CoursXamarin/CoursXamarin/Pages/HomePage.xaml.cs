using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursXamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentView
    {
        public HomePage()
        {
            InitializeComponent();
            GenerateContent();
        }

        private void GenerateContent()
        {
            StackLayout stackLayout = new StackLayout();
            Content = stackLayout;
            Label label = new Label() { Text = "content of label" };
            stackLayout.Children.Add(label);
        }
    }
}