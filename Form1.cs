using WinFormsApp1.Infrastucture;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static TokensViewModel Tokens = new();
        public Form1()
        {
            InitializeComponent();

            TokensCreator tokenCreator = new();
            for (int i = 0; i < 5; i++)
            {
                Tokens.Append((Token)tokenCreator.GetContact());
            }

            Tokens.AddToListView(listView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.lv = listView1;
            f2.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            Tokens.AddToListView(listView1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            Tokens.Delete(int.Parse(listView1.Items[index].SubItems[0].Text));

            listView1.Items.Clear();

            Tokens.AddToListView(listView1);
        }
    }
}