
namespace TicTacToe
{
    partial class TicTacToe
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
            this.grpBoard = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCell12 = new System.Windows.Forms.Label();
            this.lblCell13 = new System.Windows.Forms.Label();
            this.lblCell21 = new System.Windows.Forms.Label();
            this.lblCell22 = new System.Windows.Forms.Label();
            this.lblCell23 = new System.Windows.Forms.Label();
            this.lblCell31 = new System.Windows.Forms.Label();
            this.lblCell32 = new System.Windows.Forms.Label();
            this.lblCell33 = new System.Windows.Forms.Label();
            this.lblCell11 = new System.Windows.Forms.Label();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.lblSymbol1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblSymbol2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoard.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpPlayer1.SuspendLayout();
            this.grpPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoard
            // 
            this.grpBoard.Controls.Add(this.groupBox3);
            this.grpBoard.Controls.Add(this.lblCell12);
            this.grpBoard.Controls.Add(this.lblCell13);
            this.grpBoard.Controls.Add(this.lblCell21);
            this.grpBoard.Controls.Add(this.lblCell22);
            this.grpBoard.Controls.Add(this.lblCell23);
            this.grpBoard.Controls.Add(this.lblCell31);
            this.grpBoard.Controls.Add(this.lblCell32);
            this.grpBoard.Controls.Add(this.lblCell33);
            this.grpBoard.Controls.Add(this.lblCell11);
            this.grpBoard.Location = new System.Drawing.Point(248, 12);
            this.grpBoard.Name = "grpBoard";
            this.grpBoard.Size = new System.Drawing.Size(311, 294);
            this.grpBoard.TabIndex = 0;
            this.grpBoard.TabStop = false;
            this.grpBoard.Tag = "000";
            this.grpBoard.Text = "Game Board";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(340, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 261);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 75);
            this.label13.TabIndex = 3;
            this.label13.Text = "O";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Symbol:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name:";
            // 
            // lblCell12
            // 
            this.lblCell12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell12.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCell12.Location = new System.Drawing.Point(113, 21);
            this.lblCell12.Name = "lblCell12";
            this.lblCell12.Size = new System.Drawing.Size(84, 75);
            this.lblCell12.TabIndex = 8;
            this.lblCell12.Tag = "0,1";
            this.lblCell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell12.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell13
            // 
            this.lblCell13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell13.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell13.Location = new System.Drawing.Point(212, 21);
            this.lblCell13.Name = "lblCell13";
            this.lblCell13.Size = new System.Drawing.Size(84, 75);
            this.lblCell13.TabIndex = 7;
            this.lblCell13.Tag = "0,2,1";
            this.lblCell13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell13.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell21
            // 
            this.lblCell21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell21.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell21.Location = new System.Drawing.Point(13, 111);
            this.lblCell21.Name = "lblCell21";
            this.lblCell21.Size = new System.Drawing.Size(84, 75);
            this.lblCell21.TabIndex = 6;
            this.lblCell21.Tag = "1,0";
            this.lblCell21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell21.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell22
            // 
            this.lblCell22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell22.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell22.ForeColor = System.Drawing.Color.Blue;
            this.lblCell22.Location = new System.Drawing.Point(113, 111);
            this.lblCell22.Name = "lblCell22";
            this.lblCell22.Size = new System.Drawing.Size(84, 75);
            this.lblCell22.TabIndex = 5;
            this.lblCell22.Tag = "1,1,2";
            this.lblCell22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell22.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell23
            // 
            this.lblCell23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell23.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell23.Location = new System.Drawing.Point(212, 111);
            this.lblCell23.Name = "lblCell23";
            this.lblCell23.Size = new System.Drawing.Size(84, 75);
            this.lblCell23.TabIndex = 4;
            this.lblCell23.Tag = "1,2";
            this.lblCell23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell23.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell31
            // 
            this.lblCell31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell31.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell31.Location = new System.Drawing.Point(13, 204);
            this.lblCell31.Name = "lblCell31";
            this.lblCell31.Size = new System.Drawing.Size(84, 75);
            this.lblCell31.TabIndex = 3;
            this.lblCell31.Tag = "2,0,1";
            this.lblCell31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell31.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell32
            // 
            this.lblCell32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell32.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell32.Location = new System.Drawing.Point(113, 204);
            this.lblCell32.Name = "lblCell32";
            this.lblCell32.Size = new System.Drawing.Size(84, 75);
            this.lblCell32.TabIndex = 2;
            this.lblCell32.Tag = "2,1";
            this.lblCell32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell32.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell33
            // 
            this.lblCell33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell33.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell33.Location = new System.Drawing.Point(212, 204);
            this.lblCell33.Name = "lblCell33";
            this.lblCell33.Size = new System.Drawing.Size(84, 75);
            this.lblCell33.TabIndex = 1;
            this.lblCell33.Tag = "2,2,0";
            this.lblCell33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell33.Click += new System.EventHandler(this.SendtoCell);
            // 
            // lblCell11
            // 
            this.lblCell11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell11.Location = new System.Drawing.Point(13, 21);
            this.lblCell11.Name = "lblCell11";
            this.lblCell11.Size = new System.Drawing.Size(84, 75);
            this.lblCell11.TabIndex = 0;
            this.lblCell11.Tag = "0,0,0";
            this.lblCell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell11.Click += new System.EventHandler(this.SendtoCell);
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.grpPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpPlayer1.Controls.Add(this.lblDisplay1);
            this.grpPlayer1.Controls.Add(this.lblSymbol1);
            this.grpPlayer1.Controls.Add(this.label11);
            this.grpPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPlayer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpPlayer1.Location = new System.Drawing.Point(7, 12);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(212, 294);
            this.grpPlayer1.TabIndex = 1;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player 1";
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay1.ForeColor = System.Drawing.Color.Green;
            this.lblDisplay1.Location = new System.Drawing.Point(5, 204);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(201, 27);
            this.lblDisplay1.TabIndex = 4;
            this.lblDisplay1.Text = "Your Turn";
            this.lblDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplay1.Visible = false;
            // 
            // lblSymbol1
            // 
            this.lblSymbol1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSymbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol1.ForeColor = System.Drawing.Color.Red;
            this.lblSymbol1.Location = new System.Drawing.Point(68, 41);
            this.lblSymbol1.Name = "lblSymbol1";
            this.lblSymbol1.Size = new System.Drawing.Size(84, 75);
            this.lblSymbol1.TabIndex = 3;
            this.lblSymbol1.Text = "X";
            this.lblSymbol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Symbol:";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblDisplay2);
            this.grpPlayer2.Controls.Add(this.lblSymbol2);
            this.grpPlayer2.Controls.Add(this.label17);
            this.grpPlayer2.Location = new System.Drawing.Point(582, 12);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(212, 294);
            this.grpPlayer2.TabIndex = 4;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay2.ForeColor = System.Drawing.Color.Green;
            this.lblDisplay2.Location = new System.Drawing.Point(2, 204);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(207, 27);
            this.lblDisplay2.TabIndex = 7;
            this.lblDisplay2.Text = "Your Turn";
            this.lblDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplay2.Visible = false;
            // 
            // lblSymbol2
            // 
            this.lblSymbol2.AutoSize = true;
            this.lblSymbol2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSymbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol2.ForeColor = System.Drawing.Color.Blue;
            this.lblSymbol2.Location = new System.Drawing.Point(68, 41);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.Size = new System.Drawing.Size(84, 75);
            this.lblSymbol2.TabIndex = 3;
            this.lblSymbol2.Text = "O";
            this.lblSymbol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Symbol:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(638, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(719, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.programExit);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(801, 339);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.grpBoard);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 378);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(817, 378);
            this.Name = "TicTacToe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.grpBoard.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoard;
        private System.Windows.Forms.Label lblCell12;
        private System.Windows.Forms.Label lblCell13;
        private System.Windows.Forms.Label lblCell21;
        private System.Windows.Forms.Label lblCell22;
        private System.Windows.Forms.Label lblCell23;
        private System.Windows.Forms.Label lblCell31;
        private System.Windows.Forms.Label lblCell32;
        private System.Windows.Forms.Label lblCell33;
        private System.Windows.Forms.Label lblCell11;
        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSymbol1;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.Label lblSymbol2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.Label lblDisplay2;
    }
}

