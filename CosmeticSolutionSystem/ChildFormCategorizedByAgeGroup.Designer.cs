
namespace CosmeticSolutionSystem
{
    partial class ChildFormCategorizedByAgeGroup
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D2 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.ManhattanBarSeriesView manhattanBarSeriesView2 = new DevExpress.XtraCharts.ManhattanBarSeriesView();
            this.categorizedByAgeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CategoryAgeChart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnYear2018 = new DevExpress.XtraEditors.SimpleButton();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnYear2019 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnYear2020 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.categorizedByAgeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAgeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // categorizedByAgeModelBindingSource
            // 
            this.categorizedByAgeModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.CategorizedByAgeModel);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnYear2020);
            this.layoutControl1.Controls.Add(this.btnYear2019);
            this.layoutControl1.Controls.Add(this.btnYear2018);
            this.layoutControl1.Controls.Add(this.CategoryAgeChart);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShowLineShadow = false;
            this.labelControl2.Size = new System.Drawing.Size(776, 30);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "카테고리별 연령대별 판매량";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CategoryAgeChart
            // 
            this.CategoryAgeChart.DataSource = this.categorizedByAgeModelBindingSource;
            xyDiagram3D2.AxisY.Interlaced = false;
            xyDiagram3D2.AxisY.MinorCount = 2;
            xyDiagram3D2.RotationMatrixSerializable = "0.998074116832991;-0.0553765464427024;0.0279552394404704;0;0.0550465623949169;0.9" +
    "9840629991687;0.0124393028281886;0;-0.0285995328038339;-0.0108765063521368;0.999" +
    "531774548976;0;0;0;0;1";
            xyDiagram3D2.RuntimeRotation = true;
            xyDiagram3D2.RuntimeScrolling = true;
            xyDiagram3D2.RuntimeZooming = true;
            xyDiagram3D2.ZoomPercent = 200;
            this.CategoryAgeChart.Diagram = xyDiagram3D2;
            this.CategoryAgeChart.Legend.Name = "Default Legend";
            this.CategoryAgeChart.Location = new System.Drawing.Point(12, 46);
            this.CategoryAgeChart.Name = "CategoryAgeChart";
            this.CategoryAgeChart.SeriesDataMember = "CategoryName";
            this.CategoryAgeChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CategoryAgeChart.SeriesTemplate.ArgumentDataMember = "Date";
            this.CategoryAgeChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            this.CategoryAgeChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            this.CategoryAgeChart.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.CategoryAgeChart.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            manhattanBarSeriesView2.BarWidth = 20D;
            this.CategoryAgeChart.SeriesTemplate.View = manhattanBarSeriesView2;
            this.CategoryAgeChart.Size = new System.Drawing.Size(776, 366);
            this.CategoryAgeChart.TabIndex = 26;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CategoryAgeChart;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 370);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(669, 404);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(111, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(250, 404);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(85, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnYear2018;
            this.layoutControlItem3.Location = new System.Drawing.Point(119, 404);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(131, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnYear2018
            // 
            this.btnYear2018.Location = new System.Drawing.Point(131, 416);
            this.btnYear2018.Name = "btnYear2018";
            this.btnYear2018.Size = new System.Drawing.Size(127, 22);
            this.btnYear2018.StyleController = this.layoutControl1;
            this.btnYear2018.TabIndex = 27;
            this.btnYear2018.Text = "2018";
            this.btnYear2018.Click += new System.EventHandler(this.btnYear2018_Click);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 404);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(119, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnYear2019
            // 
            this.btnYear2019.Location = new System.Drawing.Point(347, 416);
            this.btnYear2019.Name = "btnYear2019";
            this.btnYear2019.Size = new System.Drawing.Size(125, 22);
            this.btnYear2019.StyleController = this.layoutControl1;
            this.btnYear2019.TabIndex = 28;
            this.btnYear2019.Text = "2019";
            this.btnYear2019.Click += new System.EventHandler(this.btnYear2019_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnYear2019;
            this.layoutControlItem4.Location = new System.Drawing.Point(335, 404);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(129, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnYear2020
            // 
            this.btnYear2020.Location = new System.Drawing.Point(552, 416);
            this.btnYear2020.Name = "btnYear2020";
            this.btnYear2020.Size = new System.Drawing.Size(125, 22);
            this.btnYear2020.StyleController = this.layoutControl1;
            this.btnYear2020.TabIndex = 29;
            this.btnYear2020.Text = "2020";
            this.btnYear2020.Click += new System.EventHandler(this.btnYear2020_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnYear2020;
            this.layoutControlItem5.Location = new System.Drawing.Point(540, 404);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(129, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(464, 404);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(76, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ChildFormCategorizedByAgeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChildFormCategorizedByAgeGroup";
            this.Text = "카테고리별 연령대별 비중 남자 - 여자";
            this.Load += new System.EventHandler(this.ChildFormCategorizedByAgeGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorizedByAgeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAgeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource categorizedByAgeModelBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraCharts.ChartControl CategoryAgeChart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnYear2018;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btnYear2019;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnYear2020;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}