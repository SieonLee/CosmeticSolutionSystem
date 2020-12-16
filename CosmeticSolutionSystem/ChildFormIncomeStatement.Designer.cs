
namespace CosmeticSolutionSystem
{
    partial class ChildFormIncomeStatement
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.재무제표BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.재무제표BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl2
            // 
            this.chartControl2.DataSource = this.재무제표BindingSource;
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy\'년\'}";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:c}";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(516, 7);
            this.chartControl2.Name = "chartControl2";
            series1.ArgumentDataMember = "년도";
            sideBySideBarSeriesLabel1.TextPattern = "{V:c}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "영업이익";
            series1.ValueDataMembersSerializable = "영업이익";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl2.Size = new System.Drawing.Size(519, 370);
            this.chartControl2.TabIndex = 1;
            chartTitle1.Text = "영업이익";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartControl1.DataSource = this.재무제표BindingSource;
            xyDiagram2.AxisX.Label.TextPattern = "{A:yyyy\'년\'}";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Label.TextPattern = "{V:c}";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(12, 7);
            this.chartControl1.Name = "chartControl1";
            series2.ArgumentDataMember = "년도";
            sideBySideBarSeriesLabel2.TextPattern = "{V:c}";
            series2.Label = sideBySideBarSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "매출액";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "년도";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "매출액";
            this.chartControl1.Size = new System.Drawing.Size(498, 370);
            this.chartControl1.TabIndex = 2;
            chartTitle2.Text = "매출액";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // 재무제표BindingSource
            // 
            this.재무제표BindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.재무제표);
            // 
            // chartControl3
            // 
            this.chartControl3.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartControl3.DataSource = this.재무제표BindingSource;
            xyDiagram3.AxisX.Label.TextPattern = "{A:yyyy\'년\'}";
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Label.TextPattern = "{V:c}";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl3.Diagram = xyDiagram3;
            this.chartControl3.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl3.Location = new System.Drawing.Point(1041, 8);
            this.chartControl3.Name = "chartControl3";
            series3.ArgumentDataMember = "년도";
            sideBySideBarSeriesLabel3.TextPattern = "{V:c}";
            series3.Label = sideBySideBarSeriesLabel3;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.Name = "당기순이익";
            series3.ValueDataMembersSerializable = "당기순이익";
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl3.SeriesTemplate.ArgumentDataMember = "년도";
            this.chartControl3.SeriesTemplate.ValueDataMembersSerializable = "매출액";
            this.chartControl3.Size = new System.Drawing.Size(498, 370);
            this.chartControl3.TabIndex = 3;
            chartTitle3.Text = "당기순이익";
            this.chartControl3.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // ChildFormIncomeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 860);
            this.Controls.Add(this.chartControl3);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.chartControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChildFormIncomeStatement";
            this.Text = "손익 계산서";
            this.Load += new System.EventHandler(this.ChildFormIncomeStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.재무제표BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource 재무제표BindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl3;
    }
}