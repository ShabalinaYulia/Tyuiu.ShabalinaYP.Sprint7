namespace Project.V5
{
    partial class FormStatics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelBiggestOrder_SYP = new Label();
            buttonAccessData_SYP = new Button();
            labelRepeated_SYP = new Label();
            chartStaticsProduct_SYP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelExpensive_SYP = new Label();
            ((System.ComponentModel.ISupportInitialize)chartStaticsProduct_SYP).BeginInit();
            SuspendLayout();
            // 
            // labelBiggestOrder_SYP
            // 
            labelBiggestOrder_SYP.AutoSize = true;
            labelBiggestOrder_SYP.Location = new Point(12, 55);
            labelBiggestOrder_SYP.Name = "labelBiggestOrder_SYP";
            labelBiggestOrder_SYP.Size = new Size(205, 15);
            labelBiggestOrder_SYP.TabIndex = 0;
            labelBiggestOrder_SYP.Text = "Отсутствуют данные для статистики";
            // 
            // buttonAccessData_SYP
            // 
            buttonAccessData_SYP.Location = new Point(29, 248);
            buttonAccessData_SYP.Name = "buttonAccessData_SYP";
            buttonAccessData_SYP.Size = new Size(105, 92);
            buttonAccessData_SYP.TabIndex = 1;
            buttonAccessData_SYP.Text = "Предоставить данные";
            buttonAccessData_SYP.UseVisualStyleBackColor = true;
            buttonAccessData_SYP.Click += buttonCalculateStatics_Click;
            // 
            // labelRepeated_SYP
            // 
            labelRepeated_SYP.AutoSize = true;
            labelRepeated_SYP.Location = new Point(12, 156);
            labelRepeated_SYP.Name = "labelRepeated_SYP";
            labelRepeated_SYP.Size = new Size(205, 15);
            labelRepeated_SYP.TabIndex = 2;
            labelRepeated_SYP.Text = "Отсутствуют данные для статистики";
            // 
            // chartStaticsProduct_SYP
            // 
            chartArea1.Name = "ChartArea1";
            chartStaticsProduct_SYP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStaticsProduct_SYP.Legends.Add(legend1);
            chartStaticsProduct_SYP.Location = new Point(282, 31);
            chartStaticsProduct_SYP.Name = "chartStaticsProduct_SYP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "ChartAreaProduct";
            chartStaticsProduct_SYP.Series.Add(series1);
            chartStaticsProduct_SYP.Size = new Size(354, 300);
            chartStaticsProduct_SYP.TabIndex = 3;
            chartStaticsProduct_SYP.Text = "Статистика товаров";
            // 
            // labelExpensive_SYP
            // 
            labelExpensive_SYP.AutoSize = true;
            labelExpensive_SYP.Location = new Point(12, 89);
            labelExpensive_SYP.Name = "labelExpensive_SYP";
            labelExpensive_SYP.Size = new Size(205, 15);
            labelExpensive_SYP.TabIndex = 4;
            labelExpensive_SYP.Text = "Отсутствуют данные для статистики";
            // 
            // FormStatics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 368);
            Controls.Add(labelExpensive_SYP);
            Controls.Add(chartStaticsProduct_SYP);
            Controls.Add(labelRepeated_SYP);
            Controls.Add(buttonAccessData_SYP);
            Controls.Add(labelBiggestOrder_SYP);
            MaximizeBox = false;
            Name = "FormStatics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)chartStaticsProduct_SYP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBiggestOrder_SYP;
        private Button buttonAccessData_SYP;
        private Label labelRepeated_SYP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStaticsProduct_SYP;
        private Label labelExpensive_SYP;
    }
}