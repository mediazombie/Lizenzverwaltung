namespace NetzwerkInventur
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.checkBoxDuplikateFiltern = new System.Windows.Forms.CheckBox();
            this.lblAusgabeFiltern = new System.Windows.Forms.Label();
            this.datatblAusgabeFiltern = new System.Windows.Forms.DataGridView();
            this.textBoxSuchbegriffFiltern = new System.Windows.Forms.TextBox();
            this.lblSuchbegriffFiltern = new System.Windows.Forms.Label();
            this.groupBoxFilterPara = new System.Windows.Forms.GroupBox();
            this.lblBenutzerFiltern = new System.Windows.Forms.Label();
            this.lblVersionFiltern = new System.Windows.Forms.Label();
            this.lblTypFiltern = new System.Windows.Forms.Label();
            this.lblHerstellerFiltern = new System.Windows.Forms.Label();
            this.lblWorkstationFiltern = new System.Windows.Forms.Label();
            this.comboBoxBenutzerFiltern = new System.Windows.Forms.ComboBox();
            this.comboBoxVersionFiltern = new System.Windows.Forms.ComboBox();
            this.comboBoxTypFiltern = new System.Windows.Forms.ComboBox();
            this.comboBoxHerstellerFiltern = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkstationFiltern = new System.Windows.Forms.ComboBox();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.checkBoxDuplikateEdit = new System.Windows.Forms.CheckBox();
            this.lblSuchbegriffEdit = new System.Windows.Forms.Label();
            this.textBoxSuchbegriffEdit = new System.Windows.Forms.TextBox();
            this.lblAusgabeEdit = new System.Windows.Forms.Label();
            this.datatblAusgabeEdit = new System.Windows.Forms.DataGridView();
            this.tabNew = new System.Windows.Forms.TabPage();
            this.toolTipDuplikate = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatblAusgabeFiltern)).BeginInit();
            this.groupBoxFilterPara.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatblAusgabeEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFilter);
            this.tabControl.Controls.Add(this.tabEdit);
            this.tabControl.Controls.Add(this.tabNew);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(907, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.checkBoxDuplikateFiltern);
            this.tabFilter.Controls.Add(this.lblAusgabeFiltern);
            this.tabFilter.Controls.Add(this.datatblAusgabeFiltern);
            this.tabFilter.Controls.Add(this.textBoxSuchbegriffFiltern);
            this.tabFilter.Controls.Add(this.lblSuchbegriffFiltern);
            this.tabFilter.Controls.Add(this.groupBoxFilterPara);
            this.tabFilter.Location = new System.Drawing.Point(4, 22);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilter.Size = new System.Drawing.Size(899, 454);
            this.tabFilter.TabIndex = 0;
            this.tabFilter.Text = "Filtern";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuplikateFiltern
            // 
            this.checkBoxDuplikateFiltern.AutoSize = true;
            this.checkBoxDuplikateFiltern.Location = new System.Drawing.Point(38, 421);
            this.checkBoxDuplikateFiltern.Name = "checkBoxDuplikateFiltern";
            this.checkBoxDuplikateFiltern.Size = new System.Drawing.Size(134, 17);
            this.checkBoxDuplikateFiltern.TabIndex = 15;
            this.checkBoxDuplikateFiltern.Text = "Duplikate hervorheben";
            this.checkBoxDuplikateFiltern.UseVisualStyleBackColor = true;
            // 
            // lblAusgabeFiltern
            // 
            this.lblAusgabeFiltern.AutoSize = true;
            this.lblAusgabeFiltern.Location = new System.Drawing.Point(30, 194);
            this.lblAusgabeFiltern.Name = "lblAusgabeFiltern";
            this.lblAusgabeFiltern.Size = new System.Drawing.Size(49, 13);
            this.lblAusgabeFiltern.TabIndex = 14;
            this.lblAusgabeFiltern.Text = "Ausgabe";
            // 
            // datatblAusgabeFiltern
            // 
            this.datatblAusgabeFiltern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatblAusgabeFiltern.Location = new System.Drawing.Point(19, 211);
            this.datatblAusgabeFiltern.Name = "datatblAusgabeFiltern";
            this.datatblAusgabeFiltern.Size = new System.Drawing.Size(836, 189);
            this.datatblAusgabeFiltern.TabIndex = 13;
            // 
            // textBoxSuchbegriffFiltern
            // 
            this.textBoxSuchbegriffFiltern.Location = new System.Drawing.Point(104, 51);
            this.textBoxSuchbegriffFiltern.Name = "textBoxSuchbegriffFiltern";
            this.textBoxSuchbegriffFiltern.Size = new System.Drawing.Size(216, 20);
            this.textBoxSuchbegriffFiltern.TabIndex = 12;
            // 
            // lblSuchbegriffFiltern
            // 
            this.lblSuchbegriffFiltern.AutoSize = true;
            this.lblSuchbegriffFiltern.Location = new System.Drawing.Point(32, 56);
            this.lblSuchbegriffFiltern.Name = "lblSuchbegriffFiltern";
            this.lblSuchbegriffFiltern.Size = new System.Drawing.Size(61, 13);
            this.lblSuchbegriffFiltern.TabIndex = 11;
            this.lblSuchbegriffFiltern.Text = "Suchbegriff";
            // 
            // groupBoxFilterPara
            // 
            this.groupBoxFilterPara.Controls.Add(this.lblBenutzerFiltern);
            this.groupBoxFilterPara.Controls.Add(this.lblVersionFiltern);
            this.groupBoxFilterPara.Controls.Add(this.lblTypFiltern);
            this.groupBoxFilterPara.Controls.Add(this.lblHerstellerFiltern);
            this.groupBoxFilterPara.Controls.Add(this.lblWorkstationFiltern);
            this.groupBoxFilterPara.Controls.Add(this.comboBoxBenutzerFiltern);
            this.groupBoxFilterPara.Controls.Add(this.comboBoxVersionFiltern);
            this.groupBoxFilterPara.Controls.Add(this.comboBoxTypFiltern);
            this.groupBoxFilterPara.Controls.Add(this.comboBoxHerstellerFiltern);
            this.groupBoxFilterPara.Controls.Add(this.comboBoxWorkstationFiltern);
            this.groupBoxFilterPara.Location = new System.Drawing.Point(19, 94);
            this.groupBoxFilterPara.Name = "groupBoxFilterPara";
            this.groupBoxFilterPara.Size = new System.Drawing.Size(836, 77);
            this.groupBoxFilterPara.TabIndex = 10;
            this.groupBoxFilterPara.TabStop = false;
            this.groupBoxFilterPara.Text = "Filter Parameter";
            // 
            // lblBenutzerFiltern
            // 
            this.lblBenutzerFiltern.AutoSize = true;
            this.lblBenutzerFiltern.Location = new System.Drawing.Point(693, 25);
            this.lblBenutzerFiltern.Name = "lblBenutzerFiltern";
            this.lblBenutzerFiltern.Size = new System.Drawing.Size(108, 13);
            this.lblBenutzerFiltern.TabIndex = 9;
            this.lblBenutzerFiltern.Text = "Registrierter Benutzer";
            // 
            // lblVersionFiltern
            // 
            this.lblVersionFiltern.AutoSize = true;
            this.lblVersionFiltern.Location = new System.Drawing.Point(523, 25);
            this.lblVersionFiltern.Name = "lblVersionFiltern";
            this.lblVersionFiltern.Size = new System.Drawing.Size(87, 13);
            this.lblVersionFiltern.TabIndex = 8;
            this.lblVersionFiltern.Text = "Software-Version";
            // 
            // lblTypFiltern
            // 
            this.lblTypFiltern.AutoSize = true;
            this.lblTypFiltern.Location = new System.Drawing.Point(353, 25);
            this.lblTypFiltern.Name = "lblTypFiltern";
            this.lblTypFiltern.Size = new System.Drawing.Size(70, 13);
            this.lblTypFiltern.TabIndex = 7;
            this.lblTypFiltern.Text = "Software-Typ";
            // 
            // lblHerstellerFiltern
            // 
            this.lblHerstellerFiltern.AutoSize = true;
            this.lblHerstellerFiltern.Location = new System.Drawing.Point(183, 25);
            this.lblHerstellerFiltern.Name = "lblHerstellerFiltern";
            this.lblHerstellerFiltern.Size = new System.Drawing.Size(96, 13);
            this.lblHerstellerFiltern.TabIndex = 6;
            this.lblHerstellerFiltern.Text = "Software-Hersteller";
            // 
            // lblWorkstationFiltern
            // 
            this.lblWorkstationFiltern.AutoSize = true;
            this.lblWorkstationFiltern.Location = new System.Drawing.Point(13, 25);
            this.lblWorkstationFiltern.Name = "lblWorkstationFiltern";
            this.lblWorkstationFiltern.Size = new System.Drawing.Size(64, 13);
            this.lblWorkstationFiltern.TabIndex = 5;
            this.lblWorkstationFiltern.Text = "Workstation";
            // 
            // comboBoxBenutzerFiltern
            // 
            this.comboBoxBenutzerFiltern.FormattingEnabled = true;
            this.comboBoxBenutzerFiltern.Location = new System.Drawing.Point(690, 41);
            this.comboBoxBenutzerFiltern.Name = "comboBoxBenutzerFiltern";
            this.comboBoxBenutzerFiltern.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBenutzerFiltern.TabIndex = 4;
            // 
            // comboBoxVersionFiltern
            // 
            this.comboBoxVersionFiltern.FormattingEnabled = true;
            this.comboBoxVersionFiltern.Location = new System.Drawing.Point(520, 41);
            this.comboBoxVersionFiltern.Name = "comboBoxVersionFiltern";
            this.comboBoxVersionFiltern.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVersionFiltern.TabIndex = 3;
            // 
            // comboBoxTypFiltern
            // 
            this.comboBoxTypFiltern.FormattingEnabled = true;
            this.comboBoxTypFiltern.Location = new System.Drawing.Point(350, 41);
            this.comboBoxTypFiltern.Name = "comboBoxTypFiltern";
            this.comboBoxTypFiltern.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypFiltern.TabIndex = 2;
            // 
            // comboBoxHerstellerFiltern
            // 
            this.comboBoxHerstellerFiltern.FormattingEnabled = true;
            this.comboBoxHerstellerFiltern.Location = new System.Drawing.Point(180, 41);
            this.comboBoxHerstellerFiltern.Name = "comboBoxHerstellerFiltern";
            this.comboBoxHerstellerFiltern.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHerstellerFiltern.TabIndex = 1;
            // 
            // comboBoxWorkstationFiltern
            // 
            this.comboBoxWorkstationFiltern.FormattingEnabled = true;
            this.comboBoxWorkstationFiltern.Location = new System.Drawing.Point(10, 41);
            this.comboBoxWorkstationFiltern.Name = "comboBoxWorkstationFiltern";
            this.comboBoxWorkstationFiltern.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWorkstationFiltern.TabIndex = 0;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.checkBoxDuplikateEdit);
            this.tabEdit.Controls.Add(this.lblSuchbegriffEdit);
            this.tabEdit.Controls.Add(this.textBoxSuchbegriffEdit);
            this.tabEdit.Controls.Add(this.lblAusgabeEdit);
            this.tabEdit.Controls.Add(this.datatblAusgabeEdit);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(899, 454);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Editieren";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuplikateEdit
            // 
            this.checkBoxDuplikateEdit.AutoSize = true;
            this.checkBoxDuplikateEdit.Location = new System.Drawing.Point(339, 30);
            this.checkBoxDuplikateEdit.Name = "checkBoxDuplikateEdit";
            this.checkBoxDuplikateEdit.Size = new System.Drawing.Size(117, 17);
            this.checkBoxDuplikateEdit.TabIndex = 4;
            this.checkBoxDuplikateEdit.Text = "Duplikate anzeigen";
            this.checkBoxDuplikateEdit.UseVisualStyleBackColor = true;
            // 
            // lblSuchbegriffEdit
            // 
            this.lblSuchbegriffEdit.AutoSize = true;
            this.lblSuchbegriffEdit.Location = new System.Drawing.Point(27, 31);
            this.lblSuchbegriffEdit.Name = "lblSuchbegriffEdit";
            this.lblSuchbegriffEdit.Size = new System.Drawing.Size(61, 13);
            this.lblSuchbegriffEdit.TabIndex = 3;
            this.lblSuchbegriffEdit.Text = "Suchbegriff";
            // 
            // textBoxSuchbegriffEdit
            // 
            this.textBoxSuchbegriffEdit.Location = new System.Drawing.Point(100, 28);
            this.textBoxSuchbegriffEdit.Name = "textBoxSuchbegriffEdit";
            this.textBoxSuchbegriffEdit.Size = new System.Drawing.Size(192, 20);
            this.textBoxSuchbegriffEdit.TabIndex = 2;
            // 
            // lblAusgabeEdit
            // 
            this.lblAusgabeEdit.AutoSize = true;
            this.lblAusgabeEdit.Location = new System.Drawing.Point(27, 68);
            this.lblAusgabeEdit.Name = "lblAusgabeEdit";
            this.lblAusgabeEdit.Size = new System.Drawing.Size(49, 13);
            this.lblAusgabeEdit.TabIndex = 1;
            this.lblAusgabeEdit.Text = "Ausgabe";
            // 
            // datatblAusgabeEdit
            // 
            this.datatblAusgabeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatblAusgabeEdit.Location = new System.Drawing.Point(21, 84);
            this.datatblAusgabeEdit.Name = "datatblAusgabeEdit";
            this.datatblAusgabeEdit.Size = new System.Drawing.Size(848, 344);
            this.datatblAusgabeEdit.TabIndex = 0;
            // 
            // tabNew
            // 
            this.tabNew.Location = new System.Drawing.Point(4, 22);
            this.tabNew.Name = "tabNew";
            this.tabNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabNew.Size = new System.Drawing.Size(899, 454);
            this.tabNew.TabIndex = 2;
            this.tabNew.Text = "Erfassen";
            this.tabNew.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 482);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "DOGREL Lizenzverwaltung";
            this.tabControl.ResumeLayout(false);
            this.tabFilter.ResumeLayout(false);
            this.tabFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatblAusgabeFiltern)).EndInit();
            this.groupBoxFilterPara.ResumeLayout(false);
            this.groupBoxFilterPara.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatblAusgabeEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFilter;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.Label lblBenutzerFiltern;
        private System.Windows.Forms.Label lblVersionFiltern;
        private System.Windows.Forms.Label lblTypFiltern;
        private System.Windows.Forms.Label lblHerstellerFiltern;
        private System.Windows.Forms.Label lblWorkstationFiltern;
        private System.Windows.Forms.ComboBox comboBoxBenutzerFiltern;
        private System.Windows.Forms.ComboBox comboBoxVersionFiltern;
        private System.Windows.Forms.ComboBox comboBoxTypFiltern;
        private System.Windows.Forms.ComboBox comboBoxHerstellerFiltern;
        private System.Windows.Forms.ComboBox comboBoxWorkstationFiltern;
        private System.Windows.Forms.TextBox textBoxSuchbegriffFiltern;
        private System.Windows.Forms.Label lblSuchbegriffFiltern;
        private System.Windows.Forms.GroupBox groupBoxFilterPara;
        private System.Windows.Forms.CheckBox checkBoxDuplikateFiltern;
        private System.Windows.Forms.Label lblAusgabeFiltern;
        private System.Windows.Forms.DataGridView datatblAusgabeFiltern;
        private System.Windows.Forms.CheckBox checkBoxDuplikateEdit;
        private System.Windows.Forms.Label lblSuchbegriffEdit;
        private System.Windows.Forms.TextBox textBoxSuchbegriffEdit;
        private System.Windows.Forms.Label lblAusgabeEdit;
        private System.Windows.Forms.DataGridView datatblAusgabeEdit;
        private System.Windows.Forms.ToolTip toolTipDuplikate;
    }
}

