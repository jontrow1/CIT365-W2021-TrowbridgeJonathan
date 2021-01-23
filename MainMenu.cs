using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuotes addQuotes = new AddQuotes();
            addQuotes.Tag = this;
            addQuotes.Show(this);
            Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
