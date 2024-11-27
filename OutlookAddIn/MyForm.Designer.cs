namespace OutlookAddIn
{
    partial class MyForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(242, 49);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(259, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heading (Ex: Mr.): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "LblRecipient";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipient:";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(242, 85);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(259, 22);
            this.mailTextBox.TabIndex = 3;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(50, 213);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(451, 135);
            this.messageTextBox.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSend.ForeColor = System.Drawing.Color.Indigo;
            this.BtnSend.Location = new System.Drawing.Point(373, 364);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(125, 40);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "LblSunject";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(242, 122);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.subjectTextBox.Name = "SubjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(259, 22);
            this.subjectTextBox.TabIndex = 7;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(47, 187);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(42, 16);
            this.Body.TabIndex = 8;
            this.Body.Text = "Body:";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(568, 436);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyForm";
            this.Text = "Messenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label Body;
    }
}