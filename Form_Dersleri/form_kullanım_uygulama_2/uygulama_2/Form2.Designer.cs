namespace uygulama_2
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şişliManavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beşiktaşManavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furkanManavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şikayetVeTalepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şişliManavToolStripMenuItem,
            this.beşiktaşManavToolStripMenuItem,
            this.furkanManavToolStripMenuItem,
            this.şikayetVeTalepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // şişliManavToolStripMenuItem
            // 
            this.şişliManavToolStripMenuItem.Name = "şişliManavToolStripMenuItem";
            this.şişliManavToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.şişliManavToolStripMenuItem.Text = "Seyit  manav";
            this.şişliManavToolStripMenuItem.Click += new System.EventHandler(this.şişliManavToolStripMenuItem_Click);
            // 
            // beşiktaşManavToolStripMenuItem
            // 
            this.beşiktaşManavToolStripMenuItem.Name = "beşiktaşManavToolStripMenuItem";
            this.beşiktaşManavToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.beşiktaşManavToolStripMenuItem.Text = "Anıl manav";
            this.beşiktaşManavToolStripMenuItem.Click += new System.EventHandler(this.beşiktaşManavToolStripMenuItem_Click);
            // 
            // furkanManavToolStripMenuItem
            // 
            this.furkanManavToolStripMenuItem.Name = "furkanManavToolStripMenuItem";
            this.furkanManavToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.furkanManavToolStripMenuItem.Text = "Furkan Manav";
            this.furkanManavToolStripMenuItem.Click += new System.EventHandler(this.furkanManavToolStripMenuItem_Click);
            // 
            // şikayetVeTalepToolStripMenuItem
            // 
            this.şikayetVeTalepToolStripMenuItem.Name = "şikayetVeTalepToolStripMenuItem";
            this.şikayetVeTalepToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.şikayetVeTalepToolStripMenuItem.Text = "Şikayet ve Talep";
            this.şikayetVeTalepToolStripMenuItem.Click += new System.EventHandler(this.şikayetVeTalepToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şişliManavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beşiktaşManavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furkanManavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şikayetVeTalepToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}