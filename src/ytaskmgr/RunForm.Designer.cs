namespace ytaskmgr
{
    partial class RunForm
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
            this.runBtn = new System.Windows.Forms.Button();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.asAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(12, 73);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(123, 29);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "OK";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(12, 12);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(289, 26);
            this.cmdTextBox.TabIndex = 0;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(308, 12);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 20);
            this.browseBtn.TabIndex = 3;
            this.browseBtn.Text = "...";
            this.browseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // asAdminCheckBox
            // 
            this.asAdminCheckBox.AutoSize = true;
            this.asAdminCheckBox.Location = new System.Drawing.Point(12, 44);
            this.asAdminCheckBox.Name = "asAdminCheckBox";
            this.asAdminCheckBox.Size = new System.Drawing.Size(269, 23);
            this.asAdminCheckBox.TabIndex = 4;
            this.asAdminCheckBox.Text = "Запустить с админ. правами";
            this.asAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(260, 73);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 29);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // RunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 109);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.asAdminCheckBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.runBtn);
            this.Font = new System.Drawing.Font("Consolas", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запустить";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RunForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.CheckBox asAdminCheckBox;
        private System.Windows.Forms.Button cancelBtn;
    }
}