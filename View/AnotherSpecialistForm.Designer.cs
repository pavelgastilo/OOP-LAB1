
namespace lab1
{
    partial class AnotherSpecialistForm
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
            this.SalPrjButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AccBox = new System.Windows.Forms.ComboBox();
            this.SalPrjEdit = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TransferSumEdit = new System.Windows.Forms.TextBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.MyAccsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalPrjButton
            // 
            this.SalPrjButton.Location = new System.Drawing.Point(229, 94);
            this.SalPrjButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalPrjButton.Name = "SalPrjButton";
            this.SalPrjButton.Size = new System.Drawing.Size(143, 30);
            this.SalPrjButton.TabIndex = 0;
            this.SalPrjButton.Text = "Take Salary project";
            this.SalPrjButton.UseVisualStyleBackColor = true;
            this.SalPrjButton.Click += new System.EventHandler(this.SalPrjButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sum";
            // 
            // AccBox
            // 
            this.AccBox.FormattingEnabled = true;
            this.AccBox.Location = new System.Drawing.Point(229, 271);
            this.AccBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccBox.Name = "AccBox";
            this.AccBox.Size = new System.Drawing.Size(143, 24);
            this.AccBox.TabIndex = 2;
            this.AccBox.SelectedIndexChanged += new System.EventHandler(this.AccBox_SelectedIndexChanged);
            // 
            // SalPrjEdit
            // 
            this.SalPrjEdit.Location = new System.Drawing.Point(228, 49);
            this.SalPrjEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalPrjEdit.Name = "SalPrjEdit";
            this.SalPrjEdit.Size = new System.Drawing.Size(143, 22);
            this.SalPrjEdit.TabIndex = 3;
            this.SalPrjEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalPrjEdit_KeyPress);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 530);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(88, 27);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // TransferSumEdit
            // 
            this.TransferSumEdit.Location = new System.Drawing.Point(229, 358);
            this.TransferSumEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferSumEdit.Name = "TransferSumEdit";
            this.TransferSumEdit.Size = new System.Drawing.Size(143, 22);
            this.TransferSumEdit.TabIndex = 6;
            this.TransferSumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferSumEdit_KeyPress);
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(228, 416);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(88, 30);
            this.TransferButton.TabIndex = 8;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // MyAccsBox
            // 
            this.MyAccsBox.FormattingEnabled = true;
            this.MyAccsBox.Location = new System.Drawing.Point(229, 178);
            this.MyAccsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyAccsBox.Name = "MyAccsBox";
            this.MyAccsBox.Size = new System.Drawing.Size(143, 24);
            this.MyAccsBox.TabIndex = 9;
            this.MyAccsBox.SelectedIndexChanged += new System.EventHandler(this.MyAccsBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(473, 128);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 275);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnotherSpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyAccsBox);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.TransferSumEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SalPrjEdit);
            this.Controls.Add(this.AccBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalPrjButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnotherSpecialistForm";
            this.Text = "Speciallist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalPrjButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AccBox;
        private System.Windows.Forms.TextBox SalPrjEdit;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TransferSumEdit;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.ComboBox MyAccsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}