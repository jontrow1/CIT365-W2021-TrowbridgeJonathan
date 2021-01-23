using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuotes : Form
    {

        DateTime todayDate = DateTime.Today;
        private readonly DeskQuote _dquote = new DeskQuote();
        private readonly Desk _desk = new Desk();

        public AddQuotes()
        {
            InitializeComponent();
            dateLabel.Text = todayDate.ToString("MMM dd, yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ValidateDesk()
        {
            var dWidth = widthBox.Text;
            var dDepth = depthBox.Text;
            var drawNum = drawerNum.Text;
            var matType = materialBox.Text;

            if (dWidth != String.Empty)
            {
                _desk.width = Convert.ToInt32(dWidth);
            }
            if (dDepth != String.Empty)
            {
                _desk.depth = Convert.ToInt32(dDepth);
            }
            if (matType != String.Empty)
            {
                _desk.surfaceType = matType;
            }
            if (drawNum != String.Empty)
            {
                _desk.drawerNumber = Convert.ToInt32(drawNum);
            }
        }

        private void ValidateDeskQuote()
        {
            var cName = nameBox.Text;
            var tDate = dateLabel.Text;
            var rTime = rushBox.Text;

            if (cName != String.Empty)
            {
                _dquote.name = cName;
            }
            if (tDate != String.Empty)
            {
                _dquote.date = tDate;
            }
            if (rTime != String.Empty)
            {
                _dquote.delivery = rTime;
            }
            _dquote.desk = _desk;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ValidateDeskQuote();
            ValidateDesk();

            var displayQuote = new DisplayQuote(_dquote, _desk);
            displayQuote.Tag = this;
            displayQuote.Show(this);
            Hide();
        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            if ((Convert.ToInt32(widthBox.Text) < Desk.MINWIDTH) || (Convert.ToInt32(widthBox.Text) > Desk.MAXWIDTH)) {
                MessageBox.Show("The width of the desk must be between 24 and 96 inches wide.");
                widthBox.Clear();
            }
        }

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("That is not a valid integer.");
                e.Handled = true;
            }
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
