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
    public partial class MainMenuForm : Form
    {
        MainMenuForm mainMenuForm;
        SearchAllQuotes searchAllQuotes;
        AddQuote addQuote;
        ViewAllQuotes viewAllQuotes;

        public MainMenuForm()
        {
            InitializeComponent();
            addQuote = new AddQuote(this);
            searchAllQuotes = new SearchAllQuotes(this);
            viewAllQuotes = new ViewAllQuotes(this);
            this.mainMenuForm = this;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            searchAllQuotes.Show();
            this.Hide();
        }

        private void AddQuotesButton_Click(object sender, EventArgs e)
        {
            
            addQuote.Show();
            this.Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
 
            viewAllQuotes.Show();
            this.Hide();
        }
    }
}
