using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT391_Lewis_Assignment2
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void GameTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            GameTitleFlagTextBox.Text = "";
            ConsoleFlagTextBox.Text = "";
            DeveloperFlagTextBox.Text = "";
            ReleaseDateFlagTextBox.Text = "";
            GenreFlagTextBox.Text = "";
            MetacriticFlagTextBox.Text = "";

            if (GameTitleTextBox.Text.Length > 100 || GameTitleTextBox.Text.Length == 0)
            {
                MessageTextBox.Text = "*A Game Title of 100 or fewer characters is required.";
                GameTitleFlagTextBox.Text = "*";
                return;
            }

            if (ConsoleComboBox.Text != "Nintendo Switch" && ConsoleComboBox.Text != "Playstation 5" && ConsoleComboBox.Text != "Xbox Series X"
   && ConsoleComboBox.Text != "PC" && ConsoleComboBox.Text != "Atari 2600" && ConsoleComboBox.Text != "Sega Dreamcast" && ConsoleComboBox.Text != "Other")
            {
                MessageTextBox.Text = "*Please select a Console from the list.";
                ConsoleFlagTextBox.Text = "*";
                return;
            }

            if (DeveloperTextBox.Text.Length > 50)
            {
                MessageTextBox.Text = "*Developer names should be 50 characters or fewer.";
                DeveloperFlagTextBox.Text = "*";
                return;
            }

            if (ReleaseDatePicker.Value > DateTime.Now)
            {
                MessageTextBox.Text = "*Please choose a current or previous Date.";
                ReleaseDateFlagTextBox.Text = "*";
                return;
            }

            if (GenreComboBox.Text != "Action" && GenreComboBox.Text != "Adventure" && GenreComboBox.Text != "Fighter" && GenreComboBox.Text != "Puzzle"
    && GenreComboBox.Text != "Racing" && GenreComboBox.Text != "RPG" && GenreComboBox.Text != "Sports" && GenreComboBox.Text != "Other")
            {
                MessageTextBox.Text = "*Please choose a Genre from the list.";
                GenreFlagTextBox.Text = "*";
                return;
            }

            if (!Regex.Match(MetacriticTextBox.Text, "^[0-9]+$").Success)
            {
                MessageTextBox.Text = "*Metacritic Score is required and may not contain letters or special characters.";
                MetacriticFlagTextBox.Text = "*";
                return;
            }

            if (int.Parse(MetacriticTextBox.Text) < 0 || int.Parse(MetacriticTextBox.Text) > 100)
            {
                MessageTextBox.Text = "*Please enter an integer Metacritic Score between 0 and 100.";
                MetacriticFlagTextBox.Text = "*";
                return;
            }

            else
            {
                MessageBox.Show("Game has been successfully added to collection!", "Success");



                GameTitleTextBox.Text = "";
                ConsoleComboBox.Text = "Select Console...";
                DeveloperTextBox.Text = "";
                ReleaseDatePicker.Value = DateTime.Now;
                GenreComboBox.Text = "Select a Genre...";
                MetacriticTextBox.Text = "";
                MessageTextBox.Text = "";

                return;
            }


        }
    }
}
