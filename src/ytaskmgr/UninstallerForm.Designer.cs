namespace ytaskmgr
{
    partial class UninstallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UninstallerForm));
            this.programsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.uninstallBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programsCheckedListBox
            // 
            this.programsCheckedListBox.CheckOnClick = true;
            this.programsCheckedListBox.FormattingEnabled = true;
            this.programsCheckedListBox.Location = new System.Drawing.Point(1, 3);
            this.programsCheckedListBox.Name = "programsCheckedListBox";
            this.programsCheckedListBox.Size = new System.Drawing.Size(731, 234);
            this.programsCheckedListBox.TabIndex = 0;
            // 
            // uninstallBtn
            // 
            this.uninstallBtn.Location = new System.Drawing.Point(282, 243);
            this.uninstallBtn.Name = "uninstallBtn";
            this.uninstallBtn.Size = new System.Drawing.Size(162, 38);
            this.uninstallBtn.TabIndex = 1;
            this.uninstallBtn.Text = "Удалить";
            this.uninstallBtn.UseVisualStyleBackColor = true;
            this.uninstallBtn.Click += new System.EventHandler(this.uninstallBtn_Click);
            // 
            // UninstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 288);
            this.Controls.Add(this.uninstallBtn);
            this.Controls.Add(this.programsCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UninstallerForm";
            this.Text = "Деинсталлятор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox programsCheckedListBox;
        private System.Windows.Forms.Button uninstallBtn;
    }
}