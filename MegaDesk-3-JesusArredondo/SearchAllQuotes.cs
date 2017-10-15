using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JesusArredondo
{
    public partial class SearchAllQuotes : Form
    {
        MainMenuForm mainMenu;
        public string criteria { get; set; } 
        public string searchBy { get; set; }

        public SearchAllQuotes(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            mainMenu = mainMenuForm;
        }

        public string getSearchBy() {
            return this.searchBy = this.SearchComboBox.Text;
        }

        public string getCriteria() {
            return this.criteria = this.Criteria.Text;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DeskQuote deskQuote = new DeskQuote();
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            deskQuotes = deskQuote.searchQuotes("Quotes.json", this.searchBy, this);

            this.Results.AppendText("Date" + "\t\t");
            this.Results.AppendText("Client" + "\t");
            this.Results.AppendText("Depth" + "\t");
            this.Results.AppendText("Width" + "\t");
            this.Results.AppendText("Sice" + "\t");
            this.Results.AppendText("Material" + "\t\t");
            this.Results.AppendText("Price" + "\n");

            for (int i = 0; i < deskQuotes.Count; i++) {

                this.Results.AppendText(deskQuotes.ElementAt(i).date + "\t");
                this.Results.AppendText(deskQuotes.ElementAt(i).clientName + "\t");
                this.Results.AppendText(deskQuotes.ElementAt(i).desk.width + "\t");
                this.Results.AppendText(deskQuotes.ElementAt(i).desk.depth + "\t");
                this.Results.AppendText(deskQuotes.ElementAt(i).desk.size + "\t");
                if (deskQuotes.ElementAt(i).desk.material.Equals("Rossewood"))
                {
                    this.Results.AppendText(deskQuotes.ElementAt(i).desk.material + "\t");
                }
                else {
                    this.Results.AppendText(deskQuotes.ElementAt(i).desk.material + "\t\t");
                }
                this.Results.AppendText( "$" + string.Format("{0:n0}",deskQuotes.ElementAt(i).price) + "\n");
            }

            this.Search.Enabled = false;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Hide();
        }
    }
}
