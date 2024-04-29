namespace ManagementSupermarket.Manager
{
    partial class frmRevenue
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
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbb_Criteria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Revenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend1);
            this.chart_Revenue.Location = new System.Drawing.Point(12, 113);
            this.chart_Revenue.Name = "chart_Revenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.chart_Revenue.Series.Add(series1);
            this.chart_Revenue.Size = new System.Drawing.Size(907, 456);
            this.chart_Revenue.TabIndex = 0;
            this.chart_Revenue.Text = "chart1";
            // 
            // cbb_Criteria
            // 
            this.cbb_Criteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbb_Criteria.FormattingEnabled = true;
            this.cbb_Criteria.Items.AddRange(new object[] {
            "Tuần",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbb_Criteria.Location = new System.Drawing.Point(959, 27);
            this.cbb_Criteria.Name = "cbb_Criteria";
            this.cbb_Criteria.Size = new System.Drawing.Size(128, 37);
            this.cbb_Criteria.TabIndex = 1;
            this.cbb_Criteria.SelectedIndexChanged += new System.EventHandler(this.cbb_Criteria_SelectedIndexChanged);
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 735);
            this.Controls.Add(this.cbb_Criteria);
            this.Controls.Add(this.chart_Revenue);
            this.Name = "frmRevenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.ComboBox cbb_Criteria;
    }
}