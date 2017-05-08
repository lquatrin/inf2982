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
      System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
      ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
      this.tgl_vis_peding_series.Location = new System.Drawing.Point(12, 25);
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
      this.label5.Location = new System.Drawing.Point(12, 9);
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
      this.tgl_vis_denied_series.Location = new System.Drawing.Point(96, 25);
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
      this.tgl_vis_cancelled_series.Location = new System.Drawing.Point(175, 25);
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
      this.tgl_vis_undefined_series.Location = new System.Drawing.Point(267, 25);
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
      this.creditscoretrackbar.Location = new System.Drawing.Point(816, 48);
      this.creditscoretrackbar.Name = "creditscoretrackbar";
      this.creditscoretrackbar.Size = new System.Drawing.Size(156, 45);
      this.creditscoretrackbar.TabIndex = 1;
      this.creditscoretrackbar.Value = 10;
      this.creditscoretrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(727, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "RequestAmount";
      // 
      // requestamounttrackbar
      // 
      this.requestamounttrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.requestamounttrackbar.Location = new System.Drawing.Point(816, 99);
      this.requestamounttrackbar.Name = "requestamounttrackbar";
      this.requestamounttrackbar.Size = new System.Drawing.Size(156, 45);
      this.requestamounttrackbar.TabIndex = 4;
      this.requestamounttrackbar.Value = 10;
      this.requestamounttrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(727, 150);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "NumberOfOffers";
      // 
      // numberofofferstrackbar
      // 
      this.numberofofferstrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numberofofferstrackbar.Location = new System.Drawing.Point(816, 150);
      this.numberofofferstrackbar.Name = "numberofofferstrackbar";
      this.numberofofferstrackbar.Size = new System.Drawing.Size(156, 45);
      this.numberofofferstrackbar.TabIndex = 6;
      this.numberofofferstrackbar.Value = 10;
      this.numberofofferstrackbar.Scroll += new System.EventHandler(this.numberofofferstrackbar_Scroll);
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(727, 201);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "LoanGoal";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // loangoaltrackbar
      // 
      this.loangoaltrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.loangoaltrackbar.Location = new System.Drawing.Point(816, 201);
      this.loangoaltrackbar.Name = "loangoaltrackbar";
      this.loangoaltrackbar.Size = new System.Drawing.Size(156, 45);
      this.loangoaltrackbar.TabIndex = 8;
      this.loangoaltrackbar.Value = 10;
      this.loangoaltrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_2);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(727, 48);
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
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
      legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend3.Name = "Legend1";
      this.chart1.Legends.Add(legend3);
      this.chart1.Location = new System.Drawing.Point(12, 48);
      this.chart1.Name = "chart1";
      series9.ChartArea = "ChartArea1";
      series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series9.Legend = "Legend1";
      series9.MarkerColor = System.Drawing.Color.Green;
      series9.MarkerSize = 11;
      series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
      series9.Name = "A_Pending";
      series10.ChartArea = "ChartArea1";
      series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series10.Legend = "Legend1";
      series10.MarkerColor = System.Drawing.Color.Red;
      series10.MarkerSize = 10;
      series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
      series10.Name = "A_Denied";
      series11.ChartArea = "ChartArea1";
      series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series11.Legend = "Legend1";
      series11.MarkerColor = System.Drawing.Color.Blue;
      series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series11.Name = "A_Cancelled";
      series12.ChartArea = "ChartArea1";
      series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series12.Legend = "Legend1";
      series12.MarkerColor = System.Drawing.Color.Black;
      series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
      series12.Name = "Undefined";
      this.chart1.Series.Add(series9);
      this.chart1.Series.Add(series10);
      this.chart1.Series.Add(series11);
      this.chart1.Series.Add(series12);
      this.chart1.Size = new System.Drawing.Size(709, 502);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(727, 9);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(110, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Weights for each field";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 562);
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
      this.MinimumSize = new System.Drawing.Size(620, 300);
      this.Name = "Form1";
      this.Text = "Property Projection Analysis";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
  }
}

