namespace tictactoe
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.startPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.systemPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nvnButton = new System.Windows.Forms.RadioButton();
            this.pvnButton = new System.Windows.Forms.RadioButton();
            this.pvpButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fromRandom = new System.Windows.Forms.RadioButton();
            this.fromPlayer2 = new System.Windows.Forms.RadioButton();
            this.fromPlayer1 = new System.Windows.Forms.RadioButton();
            this.goTopButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.serifBox = new System.Windows.Forms.TextBox();
            this.faceBox2 = new System.Windows.Forms.PictureBox();
            this.faceBox = new System.Windows.Forms.PictureBox();
            this.gameStartButton = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.startPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.systemPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).BeginInit();
            this.gameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.BackColor = System.Drawing.SystemColors.Control;
            this.startPanel.Controls.Add(this.gamePanel);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(265, 356);
            this.startPanel.TabIndex = 0;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.gamePanel.Controls.Add(this.systemPanel);
            this.gamePanel.Controls.Add(this.goTopButton);
            this.gamePanel.Controls.Add(this.statusBox);
            this.gamePanel.Controls.Add(this.serifBox);
            this.gamePanel.Controls.Add(this.faceBox2);
            this.gamePanel.Controls.Add(this.faceBox);
            this.gamePanel.Controls.Add(this.gameStartButton);
            this.gamePanel.Controls.Add(this.gameBoard);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(265, 356);
            this.gamePanel.TabIndex = 1;
            // 
            // systemPanel
            // 
            this.systemPanel.Controls.Add(this.panel1);
            this.systemPanel.Controls.Add(this.panel2);
            this.systemPanel.Location = new System.Drawing.Point(53, 97);
            this.systemPanel.Name = "systemPanel";
            this.systemPanel.Size = new System.Drawing.Size(174, 167);
            this.systemPanel.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nvnButton);
            this.panel1.Controls.Add(this.pvnButton);
            this.panel1.Controls.Add(this.pvpButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 73);
            this.panel1.TabIndex = 31;
            // 
            // nvnButton
            // 
            this.nvnButton.AutoSize = true;
            this.nvnButton.Location = new System.Drawing.Point(3, 51);
            this.nvnButton.Name = "nvnButton";
            this.nvnButton.Size = new System.Drawing.Size(141, 16);
            this.nvnButton.TabIndex = 32;
            this.nvnButton.Text = "Computer vs Computer";
            this.nvnButton.UseVisualStyleBackColor = true;
            // 
            // pvnButton
            // 
            this.pvnButton.AutoSize = true;
            this.pvnButton.Location = new System.Drawing.Point(3, 29);
            this.pvnButton.Name = "pvnButton";
            this.pvnButton.Size = new System.Drawing.Size(124, 16);
            this.pvnButton.TabIndex = 31;
            this.pvnButton.Text = "Player vs Computer";
            this.pvnButton.UseVisualStyleBackColor = true;
            // 
            // pvpButton
            // 
            this.pvpButton.AutoSize = true;
            this.pvpButton.Checked = true;
            this.pvpButton.Location = new System.Drawing.Point(3, 7);
            this.pvpButton.Name = "pvpButton";
            this.pvpButton.Size = new System.Drawing.Size(107, 16);
            this.pvpButton.TabIndex = 30;
            this.pvpButton.TabStop = true;
            this.pvpButton.Text = "Player vs Player";
            this.pvpButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.fromRandom);
            this.panel2.Controls.Add(this.fromPlayer2);
            this.panel2.Controls.Add(this.fromPlayer1);
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 81);
            this.panel2.TabIndex = 32;
            // 
            // fromRandom
            // 
            this.fromRandom.AutoSize = true;
            this.fromRandom.Location = new System.Drawing.Point(3, 44);
            this.fromRandom.Name = "fromRandom";
            this.fromRandom.Size = new System.Drawing.Size(59, 16);
            this.fromRandom.TabIndex = 2;
            this.fromRandom.Text = "ランダム";
            this.fromRandom.UseVisualStyleBackColor = true;
            // 
            // fromPlayer2
            // 
            this.fromPlayer2.AutoSize = true;
            this.fromPlayer2.Location = new System.Drawing.Point(3, 25);
            this.fromPlayer2.Name = "fromPlayer2";
            this.fromPlayer2.Size = new System.Drawing.Size(100, 16);
            this.fromPlayer2.TabIndex = 1;
            this.fromPlayer2.Text = "プレイヤー2先手";
            this.fromPlayer2.UseVisualStyleBackColor = true;
            // 
            // fromPlayer1
            // 
            this.fromPlayer1.AutoSize = true;
            this.fromPlayer1.Checked = true;
            this.fromPlayer1.Location = new System.Drawing.Point(3, 3);
            this.fromPlayer1.Name = "fromPlayer1";
            this.fromPlayer1.Size = new System.Drawing.Size(100, 16);
            this.fromPlayer1.TabIndex = 0;
            this.fromPlayer1.TabStop = true;
            this.fromPlayer1.Text = "プレイヤー1先手";
            this.fromPlayer1.UseVisualStyleBackColor = true;
            // 
            // goTopButton
            // 
            this.goTopButton.Location = new System.Drawing.Point(178, 321);
            this.goTopButton.Name = "goTopButton";
            this.goTopButton.Size = new System.Drawing.Size(75, 23);
            this.goTopButton.TabIndex = 29;
            this.goTopButton.Text = "Go Top";
            this.goTopButton.UseVisualStyleBackColor = true;
            this.goTopButton.Click += new System.EventHandler(this.goTopButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(82, 7);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(101, 19);
            this.statusBox.TabIndex = 28;
            // 
            // serifBox
            // 
            this.serifBox.Location = new System.Drawing.Point(82, 32);
            this.serifBox.Multiline = true;
            this.serifBox.Name = "serifBox";
            this.serifBox.ReadOnly = true;
            this.serifBox.Size = new System.Drawing.Size(101, 71);
            this.serifBox.TabIndex = 27;
            // 
            // faceBox2
            // 
            this.faceBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.faceBox2.Location = new System.Drawing.Point(189, 43);
            this.faceBox2.Name = "faceBox2";
            this.faceBox2.Size = new System.Drawing.Size(64, 64);
            this.faceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faceBox2.TabIndex = 26;
            this.faceBox2.TabStop = false;
            // 
            // faceBox
            // 
            this.faceBox.BackColor = System.Drawing.Color.Coral;
            this.faceBox.Location = new System.Drawing.Point(12, 7);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(64, 64);
            this.faceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faceBox.TabIndex = 25;
            this.faceBox.TabStop = false;
            // 
            // gameStartButton
            // 
            this.gameStartButton.Location = new System.Drawing.Point(178, 321);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(75, 23);
            this.gameStartButton.TabIndex = 0;
            this.gameStartButton.Text = "GameStart";
            this.gameStartButton.UseVisualStyleBackColor = true;
            this.gameStartButton.Click += new System.EventHandler(this.gameStartButtonClick);
            // 
            // gameBoard
            // 
            this.gameBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gameBoard.ColumnCount = 3;
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameBoard.Controls.Add(this.pictureBox9, 2, 2);
            this.gameBoard.Controls.Add(this.pictureBox2, 1, 0);
            this.gameBoard.Controls.Add(this.pictureBox1, 0, 0);
            this.gameBoard.Controls.Add(this.pictureBox8, 1, 2);
            this.gameBoard.Controls.Add(this.pictureBox3, 2, 0);
            this.gameBoard.Controls.Add(this.pictureBox7, 0, 2);
            this.gameBoard.Controls.Add(this.pictureBox6, 2, 1);
            this.gameBoard.Controls.Add(this.pictureBox4, 0, 1);
            this.gameBoard.Controls.Add(this.pictureBox5, 1, 1);
            this.gameBoard.Location = new System.Drawing.Point(12, 109);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.RowCount = 3;
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameBoard.Size = new System.Drawing.Size(241, 206);
            this.gameBoard.TabIndex = 24;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Location = new System.Drawing.Point(164, 140);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 62);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(84, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(84, 140);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(73, 62);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(164, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(4, 140);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(73, 62);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(164, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(73, 61);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(4, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.cellClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(84, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.cellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(265, 356);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.startPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.systemPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).EndInit();
            this.gameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel gameBoard;
        private System.Windows.Forms.PictureBox faceBox;
        private System.Windows.Forms.PictureBox faceBox2;
        private System.Windows.Forms.TextBox serifBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button goTopButton;
        private System.Windows.Forms.Panel systemPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton nvnButton;
        private System.Windows.Forms.RadioButton pvnButton;
        private System.Windows.Forms.RadioButton pvpButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton fromRandom;
        private System.Windows.Forms.RadioButton fromPlayer2;
        private System.Windows.Forms.RadioButton fromPlayer1;
    }
    
}

