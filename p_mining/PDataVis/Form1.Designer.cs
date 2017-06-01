namespace ClassCppToCS_CS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openCFGDialog = new System.Windows.Forms.OpenFileDialog();
            this.tgl_vis_peding_series = new System.Windows.Forms.CheckBox();
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
            this.tooltiptrackbar = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingOnlySelectedDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMaxValuesUsingAllDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LAMPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tkb_ninputpoints = new System.Windows.Forms.TrackBar();
            this.txb_max_track_n_cases = new System.Windows.Forms.TextBox();
            this.txb_min_track_n_cases = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tkb_lamp_progress = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_ninputpoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_lamp_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tgl_vis_peding_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tgl_vis_peding_series.AutoSize = true;
            this.tgl_vis_peding_series.Checked = true;
            this.tgl_vis_peding_series.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_vis_peding_series.Location = new System.Drawing.Point(3, 3);
            this.tgl_vis_peding_series.Name = "tgl_vis_peding_series";
            this.tgl_vis_peding_series.Size = new System.Drawing.Size(78, 17);
            this.tgl_vis_peding_series.TabIndex = 9;
            this.tgl_vis_peding_series.Text = "A_Pending";
            this.tgl_vis_peding_series.UseVisualStyleBackColor = true;
            this.tgl_vis_peding_series.CheckedChanged += new System.EventHandler(this.tgl_vis_peding_series_CheckedChanged);
            // 
            // tgl_vis_denied_series
            // 
            this.tgl_vis_denied_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tgl_vis_denied_series.AutoSize = true;
            this.tgl_vis_denied_series.Checked = true;
            this.tgl_vis_denied_series.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_vis_denied_series.Location = new System.Drawing.Point(87, 3);
            this.tgl_vis_denied_series.Name = "tgl_vis_denied_series";
            this.tgl_vis_denied_series.Size = new System.Drawing.Size(73, 17);
            this.tgl_vis_denied_series.TabIndex = 11;
            this.tgl_vis_denied_series.Text = "A_Denied";
            this.tgl_vis_denied_series.UseVisualStyleBackColor = true;
            this.tgl_vis_denied_series.CheckedChanged += new System.EventHandler(this.tgl_vis_denied_series_CheckedChanged);
            // 
            // tgl_vis_cancelled_series
            // 
            this.tgl_vis_cancelled_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tgl_vis_cancelled_series.AutoSize = true;
            this.tgl_vis_cancelled_series.Checked = true;
            this.tgl_vis_cancelled_series.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_vis_cancelled_series.Location = new System.Drawing.Point(166, 3);
            this.tgl_vis_cancelled_series.Name = "tgl_vis_cancelled_series";
            this.tgl_vis_cancelled_series.Size = new System.Drawing.Size(86, 17);
            this.tgl_vis_cancelled_series.TabIndex = 12;
            this.tgl_vis_cancelled_series.Text = "A_Cancelled";
            this.tgl_vis_cancelled_series.UseVisualStyleBackColor = true;
            this.tgl_vis_cancelled_series.CheckedChanged += new System.EventHandler(this.tgl_vis_cancelled_series_CheckedChanged);
            // 
            // tgl_vis_undefined_series
            // 
            this.tgl_vis_undefined_series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tgl_vis_undefined_series.AutoSize = true;
            this.tgl_vis_undefined_series.Checked = true;
            this.tgl_vis_undefined_series.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_vis_undefined_series.Location = new System.Drawing.Point(258, 3);
            this.tgl_vis_undefined_series.Name = "tgl_vis_undefined_series";
            this.tgl_vis_undefined_series.Size = new System.Drawing.Size(75, 17);
            this.tgl_vis_undefined_series.TabIndex = 13;
            this.tgl_vis_undefined_series.Text = "Undefined";
            this.tgl_vis_undefined_series.UseVisualStyleBackColor = true;
            this.tgl_vis_undefined_series.CheckedChanged += new System.EventHandler(this.tgl_vis_undefined_series_CheckedChanged);
            // 
            // creditscoretrackbar
            // 
            this.creditscoretrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditscoretrackbar.Location = new System.Drawing.Point(3, 21);
            this.creditscoretrackbar.Name = "creditscoretrackbar";
            this.creditscoretrackbar.Size = new System.Drawing.Size(223, 45);
            this.creditscoretrackbar.TabIndex = 1;
            this.creditscoretrackbar.Value = 10;
            this.creditscoretrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.creditscoretrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RequestAmount";
            // 
            // requestamounttrackbar
            // 
            this.requestamounttrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestamounttrackbar.Location = new System.Drawing.Point(3, 85);
            this.requestamounttrackbar.Name = "requestamounttrackbar";
            this.requestamounttrackbar.Size = new System.Drawing.Size(223, 45);
            this.requestamounttrackbar.TabIndex = 4;
            this.requestamounttrackbar.Value = 10;
            this.requestamounttrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            this.requestamounttrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NumberOfOffers";
            // 
            // numberofofferstrackbar
            // 
            this.numberofofferstrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberofofferstrackbar.Location = new System.Drawing.Point(3, 149);
            this.numberofofferstrackbar.Name = "numberofofferstrackbar";
            this.numberofofferstrackbar.Size = new System.Drawing.Size(223, 45);
            this.numberofofferstrackbar.TabIndex = 6;
            this.numberofofferstrackbar.Value = 10;
            this.numberofofferstrackbar.Scroll += new System.EventHandler(this.numberofofferstrackbar_Scroll);
            this.numberofofferstrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LoanGoal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loangoaltrackbar
            // 
            this.loangoaltrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loangoaltrackbar.Location = new System.Drawing.Point(3, 213);
            this.loangoaltrackbar.Name = "loangoaltrackbar";
            this.loangoaltrackbar.Size = new System.Drawing.Size(223, 45);
            this.loangoaltrackbar.TabIndex = 8;
            this.loangoaltrackbar.Value = 10;
            this.loangoaltrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_2);
            this.loangoaltrackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
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
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(11, 93);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Legend1";
            series11.MarkerColor = System.Drawing.Color.Green;
            series11.MarkerSize = 11;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series11.Name = "A_Pending";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.MarkerColor = System.Drawing.Color.Red;
            series12.MarkerSize = 10;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series12.Name = "A_Denied";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series13.Legend = "Legend1";
            series13.MarkerColor = System.Drawing.Color.Blue;
            series13.MarkerSize = 8;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series13.Name = "A_Cancelled";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Legend = "Legend1";
            series14.MarkerColor = System.Drawing.Color.Black;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series14.Name = "Undefined";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Enabled = false;
            series15.Legend = "Legend1";
            series15.Name = "ControlPoints";
            series15.YValuesPerPoint = 2;
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(770, 424);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.chart_Paint);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
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
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
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
            this.autoUpdateChartToolStripMenuItem.Name = "autoUpdateChartToolStripMenuItem";
            this.autoUpdateChartToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.autoUpdateChartToolStripMenuItem.Text = "Auto Update Chart";
            this.autoUpdateChartToolStripMenuItem.Click += new System.EventHandler(this.autoUpdateChartToolStripMenuItem_Click);
            // 
            // updateMaxValuesUsingAllDataPointsToolStripMenuItem
            // 
            this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Name = "updateMaxValuesUsingAllDataPointsToolStripMenuItem";
            this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Text = "Update Max Values Using all DataPoints";
            this.updateMaxValuesUsingAllDataPointsToolStripMenuItem.Click += new System.EventHandler(this.updateMaxValuesUsingAllDataPointsToolStripMenuItem_Click);
            // 
            // projectionModeToolStripMenuItem
            // 
            this.projectionModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MDSMenuItem,
            this.LAMPMenuItem});
            this.projectionModeToolStripMenuItem.Name = "projectionModeToolStripMenuItem";
            this.projectionModeToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.projectionModeToolStripMenuItem.Text = "Projection Mode";
            // 
            // MDSMenuItem
            // 
            this.MDSMenuItem.Name = "MDSMenuItem";
            this.MDSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.MDSMenuItem.Text = "MDS";
            this.MDSMenuItem.Click += new System.EventHandler(this.MDSMenuItem_Click);
            // 
            // LAMPMenuItem
            // 
            this.LAMPMenuItem.Name = "LAMPMenuItem";
            this.LAMPMenuItem.Size = new System.Drawing.Size(106, 22);
            this.LAMPMenuItem.Text = "LAMP";
            this.LAMPMenuItem.Click += new System.EventHandler(this.LAMPMenuItem_Click);
            // 
            // tkb_ninputpoints
            // 
            this.tkb_ninputpoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkb_ninputpoints.BackColor = System.Drawing.SystemColors.Control;
            this.tkb_ninputpoints.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.tkb_ninputpoints.Location = new System.Drawing.Point(1038, 76);
            this.tkb_ninputpoints.Maximum = 30000;
            this.tkb_ninputpoints.Minimum = 5;
            this.tkb_ninputpoints.Name = "tkb_ninputpoints";
            this.tkb_ninputpoints.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_ninputpoints.Size = new System.Drawing.Size(45, 466);
            this.tkb_ninputpoints.TabIndex = 17;
            this.tkb_ninputpoints.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkb_ninputpoints.Value = 5;
            this.tkb_ninputpoints.Scroll += new System.EventHandler(this.tkb_ninputpoints_Scroll);
            this.tkb_ninputpoints.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParamsUpdateMouseUp);
            // 
            // txb_max_track_n_cases
            // 
            this.txb_max_track_n_cases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_max_track_n_cases.Location = new System.Drawing.Point(1038, 50);
            this.txb_max_track_n_cases.Name = "txb_max_track_n_cases";
            this.txb_max_track_n_cases.Size = new System.Drawing.Size(45, 20);
            this.txb_max_track_n_cases.TabIndex = 19;
            // 
            // txb_min_track_n_cases
            // 
            this.txb_min_track_n_cases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_min_track_n_cases.Location = new System.Drawing.Point(1038, 548);
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
            this.label7.Location = new System.Drawing.Point(1041, 33);
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
            this.tkb_lamp_progress.Location = new System.Drawing.Point(11, 523);
            this.tkb_lamp_progress.Minimum = 5;
            this.tkb_lamp_progress.Name = "tkb_lamp_progress";
            this.tkb_lamp_progress.Size = new System.Drawing.Size(770, 45);
            this.tkb_lamp_progress.TabIndex = 22;
            this.tkb_lamp_progress.Value = 5;
            this.tkb_lamp_progress.Scroll += new System.EventHandler(this.tkb_lamp_progress_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(3, 277);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_3);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Levenshtein Distance";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(3, 341);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(223, 45);
            this.trackBar2.TabIndex = 27;
            this.trackBar2.Value = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Jaccard Distance";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Levenshtein Distance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(790, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 541);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weights for each field";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.loangoaltrackbar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numberofofferstrackbar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.requestamounttrackbar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.creditscoretrackbar);
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 515);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(11, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 60);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visible Series";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tgl_vis_peding_series);
            this.panel2.Controls.Add(this.tgl_vis_denied_series);
            this.panel2.Controls.Add(this.tgl_vis_cancelled_series);
            this.panel2.Controls.Add(this.tgl_vis_undefined_series);
            this.panel2.Location = new System.Drawing.Point(7, 16);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(757, 38);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Jaccard Distance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tkb_lamp_progress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_min_track_n_cases);
            this.Controls.Add(this.txb_max_track_n_cases);
            this.Controls.Add(this.tkb_ninputpoints);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button MDS;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.OpenFileDialog openCFGDialog;
    private System.Windows.Forms.CheckBox tgl_vis_peding_series;
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
    private System.Windows.Forms.TrackBar creditscoretrackbar;
    private System.Windows.Forms.ToolTip tooltiptrackbar;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportSelectedDataPointsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem usingOnlySelectedDataPointsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem projectionModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MDSMenuItem;
    private System.Windows.Forms.ToolStripMenuItem LAMPMenuItem;
    private System.Windows.Forms.TrackBar tkb_ninputpoints;
    private System.Windows.Forms.TextBox txb_max_track_n_cases;
    private System.Windows.Forms.TextBox txb_min_track_n_cases;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TrackBar tkb_lamp_progress;
    private System.Windows.Forms.ToolStripMenuItem autoUpdateChartToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem updateMaxValuesUsingAllDataPointsToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
    }
}

