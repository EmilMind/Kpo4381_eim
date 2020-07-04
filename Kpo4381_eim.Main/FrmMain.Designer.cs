namespace Kpo4381.eim.Main
{
    partial class FrmMain
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
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.nmSaver = new System.Windows.Forms.ToolStripMenuItem();
            this.mmOfficePacks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenOfficePacks = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogPath = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDataFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.SSlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvMockOfficePacksListCommand = new System.Windows.Forms.DataGridView();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.MMenu.SuspendLayout();
            this.SStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockOfficePacksListCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmOfficePacks,
            this.mmSettings});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(777, 36);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen,
            this.nmSaver});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(83, 32);
            this.mmFile.Text = "1&.Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(200, 34);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(200, 34);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // nmSaver
            // 
            this.nmSaver.Name = "nmSaver";
            this.nmSaver.Size = new System.Drawing.Size(200, 34);
            this.nmSaver.Text = "Сохранить";
            this.nmSaver.Click += new System.EventHandler(this.nmSaver_Click);
            // 
            // mmOfficePacks
            // 
            this.mmOfficePacks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenOfficePacks});
            this.mmOfficePacks.Name = "mmOfficePacks";
            this.mmOfficePacks.Size = new System.Drawing.Size(180, 32);
            this.mmOfficePacks.Text = "2&.Офисные пакеты";
            // 
            // mnOpenOfficePacks
            // 
            this.mnOpenOfficePacks.Name = "mnOpenOfficePacks";
            this.mnOpenOfficePacks.Size = new System.Drawing.Size(397, 34);
            this.mnOpenOfficePacks.Text = "Открыть данные офисных пакетов";
            this.mnOpenOfficePacks.Click += new System.EventHandler(this.mnOpenOfficePacks_Click);
            // 
            // mmSettings
            // 
            this.mmSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogPath,
            this.mnDataFileName});
            this.mmSettings.Name = "mmSettings";
            this.mmSettings.Size = new System.Drawing.Size(130, 32);
            this.mmSettings.Text = "3&.Настройки";
            // 
            // mnLogPath
            // 
            this.mnLogPath.Name = "mnLogPath";
            this.mnLogPath.Size = new System.Drawing.Size(230, 34);
            this.mnLogPath.Text = "Показать логу";
            this.mnLogPath.Click += new System.EventHandler(this.mnLogPath_Click);
            // 
            // mnDataFileName
            // 
            this.mnDataFileName.Name = "mnDataFileName";
            this.mnDataFileName.Size = new System.Drawing.Size(230, 34);
            this.mnDataFileName.Text = "Показать путь";
            this.mnDataFileName.Click += new System.EventHandler(this.mnDataFileName_Click);
            // 
            // SStatus
            // 
            this.SStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSlblStatus});
            this.SStatus.Location = new System.Drawing.Point(0, 486);
            this.SStatus.Name = "SStatus";
            this.SStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.SStatus.Size = new System.Drawing.Size(777, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // SSlblStatus
            // 
            this.SSlblStatus.Name = "SSlblStatus";
            this.SSlblStatus.Size = new System.Drawing.Size(0, 15);
            // 
            // dgvMockOfficePacksListCommand
            // 
            this.dgvMockOfficePacksListCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMockOfficePacksListCommand.Location = new System.Drawing.Point(12, 79);
            this.dgvMockOfficePacksListCommand.Name = "dgvMockOfficePacksListCommand";
            this.dgvMockOfficePacksListCommand.RowHeadersWidth = 62;
            this.dgvMockOfficePacksListCommand.RowTemplate.Height = 28;
            this.dgvMockOfficePacksListCommand.Size = new System.Drawing.Size(751, 323);
            this.dgvMockOfficePacksListCommand.TabIndex = 2;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(12, 408);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(751, 75);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "CANвертация";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 508);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.dgvMockOfficePacksListCommand);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "КПО:4381:Миндубаев";
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            this.SStatus.ResumeLayout(false);
            this.SStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockOfficePacksListCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvMockOfficePacksListCommand;
        private System.Windows.Forms.ToolStripMenuItem mmOfficePacks;
        private System.Windows.Forms.ToolStripMenuItem mnOpenOfficePacks;
        private System.Windows.Forms.ToolStripMenuItem mmSettings;
        private System.Windows.Forms.ToolStripMenuItem mnLogPath;
        private System.Windows.Forms.ToolStripMenuItem mnDataFileName;
        private System.Windows.Forms.ToolStripMenuItem nmSaver;
        private System.Windows.Forms.ToolStripStatusLabel SSlblStatus;
        private System.Windows.Forms.Button ConvertButton;
    }
}

