﻿namespace ClassCppToCS_CS
{
  partial class Form1
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.openCFGDialog = new System.Windows.Forms.OpenFileDialog();
      this.tgl_vis_peding_series = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tgl_vis_denied_series = new System.Windows.Forms.CheckBox();
      this.tgl_vis_cancelled_series = new System.Windows.Forms.CheckBox();
      this.tgl_vis_undefined_series = new System.Windows.Forms.CheckBox();
      this.creditscoretrackbar = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.requestamounttrackbar = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.numberofofferstrackbar = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      this.loangoaltrackbar = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label6 = new System.Windows.Forms.Label();
      this.tooltiptrackbar = new System.Windows.Forms.ToolTip(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exportSelectedDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.usingOnlySelectedDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.autoUpdateChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.projectionModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lAMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tkb_ninputpoints = new System.Windows.Forms.TrackBar();
      this.txb_max_track_n_cases = new System.Windows.Forms.TextBox();
      this.txb_min_track_n_cases = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tkb_lamp_progress = new System.Windows.Forms.TrackBar();
      this.label8 = new System.Windows.Forms.Label();
      this.updateMaxValuesUsingAllDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tkb_ninputpoints)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tkb_lamp_progress)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // openCFGDialog
      // 
      this.openCFGDialog.FileName = "openCFGDialog";
      // 
      // tgl_vis_peding_series
      // 
      this.tgl_vis_peding_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tgl_vis_peding_series.AutoSize = true;
      this.tgl_vis_peding_series.Checked = true;
      this.tgl_vis_peding_series.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tgl_vis_peding_series.Location = new System.Drawing.Point(8, 52);
      this.tgl_vis_peding_series.Name = "tgl_vis_peding_series";
      this.tgl_vis_peding_series.Size = new System.Drawing.Size(78, 17);
      this.tgl_vis_peding_series.TabIndex = 9;
      this.tgl_vis_peding_series.Text = "A_Pending";
      this.tgl_vis_peding_series.UseVisualStyleBackColor = true;
      this.tgl_vis_peding_series.CheckedChanged += new System.EventHandler(this.tgl_vis_peding_series_CheckedChanged);
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(8, 33);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Visible Series";
      // 
      // tgl_vis_denied_series
      // 
      this.tgl_vis_denied_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tgl_vis_denied_series.AutoSize = true;
      this.tgl_vis_denied_series.Checked = true;
      this.tgl_vis_denied_series.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tgl_vis_denied_series.Location = new System.Drawing.Point(92, 52);
      this.tgl_vis_denied_series.Name = "tgl_vis_denied_series";
      this.tgl_vis_denied_series.Size = new System.Drawing.Size(73, 17);
      this.tgl_vis_denied_series.TabIndex = 11;
      this.tgl_vis_denied_series.Text = "A_Denied";
      this.tgl_vis_denied_series.UseVisualStyleBackColor = true;
      this.tgl_vis_denied_series.CheckedChanged += new System.EventHandler(this.tgl_vis_denied_series_CheckedChanged);
      // 
      // tgl_vis_cancelled_series
      // 
      this.tgl_vis_cancelled_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tgl_vis_cancelled_series.AutoSize = true;
      this.tgl_vis_cancelled_series.Checked = true;
      this.tgl_vis_cancelled_series.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tgl_vis_cancelled_series.Location = new System.Drawing.Point(171, 52);
      this.tgl_vis_cancelled_series.Name = "tgl_vis_cancelled_series";
      this.tgl_vis_cancelled_series.Size = new System.Drawing.Size(86, 17);
      this.tgl_vis_cancelled_series.TabIndex = 12;
      this.tgl_vis_cancelled_series.Text = "A_Cancelled";
      this.tgl_vis_cancelled_series.UseVisualStyleBackColor = true;
      this.tgl_vis_cancelled_series.CheckedChanged += new System.EventHandler(this.tgl_vis_cancelled_series_CheckedChanged);
      // 
      // tgl_vis_undefined_series
      // 
      this.tgl_vis_undefined_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tgl_vis_undefined_series.AutoSize = true;
      this.tgl_vis_undefined_series.Checked = true;
      this.tgl_vis_undefined_series.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tgl_vis_undefined_series.Location = new System.Drawing.Point(263, 52);
      this.tgl_vis_undefined_series.Name = "tgl_vis_undefined_series";
      this.tgl_vis_undefined_series.Size = new System.Drawing.Size(75, 17);
      this.tgl_vis_undefined_series.TabIndex = 13;
      this.tgl_vis_undefined_series.Text = "Undefined";
      this.tgl_vis_undefined_series.UseVisualStyleBackColor = true;
      this.tgl_vis_undefined_series.CheckedChanged += new System.EventHandler(this.tgl_vis_undefined_series_CheckedChanged);
      // 
      // creditscoretrackbar
      // 
      this.creditscoretrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.creditscoretrackbar.Location = new System.Drawing.Point(765, 52);
      this.creditscoretrackbar.Name = "creditscoretrackbar";
      this.creditscoretrackbar.Size = new System.Drawing.Size(156, 45);
      this.creditscoretrackbar.TabIndex = 1;
      this.creditscoretrackbar.Value = 10;
      this.creditscoretrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      this.creditscoretrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(676, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "RequestAmount";
      // 
      // requestamounttrackbar
      // 
      this.requestamounttrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.requestamounttrackbar.Location = new System.Drawing.Point(765, 103);
      this.requestamounttrackbar.Name = "requestamounttrackbar";
      this.requestamounttrackbar.Size = new System.Drawing.Size(156, 45);
      this.requestamounttrackbar.TabIndex = 4;
      this.requestamounttrackbar.Value = 10;
      this.requestamounttrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
      this.requestamounttrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(676, 154);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "NumberOfOffers";
      // 
      // numberofofferstrackbar
      // 
      this.numberofofferstrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numberofofferstrackbar.Location = new System.Drawing.Point(765, 154);
      this.numberofofferstrackbar.Name = "numberofofferstrackbar";
      this.numberofofferstrackbar.Size = new System.Drawing.Size(156, 45);
      this.numberofofferstrackbar.TabIndex = 6;
      this.numberofofferstrackbar.Value = 10;
      this.numberofofferstrackbar.Scroll += new System.EventHandler(this.numberofofferstrackbar_Scroll);
      this.numberofofferstrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(676, 205);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "LoanGoal";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // loangoaltrackbar
      // 
      this.loangoaltrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.loangoaltrackbar.Location = new System.Drawing.Point(765, 205);
      this.loangoaltrackbar.Name = "loangoaltrackbar";
      this.loangoaltrackbar.Size = new System.Drawing.Size(156, 45);
      this.loangoaltrackbar.TabIndex = 8;
      this.loangoaltrackbar.Value = 10;
      this.loangoaltrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_2);
      this.loangoaltrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(676, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "CreditScore";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // chart1
      // 
      this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
      legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(11, 75);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series1.Legend = "Legend1";
      series1.MarkerColor = System.Drawing.Color.Green;
      series1.MarkerSize = 11;
      series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
      series1.Name = "A_Pending";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series2.Legend = "Legend1";
      series2.MarkerColor = System.Drawing.Color.Red;
      series2.MarkerSize = 10;
      series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
      series2.Name = "A_Denied";
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series3.Legend = "Legend1";
      series3.MarkerColor = System.Drawing.Color.Blue;
      series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series3.Name = "A_Cancelled";
      series4.ChartArea = "ChartArea1";
      series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series4.Legend = "Legend1";
      series4.MarkerColor = System.Drawing.Color.Black;
      series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
      series4.Name = "Undefined";
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Series.Add(series3);
      this.chart1.Series.Add(series4);
      this.chart1.Size = new System.Drawing.Size(659, 527);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.chart_Paint);
      this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
      this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
      this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart_MouseUp);
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(676, 29);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(110, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Weights for each field";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(676, 256);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(245, 23);
      this.button1.TabIndex = 15;
      this.button1.Text = "Project Cases";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectionModeToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(984, 24);
      this.menuStrip1.TabIndex = 16;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSelectedDataPointsToolStripMenuItem,
            this.autoUpdateChartToolStripMenuItem,
            this.updateMaxValuesUsingAllDataPointsToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
      // 
      // exportSelectedDataPointsToolStripMenuItem
      // 
      this.exportSelectedDataPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usingOnlySelectedDataPointsToolStripMenuItem});
      this.exportSelectedDataPointsToolStripMenuItem.Name = "exportSelectedDataPointsToolStripMenuItem";
      this.exportSelectedDataPointsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
      this.exportSelectedDataPointsToolStripMenuItem.Text = "Export csv";
      this.exportSelectedDataPointsToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedDataPointsToolStripMenuItem_Click);
      // 
      // usingOnlySelectedDataPointsToolStripMenuItem
      // 
      this.usingOnlySelectedDataPointsToolStripMenuItem.Name = "usingOnlySelectedDataPointsToolStripMenuItem";
      this.usingOnlySelectedDataPointsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
      this.usingOnlySelectedDataPointsToolStripMenuItem.Text = "Using only selected DataPoints";
      this.usingOnlySelectedDataPointsToolStripMenuItem.Click += new System.EventHandler(this.usingOnlySelectedDataPointsToolStripMenuItem_Click);
      // 
      // autoUpdateChartToolStripMenuItem
      // 
      this.autoUpdateChartToolStripMenuItem.Checked = true;
      this.autoUpdateChartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.autoUpdateChartToolStripMenuItem.Name = "autoUpdateChartToolStripMenuItem";
      this.autoUpdateChartToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
      this.autoUpdateChartToolStripMenuItem.Text = "Auto Update Chart";
      this.autoUpdateChartToolStripMenuItem.Click += new System.EventHandler(this.autoUpdateChartToolStripMenuItem_Click);
      // 
      // projectionModeToolStripMenuItem
      // 
      this.projectionModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDSToolStripMenuItem,
            this.lAMPToolStripMenuItem});
      this.projectionModeToolStripMenuItem.Name = "projectionModeToolStripMenuItem";
      this.projectionModeToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
      this.projectionModeToolStripMenuItem.Text = "Projection Mode";
      // 
      // mDSToolStripMenuItem
      // 
      this.mDSToolStripMenuItem.Name = "mDSToolStripMenuItem";
      this.mDSToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
      this.mDSToolStripMenuItem.Text = "MDS";
      // 
      // lAMPToolStripMenuItem
      // 
      this.lAMPToolStripMenuItem.Name = "lAMPToolStripMenuItem";
      this.lAMPToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
      this.lAMPToolStripMenuItem.Text = "LAMP";
      // 
      // tkb_ninputpoints
      // 
      this.tkb_ninputpoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tkb_ninputpoints.BackColor = System.Drawing.SystemColors.Control;
      this.tkb_ninputpoints.Cursor = System.Windows.Forms.Cursors.SizeNS;
      this.tkb_ninputpoints.Location = new System.Drawing.Point(927, 76);
      this.tkb_ninputpoints.Maximum = 30000;
      this.tkb_ninputpoints.Minimum = 5;
      this.tkb_ninputpoints.Name = "tkb_ninputpoints";
      this.tkb_ninputpoints.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.tkb_ninputpoints.Size = new System.Drawing.Size(45, 551);
      this.tkb_ninputpoints.TabIndex = 17;
      this.tkb_ninputpoints.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.tkb_ninputpoints.Value = 5;
      this.tkb_ninputpoints.Scroll += new System.EventHandler(this.tkb_ninputpoints_Scroll);
      this.tkb_ninputpoints.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
      // 
      // txb_max_track_n_cases
      // 
      this.txb_max_track_n_cases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txb_max_track_n_cases.Location = new System.Drawing.Point(927, 50);
      this.txb_max_track_n_cases.Name = "txb_max_track_n_cases";
      this.txb_max_track_n_cases.Size = new System.Drawing.Size(45, 20);
      this.txb_max_track_n_cases.TabIndex = 19;
      // 
      // txb_min_track_n_cases
      // 
      this.txb_min_track_n_cases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.txb_min_track_n_cases.Location = new System.Drawing.Point(927, 633);
      this.txb_min_track_n_cases.Name = "txb_min_track_n_cases";
      this.txb_min_track_n_cases.Size = new System.Drawing.Size(45, 20);
      this.txb_min_track_n_cases.TabIndex = 20;
      this.txb_min_track_n_cases.Text = "0";
      this.txb_min_track_n_cases.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(930, 33);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(36, 13);
      this.label7.TabIndex = 21;
      this.label7.Text = "Cases";
      // 
      // tkb_lamp_progress
      // 
      this.tkb_lamp_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tkb_lamp_progress.BackColor = System.Drawing.SystemColors.Control;
      this.tkb_lamp_progress.Cursor = System.Windows.Forms.Cursors.SizeWE;
      this.tkb_lamp_progress.Enabled = false;
      this.tkb_lamp_progress.Location = new System.Drawing.Point(11, 608);
      this.tkb_lamp_progress.Minimum = 5;
      this.tkb_lamp_progress.Name = "tkb_lamp_progress";
      this.tkb_lamp_progress.Size = new System.Drawing.Size(659, 45);
      this.tkb_lamp_progress.TabIndex = 22;
      this.tkb_lamp_progress.Value = 5;
      // 
      // label8
      // 
      this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(288, 624);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(172, 13);
      this.label8.TabIndex = 23;
      this.label8.Text = "TODO: LAMP add point interaction";
      // 
      // updateMaxValuesUsingAllDataPointsToolStripMenuItem
      // 
      this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Name = "updateMaxValuesUsingAllDataPointsToolStripMenuItem";
      this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
      this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Text = "Update Max Values Using all DataPoints";
      this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Click += new System.EventHandler(this.updateMaxValuesUsingAllDataPointsToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 665);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.tkb_lamp_progress);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txb_min_track_n_cases);
      this.Controls.Add(this.txb_max_track_n_cases);
      this.Controls.Add(this.tkb_ninputpoints);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.tgl_vis_undefined_series);
      this.Controls.Add(this.tgl_vis_cancelled_series);
      this.Controls.Add(this.tgl_vis_denied_series);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.tgl_vis_peding_series);
      this.Controls.Add(this.loangoaltrackbar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numberofofferstrackbar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.requestamounttrackbar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.creditscoretrackbar);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.menuStrip1);
      this.MinimumSize = new System.Drawing.Size(620, 400);
      this.Name = "Form1";
      this.Text = "Property Projection Analysis";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tkb_ninputpoints)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tkb_lamp_progress)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button MDS;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.OpenFileDialog openCFGDialog;
    private System.Windows.Forms.CheckBox tgl_vis_peding_series;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox tgl_vis_denied_series;
    private System.Windows.Forms.CheckBox tgl_vis_cancelled_series;
    private System.Windows.Forms.CheckBox tgl_vis_undefined_series;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar requestamounttrackbar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar numberofofferstrackbar;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TrackBar loangoaltrackbar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TrackBar creditscoretrackbar;
    private System.Windows.Forms.ToolTip tooltiptrackbar;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportSelectedDataPointsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem usingOnlySelectedDataPointsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem projectionModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mDSToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lAMPToolStripMenuItem;
    private System.Windows.Forms.TrackBar tkb_ninputpoints;
    private System.Windows.Forms.TextBox txb_max_track_n_cases;
    private System.Windows.Forms.TextBox txb_min_track_n_cases;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TrackBar tkb_lamp_progress;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ToolStripMenuItem autoUpdateChartToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem updateMaxValuesUsingAllDataPointsToolStripMenuItem;
  }
}

