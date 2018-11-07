namespace SMTP_Email_Customizer
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
            this.attachExcelButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.attachHTMLButton = new System.Windows.Forms.Button();
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.smtpHostComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.smtpPortLabel = new System.Windows.Forms.Label();
            this.smtpHostLabel = new System.Windows.Forms.Label();
            this.useRichTextCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // attachExcelButton
            // 
            this.attachExcelButton.Location = new System.Drawing.Point(229, 12);
            this.attachExcelButton.Name = "attachExcelButton";
            this.attachExcelButton.Size = new System.Drawing.Size(211, 47);
            this.attachExcelButton.TabIndex = 0;
            this.attachExcelButton.Text = "Attach Excel Source";
            this.attachExcelButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 119);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(211, 147);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // attachHTMLButton
            // 
            this.attachHTMLButton.Location = new System.Drawing.Point(12, 12);
            this.attachHTMLButton.Name = "attachHTMLButton";
            this.attachHTMLButton.Size = new System.Drawing.Size(211, 47);
            this.attachHTMLButton.TabIndex = 2;
            this.attachHTMLButton.Text = "Attach HTML File";
            this.attachHTMLButton.UseVisualStyleBackColor = true;
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.Location = new System.Drawing.Point(229, 219);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(211, 47);
            this.sendEmailsButton.TabIndex = 3;
            this.sendEmailsButton.Text = "Send Emails";
            this.sendEmailsButton.UseVisualStyleBackColor = true;
            this.sendEmailsButton.Click += new System.EventHandler(this.sendEmailsButton_Click);
            // 
            // smtpHostComboBox
            // 
            this.smtpHostComboBox.FormattingEnabled = true;
            this.smtpHostComboBox.Location = new System.Drawing.Point(229, 119);
            this.smtpHostComboBox.Name = "smtpHostComboBox";
            this.smtpHostComboBox.Size = new System.Drawing.Size(211, 21);
            this.smtpHostComboBox.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(229, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // smtpPortLabel
            // 
            this.smtpPortLabel.AutoSize = true;
            this.smtpPortLabel.Location = new System.Drawing.Point(231, 161);
            this.smtpPortLabel.Name = "smtpPortLabel";
            this.smtpPortLabel.Size = new System.Drawing.Size(56, 13);
            this.smtpPortLabel.TabIndex = 6;
            this.smtpPortLabel.Text = "Smtp Port:";
            // 
            // smtpHostLabel
            // 
            this.smtpHostLabel.AutoSize = true;
            this.smtpHostLabel.Location = new System.Drawing.Point(231, 97);
            this.smtpHostLabel.Name = "smtpHostLabel";
            this.smtpHostLabel.Size = new System.Drawing.Size(59, 13);
            this.smtpHostLabel.TabIndex = 7;
            this.smtpHostLabel.Text = "Smtp Host:";
            // 
            // useRichTextCheckBox
            // 
            this.useRichTextCheckBox.AutoSize = true;
            this.useRichTextCheckBox.Location = new System.Drawing.Point(12, 96);
            this.useRichTextCheckBox.Name = "useRichTextCheckBox";
            this.useRichTextCheckBox.Size = new System.Drawing.Size(94, 17);
            this.useRichTextCheckBox.TabIndex = 8;
            this.useRichTextCheckBox.Text = "Use Rich Text";
            this.useRichTextCheckBox.UseVisualStyleBackColor = true;
            this.useRichTextCheckBox.CheckedChanged += new System.EventHandler(this.useRichTextCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 276);
            this.Controls.Add(this.useRichTextCheckBox);
            this.Controls.Add(this.smtpHostLabel);
            this.Controls.Add(this.smtpPortLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.smtpHostComboBox);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.attachHTMLButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.attachExcelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attachExcelButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button attachHTMLButton;
        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.ComboBox smtpHostComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label smtpPortLabel;
        private System.Windows.Forms.Label smtpHostLabel;
        private System.Windows.Forms.CheckBox useRichTextCheckBox;
    }
}

