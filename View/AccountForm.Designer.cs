
namespace lab1
{
    partial class AccountForm
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
            this.AccountMemo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavingButton = new System.Windows.Forms.Button();
            this.SavingEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CashOutButton = new System.Windows.Forms.Button();
            this.CashOutEdit = new System.Windows.Forms.TextBox();
            this.SavingMemo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TransferEdit = new System.Windows.Forms.Button();
            this.TransferSumEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AccumulationButton = new System.Windows.Forms.Button();
            this.AccumulationPercentEdit = new System.Windows.Forms.TextBox();
            this.AccumulationEdit = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.FreezingButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.AccumMemo = new System.Windows.Forms.RichTextBox();
            this.NumberTransBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AccountMemo
            // 
            this.AccountMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountMemo.Location = new System.Drawing.Point(295, 66);
            this.AccountMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountMemo.Name = "AccountMemo";
            this.AccountMemo.Size = new System.Drawing.Size(220, 50);
            this.AccountMemo.TabIndex = 0;
            this.AccountMemo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saving";
            // 
            // SavingButton
            // 
            this.SavingButton.Location = new System.Drawing.Point(37, 89);
            this.SavingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavingButton.Name = "SavingButton";
            this.SavingButton.Size = new System.Drawing.Size(83, 28);
            this.SavingButton.TabIndex = 3;
            this.SavingButton.Text = "Save";
            this.SavingButton.UseVisualStyleBackColor = true;
            this.SavingButton.Click += new System.EventHandler(this.SavingButton_Click);
            // 
            // SavingEdit
            // 
            this.SavingEdit.Location = new System.Drawing.Point(35, 55);
            this.SavingEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavingEdit.Multiline = true;
            this.SavingEdit.Name = "SavingEdit";
            this.SavingEdit.Size = new System.Drawing.Size(149, 27);
            this.SavingEdit.TabIndex = 4;
            this.SavingEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SavingEdit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cashing out";
            // 
            // CashOutButton
            // 
            this.CashOutButton.Location = new System.Drawing.Point(35, 222);
            this.CashOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashOutButton.Name = "CashOutButton";
            this.CashOutButton.Size = new System.Drawing.Size(83, 28);
            this.CashOutButton.TabIndex = 3;
            this.CashOutButton.Text = "Cash out";
            this.CashOutButton.UseVisualStyleBackColor = true;
            this.CashOutButton.Click += new System.EventHandler(this.CashOutButton_Click);
            // 
            // CashOutEdit
            // 
            this.CashOutEdit.Location = new System.Drawing.Point(35, 178);
            this.CashOutEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashOutEdit.Multiline = true;
            this.CashOutEdit.Name = "CashOutEdit";
            this.CashOutEdit.Size = new System.Drawing.Size(149, 27);
            this.CashOutEdit.TabIndex = 4;
            this.CashOutEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashOutEdit_KeyPress);
            // 
            // SavingMemo
            // 
            this.SavingMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavingMemo.Location = new System.Drawing.Point(295, 178);
            this.SavingMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavingMemo.Name = "SavingMemo";
            this.SavingMemo.Size = new System.Drawing.Size(220, 50);
            this.SavingMemo.TabIndex = 0;
            this.SavingMemo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(305, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "On Saving";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sum of transfer";
            // 
            // TransferEdit
            // 
            this.TransferEdit.Location = new System.Drawing.Point(64, 453);
            this.TransferEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferEdit.Name = "TransferEdit";
            this.TransferEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransferEdit.Size = new System.Drawing.Size(83, 28);
            this.TransferEdit.TabIndex = 3;
            this.TransferEdit.Text = "Transfer";
            this.TransferEdit.UseVisualStyleBackColor = true;
            this.TransferEdit.Click += new System.EventHandler(this.TransferEdit_Click);
            // 
            // TransferSumEdit
            // 
            this.TransferSumEdit.Location = new System.Drawing.Point(64, 322);
            this.TransferSumEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferSumEdit.Multiline = true;
            this.TransferSumEdit.Name = "TransferSumEdit";
            this.TransferSumEdit.Size = new System.Drawing.Size(149, 27);
            this.TransferSumEdit.TabIndex = 4;
            this.TransferSumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferSumEdit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of recepient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Accumulation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Percent";
            // 
            // AccumulationButton
            // 
            this.AccumulationButton.Location = new System.Drawing.Point(621, 309);
            this.AccumulationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumulationButton.Name = "AccumulationButton";
            this.AccumulationButton.Size = new System.Drawing.Size(109, 28);
            this.AccumulationButton.TabIndex = 3;
            this.AccumulationButton.Text = "Accumulate";
            this.AccumulationButton.UseVisualStyleBackColor = true;
            this.AccumulationButton.Click += new System.EventHandler(this.AccumulationButton_Click);
            // 
            // AccumulationPercentEdit
            // 
            this.AccumulationPercentEdit.Location = new System.Drawing.Point(621, 406);
            this.AccumulationPercentEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumulationPercentEdit.Multiline = true;
            this.AccumulationPercentEdit.Name = "AccumulationPercentEdit";
            this.AccumulationPercentEdit.Size = new System.Drawing.Size(149, 27);
            this.AccumulationPercentEdit.TabIndex = 4;
            this.AccumulationPercentEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccumulationPercentEdit_KeyPress);
            // 
            // AccumulationEdit
            // 
            this.AccumulationEdit.Location = new System.Drawing.Point(621, 266);
            this.AccumulationEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumulationEdit.Multiline = true;
            this.AccumulationEdit.Name = "AccumulationEdit";
            this.AccumulationEdit.Size = new System.Drawing.Size(149, 27);
            this.AccumulationEdit.TabIndex = 4;
            this.AccumulationEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccumulationEdit_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 548);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(83, 25);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FreezingButton
            // 
            this.FreezingButton.Location = new System.Drawing.Point(295, 497);
            this.FreezingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FreezingButton.Name = "FreezingButton";
            this.FreezingButton.Size = new System.Drawing.Size(112, 28);
            this.FreezingButton.TabIndex = 7;
            this.FreezingButton.Text = "Freeze";
            this.FreezingButton.UseVisualStyleBackColor = true;
            this.FreezingButton.Click += new System.EventHandler(this.FreezingButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(449, 497);
            this.BlockButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(112, 28);
            this.BlockButton.TabIndex = 9;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(305, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "On Accumulation";
            // 
            // AccumMemo
            // 
            this.AccumMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccumMemo.Location = new System.Drawing.Point(295, 300);
            this.AccumMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumMemo.Name = "AccumMemo";
            this.AccumMemo.Size = new System.Drawing.Size(220, 50);
            this.AccumMemo.TabIndex = 10;
            this.AccumMemo.Text = "";
            // 
            // NumberTransBox
            // 
            this.NumberTransBox.FormattingEnabled = true;
            this.NumberTransBox.Location = new System.Drawing.Point(64, 409);
            this.NumberTransBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberTransBox.Name = "NumberTransBox";
            this.NumberTransBox.Size = new System.Drawing.Size(149, 24);
            this.NumberTransBox.TabIndex = 12;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 570);
            this.Controls.Add(this.NumberTransBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AccumMemo);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.FreezingButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AccumulationEdit);
            this.Controls.Add(this.AccumulationPercentEdit);
            this.Controls.Add(this.TransferSumEdit);
            this.Controls.Add(this.AccumulationButton);
            this.Controls.Add(this.CashOutEdit);
            this.Controls.Add(this.TransferEdit);
            this.Controls.Add(this.SavingEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CashOutButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SavingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavingMemo);
            this.Controls.Add(this.AccountMemo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AccountMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavingButton;
        private System.Windows.Forms.TextBox SavingEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CashOutButton;
        private System.Windows.Forms.TextBox CashOutEdit;
        private System.Windows.Forms.RichTextBox SavingMemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TransferEdit;
        private System.Windows.Forms.TextBox TransferSumEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AccumulationButton;
        private System.Windows.Forms.TextBox AccumulationPercentEdit;
        private System.Windows.Forms.TextBox AccumulationEdit;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FreezingButton;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox AccumMemo;
        private System.Windows.Forms.ComboBox NumberTransBox;
    }
}