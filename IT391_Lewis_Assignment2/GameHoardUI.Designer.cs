
namespace IT391_Lewis_Assignment2
{
    partial class GameHoardUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeNavButton = new System.Windows.Forms.Button();
            this.AboutNavButton = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.about1 = new IT391_Lewis_Assignment2.About();
            this.home1 = new IT391_Lewis_Assignment2.Home();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeNavButton
            // 
            this.HomeNavButton.Location = new System.Drawing.Point(17, 12);
            this.HomeNavButton.Name = "HomeNavButton";
            this.HomeNavButton.Size = new System.Drawing.Size(257, 92);
            this.HomeNavButton.TabIndex = 0;
            this.HomeNavButton.Text = "Home";
            this.HomeNavButton.UseVisualStyleBackColor = true;
            this.HomeNavButton.Click += new System.EventHandler(this.HomeNavButton_Click);
            // 
            // AboutNavButton
            // 
            this.AboutNavButton.Location = new System.Drawing.Point(17, 130);
            this.AboutNavButton.Name = "AboutNavButton";
            this.AboutNavButton.Size = new System.Drawing.Size(257, 92);
            this.AboutNavButton.TabIndex = 1;
            this.AboutNavButton.Text = "About";
            this.AboutNavButton.UseVisualStyleBackColor = true;
            this.AboutNavButton.Click += new System.EventHandler(this.AboutNavButton_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.about1);
            this.PanelContainer.Controls.Add(this.home1);
            this.PanelContainer.Location = new System.Drawing.Point(296, 12);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(954, 649);
            this.PanelContainer.TabIndex = 2;
            // 
            // about1
            // 
            this.about1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about1.Location = new System.Drawing.Point(0, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(954, 649);
            this.about1.TabIndex = 3;
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(954, 649);
            this.home1.TabIndex = 0;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(290, 673);
            this.NavPanel.TabIndex = 3;
            // 
            // GameHoardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.AboutNavButton);
            this.Controls.Add(this.HomeNavButton);
            this.Controls.Add(this.NavPanel);
            this.Name = "GameHoardUI";
            this.Text = "Game Hoard";
            this.PanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeNavButton;
        private System.Windows.Forms.Button AboutNavButton;
        private System.Windows.Forms.Panel PanelContainer;
        private About about1;
        private Home home1;
        private System.Windows.Forms.Panel NavPanel;
    }
}

