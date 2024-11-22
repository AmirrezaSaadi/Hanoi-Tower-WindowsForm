namespace Hanoi_Tower
{
    partial class Form1
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
            this.pbHanoiB = new System.Windows.Forms.PictureBox();
            this.pbHanoiA = new System.Windows.Forms.PictureBox();
            this.pbHanoiC = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfCircles = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNumberOfMoves = new System.Windows.Forms.Label();
            this.gbMoves = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHanoiB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHanoiA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHanoiC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbMoves.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHanoiB
            // 
            this.pbHanoiB.Image = global::Hanoi_Tower.Properties.Resources.Hanoi_B___C;
            this.pbHanoiB.Location = new System.Drawing.Point(236, 127);
            this.pbHanoiB.Name = "pbHanoiB";
            this.pbHanoiB.Size = new System.Drawing.Size(163, 190);
            this.pbHanoiB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHanoiB.TabIndex = 1;
            this.pbHanoiB.TabStop = false;
            // 
            // pbHanoiA
            // 
            this.pbHanoiA.Image = global::Hanoi_Tower.Properties.Resources.Hanoi_A;
            this.pbHanoiA.Location = new System.Drawing.Point(21, 127);
            this.pbHanoiA.Name = "pbHanoiA";
            this.pbHanoiA.Size = new System.Drawing.Size(179, 190);
            this.pbHanoiA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHanoiA.TabIndex = 0;
            this.pbHanoiA.TabStop = false;
            // 
            // pbHanoiC
            // 
            this.pbHanoiC.Image = global::Hanoi_Tower.Properties.Resources.Hanoi_B___C;
            this.pbHanoiC.Location = new System.Drawing.Point(432, 127);
            this.pbHanoiC.Name = "pbHanoiC";
            this.pbHanoiC.Size = new System.Drawing.Size(163, 190);
            this.pbHanoiC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHanoiC.TabIndex = 2;
            this.pbHanoiC.TabStop = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(100, 320);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(22, 24);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(305, 320);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(22, 24);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(503, 320);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(22, 24);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(432, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 29);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumberOfCircles
            // 
            this.lblNumberOfCircles.AutoSize = true;
            this.lblNumberOfCircles.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCircles.Location = new System.Drawing.Point(501, 27);
            this.lblNumberOfCircles.Name = "lblNumberOfCircles";
            this.lblNumberOfCircles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumberOfCircles.Size = new System.Drawing.Size(93, 22);
            this.lblNumberOfCircles.TabIndex = 7;
            this.lblNumberOfCircles.Text = "تعداد مهره:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(324, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNumberOfMoves
            // 
            this.lblNumberOfMoves.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMoves.Location = new System.Drawing.Point(17, 70);
            this.lblNumberOfMoves.Name = "lblNumberOfMoves";
            this.lblNumberOfMoves.Size = new System.Drawing.Size(573, 36);
            this.lblNumberOfMoves.TabIndex = 9;
            // 
            // gbMoves
            // 
            this.gbMoves.Controls.Add(this.textBox1);
            this.gbMoves.Location = new System.Drawing.Point(622, 12);
            this.gbMoves.Name = "gbMoves";
            this.gbMoves.Size = new System.Drawing.Size(224, 332);
            this.gbMoves.TabIndex = 10;
            this.gbMoves.TabStop = false;
            this.gbMoves.Text = "حرکات";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(212, 307);
            this.textBox1.TabIndex = 0;
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.Location = new System.Drawing.Point(156, 28);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMadeBy.Size = new System.Drawing.Size(151, 21);
            this.lblMadeBy.TabIndex = 11;
            this.lblMadeBy.Text = "ساخته شده توسط:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCredits.Location = new System.Drawing.Point(12, 30);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(138, 21);
            this.lblCredits.TabIndex = 12;
            this.lblCredits.Text = "Amirreza Saadi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 356);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.gbMoves);
            this.Controls.Add(this.lblNumberOfMoves);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNumberOfCircles);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pbHanoiC);
            this.Controls.Add(this.pbHanoiB);
            this.Controls.Add(this.pbHanoiA);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HanoiTower";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHanoiB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHanoiA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHanoiC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbMoves.ResumeLayout(false);
            this.gbMoves.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHanoiA;
        private System.Windows.Forms.PictureBox pbHanoiB;
        private System.Windows.Forms.PictureBox pbHanoiC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblNumberOfCircles;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNumberOfMoves;
        private System.Windows.Forms.GroupBox gbMoves;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.Label lblCredits;
    }
}

