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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            textOutput = new TextBox();
            R1C1 = new Button();
            R1C2 = new Button();
            R1C3 = new Button();
            R2C1 = new Button();
            R2C2 = new Button();
            R2C3 = new Button();
            R3C1 = new Button();
            R3C2 = new Button();
            R3C3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(260, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Quit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(51, 20);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // textOutput
            // 
            textOutput.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textOutput.Location = new Point(12, 33);
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(236, 23);
            textOutput.TabIndex = 1;
            textOutput.TabStop = false;
            textOutput.Text = "Round: 0";
            // 
            // R1C1
            // 
            R1C1.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R1C1.Location = new Point(12, 62);
            R1C1.Name = "R1C1";
            R1C1.Size = new Size(75, 75);
            R1C1.TabIndex = 2;
            R1C1.TabStop = false;
            R1C1.UseVisualStyleBackColor = true;
            R1C1.Click += button_click;
            // 
            // R1C2
            // 
            R1C2.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R1C2.Location = new Point(93, 62);
            R1C2.Name = "R1C2";
            R1C2.Size = new Size(75, 75);
            R1C2.TabIndex = 3;
            R1C2.TabStop = false;
            R1C2.UseVisualStyleBackColor = true;
            R1C2.Click += button_click;
            // 
            // R1C3
            // 
            R1C3.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R1C3.Location = new Point(173, 62);
            R1C3.Name = "R1C3";
            R1C3.Size = new Size(75, 75);
            R1C3.TabIndex = 4;
            R1C3.TabStop = false;
            R1C3.UseVisualStyleBackColor = true;
            R1C3.Click += button_click;
            // 
            // R2C1
            // 
            R2C1.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R2C1.Location = new Point(12, 143);
            R2C1.Name = "R2C1";
            R2C1.Size = new Size(75, 75);
            R2C1.TabIndex = 5;
            R2C1.TabStop = false;
            R2C1.UseVisualStyleBackColor = true;
            R2C1.Click += button_click;
            // 
            // R2C2
            // 
            R2C2.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R2C2.Location = new Point(93, 143);
            R2C2.Name = "R2C2";
            R2C2.Size = new Size(75, 75);
            R2C2.TabIndex = 6;
            R2C2.TabStop = false;
            R2C2.UseVisualStyleBackColor = true;
            R2C2.Click += button_click;
            // 
            // R2C3
            // 
            R2C3.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R2C3.Location = new Point(173, 143);
            R2C3.Name = "R2C3";
            R2C3.Size = new Size(75, 75);
            R2C3.TabIndex = 7;
            R2C3.TabStop = false;
            R2C3.UseVisualStyleBackColor = true;
            R2C3.Click += button_click;
            // 
            // R3C1
            // 
            R3C1.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R3C1.Location = new Point(12, 222);
            R3C1.Name = "R3C1";
            R3C1.Size = new Size(75, 75);
            R3C1.TabIndex = 8;
            R3C1.TabStop = false;
            R3C1.UseVisualStyleBackColor = true;
            R3C1.Click += button_click;
            // 
            // R3C2
            // 
            R3C2.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R3C2.Location = new Point(93, 222);
            R3C2.Name = "R3C2";
            R3C2.Size = new Size(75, 75);
            R3C2.TabIndex = 9;
            R3C2.TabStop = false;
            R3C2.UseVisualStyleBackColor = true;
            R3C2.Click += button_click;
            // 
            // R3C3
            // 
            R3C3.Font = new Font("Arial Unicode MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            R3C3.Location = new Point(173, 222);
            R3C3.Name = "R3C3";
            R3C3.Size = new Size(75, 75);
            R3C3.TabIndex = 10;
            R3C3.TabStop = false;
            R3C3.UseVisualStyleBackColor = true;
            R3C3.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 309);
            Controls.Add(R3C3);
            Controls.Add(R3C2);
            Controls.Add(R3C1);
            Controls.Add(R2C3);
            Controls.Add(R2C2);
            Controls.Add(R2C1);
            Controls.Add(R1C3);
            Controls.Add(R1C2);
            Controls.Add(R1C1);
            Controls.Add(textOutput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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