using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _dQuote;
        private Desk _desk;
        
        public DisplayQuote(DeskQuote dQuote, Desk desk)
        {

            _dQuote = dQuote;
            _desk = desk;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuotes addQuotes = (AddQuotes)Tag;
            addQuotes.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            nameData.Text = _dQuote.name;
            dateData.Text = _dQuote.date;
            rushOption.Text = _dQuote.delivery;
            rushCost.Text = _dQuote.calculateRush().ToString("F2");
            totalArea.Text = _desk.calculateArea().ToString("##,#");
            drawerCount.Text = _desk.drawerNumber.ToString();
            drawerCost.Text = _dQuote.calculateDrawer().ToString("F2");
            materialType.Text = _desk.surfaceType;
            materialCost.Text = _dQuote.calculateMaterial().ToString("F2");
            totalCost.Text = _dQuote.calculatePrice().ToString("##,#.00");
            areaCost.Text = _dQuote.calculateSize().ToString("##,#.00");
        }
    }
}
