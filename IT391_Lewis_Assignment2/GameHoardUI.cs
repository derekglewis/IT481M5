using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT391_Lewis_Assignment2
{
    public partial class GameHoardUI : Form
    {
        public GameHoardUI()
        {
            InitializeComponent();
            Load += GameHoardUI_Load;
        }

        private void GameHoardUI_Load(object sender, EventArgs e)
        {
            SetActivePanel(home1);
        }

        private void HomeNavButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(home1);
        }

        public void SetActivePanel(UserControl control)
        {
            home1.Visible = false;
            about1.Visible = false;

            control.Visible = true;
        }

        private void AboutNavButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(about1);
        }
    }
}
