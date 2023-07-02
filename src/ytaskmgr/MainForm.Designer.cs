namespace ytaskmgr
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProcListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yTaskMgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAsAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAtSystemStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceUpdateProcListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunNewTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemUtilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетныеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPasswords2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certlmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certmgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comexpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compmgmtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devmgmtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventvwrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsmgmtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lusrmgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfmonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskschdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virtmgmtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wmimgmtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdShellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsPowerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wslToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утилитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcListBox
            // 
            this.ProcListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.ProcListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProcListBox.FormattingEnabled = true;
            this.ProcListBox.ItemHeight = 29;
            this.ProcListBox.Location = new System.Drawing.Point(3, 41);
            this.ProcListBox.Name = "ProcListBox";
            this.ProcListBox.Size = new System.Drawing.Size(791, 323);
            this.ProcListBox.TabIndex = 0;
            this.ProcListBox.SelectedIndexChanged += new System.EventHandler(this.ProcListBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.procFolderToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 100);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.killToolStripMenuItem.Text = "Завершить процесс";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // procFolderToolStripMenuItem
            // 
            this.procFolderToolStripMenuItem.Name = "procFolderToolStripMenuItem";
            this.procFolderToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.procFolderToolStripMenuItem.Text = "Расположение файла";
            this.procFolderToolStripMenuItem.Click += new System.EventHandler(this.procFolderToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.propertiesToolStripMenuItem.Text = "Свойства";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yTaskMgrToolStripMenuItem,
            this.запускToolStripMenuItem,
            this.утилитыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yTaskMgrToolStripMenuItem
            // 
            this.yTaskMgrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.runAsAdminToolStripMenuItem,
            this.runAtSystemStartupToolStripMenuItem,
            this.forceUpdateProcListToolStripMenuItem,
            this.findProcessToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.yTaskMgrToolStripMenuItem.Name = "yTaskMgrToolStripMenuItem";
            this.yTaskMgrToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.yTaskMgrToolStripMenuItem.Text = "YTaskMgr";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.newWindowToolStripMenuItem.Text = "Новое окно";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // runAsAdminToolStripMenuItem
            // 
            this.runAsAdminToolStripMenuItem.Name = "runAsAdminToolStripMenuItem";
            this.runAsAdminToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.runAsAdminToolStripMenuItem.Text = "Перезапуск с админ.правами";
            this.runAsAdminToolStripMenuItem.Click += new System.EventHandler(this.runAsAdminToolStripMenuItem_Click);
            // 
            // runAtSystemStartupToolStripMenuItem
            // 
            this.runAtSystemStartupToolStripMenuItem.Name = "runAtSystemStartupToolStripMenuItem";
            this.runAtSystemStartupToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.runAtSystemStartupToolStripMenuItem.Text = "Запустить во время загрузки системы";
            this.runAtSystemStartupToolStripMenuItem.Click += new System.EventHandler(this.runAtSystemStartupToolStripMenuItem_Click);
            // 
            // forceUpdateProcListToolStripMenuItem
            // 
            this.forceUpdateProcListToolStripMenuItem.Name = "forceUpdateProcListToolStripMenuItem";
            this.forceUpdateProcListToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.forceUpdateProcListToolStripMenuItem.Text = "Обновить список процессов";
            this.forceUpdateProcListToolStripMenuItem.Click += new System.EventHandler(this.forceUpdateProcListToolStripMenuItem_Click);
            // 
            // findProcessToolStripMenuItem
            // 
            this.findProcessToolStripMenuItem.Name = "findProcessToolStripMenuItem";
            this.findProcessToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.findProcessToolStripMenuItem.Text = "Найти процесс";
            this.findProcessToolStripMenuItem.Click += new System.EventHandler(this.findProcessToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(422, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(425, 34);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // запускToolStripMenuItem
            // 
            this.запускToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunNewTaskMenuItem,
            this.runWindowToolStripMenuItem,
            this.systemUtilsToolStripMenuItem});
            this.запускToolStripMenuItem.Name = "запускToolStripMenuItem";
            this.запускToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.запускToolStripMenuItem.Text = "Запуск";
            // 
            // RunNewTaskMenuItem
            // 
            this.RunNewTaskMenuItem.Name = "RunNewTaskMenuItem";
            this.RunNewTaskMenuItem.Size = new System.Drawing.Size(274, 34);
            this.RunNewTaskMenuItem.Text = "Запустить процесс";
            this.RunNewTaskMenuItem.Click += new System.EventHandler(this.RunNewTaskMenuItem_Click);
            // 
            // runWindowToolStripMenuItem
            // 
            this.runWindowToolStripMenuItem.Name = "runWindowToolStripMenuItem";
            this.runWindowToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.runWindowToolStripMenuItem.Text = "Выполнить...";
            this.runWindowToolStripMenuItem.Click += new System.EventHandler(this.runWindowToolStripMenuItem_Click);
            // 
            // systemUtilsToolStripMenuItem
            // 
            this.systemUtilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlPanelToolStripMenuItem,
            this.MMCToolStripMenuItem,
            this.cmdShellsToolStripMenuItem,
            this.textEditorsToolStripMenuItem});
            this.systemUtilsToolStripMenuItem.Name = "systemUtilsToolStripMenuItem";
            this.systemUtilsToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.systemUtilsToolStripMenuItem.Text = "Системные утилиты";
            // 
            // controlPanelToolStripMenuItem
            // 
            this.controlPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysdmToolStripMenuItem,
            this.учетныеЗаписиToolStripMenuItem});
            this.controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            this.controlPanelToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.controlPanelToolStripMenuItem.Text = "Панель управления";
            // 
            // sysdmToolStripMenuItem
            // 
            this.sysdmToolStripMenuItem.Name = "sysdmToolStripMenuItem";
            this.sysdmToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.sysdmToolStripMenuItem.Text = "Свойства системы (SysDm)";
            this.sysdmToolStripMenuItem.Click += new System.EventHandler(this.sysdmToolStripMenuItem_Click);
            // 
            // учетныеЗаписиToolStripMenuItem
            // 
            this.учетныеЗаписиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPasswordsToolStripMenuItem,
            this.userPasswords2ToolStripMenuItem});
            this.учетныеЗаписиToolStripMenuItem.Name = "учетныеЗаписиToolStripMenuItem";
            this.учетныеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.учетныеЗаписиToolStripMenuItem.Text = "Учетные записи";
            // 
            // userPasswordsToolStripMenuItem
            // 
            this.userPasswordsToolStripMenuItem.Name = "userPasswordsToolStripMenuItem";
            this.userPasswordsToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.userPasswordsToolStripMenuItem.Text = "UserPasswords";
            this.userPasswordsToolStripMenuItem.Click += new System.EventHandler(this.userPasswordsToolStripMenuItem_Click);
            // 
            // userPasswords2ToolStripMenuItem
            // 
            this.userPasswords2ToolStripMenuItem.Name = "userPasswords2ToolStripMenuItem";
            this.userPasswords2ToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.userPasswords2ToolStripMenuItem.Text = "UserPasswords2";
            this.userPasswords2ToolStripMenuItem.Click += new System.EventHandler(this.userPasswords2ToolStripMenuItem_Click);
            // 
            // MMCToolStripMenuItem
            // 
            this.MMCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyConsoleToolStripMenuItem,
            this.azmanToolStripMenuItem,
            this.certsToolStripMenuItem,
            this.comexpToolStripMenuItem,
            this.compmgmtToolStripMenuItem,
            this.devmgmtToolStripMenuItem,
            this.eventvwrToolStripMenuItem,
            this.fsmgmtToolStripMenuItem,
            this.lusrmgrToolStripMenuItem,
            this.perfmonToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.taskschdToolStripMenuItem,
            this.tpmToolStripMenuItem,
            this.virtmgmtToolStripMenuItem,
            this.WFToolStripMenuItem,
            this.wmimgmtToolStripMenuItem});
            this.MMCToolStripMenuItem.Name = "MMCToolStripMenuItem";
            this.MMCToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.MMCToolStripMenuItem.Text = "Консоль MMC";
            // 
            // emptyConsoleToolStripMenuItem
            // 
            this.emptyConsoleToolStripMenuItem.Name = "emptyConsoleToolStripMenuItem";
            this.emptyConsoleToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.emptyConsoleToolStripMenuItem.Text = "Пустая консоль";
            this.emptyConsoleToolStripMenuItem.Click += new System.EventHandler(this.emptyConsoleToolStripMenuItem_Click);
            // 
            // azmanToolStripMenuItem
            // 
            this.azmanToolStripMenuItem.Name = "azmanToolStripMenuItem";
            this.azmanToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.azmanToolStripMenuItem.Text = "Диспетчер авторизации";
            this.azmanToolStripMenuItem.Click += new System.EventHandler(this.azmanToolStripMenuItem_Click);
            // 
            // certsToolStripMenuItem
            // 
            this.certsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certlmToolStripMenuItem,
            this.certmgrToolStripMenuItem});
            this.certsToolStripMenuItem.Name = "certsToolStripMenuItem";
            this.certsToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.certsToolStripMenuItem.Text = "Сертификаты";
            // 
            // certlmToolStripMenuItem
            // 
            this.certlmToolStripMenuItem.Name = "certlmToolStripMenuItem";
            this.certlmToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.certlmToolStripMenuItem.Text = "Компьютер";
            this.certlmToolStripMenuItem.Click += new System.EventHandler(this.certlmToolStripMenuItem_Click);
            // 
            // certmgrToolStripMenuItem
            // 
            this.certmgrToolStripMenuItem.Name = "certmgrToolStripMenuItem";
            this.certmgrToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.certmgrToolStripMenuItem.Text = "Локальный пользователь";
            this.certmgrToolStripMenuItem.Click += new System.EventHandler(this.certmgrToolStripMenuItem_Click);
            // 
            // comexpToolStripMenuItem
            // 
            this.comexpToolStripMenuItem.Name = "comexpToolStripMenuItem";
            this.comexpToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.comexpToolStripMenuItem.Text = "Службы компонентов";
            this.comexpToolStripMenuItem.Click += new System.EventHandler(this.comexpToolStripMenuItem_Click);
            // 
            // compmgmtToolStripMenuItem
            // 
            this.compmgmtToolStripMenuItem.Name = "compmgmtToolStripMenuItem";
            this.compmgmtToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.compmgmtToolStripMenuItem.Text = "Управление компьютером";
            this.compmgmtToolStripMenuItem.Click += new System.EventHandler(this.compmgmtToolStripMenuItem_Click);
            // 
            // devmgmtToolStripMenuItem
            // 
            this.devmgmtToolStripMenuItem.Name = "devmgmtToolStripMenuItem";
            this.devmgmtToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.devmgmtToolStripMenuItem.Text = "Диспетчер устройств";
            this.devmgmtToolStripMenuItem.Click += new System.EventHandler(this.devmgmtToolStripMenuItem_Click);
            // 
            // eventvwrToolStripMenuItem
            // 
            this.eventvwrToolStripMenuItem.Name = "eventvwrToolStripMenuItem";
            this.eventvwrToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.eventvwrToolStripMenuItem.Text = "Просмотр событий";
            this.eventvwrToolStripMenuItem.Click += new System.EventHandler(this.eventvwrToolStripMenuItem_Click);
            // 
            // fsmgmtToolStripMenuItem
            // 
            this.fsmgmtToolStripMenuItem.Name = "fsmgmtToolStripMenuItem";
            this.fsmgmtToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.fsmgmtToolStripMenuItem.Text = "Общие папки";
            this.fsmgmtToolStripMenuItem.Click += new System.EventHandler(this.fsmgmtToolStripMenuItem_Click);
            // 
            // lusrmgrToolStripMenuItem
            // 
            this.lusrmgrToolStripMenuItem.Name = "lusrmgrToolStripMenuItem";
            this.lusrmgrToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.lusrmgrToolStripMenuItem.Text = "Локальные пользователи и группы";
            this.lusrmgrToolStripMenuItem.Click += new System.EventHandler(this.lusrmgrToolStripMenuItem_Click);
            // 
            // perfmonToolStripMenuItem
            // 
            this.perfmonToolStripMenuItem.Name = "perfmonToolStripMenuItem";
            this.perfmonToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.perfmonToolStripMenuItem.Text = "Системный монитор";
            this.perfmonToolStripMenuItem.Click += new System.EventHandler(this.perfmonToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.servicesToolStripMenuItem.Text = "Службы";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // taskschdToolStripMenuItem
            // 
            this.taskschdToolStripMenuItem.Name = "taskschdToolStripMenuItem";
            this.taskschdToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.taskschdToolStripMenuItem.Text = "Планировщик заданий";
            this.taskschdToolStripMenuItem.Click += new System.EventHandler(this.taskschdToolStripMenuItem_Click);
            // 
            // tpmToolStripMenuItem
            // 
            this.tpmToolStripMenuItem.Name = "tpmToolStripMenuItem";
            this.tpmToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.tpmToolStripMenuItem.Text = "Управление TPM";
            this.tpmToolStripMenuItem.Click += new System.EventHandler(this.tpmToolStripMenuItem_Click);
            // 
            // virtmgmtToolStripMenuItem
            // 
            this.virtmgmtToolStripMenuItem.Name = "virtmgmtToolStripMenuItem";
            this.virtmgmtToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.virtmgmtToolStripMenuItem.Text = "Диспетчер Hyper-V";
            this.virtmgmtToolStripMenuItem.Click += new System.EventHandler(this.virtmgmtToolStripMenuItem_Click);
            // 
            // WFToolStripMenuItem
            // 
            this.WFToolStripMenuItem.Name = "WFToolStripMenuItem";
            this.WFToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.WFToolStripMenuItem.Text = "Монитор брандмауэра";
            this.WFToolStripMenuItem.Click += new System.EventHandler(this.WFToolStripMenuItem_Click);
            // 
            // wmimgmtToolStripMenuItem
            // 
            this.wmimgmtToolStripMenuItem.Name = "wmimgmtToolStripMenuItem";
            this.wmimgmtToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.wmimgmtToolStripMenuItem.Text = "Управление WMI";
            this.wmimgmtToolStripMenuItem.Click += new System.EventHandler(this.wmimgmtToolStripMenuItem_Click);
            // 
            // cmdShellsToolStripMenuItem
            // 
            this.cmdShellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdToolStripMenuItem,
            this.windowsPowerShellToolStripMenuItem,
            this.wslToolStripMenuItem});
            this.cmdShellsToolStripMenuItem.Name = "cmdShellsToolStripMenuItem";
            this.cmdShellsToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.cmdShellsToolStripMenuItem.Text = "Командные оболочки";
            // 
            // cmdToolStripMenuItem
            // 
            this.cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            this.cmdToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.cmdToolStripMenuItem.Text = "CMD";
            this.cmdToolStripMenuItem.Click += new System.EventHandler(this.cmdToolStripMenuItem_Click);
            // 
            // windowsPowerShellToolStripMenuItem
            // 
            this.windowsPowerShellToolStripMenuItem.Name = "windowsPowerShellToolStripMenuItem";
            this.windowsPowerShellToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.windowsPowerShellToolStripMenuItem.Text = "Windows PowerShell";
            this.windowsPowerShellToolStripMenuItem.Click += new System.EventHandler(this.windowsPowerShellToolStripMenuItem_Click);
            // 
            // wslToolStripMenuItem
            // 
            this.wslToolStripMenuItem.Name = "wslToolStripMenuItem";
            this.wslToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.wslToolStripMenuItem.Text = "WSL (если установлен)";
            this.wslToolStripMenuItem.Click += new System.EventHandler(this.wslToolStripMenuItem_Click);
            // 
            // textEditorsToolStripMenuItem
            // 
            this.textEditorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.wordPadToolStripMenuItem});
            this.textEditorsToolStripMenuItem.Name = "textEditorsToolStripMenuItem";
            this.textEditorsToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.textEditorsToolStripMenuItem.Text = "Текстовые редакторы";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.notepadToolStripMenuItem.Text = "Блокнот";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // wordPadToolStripMenuItem
            // 
            this.wordPadToolStripMenuItem.Name = "wordPadToolStripMenuItem";
            this.wordPadToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.wordPadToolStripMenuItem.Text = "WordPad";
            this.wordPadToolStripMenuItem.Click += new System.EventHandler(this.wordPadToolStripMenuItem_Click);
            // 
            // утилитыToolStripMenuItem
            // 
            this.утилитыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMgrToolStripMenuItem,
            this.uninstallerToolStripMenuItem});
            this.утилитыToolStripMenuItem.Name = "утилитыToolStripMenuItem";
            this.утилитыToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.утилитыToolStripMenuItem.Text = "Утилиты";
            // 
            // fileMgrToolStripMenuItem
            // 
            this.fileMgrToolStripMenuItem.Name = "fileMgrToolStripMenuItem";
            this.fileMgrToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.fileMgrToolStripMenuItem.Text = "Файловый менеджер";
            this.fileMgrToolStripMenuItem.Click += new System.EventHandler(this.fileMgrToolStripMenuItem_Click);
            // 
            // uninstallerToolStripMenuItem
            // 
            this.uninstallerToolStripMenuItem.Name = "uninstallerToolStripMenuItem";
            this.uninstallerToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.uninstallerToolStripMenuItem.Text = "Деинсталлятор";
            this.uninstallerToolStripMenuItem.Click += new System.EventHandler(this.uninstallerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.ProcListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YTaskMgr";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProcListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunNewTaskMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemUtilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdShellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsPowerShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wslToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysdmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетныеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPasswords2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certlmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certmgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comexpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compmgmtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devmgmtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventvwrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fsmgmtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lusrmgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfmonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskschdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tpmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virtmgmtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wmimgmtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textEditorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordPadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yTaskMgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAsAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceUpdateProcListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem утилитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runWindowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAtSystemStartupToolStripMenuItem;
    }
}

