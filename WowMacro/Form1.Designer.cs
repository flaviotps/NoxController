namespace WowMacro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProcesses = new System.Windows.Forms.ComboBox();
            this.buttonStartWow = new System.Windows.Forms.Button();
            this.dataGridProcess = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbProcesses);
            this.panel1.Controls.Add(this.buttonStartWow);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 150);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target";
            // 
            // cbProcesses
            // 
            this.cbProcesses.FormattingEnabled = true;
            this.cbProcesses.Location = new System.Drawing.Point(15, 24);
            this.cbProcesses.Name = "cbProcesses";
            this.cbProcesses.Size = new System.Drawing.Size(227, 21);
            this.cbProcesses.TabIndex = 2;
            this.cbProcesses.SelectedIndexChanged += new System.EventHandler(this.cbProcesses_SelectedIndexChanged);
            this.cbProcesses.Click += new System.EventHandler(this.cbProcesses_Click);
            // 
            // buttonStartWow
            // 
            this.buttonStartWow.Location = new System.Drawing.Point(15, 103);
            this.buttonStartWow.Name = "buttonStartWow";
            this.buttonStartWow.Size = new System.Drawing.Size(227, 31);
            this.buttonStartWow.TabIndex = 0;
            this.buttonStartWow.Text = "Start";
            this.buttonStartWow.UseVisualStyleBackColor = true;
            this.buttonStartWow.Click += new System.EventHandler(this.buttonStartWow_Click);
            // 
            // dataGridProcess
            // 
            this.dataGridProcess.AllowUserToAddRows = false;
            this.dataGridProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProcess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Process,
            this.Character,
            this.Status});
            this.dataGridProcess.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridProcess.Location = new System.Drawing.Point(284, 12);
            this.dataGridProcess.MultiSelect = false;
            this.dataGridProcess.Name = "dataGridProcess";
            this.dataGridProcess.Size = new System.Drawing.Size(388, 150);
            this.dataGridProcess.TabIndex = 2;
            this.dataGridProcess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProcess_CellContentClick);
            this.dataGridProcess.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridProcess_UserDeletingRow);
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 50;
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            // 
            // Character
            // 
            this.Character.HeaderText = "Character";
            this.Character.Name = "Character";
            this.Character.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.Name = "contextMenuStripGrid";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(684, 172);
            this.Controls.Add(this.dataGridProcess);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nox Controller";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStartWow;
        private System.Windows.Forms.ComboBox cbProcesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}

