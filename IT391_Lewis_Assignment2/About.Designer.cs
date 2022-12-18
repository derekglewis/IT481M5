
namespace IT391_Lewis_Assignment2
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutLabel = new System.Windows.Forms.Label();
            this.GameHoardLabel = new System.Windows.Forms.Label();
            this.AboutContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AboutLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutLabel.Location = new System.Drawing.Point(329, 129);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(297, 34);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "About Game Hoard";
            // 
            // GameHoardLabel
            // 
            this.GameHoardLabel.AutoSize = true;
            this.GameHoardLabel.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameHoardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GameHoardLabel.Location = new System.Drawing.Point(148, 21);
            this.GameHoardLabel.Name = "GameHoardLabel";
            this.GameHoardLabel.Size = new System.Drawing.Size(658, 91);
            this.GameHoardLabel.TabIndex = 1;
            this.GameHoardLabel.Text = "Game Hoard beta";
            // 
            // AboutContentLabel
            // 
            this.AboutContentLabel.AutoSize = true;
            this.AboutContentLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutContentLabel.Location = new System.Drawing.Point(189, 200);
            this.AboutContentLabel.Name = "AboutContentLabel";
            this.AboutContentLabel.Size = new System.Drawing.Size(623, 216);
            this.AboutContentLabel.TabIndex = 2;
            this.AboutContentLabel.Text = resources.GetString("AboutContentLabel.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AboutContentLabel);
            this.Controls.Add(this.GameHoardLabel);
            this.Controls.Add(this.AboutLabel);
            this.Name = "About";
            this.Size = new System.Drawing.Size(954, 649);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label GameHoardLabel;
        private System.Windows.Forms.Label AboutContentLabel;
    }
}
