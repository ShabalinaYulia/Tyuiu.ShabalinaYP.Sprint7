using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.V5
{
    public partial class FormStatics : Form
    {
        private static DataGridView mainFormDataGrid;
        private int BiggestOrders = 0;
        public FormStatics(DataGridView dataGrid)
        {
            mainFormDataGrid = dataGrid;
            InitializeComponent();
        }
        public void GetBiggestOrder()
        {
            string ans = null;
            for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
            {
                if (mainFormDataGrid.Rows[i].Cells[4].Value != null &&
          int.TryParse(mainFormDataGrid.Rows[i].Cells[4].Value.ToString(), out int cellValue))
                {
                    if (cellValue > BiggestOrders)
                    {
                        BiggestOrders = cellValue;
                        ans = mainFormDataGrid.Rows[i].Cells[4].Value.ToString();
                    }
                }
            }
            labelBiggestOrder_SYP.Text = $"Самый большой заказ: {ans}";
        }
        private void GetMostRepeatedString()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (DataGridViewRow row in mainFormDataGrid.Rows)
            {
                if (row.IsNewRow) continue;
                string value = row.Cells[3].Value?.ToString();
                if (value != null)
                {
                    if (counts.ContainsKey(value))
                    {
                        counts[value]++;
                    }
                    else
                    {
                        counts[value] = 1;
                    }
                }
            }

            string mostFrequent = null;
            int maxCount = 0;
            foreach (var pair in counts)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequent = pair.Key;
                }
            }
            labelRepeated_SYP.Text = $"Наиболее частый Поставщик: {mostFrequent}";
        }
        private void GetMostExpensive()
        {
            string ans = null;
            for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
            {
                if (mainFormDataGrid.Rows[i].Cells[6].Value != null &&
          int.TryParse(mainFormDataGrid.Rows[i].Cells[6].Value.ToString(), out int cellValue))
                {
                    if (cellValue > BiggestOrders)
                    {
                        BiggestOrders = cellValue;
                        ans = mainFormDataGrid.Rows[i].Cells[2].Value.ToString();
                    }
                }
            }
            labelExpensive_SYP.Text = $"Самый дорогой товар: {ans}";

        }

        private void buttonCalculateStatics_Click(object sender, EventArgs e)
        {
            GetBiggestOrder();
            GetMostRepeatedString();
            GetMostExpensive();
            if (chartStaticsProduct_SYP == null)
            {
                MessageBox.Show("Chart не инициализирован.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mainFormDataGrid == null || mainFormDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для отображения на графике.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mainFormDataGrid.Columns.Count < 3)
            {
                MessageBox.Show("Для построения графика нужно минимум 3 столбца.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Получаем заголовок графика из таблицы
                string chartTitle = $"График: {mainFormDataGrid.Columns[2].HeaderText}";
                // Устанавливаем заголовок
                this.chartStaticsProduct_SYP.Titles.Clear(); // Очищаем старые заголовки.
                this.chartStaticsProduct_SYP.Titles.Add(chartTitle);
                // Устанавливаем заголовки осей X и Y, из столбцов таблицы
                this.chartStaticsProduct_SYP.ChartAreas[0].AxisX.Title = mainFormDataGrid.Columns[4].HeaderText;
                this.chartStaticsProduct_SYP.ChartAreas[0].AxisY.Title = mainFormDataGrid.Columns[6].HeaderText;

                // Очищаем данные chart
                this.chartStaticsProduct_SYP.Series.Clear();
                this.chartStaticsProduct_SYP.Series.Add(new Series("Series1"));
                this.chartStaticsProduct_SYP.Series[0].ChartType = SeriesChartType.Column; // Устанавливаем тип графика как сплайн.
                this.chartStaticsProduct_SYP.Series[0].XValueType = ChartValueType.Double;  // Устанавливаем числовой тип для оси X
                this.chartStaticsProduct_SYP.Series[0].YValueType = ChartValueType.Double;
                // Переменные для хранения данных для графика
                List<double> xValues = new List<double>();
                List<double> yValues = new List<double>();

                for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
                {
                    if (mainFormDataGrid.Rows[i].IsNewRow) continue;
                    object xValueObject = mainFormDataGrid.Rows[i].Cells[4].Value; // Получаем значение для оси X
                    object yValueObject = mainFormDataGrid.Rows[i].Cells[6].Value; // Получаем значение для оси Y

                    if (xValueObject != null && yValueObject != null)
                    {
                        // Пытаемся преобразовать xValue к double, и добавляем его
                        if (double.TryParse(xValueObject.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double xValue))
                        {
                            if (double.TryParse(yValueObject.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double yValue))
                            {
                                xValues.Add(xValue);
                                yValues.Add(yValue);
                            }
                            else
                            {
                                MessageBox.Show($"Не удалось преобразовать значение '{yValueObject}' в число.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Не удалось преобразовать значение '{xValueObject}' в число.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Добавляем данные в chart
                for (int i = 0; i < xValues.Count; i++)
                {
                    this.chartStaticsProduct_SYP.Series[0].Points.AddXY(xValues[i], yValues[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при построении графика: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
