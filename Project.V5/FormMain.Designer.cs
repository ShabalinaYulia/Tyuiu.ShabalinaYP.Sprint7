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
            buttonOpenFile_SYP = new Button();
            buttonSaveFile_SYP = new Button();
            panelDataFile_SYP = new Panel();
            groupBoxDataFile_SYP = new GroupBox();
            tabControlFile_SYP = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewOriginalFile_SYP = new DataGridView();
            tabPage2 = new TabPage();
            splitter1 = new Splitter();
            openFileDialogTask_SYP = new OpenFileDialog();
            saveFileDialog_SYP = new SaveFileDialog();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panelInformation_SYP.SuspendLayout();
            statusStripManageData_SYP.SuspendLayout();
            panelManagerData_SYP.SuspendLayout();
            panelDataFile_SYP.SuspendLayout();
            groupBoxDataFile_SYP.SuspendLayout();
            tabControlFile_SYP.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelInformation_SYP
            // 
            panelInformation_SYP.BackColor = SystemColors.ActiveCaption;
            panelInformation_SYP.Controls.Add(statusStripManageData_SYP);
            panelInformation_SYP.Dock = DockStyle.Top;
            panelInformation_SYP.Location = new Point(0, 0);
            panelInformation_SYP.Name = "panelInformation_SYP";
            panelInformation_SYP.Size = new Size(800, 35);
            panelInformation_SYP.TabIndex = 0;
            // 
            // statusStripManageData_SYP
            // 
            statusStripManageData_SYP.Dock = DockStyle.Fill;
            statusStripManageData_SYP.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabelChabgeData_SYP });
            statusStripManageData_SYP.Location = new Point(0, 0);
            statusStripManageData_SYP.Name = "statusStripManageData_SYP";
            statusStripManageData_SYP.Size = new Size(800, 35);
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
            panelManagerData_SYP.Controls.Add(button1);
            panelManagerData_SYP.Controls.Add(buttonOpenFile_SYP);
            panelManagerData_SYP.Controls.Add(buttonSaveFile_SYP);
            panelManagerData_SYP.Dock = DockStyle.Left;
            panelManagerData_SYP.Location = new Point(0, 35);
            panelManagerData_SYP.Name = "panelManagerData_SYP";
            panelManagerData_SYP.Size = new Size(200, 415);
            panelManagerData_SYP.TabIndex = 1;
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
            // 
            // panelDataFile_SYP
            // 
            panelDataFile_SYP.BackColor = SystemColors.ButtonFace;
            panelDataFile_SYP.Controls.Add(groupBoxDataFile_SYP);
            panelDataFile_SYP.Dock = DockStyle.Fill;
            panelDataFile_SYP.Location = new Point(200, 35);
            panelDataFile_SYP.Name = "panelDataFile_SYP";
            panelDataFile_SYP.Size = new Size(600, 415);
            panelDataFile_SYP.TabIndex = 2;
            // 
            // groupBoxDataFile_SYP
            // 
            groupBoxDataFile_SYP.Controls.Add(tabControlFile_SYP);
            groupBoxDataFile_SYP.Dock = DockStyle.Fill;
            groupBoxDataFile_SYP.Location = new Point(0, 0);
            groupBoxDataFile_SYP.Name = "groupBoxDataFile_SYP";
            groupBoxDataFile_SYP.Size = new Size(600, 415);
            groupBoxDataFile_SYP.TabIndex = 1;
            groupBoxDataFile_SYP.TabStop = false;
            groupBoxDataFile_SYP.Text = "Данные";
            // 
            // tabControlFile_SYP
            // 
            tabControlFile_SYP.Controls.Add(tabPage1);
            tabControlFile_SYP.Controls.Add(tabPage2);
            tabControlFile_SYP.Dock = DockStyle.Fill;
            tabControlFile_SYP.Location = new Point(3, 19);
            tabControlFile_SYP.Name = "tabControlFile_SYP";
            tabControlFile_SYP.SelectedIndex = 0;
            tabControlFile_SYP.Size = new Size(594, 393);
            tabControlFile_SYP.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewOriginalFile_SYP);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(586, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOriginalFile_SYP
            // 
            dataGridViewOriginalFile_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOriginalFile_SYP.Dock = DockStyle.Fill;
            dataGridViewOriginalFile_SYP.Location = new Point(3, 3);
            dataGridViewOriginalFile_SYP.Name = "dataGridViewOriginalFile_SYP";
            dataGridViewOriginalFile_SYP.RowHeadersVisible = false;
            dataGridViewOriginalFile_SYP.Size = new Size(580, 359);
            dataGridViewOriginalFile_SYP.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(586, 365);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(580, 359);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(33, 131);
            button1.Name = "button1";
            button1.Size = new Size(46, 39);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridView dataGridViewOriginalFile_SYP;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
