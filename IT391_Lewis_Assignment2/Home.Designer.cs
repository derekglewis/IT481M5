
namespace IT391_Lewis_Assignment2
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameHoardLabel = new System.Windows.Forms.Label();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.GameTitleTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.ConsoleComboBox = new System.Windows.Forms.ComboBox();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.DeveloperTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.ReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.MetacriticLabel = new System.Windows.Forms.Label();
            this.MetacriticTextBox = new System.Windows.Forms.TextBox();
            this.GameTitleFlagTextBox = new System.Windows.Forms.TextBox();
            this.ConsoleFlagTextBox = new System.Windows.Forms.TextBox();
            this.DeveloperFlagTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateFlagTextBox = new System.Windows.Forms.TextBox();
            this.GenreFlagTextBox = new System.Windows.Forms.TextBox();
            this.MetacriticFlagTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GameHoardLabel
            // 
            this.GameHoardLabel.AutoSize = true;
            this.GameHoardLabel.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameHoardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GameHoardLabel.Location = new System.Drawing.Point(148, 21);
            this.GameHoardLabel.Name = "GameHoardLabel";
            this.GameHoardLabel.Size = new System.Drawing.Size(658, 91);
            this.GameHoardLabel.TabIndex = 0;
            this.GameHoardLabel.Text = "Game Hoard beta";
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitleLabel.Location = new System.Drawing.Point(30, 152);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(163, 32);
            this.GameTitleLabel.TabIndex = 1;
            this.GameTitleLabel.Text = "Game Title:";
            // 
            // GameTitleTextBox
            // 
            this.GameTitleTextBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitleTextBox.Location = new System.Drawing.Point(194, 150);
            this.GameTitleTextBox.Name = "GameTitleTextBox";
            this.GameTitleTextBox.Size = new System.Drawing.Size(212, 38);
            this.GameTitleTextBox.TabIndex = 2;
            this.GameTitleTextBox.TextChanged += new System.EventHandler(this.GameTitleTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.Location = new System.Drawing.Point(396, 495);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(162, 50);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageTextBox.ForeColor = System.Drawing.Color.Red;
            this.MessageTextBox.Location = new System.Drawing.Point(0, 561);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(954, 23);
            this.MessageTextBox.TabIndex = 4;
            this.MessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleLabel.Location = new System.Drawing.Point(463, 152);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(128, 32);
            this.ConsoleLabel.TabIndex = 1;
            this.ConsoleLabel.Text = "Console:";
            // 
            // ConsoleComboBox
            // 
            this.ConsoleComboBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleComboBox.FormattingEnabled = true;
            this.ConsoleComboBox.Items.AddRange(new object[] {
            "Nintendo Switch",
            "Playstation 5",
            "Xbox Series X",
            "PC",
            "Atari 2600",
            "Sega Dreamcast",
            "Other"});
            this.ConsoleComboBox.Location = new System.Drawing.Point(701, 150);
            this.ConsoleComboBox.Name = "ConsoleComboBox";
            this.ConsoleComboBox.Size = new System.Drawing.Size(212, 39);
            this.ConsoleComboBox.TabIndex = 5;
            this.ConsoleComboBox.Text = "Select Console...";
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeveloperLabel.Location = new System.Drawing.Point(30, 284);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(157, 32);
            this.DeveloperLabel.TabIndex = 6;
            this.DeveloperLabel.Text = "Developer:";
            // 
            // DeveloperTextBox
            // 
            this.DeveloperTextBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeveloperTextBox.Location = new System.Drawing.Point(194, 282);
            this.DeveloperTextBox.Name = "DeveloperTextBox";
            this.DeveloperTextBox.Size = new System.Drawing.Size(212, 38);
            this.DeveloperTextBox.TabIndex = 7;
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateLabel.Location = new System.Drawing.Point(463, 284);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(196, 32);
            this.ReleaseDateLabel.TabIndex = 8;
            this.ReleaseDateLabel.Text = "Release Date:";
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReleaseDatePicker.Location = new System.Drawing.Point(701, 279);
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(212, 38);
            this.ReleaseDatePicker.TabIndex = 9;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreLabel.Location = new System.Drawing.Point(30, 416);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(103, 32);
            this.GenreLabel.TabIndex = 10;
            this.GenreLabel.Text = "Genre:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Fighter",
            "Puzzle",
            "Racing",
            "RPG",
            "Sports",
            "Other"});
            this.GenreComboBox.Location = new System.Drawing.Point(194, 414);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(212, 39);
            this.GenreComboBox.TabIndex = 11;
            this.GenreComboBox.Text = "Select Genre...";
            // 
            // MetacriticLabel
            // 
            this.MetacriticLabel.AutoSize = true;
            this.MetacriticLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MetacriticLabel.Location = new System.Drawing.Point(463, 416);
            this.MetacriticLabel.Name = "MetacriticLabel";
            this.MetacriticLabel.Size = new System.Drawing.Size(239, 32);
            this.MetacriticLabel.TabIndex = 12;
            this.MetacriticLabel.Text = "Metacritic Score:";
            // 
            // MetacriticTextBox
            // 
            this.MetacriticTextBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MetacriticTextBox.Location = new System.Drawing.Point(701, 414);
            this.MetacriticTextBox.Name = "MetacriticTextBox";
            this.MetacriticTextBox.Size = new System.Drawing.Size(212, 38);
            this.MetacriticTextBox.TabIndex = 13;
            // 
            // GameTitleFlagTextBox
            // 
            this.GameTitleFlagTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.GameTitleFlagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameTitleFlagTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameTitleFlagTextBox.ForeColor = System.Drawing.Color.Red;
            this.GameTitleFlagTextBox.Location = new System.Drawing.Point(412, 150);
            this.GameTitleFlagTextBox.Name = "GameTitleFlagTextBox";
            this.GameTitleFlagTextBox.Size = new System.Drawing.Size(23, 36);
            this.GameTitleFlagTextBox.TabIndex = 14;
            // 
            // ConsoleFlagTextBox
            // 
            this.ConsoleFlagTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ConsoleFlagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleFlagTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleFlagTextBox.ForeColor = System.Drawing.Color.Red;
            this.ConsoleFlagTextBox.Location = new System.Drawing.Point(919, 150);
            this.ConsoleFlagTextBox.Name = "ConsoleFlagTextBox";
            this.ConsoleFlagTextBox.Size = new System.Drawing.Size(23, 36);
            this.ConsoleFlagTextBox.TabIndex = 15;
            // 
            // DeveloperFlagTextBox
            // 
            this.DeveloperFlagTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DeveloperFlagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperFlagTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeveloperFlagTextBox.ForeColor = System.Drawing.Color.Red;
            this.DeveloperFlagTextBox.Location = new System.Drawing.Point(412, 282);
            this.DeveloperFlagTextBox.Name = "DeveloperFlagTextBox";
            this.DeveloperFlagTextBox.Size = new System.Drawing.Size(23, 36);
            this.DeveloperFlagTextBox.TabIndex = 16;
            // 
            // ReleaseDateFlagTextBox
            // 
            this.ReleaseDateFlagTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ReleaseDateFlagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReleaseDateFlagTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateFlagTextBox.ForeColor = System.Drawing.Color.Red;
            this.ReleaseDateFlagTextBox.Location = new System.Drawing.Point(919, 279);
            this.ReleaseDateFlagTextBox.Name = "ReleaseDateFlagTextBox";
            this.ReleaseDateFlagTextBox.Size = new System.Drawing.Size(23, 36);
            this.ReleaseDateFlagTextBox.TabIndex = 17;
            // 
            // GenreFlagTextBox
            // 
            this.GenreFlagTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.GenreFlagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreFlagTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreFlagTextBox.ForeColor = System.Drawing.Color.Red;
            this.GenreFlagTextBox.Location = new System.Drawing.Point(412, 414);
            this.GenreFlagTextBox.Name = "GenreFlagTextBox";
            this.GenreFlagTextBox.Size = new System.Drawing.Size(23, 36);
            this.GenreFlagTextBox.TabIndex = 18;
            // 
            // MetacriticFlagTextBox
            // 
            this.MetacriticFlagTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MetacriticFlagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetacriticFlagTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MetacriticFlagTextBox.ForeColor = System.Drawing.Color.Red;
            this.MetacriticFlagTextBox.Location = new System.Drawing.Point(919, 414);
            this.MetacriticFlagTextBox.Name = "MetacriticFlagTextBox";
            this.MetacriticFlagTextBox.Size = new System.Drawing.Size(23, 36);
            this.MetacriticFlagTextBox.TabIndex = 19;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MetacriticFlagTextBox);
            this.Controls.Add(this.GenreFlagTextBox);
            this.Controls.Add(this.ReleaseDateFlagTextBox);
            this.Controls.Add(this.DeveloperFlagTextBox);
            this.Controls.Add(this.ConsoleFlagTextBox);
            this.Controls.Add(this.GameTitleFlagTextBox);
            this.Controls.Add(this.MetacriticTextBox);
            this.Controls.Add(this.MetacriticLabel);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.ReleaseDatePicker);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.DeveloperTextBox);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.ConsoleComboBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.GameTitleTextBox);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.GameTitleLabel);
            this.Controls.Add(this.GameHoardLabel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(954, 649);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameHoardLabel;
        private System.Windows.Forms.Label GameTitleLabel;
        private System.Windows.Forms.TextBox GameTitleTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.ComboBox ConsoleComboBox;
        private System.Windows.Forms.Label DeveloperLabel;
        private System.Windows.Forms.TextBox DeveloperTextBox;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.DateTimePicker ReleaseDatePicker;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label MetacriticLabel;
        private System.Windows.Forms.TextBox MetacriticTextBox;
        private System.Windows.Forms.TextBox GameTitleFlagTextBox;
        private System.Windows.Forms.TextBox ConsoleFlagTextBox;
        private System.Windows.Forms.TextBox DeveloperFlagTextBox;
        private System.Windows.Forms.TextBox ReleaseDateFlagTextBox;
        private System.Windows.Forms.TextBox GenreFlagTextBox;
        private System.Windows.Forms.TextBox MetacriticFlagTextBox;
    }
}
