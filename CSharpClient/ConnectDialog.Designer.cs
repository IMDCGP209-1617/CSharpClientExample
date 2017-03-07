namespace CSharpClient
{
    partial class ConnectDialog
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
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ipAddressText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConnectBtn.Location = new System.Drawing.Point(12, 38);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(93, 38);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ipAddressText
            // 
            this.ipAddressText.Location = new System.Drawing.Point(16, 12);
            this.ipAddressText.MaxLength = 15;
            this.ipAddressText.Name = "ipAddressText";
            this.ipAddressText.Size = new System.Drawing.Size(94, 20);
            this.ipAddressText.TabIndex = 2;
            this.ipAddressText.Text = "127.0.0.1";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(116, 12);
            this.portText.MaxLength = 15;
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(48, 20);
            this.portText.TabIndex = 3;
            this.portText.Text = "1234";
            // 
            // ConnectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(185, 73);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.ipAddressText);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConnectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConnectDialog";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox ipAddressText;
        private System.Windows.Forms.TextBox portText;
    }
}