namespace Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelInformation_SYP = new Panel();
            statusStripManageData_SYP = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelChabgeData_SYP = new ToolStripStatusLabel();
            panelManagerData_SYP = new Panel();
            buttonAddtoCard_SYP = new Button();
            buttonOpenFile_SYP = new Button();
            buttonSaveFile_SYP = new Button();
            panelDataFile_SYP = new Panel();
            groupBoxDataFile_SYP = new GroupBox();
            tabControlFile_SYP = new TabControl();
            tabPageOriginalFile_SYP = new TabPage();
            dataGridViewOriginalFile_SYP = new DataGridView();
            tabPageCardFile_SYP = new TabPage();
            dataGridViewCard_SYP = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_SYP = new OpenFileDialog();
            saveFileDialog_SYP = new SaveFileDialog();
            panelInformation_SYP.SuspendLayout();
            statusStripManageData_SYP.SuspendLayout();
            panelManagerData_SYP.SuspendLayout();
            panelDataFile_SYP.SuspendLayout();
            groupBoxDataFile_SYP.SuspendLayout();
            tabControlFile_SYP.SuspendLayout();
            tabPageOriginalFile_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).BeginInit();
            tabPageCardFile_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCard_SYP).BeginInit();
            SuspendLayout();
            // 
            // panelInformation_SYP
            // 
            panelInformation_SYP.BackColor = SystemColors.ActiveCaption;
            panelInformation_SYP.Controls.Add(statusStripManageData_SYP);
            panelInformation_SYP.Dock = DockStyle.Top;
            panelInformation_SYP.Location = new Point(0, 0);
            panelInformation_SYP.Name = "panelInformation_SYP";
            panelInformation_SYP.Size = new Size(964, 35);
            panelInformation_SYP.TabIndex = 0;
            // 
            // statusStripManageData_SYP
            // 
            statusStripManageData_SYP.Dock = DockStyle.Fill;
            statusStripManageData_SYP.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabelChabgeData_SYP });
            statusStripManageData_SYP.Location = new Point(0, 0);
            statusStripManageData_SYP.Name = "statusStripManageData_SYP";
            statusStripManageData_SYP.Size = new Size(964, 35);
            statusStripManageData_SYP.TabIndex = 0;
            statusStripManageData_SYP.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 30);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelChabgeData_SYP
            // 
            toolStripStatusLabelChabgeData_SYP.BackColor = SystemColors.ButtonFace;
            toolStripStatusLabelChabgeData_SYP.Name = "toolStripStatusLabelChabgeData_SYP";
            toolStripStatusLabelChabgeData_SYP.Size = new Size(118, 30);
            toolStripStatusLabelChabgeData_SYP.Text = "toolStripStatusLabel2";
            // 
            // panelManagerData_SYP
            // 
            panelManagerData_SYP.BackColor = Color.RosyBrown;
            panelManagerData_SYP.Controls.Add(buttonAddtoCard_SYP);
            panelManagerData_SYP.Controls.Add(buttonOpenFile_SYP);
            panelManagerData_SYP.Controls.Add(buttonSaveFile_SYP);
            panelManagerData_SYP.Dock = DockStyle.Left;
            panelManagerData_SYP.Location = new Point(0, 35);
            panelManagerData_SYP.Name = "panelManagerData_SYP";
            panelManagerData_SYP.Size = new Size(200, 415);
            panelManagerData_SYP.TabIndex = 1;
            // 
            // buttonAddtoCard_SYP
            // 
            buttonAddtoCard_SYP.Enabled = false;
            buttonAddtoCard_SYP.Image = (Image)resources.GetObject("buttonAddtoCard_SYP.Image");
            buttonAddtoCard_SYP.Location = new Point(33, 131);
            buttonAddtoCard_SYP.Name = "buttonAddtoCard_SYP";
            buttonAddtoCard_SYP.Size = new Size(46, 39);
            buttonAddtoCard_SYP.TabIndex = 2;
            buttonAddtoCard_SYP.UseVisualStyleBackColor = true;
            buttonAddtoCard_SYP.Click += buttonAddtoCard_SYP_Click;
            // 
            // buttonOpenFile_SYP
            // 
            buttonOpenFile_SYP.Image = (Image)resources.GetObject("buttonOpenFile_SYP.Image");
            buttonOpenFile_SYP.Location = new Point(33, 43);
            buttonOpenFile_SYP.Name = "buttonOpenFile_SYP";
            buttonOpenFile_SYP.Size = new Size(46, 39);
            buttonOpenFile_SYP.TabIndex = 1;
            buttonOpenFile_SYP.UseVisualStyleBackColor = true;
            buttonOpenFile_SYP.Click += buttonOpenFile_SYP_Click;
            // 
            // buttonSaveFile_SYP
            // 
            buttonSaveFile_SYP.Enabled = false;
            buttonSaveFile_SYP.Image = (Image)resources.GetObject("buttonSaveFile_SYP.Image");
            buttonSaveFile_SYP.Location = new Point(107, 43);
            buttonSaveFile_SYP.Name = "buttonSaveFile_SYP";
            buttonSaveFile_SYP.Size = new Size(46, 39);
            buttonSaveFile_SYP.TabIndex = 0;
            buttonSaveFile_SYP.UseVisualStyleBackColor = true;
            buttonSaveFile_SYP.Click += buttonSaveFile_SBI_Click;
            // 
            // panelDataFile_SYP
            // 
            panelDataFile_SYP.BackColor = SystemColors.ButtonFace;
            panelDataFile_SYP.Controls.Add(groupBoxDataFile_SYP);
            panelDataFile_SYP.Dock = DockStyle.Fill;
            panelDataFile_SYP.Location = new Point(200, 35);
            panelDataFile_SYP.Name = "panelDataFile_SYP";
            panelDataFile_SYP.Size = new Size(764, 415);
            panelDataFile_SYP.TabIndex = 2;
            // 
            // groupBoxDataFile_SYP
            // 
            groupBoxDataFile_SYP.Controls.Add(tabControlFile_SYP);
            groupBoxDataFile_SYP.Dock = DockStyle.Fill;
            groupBoxDataFile_SYP.Location = new Point(0, 0);
            groupBoxDataFile_SYP.Name = "groupBoxDataFile_SYP";
            groupBoxDataFile_SYP.Size = new Size(764, 415);
            groupBoxDataFile_SYP.TabIndex = 1;
            groupBoxDataFile_SYP.TabStop = false;
            groupBoxDataFile_SYP.Text = "Данные";
            // 
            // tabControlFile_SYP
            // 
            tabControlFile_SYP.Controls.Add(tabPageOriginalFile_SYP);
            tabControlFile_SYP.Controls.Add(tabPageCardFile_SYP);
            tabControlFile_SYP.Dock = DockStyle.Fill;
            tabControlFile_SYP.Location = new Point(3, 19);
            tabControlFile_SYP.Name = "tabControlFile_SYP";
            tabControlFile_SYP.SelectedIndex = 0;
            tabControlFile_SYP.Size = new Size(758, 393);
            tabControlFile_SYP.TabIndex = 0;
            // 
            // tabPageOriginalFile_SYP
            // 
            tabPageOriginalFile_SYP.Controls.Add(dataGridViewOriginalFile_SYP);
            tabPageOriginalFile_SYP.Location = new Point(4, 24);
            tabPageOriginalFile_SYP.Name = "tabPageOriginalFile_SYP";
            tabPageOriginalFile_SYP.Padding = new Padding(3);
            tabPageOriginalFile_SYP.Size = new Size(750, 365);
            tabPageOriginalFile_SYP.TabIndex = 0;
            tabPageOriginalFile_SYP.Text = "Оптовая база";
            tabPageOriginalFile_SYP.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOriginalFile_SYP
            // 
            dataGridViewOriginalFile_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOriginalFile_SYP.Dock = DockStyle.Fill;
            dataGridViewOriginalFile_SYP.Location = new Point(3, 3);
            dataGridViewOriginalFile_SYP.Name = "dataGridViewOriginalFile_SYP";
            dataGridViewOriginalFile_SYP.RowHeadersVisible = false;
            dataGridViewOriginalFile_SYP.Size = new Size(744, 359);
            dataGridViewOriginalFile_SYP.TabIndex = 0;
            // 
            // tabPageCardFile_SYP
            // 
            tabPageCardFile_SYP.Controls.Add(dataGridViewCard_SYP);
            tabPageCardFile_SYP.Location = new Point(4, 24);
            tabPageCardFile_SYP.Name = "tabPageCardFile_SYP";
            tabPageCardFile_SYP.Padding = new Padding(3);
            tabPageCardFile_SYP.Size = new Size(750, 365);
            tabPageCardFile_SYP.TabIndex = 1;
            tabPageCardFile_SYP.Text = "Корзина";
            tabPageCardFile_SYP.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCard_SYP
            // 
            dataGridViewCard_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCard_SYP.Dock = DockStyle.Fill;
            dataGridViewCard_SYP.Location = new Point(3, 3);
            dataGridViewCard_SYP.Name = "dataGridViewCard_SYP";
            dataGridViewCard_SYP.RowHeadersVisible = false;
            dataGridViewCard_SYP.Size = new Size(744, 359);
            dataGridViewCard_SYP.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 35);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 415);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_SYP
            // 
            openFileDialogTask_SYP.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 450);
            Controls.Add(splitter1);
            Controls.Add(panelDataFile_SYP);
            Controls.Add(panelManagerData_SYP);
            Controls.Add(panelInformation_SYP);
            Name = "FormMain";
            Text = "Form1";
            panelInformation_SYP.ResumeLayout(false);
            panelInformation_SYP.PerformLayout();
            statusStripManageData_SYP.ResumeLayout(false);
            statusStripManageData_SYP.PerformLayout();
            panelManagerData_SYP.ResumeLayout(false);
            panelDataFile_SYP.ResumeLayout(false);
            groupBoxDataFile_SYP.ResumeLayout(false);
            tabControlFile_SYP.ResumeLayout(false);
            tabPageOriginalFile_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).EndInit();
            tabPageCardFile_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCard_SYP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformation_SYP;
        private Panel panelManagerData_SYP;
        private Panel panelDataFile_SYP;
        private Splitter splitter1;
        private Button buttonSaveFile_SYP;
        private OpenFileDialog openFileDialogTask_SYP;
        private Button buttonOpenFile_SYP;
        private SaveFileDialog saveFileDialog_SYP;
        private StatusStrip statusStripManageData_SYP;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelChabgeData_SYP;
        private GroupBox groupBoxDataFile_SYP;
        private TabControl tabControlFile_SYP;
        private TabPage tabPageCardFile_SYP;
        private TabPage tabPageOriginalFile_SYP;
        private DataGridView dataGridViewOriginalFile_SYP;
        private DataGridView dataGridViewCard_SYP;
        private Button buttonAddtoCard_SYP;
    }
}
