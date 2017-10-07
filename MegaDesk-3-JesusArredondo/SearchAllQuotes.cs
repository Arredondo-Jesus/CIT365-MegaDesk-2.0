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

        public SearchAllQuotes(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            mainMenu = mainMenuForm;
        }

        private void SearchAllQutotesButton_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Hide();
        }
    }
}
