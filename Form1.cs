using WinFormsApp1.Infrastucture;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TokensCreator tokenCreator = new();
            TokensViewModel tokens = new();
            for (int i = 0; i < 5; i++)
            {
                tokens.Append((Token)tokenCreator.GetContact());
            }

            tokens.AddToListView(listView1);
        }
    }
}