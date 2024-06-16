namespace CD_DVD_Shop
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
            this.lblGames = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGames.Location = new System.Drawing.Point(47, 53);
            this.lblGames.Name = "lblGames";
            this.lblGames.Padding = new System.Windows.Forms.Padding(5);
            this.lblGames.Size = new System.Drawing.Size(92, 42);
            this.lblGames.TabIndex = 0;
            this.lblGames.Text = "IGRE";
            this.lblGames.Click += new System.EventHandler(this.lblGames_Click);
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.BackColor = System.Drawing.Color.Black;
            this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMusic.Location = new System.Drawing.Point(229, 53);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Padding = new System.Windows.Forms.Padding(5);
            this.lblMusic.Size = new System.Drawing.Size(136, 42);
            this.lblMusic.TabIndex = 3;
            this.lblMusic.Text = "GLAZBA";
            this.lblMusic.Click += new System.EventHandler(this.lblMusic_Click);
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.ForeColor = System.Drawing.Color.White;
            this.lblMovies.Location = new System.Drawing.Point(461, 53);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Padding = new System.Windows.Forms.Padding(5);
            this.lblMovies.Size = new System.Drawing.Size(135, 42);
            this.lblMovies.TabIndex = 4;
            this.lblMovies.Text = "FILMOVI";
            this.lblMovies.Click += new System.EventHandler(this.lblMovies_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(53, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(229, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "DODAJ U KOŠARICU";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(53, 157);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(444, 324);
            this.lbItems.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 622);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblGames);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbItems;
    }
}