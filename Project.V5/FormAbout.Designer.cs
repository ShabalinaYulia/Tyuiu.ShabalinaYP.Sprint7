namespace Project.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxIcon_SYP = new PictureBox();
            labelAbout_SYP = new Label();
            buttonOK_SYP = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_SYP).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIcon_SYP
            // 
            pictureBoxIcon_SYP.Image = (Image)resources.GetObject("pictureBoxIcon_SYP.Image");
            pictureBoxIcon_SYP.Location = new Point(43, 24);
            pictureBoxIcon_SYP.Name = "pictureBoxIcon_SYP";
            pictureBoxIcon_SYP.Size = new Size(180, 242);
            pictureBoxIcon_SYP.TabIndex = 0;
            pictureBoxIcon_SYP.TabStop = false;
            // 
            // labelAbout_SYP
            // 
            labelAbout_SYP.AutoSize = true;
            labelAbout_SYP.Location = new Point(250, 68);
            labelAbout_SYP.Name = "labelAbout_SYP";
            labelAbout_SYP.Size = new Size(303, 120);
            labelAbout_SYP.TabIndex = 1;
            labelAbout_SYP.Text = resources.GetString("labelAbout_SYP.Text");
            // 
            // buttonOK_SYP
            // 
            buttonOK_SYP.Location = new Point(478, 243);
            buttonOK_SYP.Name = "buttonOK_SYP";
            buttonOK_SYP.Size = new Size(75, 23);
            buttonOK_SYP.TabIndex = 2;
            buttonOK_SYP.Text = "Ок";
            buttonOK_SYP.UseVisualStyleBackColor = true;
            buttonOK_SYP.Click += buttonOK_SYP_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 313);
            Controls.Add(buttonOK_SYP);
            Controls.Add(labelAbout_SYP);
            Controls.Add(pictureBoxIcon_SYP);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_SYP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIcon_SYP;
        private Label labelAbout_SYP;
        private Button buttonOK_SYP;
    }
}