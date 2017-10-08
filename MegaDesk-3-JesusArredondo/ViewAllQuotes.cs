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

            for (int i = 0; i < deskQuotes.Count; i++) {
                this.Results.Text = deskQuotes.ElementAt(i).date; 
            }
        }
    }
}
 