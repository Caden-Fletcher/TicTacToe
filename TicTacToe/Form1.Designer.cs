namespace TicTacToe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.R1C1 = new System.Windows.Forms.Button();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textOutput
            // 
            this.textOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textOutput.Location = new System.Drawing.Point(12, 33);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(236, 23);
            this.textOutput.TabIndex = 1;
            this.textOutput.TabStop = false;
            this.textOutput.Text = "Round: 0";
            // 
            // R1C1
            // 
            this.R1C1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R1C1.Location = new System.Drawing.Point(12, 62);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(75, 75);
            this.R1C1.TabIndex = 2;
            this.R1C1.TabStop = false;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.button_click);
            // 
            // R1C2
            // 
            this.R1C2.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R1C2.Location = new System.Drawing.Point(93, 62);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(75, 75);
            this.R1C2.TabIndex = 3;
            this.R1C2.TabStop = false;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.button_click);
            // 
            // R1C3
            // 
            this.R1C3.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R1C3.Location = new System.Drawing.Point(173, 62);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(75, 75);
            this.R1C3.TabIndex = 4;
            this.R1C3.TabStop = false;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.button_click);
            // 
            // R2C1
            // 
            this.R2C1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R2C1.Location = new System.Drawing.Point(12, 143);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(75, 75);
            this.R2C1.TabIndex = 5;
            this.R2C1.TabStop = false;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.button_click);
            // 
            // R2C2
            // 
            this.R2C2.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R2C2.Location = new System.Drawing.Point(93, 143);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(75, 75);
            this.R2C2.TabIndex = 6;
            this.R2C2.TabStop = false;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.button_click);
            // 
            // R2C3
            // 
            this.R2C3.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R2C3.Location = new System.Drawing.Point(173, 143);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(75, 75);
            this.R2C3.TabIndex = 7;
            this.R2C3.TabStop = false;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.button_click);
            // 
            // R3C1
            // 
            this.R3C1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R3C1.Location = new System.Drawing.Point(12, 222);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(75, 75);
            this.R3C1.TabIndex = 8;
            this.R3C1.TabStop = false;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.button_click);
            // 
            // R3C2
            // 
            this.R3C2.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R3C2.Location = new System.Drawing.Point(93, 222);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(75, 75);
            this.R3C2.TabIndex = 9;
            this.R3C2.TabStop = false;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.button_click);
            // 
            // R3C3
            // 
            this.R3C3.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R3C3.Location = new System.Drawing.Point(173, 222);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(75, 75);
            this.R3C3.TabIndex = 10;
            this.R3C3.TabStop = false;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 309);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R1C1);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox textOutput;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Button R1C1;
        private Button R1C2;
        private Button R1C3;
        private Button R2C1;
        private Button R2C2;
        private Button R2C3;
        private Button R3C1;
        private Button R3C2;
        private Button R3C3;
    }
}