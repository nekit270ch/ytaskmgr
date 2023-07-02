namespace ytaskmgr
{
    partial class FileMgrForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMgrForm));
            this.files = new System.Windows.Forms.ListView();
            this.fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.newFileBtn = new System.Windows.Forms.Button();
            this.dirContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileContextMenu.SuspendLayout();
            this.dirContentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // files
            // 
            this.files.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.files.Font = new System.Drawing.Font("Consolas", 12F);
            this.files.GridLines = true;
            this.files.HideSelection = false;
            this.files.LabelEdit = true;
            this.files.Location = new System.Drawing.Point(-2, 48);
            this.files.MultiSelect = false;
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(802, 381);
            this.files.TabIndex = 1;
            this.files.UseCompatibleStateImageBehavior = false;
            this.files.View = System.Windows.Forms.View.Details;
            this.files.ItemActivate += new System.EventHandler(this.files_ItemActivate);
            this.files.SelectedIndexChanged += new System.EventHandler(this.UpdateContextMenu);
            this.files.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateContextMenu);
            // 
            // fileContextMenu
            // 
            this.fileContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFileWithToolStripMenuItem,
            this.editFileToolStripMenuItem,
            this.renameFileToolStripMenuItem,
            this.copyFileToolStripMenuItem,
            this.moveFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem,
            this.filePropertiesToolStripMenuItem});
            this.fileContextMenu.Name = "fileContextMenu";
            this.fileContextMenu.Size = new System.Drawing.Size(269, 260);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.openFileToolStripMenuItem.Text = "Открыть";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileWithToolStripMenuItem
            // 
            this.openFileWithToolStripMenuItem.Name = "openFileWithToolStripMenuItem";
            this.openFileWithToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.openFileWithToolStripMenuItem.Text = "Открыть с помощью...";
            this.openFileWithToolStripMenuItem.Click += new System.EventHandler(this.openFileWithToolStripMenuItem_Click);
            // 
            // editFileToolStripMenuItem
            // 
            this.editFileToolStripMenuItem.Name = "editFileToolStripMenuItem";
            this.editFileToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.editFileToolStripMenuItem.Text = "Редактировать";
            this.editFileToolStripMenuItem.Click += new System.EventHandler(this.editFileToolStripMenuItem_Click);
            // 
            // renameFileToolStripMenuItem
            // 
            this.renameFileToolStripMenuItem.Name = "renameFileToolStripMenuItem";
            this.renameFileToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.renameFileToolStripMenuItem.Text = "Переименовать";
            this.renameFileToolStripMenuItem.Click += new System.EventHandler(this.renameFileToolStripMenuItem_Click);
            // 
            // copyFileToolStripMenuItem
            // 
            this.copyFileToolStripMenuItem.Name = "copyFileToolStripMenuItem";
            this.copyFileToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.copyFileToolStripMenuItem.Text = "Копировать";
            this.copyFileToolStripMenuItem.Click += new System.EventHandler(this.copyFileToolStripMenuItem_Click);
            // 
            // moveFileToolStripMenuItem
            // 
            this.moveFileToolStripMenuItem.Name = "moveFileToolStripMenuItem";
            this.moveFileToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.moveFileToolStripMenuItem.Text = "Переместить";
            this.moveFileToolStripMenuItem.Click += new System.EventHandler(this.moveFileToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.deleteFileToolStripMenuItem.Text = "Удалить";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // filePropertiesToolStripMenuItem
            // 
            this.filePropertiesToolStripMenuItem.Name = "filePropertiesToolStripMenuItem";
            this.filePropertiesToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.filePropertiesToolStripMenuItem.Text = "Свойства";
            this.filePropertiesToolStripMenuItem.Click += new System.EventHandler(this.filePropertiesToolStripMenuItem_Click);
            // 
            // dirTextBox
            // 
            this.dirTextBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.dirTextBox.Location = new System.Drawing.Point(12, 6);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(566, 36);
            this.dirTextBox.TabIndex = 2;
            this.dirTextBox.WordWrap = false;
            this.dirTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dirTextBox_KeyDown);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnUp.Location = new System.Drawing.Point(584, 6);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(94, 27);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "..";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnGo.Location = new System.Drawing.Point(684, 6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 27);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // newFileBtn
            // 
            this.newFileBtn.Location = new System.Drawing.Point(332, 435);
            this.newFileBtn.Name = "newFileBtn";
            this.newFileBtn.Size = new System.Drawing.Size(112, 31);
            this.newFileBtn.TabIndex = 6;
            this.newFileBtn.Text = "Новый файл";
            this.newFileBtn.UseVisualStyleBackColor = true;
            this.newFileBtn.Click += new System.EventHandler(this.newFileBtn_Click);
            // 
            // dirContentMenu
            // 
            this.dirContentMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dirContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirToolStripMenuItem,
            this.openDirInNewWindowToolStripMenuItem,
            this.renameDirToolStripMenuItem,
            this.copyDirToolStripMenuItem,
            this.moveDirToolStripMenuItem,
            this.deleteDirToolStripMenuItem,
            this.dirPropertiesToolStripMenuItem});
            this.dirContentMenu.Name = "dirContentMenu";
            this.dirContentMenu.Size = new System.Drawing.Size(274, 228);
            // 
            // openDirToolStripMenuItem
            // 
            this.openDirToolStripMenuItem.Name = "openDirToolStripMenuItem";
            this.openDirToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.openDirToolStripMenuItem.Text = "Открыть";
            this.openDirToolStripMenuItem.Click += new System.EventHandler(this.openDirToolStripMenuItem_Click);
            // 
            // openDirInNewWindowToolStripMenuItem
            // 
            this.openDirInNewWindowToolStripMenuItem.Name = "openDirInNewWindowToolStripMenuItem";
            this.openDirInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.openDirInNewWindowToolStripMenuItem.Text = "Открыть в новом окне";
            this.openDirInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openDirInNewWindowToolStripMenuItem_Click);
            // 
            // renameDirToolStripMenuItem
            // 
            this.renameDirToolStripMenuItem.Name = "renameDirToolStripMenuItem";
            this.renameDirToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.renameDirToolStripMenuItem.Text = "Переименовать";
            this.renameDirToolStripMenuItem.Click += new System.EventHandler(this.renameDirToolStripMenuItem_Click);
            // 
            // copyDirToolStripMenuItem
            // 
            this.copyDirToolStripMenuItem.Name = "copyDirToolStripMenuItem";
            this.copyDirToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.copyDirToolStripMenuItem.Text = "Копировать";
            this.copyDirToolStripMenuItem.Click += new System.EventHandler(this.copyDirToolStripMenuItem_Click);
            // 
            // moveDirToolStripMenuItem
            // 
            this.moveDirToolStripMenuItem.Name = "moveDirToolStripMenuItem";
            this.moveDirToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.moveDirToolStripMenuItem.Text = "Переместить";
            this.moveDirToolStripMenuItem.Click += new System.EventHandler(this.moveDirToolStripMenuItem_Click);
            // 
            // deleteDirToolStripMenuItem
            // 
            this.deleteDirToolStripMenuItem.Name = "deleteDirToolStripMenuItem";
            this.deleteDirToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.deleteDirToolStripMenuItem.Text = "Удалить";
            this.deleteDirToolStripMenuItem.Click += new System.EventHandler(this.deleteDirToolStripMenuItem_Click);
            // 
            // dirPropertiesToolStripMenuItem
            // 
            this.dirPropertiesToolStripMenuItem.Name = "dirPropertiesToolStripMenuItem";
            this.dirPropertiesToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.dirPropertiesToolStripMenuItem.Text = "Свойства";
            this.dirPropertiesToolStripMenuItem.Click += new System.EventHandler(this.dirPropertiesToolStripMenuItem_Click);
            // 
            // FileMgrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.newFileBtn);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.dirTextBox);
            this.Controls.Add(this.files);
            this.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileMgrForm";
            this.Text = "Файловый менеджер";
            this.fileContextMenu.ResumeLayout(false);
            this.dirContentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView files;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button newFileBtn;
        private System.Windows.Forms.ContextMenuStrip fileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip dirContentMenu;
        private System.Windows.Forms.ToolStripMenuItem openDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirPropertiesToolStripMenuItem;
    }
}

