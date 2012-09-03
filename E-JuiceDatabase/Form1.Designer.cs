namespace E_JuiceDatabase
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FAmount = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.SaveBtnFL = new System.Windows.Forms.Button();
            this.Jconcentration = new System.Windows.Forms.TextBox();
            this.JAmountBox = new System.Windows.Forms.TextBox();
            this.JNameBox = new System.Windows.Forms.TextBox();
            this.SaveBtnJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FAmount);
            this.splitContainer1.Panel1.Controls.Add(this.FName);
            this.splitContainer1.Panel1.Controls.Add(this.SaveBtnFL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Jconcentration);
            this.splitContainer1.Panel2.Controls.Add(this.JAmountBox);
            this.splitContainer1.Panel2.Controls.Add(this.JNameBox);
            this.splitContainer1.Panel2.Controls.Add(this.SaveBtnJ);
            this.splitContainer1.Size = new System.Drawing.Size(760, 421);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // FAmount
            // 
            this.FAmount.Location = new System.Drawing.Point(47, 88);
            this.FAmount.Name = "FAmount";
            this.FAmount.Size = new System.Drawing.Size(100, 20);
            this.FAmount.TabIndex = 2;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(47, 43);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(100, 20);
            this.FName.TabIndex = 1;
            // 
            // SaveBtnFL
            // 
            this.SaveBtnFL.Location = new System.Drawing.Point(72, 230);
            this.SaveBtnFL.Name = "SaveBtnFL";
            this.SaveBtnFL.Size = new System.Drawing.Size(75, 23);
            this.SaveBtnFL.TabIndex = 0;
            this.SaveBtnFL.Text = "button1";
            this.SaveBtnFL.UseVisualStyleBackColor = true;
            this.SaveBtnFL.Click += new System.EventHandler(this.SaveBtnFL_Click);
            // 
            // Jconcentration
            // 
            this.Jconcentration.Location = new System.Drawing.Point(304, 181);
            this.Jconcentration.Name = "Jconcentration";
            this.Jconcentration.Size = new System.Drawing.Size(100, 20);
            this.Jconcentration.TabIndex = 3;
            // 
            // JAmountBox
            // 
            this.JAmountBox.Location = new System.Drawing.Point(304, 127);
            this.JAmountBox.Name = "JAmountBox";
            this.JAmountBox.Size = new System.Drawing.Size(100, 20);
            this.JAmountBox.TabIndex = 2;
            // 
            // JNameBox
            // 
            this.JNameBox.Location = new System.Drawing.Point(304, 65);
            this.JNameBox.Name = "JNameBox";
            this.JNameBox.Size = new System.Drawing.Size(100, 20);
            this.JNameBox.TabIndex = 1;
            // 
            // SaveBtnJ
            // 
            this.SaveBtnJ.Location = new System.Drawing.Point(314, 268);
            this.SaveBtnJ.Name = "SaveBtnJ";
            this.SaveBtnJ.Size = new System.Drawing.Size(75, 23);
            this.SaveBtnJ.TabIndex = 0;
            this.SaveBtnJ.Text = "button1";
            this.SaveBtnJ.UseVisualStyleBackColor = true;
            this.SaveBtnJ.Click += new System.EventHandler(this.SaveBtnJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SaveBtnFL;
        private System.Windows.Forms.TextBox FAmount;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox Jconcentration;
        private System.Windows.Forms.TextBox JAmountBox;
        private System.Windows.Forms.TextBox JNameBox;
        private System.Windows.Forms.Button SaveBtnJ;
    }
}

