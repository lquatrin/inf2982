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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.openCFGDialog = new System.Windows.Forms.OpenFileDialog();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.creditscoretrackbar = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.requestamounttrackbar = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.numberofofferstrackbar = new System.Windows.Forms.TrackBar();
      this.loangoaltrackbar = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).BeginInit();
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
      // chart1
      // 
      this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart1.Legends.Add(legend3);
      this.chart1.Location = new System.Drawing.Point(12, 12);
      this.chart1.Name = "chart1";
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      series3.IsVisibleInLegend = false;
      this.chart1.Series.Add(series3);
      this.chart1.Size = new System.Drawing.Size(579, 353);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // creditscoretrackbar
      // 
      this.creditscoretrackbar.Location = new System.Drawing.Point(686, 17);
      this.creditscoretrackbar.Name = "creditscoretrackbar";
      this.creditscoretrackbar.Size = new System.Drawing.Size(232, 45);
      this.creditscoretrackbar.TabIndex = 1;
      this.creditscoretrackbar.Value = 10;
      this.creditscoretrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(597, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "CreditScore";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(597, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "RequestAmount";
      // 
      // requestamounttrackbar
      // 
      this.requestamounttrackbar.Location = new System.Drawing.Point(686, 68);
      this.requestamounttrackbar.Name = "requestamounttrackbar";
      this.requestamounttrackbar.Size = new System.Drawing.Size(232, 45);
      this.requestamounttrackbar.TabIndex = 4;
      this.requestamounttrackbar.Value = 10;
      this.requestamounttrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(597, 122);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "NumberOfOffers";
      // 
      // numberofofferstrackbar
      // 
      this.numberofofferstrackbar.Location = new System.Drawing.Point(686, 118);
      this.numberofofferstrackbar.Name = "numberofofferstrackbar";
      this.numberofofferstrackbar.Size = new System.Drawing.Size(232, 45);
      this.numberofofferstrackbar.TabIndex = 6;
      this.numberofofferstrackbar.Value = 10;
      this.numberofofferstrackbar.Scroll += new System.EventHandler(this.numberofofferstrackbar_Scroll);
      // 
      // loangoaltrackbar
      // 
      this.loangoaltrackbar.Location = new System.Drawing.Point(686, 169);
      this.loangoaltrackbar.Name = "loangoaltrackbar";
      this.loangoaltrackbar.Size = new System.Drawing.Size(232, 45);
      this.loangoaltrackbar.TabIndex = 8;
      this.loangoaltrackbar.Value = 10;
      this.loangoaltrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll_2);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(597, 173);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "LoanGoal";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(933, 374);
      this.Controls.Add(this.loangoaltrackbar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numberofofferstrackbar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.requestamounttrackbar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.creditscoretrackbar);
      this.Controls.Add(this.chart1);
      this.Name = "Form1";
      this.Text = "Property Projection Analysis";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.creditscoretrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requestamounttrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numberofofferstrackbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loangoaltrackbar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button MDS;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.OpenFileDialog openCFGDialog;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.TrackBar creditscoretrackbar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar requestamounttrackbar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar numberofofferstrackbar;
    private System.Windows.Forms.TrackBar loangoaltrackbar;
    private System.Windows.Forms.Label label4;
  }
}

