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
    public partial class ViewAllQuotes : Form
    {
        MainMenuForm mainMenu;

        public ViewAllQuotes(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            mainMenu = mainMenuForm;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        { 
            List<DeskQuote> deskQuotes = new List<DeskQuote>();
            DeskQuote deskQuote = new DeskQuote();
            deskQuotes = deskQuote.readJSONFile("Quotes.json");

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
    }
}
 