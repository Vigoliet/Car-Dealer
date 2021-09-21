
namespace Car_Dealer_v1._0
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AmountRed = new System.Windows.Forms.Button();
            this.olderthan2003 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(348, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 407);
            this.listBox1.TabIndex = 0;
            // 
            // AmountRed
            // 
            this.AmountRed.Location = new System.Drawing.Point(59, 12);
            this.AmountRed.Name = "AmountRed";
            this.AmountRed.Size = new System.Drawing.Size(107, 82);
            this.AmountRed.TabIndex = 1;
            this.AmountRed.Text = "button1";
            this.AmountRed.UseVisualStyleBackColor = true;
            // 
            // olderthan2003
            // 
            this.olderthan2003.Location = new System.Drawing.Point(59, 120);
            this.olderthan2003.Name = "olderthan2003";
            this.olderthan2003.Size = new System.Drawing.Size(107, 82);
            this.olderthan2003.TabIndex = 2;
            this.olderthan2003.Text = "button1";
            this.olderthan2003.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.olderthan2003);
            this.Controls.Add(this.AmountRed);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AmountRed;
        private System.Windows.Forms.Button olderthan2003;
    }
}

