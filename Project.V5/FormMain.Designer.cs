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
            panelInformation_SYP = new Panel();
            panelManagerData_SYP = new Panel();
            buttonOpenFile_SYP = new Button();
            buttonDone_SYP = new Button();
            panelDataFile_SYP = new Panel();
            dataGridViewOriginalFile_SYP = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_SYP = new OpenFileDialog();
            saveFileDialog_SYP = new SaveFileDialog();
            panelManagerData_SYP.SuspendLayout();
            panelDataFile_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).BeginInit();
            SuspendLayout();
            // 
            // panelInformation_SYP
            // 
            panelInformation_SYP.BackColor = SystemColors.ActiveCaption;
            panelInformation_SYP.Dock = DockStyle.Bottom;
            panelInformation_SYP.Location = new Point(0, 350);
            panelInformation_SYP.Name = "panelInformation_SYP";
            panelInformation_SYP.Size = new Size(800, 100);
            panelInformation_SYP.TabIndex = 0;
            // 
            // panelManagerData_SYP
            // 
            panelManagerData_SYP.BackColor = Color.RosyBrown;
            panelManagerData_SYP.Controls.Add(buttonOpenFile_SYP);
            panelManagerData_SYP.Controls.Add(buttonDone_SYP);
            panelManagerData_SYP.Dock = DockStyle.Left;
            panelManagerData_SYP.Location = new Point(0, 0);
            panelManagerData_SYP.Name = "panelManagerData_SYP";
            panelManagerData_SYP.Size = new Size(200, 350);
            panelManagerData_SYP.TabIndex = 1;
            // 
            // buttonOpenFile_SYP
            // 
            buttonOpenFile_SYP.Location = new Point(53, 183);
            buttonOpenFile_SYP.Name = "buttonOpenFile_SYP";
            buttonOpenFile_SYP.Size = new Size(75, 23);
            buttonOpenFile_SYP.TabIndex = 1;
            buttonOpenFile_SYP.Text = "button1";
            buttonOpenFile_SYP.UseVisualStyleBackColor = true;
            buttonOpenFile_SYP.Click += buttonOpenFile_SYP_Click;
            // 
            // buttonDone_SYP
            // 
            buttonDone_SYP.Location = new Point(40, 53);
            buttonDone_SYP.Name = "buttonDone_SYP";
            buttonDone_SYP.Size = new Size(62, 55);
            buttonDone_SYP.TabIndex = 0;
            buttonDone_SYP.Text = "button1";
            buttonDone_SYP.UseVisualStyleBackColor = true;
            // 
            // panelDataFile_SYP
            // 
            panelDataFile_SYP.BackColor = Color.Pink;
            panelDataFile_SYP.Controls.Add(dataGridViewOriginalFile_SYP);
            panelDataFile_SYP.Dock = DockStyle.Fill;
            panelDataFile_SYP.Location = new Point(200, 0);
            panelDataFile_SYP.Name = "panelDataFile_SYP";
            panelDataFile_SYP.Size = new Size(600, 350);
            panelDataFile_SYP.TabIndex = 2;
            // 
            // dataGridViewOriginalFile_SYP
            // 
            dataGridViewOriginalFile_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOriginalFile_SYP.Dock = DockStyle.Fill;
            dataGridViewOriginalFile_SYP.Location = new Point(0, 0);
            dataGridViewOriginalFile_SYP.Name = "dataGridViewOriginalFile_SYP";
            dataGridViewOriginalFile_SYP.RowHeadersVisible = false;
            dataGridViewOriginalFile_SYP.Size = new Size(600, 350);
            dataGridViewOriginalFile_SYP.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 350);
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
            ClientSize = new Size(800, 450);
            Controls.Add(splitter1);
            Controls.Add(panelDataFile_SYP);
            Controls.Add(panelManagerData_SYP);
            Controls.Add(panelInformation_SYP);
            Name = "FormMain";
            Text = "Form1";
            panelManagerData_SYP.ResumeLayout(false);
            panelDataFile_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformation_SYP;
        private Panel panelManagerData_SYP;
        private Panel panelDataFile_SYP;
        private Splitter splitter1;
        private DataGridView dataGridViewOriginalFile_SYP;
        private Button buttonDone_SYP;
        private OpenFileDialog openFileDialogTask_SYP;
        private Button buttonOpenFile_SYP;
        private SaveFileDialog saveFileDialog_SYP;
    }
}
