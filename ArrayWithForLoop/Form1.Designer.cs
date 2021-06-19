
namespace ArrayWithForLoop
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
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.lbxWinners = new System.Windows.Forms.ListBox();
            this.btnArray = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxNames
            // 
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.ItemHeight = 15;
            this.lbxNames.Location = new System.Drawing.Point(12, 58);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(149, 214);
            this.lbxNames.TabIndex = 0;
            // 
            // lbxWinners
            // 
            this.lbxWinners.FormattingEnabled = true;
            this.lbxWinners.ItemHeight = 15;
            this.lbxWinners.Location = new System.Drawing.Point(312, 58);
            this.lbxWinners.Name = "lbxWinners";
            this.lbxWinners.Size = new System.Drawing.Size(149, 214);
            this.lbxWinners.TabIndex = 1;
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(167, 105);
            this.btnArray.Name = "btnArray";
            this.btnArray.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnArray.Size = new System.Drawing.Size(139, 122);
            this.btnArray.TabIndex = 2;
            this.btnArray.Text = "Run Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(167, 58);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(63, 15);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "lblwinnder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 280);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.lbxWinners);
            this.Controls.Add(this.lbxNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.ListBox lbxWinners;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Label lblWinner;
    }
}

