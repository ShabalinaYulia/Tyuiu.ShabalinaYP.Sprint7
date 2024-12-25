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
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemGuide_SYP = new ToolStripMenuItem();
            ToolStripMenuItemAbout_SYP = new ToolStripMenuItem();
            ToolStripMenuItemFile_SYP = new ToolStripMenuItem();
            сохранитьToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItemOpenNewFile_SYP = new ToolStripMenuItem();
            panelManagerData_SYP = new Panel();
            buttonSearchProduct_SYP = new Button();
            buttonDeleteCompletedOrders_SYP = new Button();
            labelSearchProduct_SYP = new Label();
            buttonAddCompletedOrders_SYP = new Button();
            textBoxSearch_SYP = new TextBox();
            groupBox1 = new GroupBox();
            buttonOpenFile_SYP = new Button();
            buttonSaveFile_SYP = new Button();
            groupBox2 = new GroupBox();
            panelDataFile_SYP = new Panel();
            groupBoxDataFile_SYP = new GroupBox();
            tabControlFile_SYP = new TabControl();
            tabPageOriginalFile_SYP = new TabPage();
            dataGridViewOriginalFile_SYP = new DataGridView();
            tabPageCardFile_SYP = new TabPage();
            dataGridViewCompletedOrders_SYP = new DataGridView();
            openFileDialogTask_SYP = new OpenFileDialog();
            saveFileDialog_SYP = new SaveFileDialog();
            button1 = new Button();
            panelInformation_SYP.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelManagerData_SYP.SuspendLayout();
            groupBox1.SuspendLayout();
            panelDataFile_SYP.SuspendLayout();
            groupBoxDataFile_SYP.SuspendLayout();
            tabControlFile_SYP.SuspendLayout();
            tabPageOriginalFile_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).BeginInit();
            tabPageCardFile_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompletedOrders_SYP).BeginInit();
            SuspendLayout();
            // 
            // panelInformation_SYP
            // 
            panelInformation_SYP.BackColor = SystemColors.ActiveCaption;
            panelInformation_SYP.Controls.Add(menuStrip1);
            panelInformation_SYP.Dock = DockStyle.Top;
            panelInformation_SYP.Location = new Point(0, 0);
            panelInformation_SYP.Name = "panelInformation_SYP";
            panelInformation_SYP.Size = new Size(964, 35);
            panelInformation_SYP.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem, ToolStripMenuItemFile_SYP });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(964, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemGuide_SYP, ToolStripMenuItemAbout_SYP });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(94, 31);
            ToolStripMenuItem.Text = "О программе";
            // 
            // ToolStripMenuItemGuide_SYP
            // 
            ToolStripMenuItemGuide_SYP.Name = "ToolStripMenuItemGuide_SYP";
            ToolStripMenuItemGuide_SYP.Size = new Size(143, 22);
            ToolStripMenuItemGuide_SYP.Text = "Руководство";
            ToolStripMenuItemGuide_SYP.Click += buttonStatics_SYP_Click;
            // 
            // ToolStripMenuItemAbout_SYP
            // 
            ToolStripMenuItemAbout_SYP.Name = "ToolStripMenuItemAbout_SYP";
            ToolStripMenuItemAbout_SYP.Size = new Size(143, 22);
            ToolStripMenuItemAbout_SYP.Text = "Справка";
            ToolStripMenuItemAbout_SYP.Click += ToolStripMenuItemAbout_SYP_Click;
            // 
            // ToolStripMenuItemFile_SYP
            // 
            ToolStripMenuItemFile_SYP.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem1, ToolStripMenuItemOpenNewFile_SYP });
            ToolStripMenuItemFile_SYP.Name = "ToolStripMenuItemFile_SYP";
            ToolStripMenuItemFile_SYP.Size = new Size(48, 31);
            ToolStripMenuItemFile_SYP.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            сохранитьToolStripMenuItem1.Size = new Size(196, 22);
            сохранитьToolStripMenuItem1.Text = "Сохранить изменения";
            сохранитьToolStripMenuItem1.Click += buttonChangeFile_SYP_Click;
            // 
            // ToolStripMenuItemOpenNewFile_SYP
            // 
            ToolStripMenuItemOpenNewFile_SYP.Name = "ToolStripMenuItemOpenNewFile_SYP";
            ToolStripMenuItemOpenNewFile_SYP.Size = new Size(196, 22);
            ToolStripMenuItemOpenNewFile_SYP.Text = "Открыть новый файл";
            ToolStripMenuItemOpenNewFile_SYP.Click += buttonOpenFile_SYP_Click;
            // 
            // panelManagerData_SYP
            // 
            panelManagerData_SYP.BackColor = Color.RosyBrown;
            panelManagerData_SYP.Controls.Add(button1);
            panelManagerData_SYP.Controls.Add(buttonSearchProduct_SYP);
            panelManagerData_SYP.Controls.Add(buttonDeleteCompletedOrders_SYP);
            panelManagerData_SYP.Controls.Add(labelSearchProduct_SYP);
            panelManagerData_SYP.Controls.Add(buttonAddCompletedOrders_SYP);
            panelManagerData_SYP.Controls.Add(textBoxSearch_SYP);
            panelManagerData_SYP.Controls.Add(groupBox1);
            panelManagerData_SYP.Controls.Add(groupBox2);
            panelManagerData_SYP.Dock = DockStyle.Left;
            panelManagerData_SYP.Location = new Point(0, 35);
            panelManagerData_SYP.Name = "panelManagerData_SYP";
            panelManagerData_SYP.Size = new Size(200, 415);
            panelManagerData_SYP.TabIndex = 1;
            // 
            // buttonSearchProduct_SYP
            // 
            buttonSearchProduct_SYP.Enabled = false;
            buttonSearchProduct_SYP.Image = (Image)resources.GetObject("buttonSearchProduct_SYP.Image");
            buttonSearchProduct_SYP.Location = new Point(3, 114);
            buttonSearchProduct_SYP.Name = "buttonSearchProduct_SYP";
            buttonSearchProduct_SYP.Size = new Size(42, 41);
            buttonSearchProduct_SYP.TabIndex = 4;
            buttonSearchProduct_SYP.UseVisualStyleBackColor = true;
            buttonSearchProduct_SYP.Click += buttonSearch_SYP_Click;
            // 
            // buttonDeleteCompletedOrders_SYP
            // 
            buttonDeleteCompletedOrders_SYP.Enabled = false;
            buttonDeleteCompletedOrders_SYP.Image = (Image)resources.GetObject("buttonDeleteCompletedOrders_SYP.Image");
            buttonDeleteCompletedOrders_SYP.Location = new Point(72, 246);
            buttonDeleteCompletedOrders_SYP.Name = "buttonDeleteCompletedOrders_SYP";
            buttonDeleteCompletedOrders_SYP.Size = new Size(57, 51);
            buttonDeleteCompletedOrders_SYP.TabIndex = 3;
            buttonDeleteCompletedOrders_SYP.UseVisualStyleBackColor = true;
            buttonDeleteCompletedOrders_SYP.Click += buttonDeleteCompletedOrders_SYP_Click;
            // 
            // labelSearchProduct_SYP
            // 
            labelSearchProduct_SYP.AutoSize = true;
            labelSearchProduct_SYP.Enabled = false;
            labelSearchProduct_SYP.Location = new Point(51, 111);
            labelSearchProduct_SYP.Name = "labelSearchProduct_SYP";
            labelSearchProduct_SYP.Size = new Size(143, 15);
            labelSearchProduct_SYP.TabIndex = 3;
            labelSearchProduct_SYP.Text = "Введите название товара";
            // 
            // buttonAddCompletedOrders_SYP
            // 
            buttonAddCompletedOrders_SYP.Enabled = false;
            buttonAddCompletedOrders_SYP.Image = (Image)resources.GetObject("buttonAddCompletedOrders_SYP.Image");
            buttonAddCompletedOrders_SYP.Location = new Point(9, 246);
            buttonAddCompletedOrders_SYP.Name = "buttonAddCompletedOrders_SYP";
            buttonAddCompletedOrders_SYP.Size = new Size(57, 51);
            buttonAddCompletedOrders_SYP.TabIndex = 2;
            buttonAddCompletedOrders_SYP.UseVisualStyleBackColor = true;
            buttonAddCompletedOrders_SYP.Click += buttonAddCompletedOrders_SYP_Click;
            // 
            // textBoxSearch_SYP
            // 
            textBoxSearch_SYP.Enabled = false;
            textBoxSearch_SYP.Location = new Point(51, 132);
            textBoxSearch_SYP.Name = "textBoxSearch_SYP";
            textBoxSearch_SYP.Size = new Size(143, 23);
            textBoxSearch_SYP.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonOpenFile_SYP);
            groupBox1.Controls.Add(buttonSaveFile_SYP);
            groupBox1.Location = new Point(3, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(191, 86);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonOpenFile_SYP
            // 
            buttonOpenFile_SYP.Image = (Image)resources.GetObject("buttonOpenFile_SYP.Image");
            buttonOpenFile_SYP.Location = new Point(6, 24);
            buttonOpenFile_SYP.Name = "buttonOpenFile_SYP";
            buttonOpenFile_SYP.Size = new Size(57, 51);
            buttonOpenFile_SYP.TabIndex = 1;
            buttonOpenFile_SYP.UseVisualStyleBackColor = true;
            buttonOpenFile_SYP.Click += buttonOpenFile_SYP_Click;
            // 
            // buttonSaveFile_SYP
            // 
            buttonSaveFile_SYP.Enabled = false;
            buttonSaveFile_SYP.Image = (Image)resources.GetObject("buttonSaveFile_SYP.Image");
            buttonSaveFile_SYP.Location = new Point(72, 24);
            buttonSaveFile_SYP.Name = "buttonSaveFile_SYP";
            buttonSaveFile_SYP.Size = new Size(57, 51);
            buttonSaveFile_SYP.TabIndex = 0;
            buttonSaveFile_SYP.UseVisualStyleBackColor = true;
            buttonSaveFile_SYP.Click += buttonSaveFile_SYP_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
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
            tabPageCardFile_SYP.Controls.Add(dataGridViewCompletedOrders_SYP);
            tabPageCardFile_SYP.Location = new Point(4, 24);
            tabPageCardFile_SYP.Name = "tabPageCardFile_SYP";
            tabPageCardFile_SYP.Padding = new Padding(3);
            tabPageCardFile_SYP.Size = new Size(750, 365);
            tabPageCardFile_SYP.TabIndex = 1;
            tabPageCardFile_SYP.Text = "Доставленные заказы";
            tabPageCardFile_SYP.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCompletedOrders_SYP
            // 
            dataGridViewCompletedOrders_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompletedOrders_SYP.Dock = DockStyle.Fill;
            dataGridViewCompletedOrders_SYP.Location = new Point(3, 3);
            dataGridViewCompletedOrders_SYP.Name = "dataGridViewCompletedOrders_SYP";
            dataGridViewCompletedOrders_SYP.RowHeadersVisible = false;
            dataGridViewCompletedOrders_SYP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompletedOrders_SYP.Size = new Size(744, 359);
            dataGridViewCompletedOrders_SYP.TabIndex = 0;
            // 
            // openFileDialogTask_SYP
            // 
            openFileDialogTask_SYP.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(32, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonStatics_SYP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 450);
            Controls.Add(panelDataFile_SYP);
            Controls.Add(panelManagerData_SYP);
            Controls.Add(panelInformation_SYP);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Form1";
            panelInformation_SYP.ResumeLayout(false);
            panelInformation_SYP.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelManagerData_SYP.ResumeLayout(false);
            panelManagerData_SYP.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelDataFile_SYP.ResumeLayout(false);
            groupBoxDataFile_SYP.ResumeLayout(false);
            tabControlFile_SYP.ResumeLayout(false);
            tabPageOriginalFile_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginalFile_SYP).EndInit();
            tabPageCardFile_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompletedOrders_SYP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformation_SYP;
        private Panel panelManagerData_SYP;
        private Panel panelDataFile_SYP;
        private Button buttonSaveFile_SYP;
        private OpenFileDialog openFileDialogTask_SYP;
        private Button buttonOpenFile_SYP;
        private SaveFileDialog saveFileDialog_SYP;
        private GroupBox groupBoxDataFile_SYP;
        private TabControl tabControlFile_SYP;
        private TabPage tabPageCardFile_SYP;
        private TabPage tabPageOriginalFile_SYP;
        private DataGridView dataGridViewOriginalFile_SYP;
        private DataGridView dataGridViewCompletedOrders_SYP;
        private Button buttonAddCompletedOrders_SYP;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemGuide_SYP;
        private ToolStripMenuItem ToolStripMenuItemAbout_SYP;
        private Button buttonDeleteCompletedOrders_SYP;
        private ToolStripMenuItem ToolStripMenuItemFile_SYP;
        private ToolStripMenuItem сохранитьToolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItemOpenNewFile_SYP;
        private GroupBox groupBox1;
        private Button buttonSearchProduct_SYP;
        private Label labelSearchProduct_SYP;
        private TextBox textBoxSearch_SYP;
        private GroupBox groupBox2;
        private Button button1;
    }
}
