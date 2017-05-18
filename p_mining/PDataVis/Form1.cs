using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Windows.Input;

using CppWrapper;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClassCppToCS_CS
{
  public partial class Form1 : Form
  {
    public CppWrapper.CppMDSWrapper data_prov_wrapper;

    int param_number_of_cases = 250;
    bool auto_update_chart = true;

    // ith case -> ith point in a specific series
    Hashtable hst_cases_to_points = new Hashtable();

    Point mdown = Point.Empty;
    List<DataPoint> selectedPoints = new List<DataPoint>();
    Rectangle left_rectangle = Rectangle.Empty;

    Point r_mdown = Point.Empty;
    Rectangle right_rectangle = Rectangle.Empty;

    public Form1()
    {
      InitializeComponent();

      data_prov_wrapper = new CppWrapper.CppMDSWrapper();

      hst_cases_to_points = new Hashtable();

      txb_max_track_n_cases.Text = data_prov_wrapper.GetMaxCasesCount().ToString();
      tkb_ninputpoints.Maximum = data_prov_wrapper.GetMaxCasesCount();
      
      txb_min_track_n_cases.Text = "0";
      tkb_ninputpoints.Minimum = 0;

      tkb_ninputpoints.Value = param_number_of_cases;


      autoUpdateChartToolStripMenuItem.Checked = auto_update_chart;

      MDSProjectDataCasesToChart();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private Color GetPointColor (int idcolor)
    {
      if (idcolor == 0)
        return Color.Green;
      else if (idcolor == 1)
        return Color.Red;
      else if (idcolor == 2)
        return Color.Blue;
      
      return Color.Black;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      double norm_creditscore = (creditscoretrackbar.Value - creditscoretrackbar.Minimum) / (double)creditscoretrackbar.Maximum;
      data_prov_wrapper.SetCreditScoreCoeficientValue(norm_creditscore);
      tooltiptrackbar.SetToolTip(creditscoretrackbar, norm_creditscore.ToString());
    }

    private void trackBar1_Scroll_1(object sender, EventArgs e)
    {
      double norm_requestamount = (requestamounttrackbar.Value - requestamounttrackbar.Minimum) / (double)requestamounttrackbar.Maximum;
      data_prov_wrapper.SetRequestAmountCoeficientValue(norm_requestamount);
      tooltiptrackbar.SetToolTip(requestamounttrackbar, norm_requestamount.ToString());
    }

    private void numberofofferstrackbar_Scroll(object sender, EventArgs e)
    {
      double norm_numberofoffers = (numberofofferstrackbar.Value - numberofofferstrackbar.Minimum) / (double)numberofofferstrackbar.Maximum;
      data_prov_wrapper.SetNumberOfOffersCoeficientValue(norm_numberofoffers);
      tooltiptrackbar.SetToolTip(numberofofferstrackbar, norm_numberofoffers.ToString());
    }

    private void trackBar1_Scroll_2(object sender, EventArgs e)
    {
      double norm_loangoal = (loangoaltrackbar.Value - loangoaltrackbar.Minimum) / (double)loangoaltrackbar.Maximum;
      data_prov_wrapper.SetLoanGoalCoeficientValue(norm_loangoal);
      tooltiptrackbar.SetToolTip(loangoaltrackbar, norm_loangoal.ToString());
    }

    private void ParamsUpdateMouseUp (object sender, MouseEventArgs e)
    {
      if (auto_update_chart)
        MDSProjectDataCasesToChart();  
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void tgl_vis_undefined_series_CheckedChanged(object sender, EventArgs e)
    {
      chart1.Series[3].Enabled = tgl_vis_undefined_series.Checked;
    }

    private void tgl_vis_cancelled_series_CheckedChanged(object sender, EventArgs e)
    {
      chart1.Series[2].Enabled = tgl_vis_cancelled_series.Checked;
    }

    private void tgl_vis_denied_series_CheckedChanged(object sender, EventArgs e)
    {
      chart1.Series[1].Enabled = tgl_vis_denied_series.Checked;

    }

    private void tgl_vis_peding_series_CheckedChanged(object sender, EventArgs e)
    {
      chart1.Series[0].Enabled = tgl_vis_peding_series.Checked;
    }

    private void chart_Paint (object sender, PaintEventArgs e)
    {
      if (!left_rectangle.IsEmpty)
      {
        e.Graphics.DrawRectangle(Pens.DarkOrange, left_rectangle);
      }

      if (!right_rectangle.IsEmpty)
      {
        e.Graphics.DrawRectangle(Pens.Purple, right_rectangle);
      }
    }

    //http://stackoverflow.com/questions/40056264/selecting-specific-values-on-a-chart
    //////////////////////////////////////////////////////////////////////////////////
    private void chart_MouseDown (object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        mdown = e.Location;
        left_rectangle = Rectangle.Empty;
        if (!ModifierKeys.HasFlag(Keys.Control))
        {
          selectedPoints.Clear();
          // Set default marker color to all Data Points
          // for each series
          for (int ith_series = 0; ith_series < chart1.Series.Count; ith_series++)
            // for each point in the ith series
            foreach (DataPoint dp in chart1.Series[ith_series].Points)
              dp.MarkerColor = GetPointColor(GetCaseEndInfo(dp));
        }
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        r_mdown = e.Location;
        right_rectangle = Rectangle.Empty;
      }

      chart1.Refresh();
    }

    private void chart_MouseMove (object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        left_rectangle = GetRectangle(mdown, e.Location);
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        right_rectangle = GetRectangle(r_mdown, e.Location);
      }

      chart1.Refresh();
    }

    private void chart_MouseUp (object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        Axis ax = chart1.ChartAreas[0].AxisX;
        Axis ay = chart1.ChartAreas[0].AxisY;
        left_rectangle = GetRectangle(mdown, e.Location);

        for (int ith_series = 0; ith_series < chart1.Series.Count; ith_series++)
        {
          // select only if the series is enabled
          if (chart1.Series[ith_series].Enabled)
          {
            foreach (DataPoint dp in chart1.Series[ith_series].Points)
            {
              int x = (int)ax.ValueToPixelPosition(dp.XValue);
              int y = (int)ay.ValueToPixelPosition(dp.YValues[0]);

              if (left_rectangle.Contains(new Point(x, y)))
              {
                // CTRL + ALT: Remove point
                if (ModifierKeys.HasFlag(Keys.Control) && ModifierKeys.HasFlag(Keys.Alt))
                {
                  if (selectedPoints.Contains(dp)) selectedPoints.Remove(dp);
                }
                // Else: Add Point
                else
                { 
                  if (!selectedPoints.Contains(dp)) selectedPoints.Add(dp);
                }
              }
            }

            // set color to enabled datapoints:
            foreach (DataPoint dp in chart1.Series[ith_series].Points)
            {
              dp.MarkerColor = selectedPoints.Contains(dp) ? Color.DarkOrange : GetPointColor(GetCaseEndInfo(dp));
            }
          }
        }
        left_rectangle = Rectangle.Empty;
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
      }

      chart1.Refresh();
    }
    
    static public int GetDataPointID (DataPoint dp)
    {
      return int.Parse(dp.Tag.ToString()) - 1;
    }

    static public Rectangle GetRectangle(Point p1, Point p2)
    {
      return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
          Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
    }
    public int GetCaseEndInfo (DataPoint dp)
    {
      return data_prov_wrapper.GetCaseEndInfo(GetDataPointID(dp));
    }
    //////////////////////////////////////////////////////////////////////////////////

    private void button1_Click(object sender, EventArgs e)
    {
      MDSProjectDataCasesToChart();
    }

    private void exportSelectedDataPointsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void usingOnlySelectedDataPointsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (selectedPoints != null && selectedPoints.Count > 0)
      {
        SaveFileDialog save_file_datapoints = new SaveFileDialog();
        save_file_datapoints.Filter = "csv files (*.csv)|*.csv";
        save_file_datapoints.RestoreDirectory = true;

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        if (save_file_datapoints.ShowDialog() == DialogResult.OK)
        {
          int[] cases_ids = new int[selectedPoints.Count];

          for (int i = 0; i < selectedPoints.Count; i++)
            cases_ids[i] = int.Parse(selectedPoints[i].Tag.ToString());

          Array.Sort(cases_ids);

          for (int i = 0; i < cases_ids.Length; i++)
            dictionary.Add(data_prov_wrapper.GetCaseName(cases_ids[i] - 1), 1);

          try
          {
            System.IO.StreamWriter file = new System.IO.StreamWriter(save_file_datapoints.FileName);

            // TODO: diferent sources?
            var lines = File.ReadAllLines("../../data/app_log_cap.csv");
            // Write Header!
            file.WriteLine(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
              // Get CaseName!
              string casename_line = lines[i].Substring(0, lines[i].IndexOf(';'));

              // TODO: otimize this!
              if (dictionary.ContainsKey(casename_line))
                file.WriteLine(lines[i]);
            }
            file.Close();
          }
          catch
          {
            Console.Out.WriteLine("Exception thrown while trying to export a csv file");
          }
        }
      }
    }

    private void tkb_ninputpoints_Scroll(object sender, EventArgs e)
    {
      double npoints = tkb_ninputpoints.Value;
      //data_prov_wrapper.SetLoanGoalCoeficientValue(npoints);
      tooltiptrackbar.SetToolTip(tkb_ninputpoints, npoints.ToString());
      param_number_of_cases = (int)npoints;
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void MDSProjectDataCasesToChart ()
    {
      double[,] arrayMDS = data_prov_wrapper.DataProviderMDS(param_number_of_cases);

      Chart chart = chart1;
      for (int v = 0; v < chart.Series.Count; v++)
        chart.Series[v].Points.Clear();

      chart.Series[0].Enabled = tgl_vis_peding_series.Checked;
      chart.Series[1].Enabled = tgl_vis_denied_series.Checked;
      chart.Series[2].Enabled = tgl_vis_cancelled_series.Checked;
      chart.Series[3].Enabled = tgl_vis_undefined_series.Checked;

      hst_cases_to_points.Clear();

      double[] min_max_axis_limits = new Double[4];
      min_max_axis_limits[0] = Double.MaxValue;
      min_max_axis_limits[1] = Double.MinValue;
      min_max_axis_limits[2] = Double.MaxValue;
      min_max_axis_limits[3] = Double.MinValue;

      double expand_limtis = 1.2;

      for (int i = 0; i < data_prov_wrapper.GetNumberOfCases(); i++)
      {
        double mm_x = arrayMDS[i, 0]; //Math.Round(arrayMDS[i, 0], 5);
        double mm_y = arrayMDS[i, 1]; //Math.Round(arrayMDS[i, 1], 5);

        //Console.Out.WriteLine(i + " [" + mm_x + ", " + mm_y + "]");

        int series_id = data_prov_wrapper.GetCaseEndInfo(i);

        hst_cases_to_points.Add(i.ToString(), chart.Series[series_id].Points.Count);
        int id_point = chart.Series[series_id].Points.Count;

        chart.Series[series_id].Points.AddXY(mm_x, mm_y);
        chart.Series[series_id].Points[id_point].LegendToolTip = "loadedpoint";
        chart.Series[series_id].Points[id_point].Tag = (i + 1).ToString();
        chart.Series[series_id].Points[id_point].ToolTip = data_prov_wrapper.GetCaseDataInfo(i);

        min_max_axis_limits[0] = Math.Min(min_max_axis_limits[0], mm_x);
        min_max_axis_limits[1] = Math.Max(min_max_axis_limits[1], mm_x);

        min_max_axis_limits[2] = Math.Min(min_max_axis_limits[2], mm_y);
        min_max_axis_limits[3] = Math.Max(min_max_axis_limits[3], mm_y);
      }

      chart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.00}";
      chart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.00}";

      min_max_axis_limits[0] *= expand_limtis;
      min_max_axis_limits[1] *= expand_limtis;

      min_max_axis_limits[2] *= expand_limtis;
      min_max_axis_limits[3] *= expand_limtis;

      chart.ChartAreas[0].AxisX.Minimum = min_max_axis_limits[0];
      chart.ChartAreas[0].AxisX.Maximum = min_max_axis_limits[1];

      chart.ChartAreas[0].AxisY.Minimum = min_max_axis_limits[2];
      chart.ChartAreas[0].AxisY.Maximum = min_max_axis_limits[3];

      //Update selectedPoints
      ///////////////////////////////////////////////////////
      if (selectedPoints.Count > 0)
      {
        DataPoint[] cpy_selectedPoints = new DataPoint[selectedPoints.Count];
        selectedPoints.CopyTo(cpy_selectedPoints);
        selectedPoints.Clear();

        for (int v = 0; v < cpy_selectedPoints.Length; v++)
        {
          DataPoint dp = cpy_selectedPoints[v];

          // Get Global Point ID
          // [1, size] to [0, size-1]
          int point_id = int.Parse(dp.Tag.ToString()) - 1;

          // Get Series ID
          int series_id = data_prov_wrapper.GetCaseEndInfo(point_id);

          // Add DataPoint using hashtable
          int hash_point_series_id = (int)hst_cases_to_points[point_id.ToString()];
          selectedPoints.Add(chart.Series[series_id].Points[hash_point_series_id]);
        }

        // Update Marker Colors
        for (int ith_series = 0; ith_series < chart1.Series.Count; ith_series++)
        {
          foreach (DataPoint dp in chart1.Series[ith_series].Points)
          {
            dp.MarkerColor = selectedPoints.Contains(dp) ? Color.DarkOrange : GetPointColor(GetCaseEndInfo(dp));
          }
        }
      }
      ///////////////////////////////////////////////////////
    }

    private void autoUpdateChartToolStripMenuItem_Click(object sender, EventArgs e)
    {
      autoUpdateChartToolStripMenuItem.Checked = !autoUpdateChartToolStripMenuItem.Checked;
      auto_update_chart = autoUpdateChartToolStripMenuItem.Checked;
    }
  };
}
