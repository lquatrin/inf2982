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
    public CppWrapper.CppDataProjProviderWrapper data_prov_wrapper;

    public enum ProjectionMode
    {
      MDS = 0,
      LAMP = 1,
    }
    ProjectionMode project_mode = ProjectionMode.MDS;
    int CONTROL_POINT_SERIES = 4;

    int lamp_n_variants = 100;
    int[] lamp_control_points_id;
    int lamp_projected_points = 0;
    double[] lamp_min_max_axis_limits;

    int axis_number_of_intervals = 8;
    int param_number_of_cases = 250;
    bool auto_update_chart = false;

    // ith case -> ith point in a specific series
    Hashtable hst_cases_to_points = new Hashtable();

    Point mdown = Point.Empty;
    List<DataPoint> selectedPoints = new List<DataPoint>();
    Rectangle left_rectangle = Rectangle.Empty;

    Point r_mdown = Point.Empty;
    Rectangle right_rectangle = Rectangle.Empty;

    Point cp_r_mdown = Point.Empty;
    DataPoint cp_point_ref = null;
    double ref_max_dist_hit = 0.1;

    public Form1()
    {
      InitializeComponent();

      data_prov_wrapper = new CppWrapper.CppDataProjProviderWrapper();

      hst_cases_to_points = new Hashtable();

      txb_max_track_n_cases.Text = data_prov_wrapper.GetMaxCasesCount().ToString();
      tkb_ninputpoints.Maximum = data_prov_wrapper.GetMaxCasesCount();
      
      txb_min_track_n_cases.Text = "0";
      tkb_ninputpoints.Minimum = 0;
      data_prov_wrapper.SetNumberOfCases(param_number_of_cases);
      data_prov_wrapper.UpdateMaxValuesUsingAllDataPoints(updateMaxValuesUsingAllDataPointsToolStripMenuItem.Checked);

      // Set Menu Item Auto Update Chart
      autoUpdateChartToolStripMenuItem.Checked = auto_update_chart;

      // Set Number of Projected Cases
      if (project_mode == ProjectionMode.MDS)
        tkb_ninputpoints.Value = param_number_of_cases;
      else if (project_mode == ProjectionMode.LAMP)
        tkb_ninputpoints.Value = lamp_projected_points;


      chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
      chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

      UpdateInterfaceElements();

      UpdateCurrentChartProjection();
    }

    private void UpdateInterfaceElements ()
    {
      MDSMenuItem.Checked = project_mode == ProjectionMode.MDS;
      LAMPMenuItem.Checked = project_mode == ProjectionMode.LAMP;
      tkb_ninputpoints.Enabled = project_mode == ProjectionMode.MDS || project_mode == ProjectionMode.LAMP;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private MarkerStyle GetPointMarkerStyle (int id_end_sit)
    {
      if (id_end_sit == 0)
        return MarkerStyle.Star5;
      else if (id_end_sit == 1)
        return MarkerStyle.Cross;
      else if (id_end_sit == 2)
        return MarkerStyle.Diamond;

      return MarkerStyle.Square;

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
        UpdateCurrentChartProjection();  
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
          {
            if (ith_series == CONTROL_POINT_SERIES) continue;

            // for each point in the ith series
            foreach (DataPoint dp in chart1.Series[ith_series].Points)
              dp.MarkerColor = GetPointColor(GetCaseEndInfo(dp));
          }
        }
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
      {
        r_mdown = e.Location;
        right_rectangle = Rectangle.Empty;
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        cp_point_ref = null;

        cp_r_mdown = e.Location;

        double x = chart1.ChartAreas[0].AxisX.PixelPositionToValue(cp_r_mdown.X);
        double y = chart1.ChartAreas[0].AxisY.PixelPositionToValue(cp_r_mdown.Y);

        double min_dist = double.MaxValue;
        foreach (DataPoint dp in chart1.Series[CONTROL_POINT_SERIES].Points)
        {
          double px = dp.XValue;
          double py = dp.YValues[0];
          
          double distance_p = Math.Sqrt(Math.Pow(x - px, 2.0) + Math.Pow(y - py, 2.0));

          if (distance_p < ref_max_dist_hit && distance_p < min_dist)
          {
            
            min_dist = distance_p;
            cp_point_ref = dp;
          }
        }
      }

      chart1.Refresh();
    }

    private void chart_MouseMove (object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        left_rectangle = GetRectangle(mdown, e.Location);
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
      {
        right_rectangle = GetRectangle(r_mdown, e.Location);
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        if (cp_point_ref != null)
        {
          double x = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
          double y = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y);

          cp_point_ref.XValue = x;
          cp_point_ref.YValues[0] = y;
        }
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
          if (ith_series == CONTROL_POINT_SERIES) continue;

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
      else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
      {
      }
      else if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        cp_r_mdown = Point.Empty;
        cp_point_ref = null;
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
      UpdateCurrentChartProjection();
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

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void MDSProjectDataCasesToChart ()
    {
      double[,] arrayMDS = data_prov_wrapper.DataProviderMDS();

      Chart chart = chart1;
      for (int v = 0; v < chart.Series.Count; v++)
        chart.Series[v].Points.Clear();

      chart.Series[0].Enabled = tgl_vis_peding_series.Checked;
      chart.Series[1].Enabled = tgl_vis_denied_series.Checked;
      chart.Series[2].Enabled = tgl_vis_cancelled_series.Checked;
      chart.Series[3].Enabled = tgl_vis_undefined_series.Checked;
      chart.Series[CONTROL_POINT_SERIES].Enabled = false;

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

      chart.ChartAreas[0].AxisX.Interval = (min_max_axis_limits[1] - min_max_axis_limits[0]) / (double)axis_number_of_intervals;
      chart.ChartAreas[0].AxisY.Interval = (min_max_axis_limits[3] - min_max_axis_limits[2]) / (double)axis_number_of_intervals;
      
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

    private void UpdateCurrentChartProjection ()
    {
      UpdateInterfaceElements();
      if(project_mode == ProjectionMode.MDS)
        MDSProjectDataCasesToChart();
      else if (project_mode == ProjectionMode.LAMP)
        LAMPProjectDataCasesToChart();
    }

    private void autoUpdateChartToolStripMenuItem_Click(object sender, EventArgs e)
    {
      autoUpdateChartToolStripMenuItem.Checked = !autoUpdateChartToolStripMenuItem.Checked;
      auto_update_chart = autoUpdateChartToolStripMenuItem.Checked;
    }

    private void updateMaxValuesUsingAllDataPointsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      updateMaxValuesUsingAllDataPointsToolStripMenuItem.Checked = !updateMaxValuesUsingAllDataPointsToolStripMenuItem.Checked;
    
      data_prov_wrapper.UpdateMaxValuesUsingAllDataPoints(updateMaxValuesUsingAllDataPointsToolStripMenuItem.Checked);
    
      UpdateCurrentChartProjection();
    }

    private void LAMPProjectDataCasesToChart()
    {
      //Console.Out.WriteLine("LAMPProjectDataCasesToChart");
      //EVALUATE MDS FOR THE FIRST N VARIANTS TO BE SET AS CONTROL POINTS
      lamp_control_points_id = data_prov_wrapper.FirstNVariants(lamp_n_variants);
      double[,] arrayMDSCP = data_prov_wrapper.DataProviderMDSCP(lamp_control_points_id, lamp_n_variants);

      Chart chart = chart1;
      for (int v = 0; v < chart.Series.Count; v++)
        chart.Series[v].Points.Clear();

      chart.Series[0].Enabled = tgl_vis_peding_series.Checked;
      chart.Series[1].Enabled = tgl_vis_denied_series.Checked;
      chart.Series[2].Enabled = tgl_vis_cancelled_series.Checked;
      chart.Series[3].Enabled = tgl_vis_undefined_series.Checked;
      chart.Series[CONTROL_POINT_SERIES].Enabled = true;

      lamp_projected_points = 0;
      tkb_ninputpoints.Value = lamp_projected_points;

      hst_cases_to_points.Clear();

      lamp_min_max_axis_limits = new Double[4];
      lamp_min_max_axis_limits[0] = Double.MaxValue;
      lamp_min_max_axis_limits[1] = Double.MinValue;
      lamp_min_max_axis_limits[2] = Double.MaxValue;
      lamp_min_max_axis_limits[3] = Double.MinValue;

      double expand_limtis = 1.2;

      //Adding static controlPoints
      for (int i = 0; i < lamp_n_variants; i++)
      {
        if (lamp_control_points_id[i] == -1) continue;
        
        double mm_x = arrayMDSCP[i, 0];
        double mm_y = arrayMDSCP[i, 1];

        chart.Series[CONTROL_POINT_SERIES].Points.AddXY(mm_x, mm_y);
        chart.Series[CONTROL_POINT_SERIES].Points[i].LegendToolTip = "controlpoint";
        chart.Series[CONTROL_POINT_SERIES].Points[i].Tag = (i + 1).ToString();
        chart.Series[CONTROL_POINT_SERIES].Points[i].ToolTip = data_prov_wrapper.GetCaseDataInfo(lamp_control_points_id[i]);

        chart.Series[CONTROL_POINT_SERIES].Points[i].MarkerStyle = GetPointMarkerStyle(data_prov_wrapper.GetCaseEndInfo(lamp_control_points_id[i]));
        chart.Series[CONTROL_POINT_SERIES].Points[i].MarkerColor = GetPointColor(data_prov_wrapper.GetCaseEndInfo(lamp_control_points_id[i]));
        chart.Series[CONTROL_POINT_SERIES].Points[i].MarkerSize = 18;
        chart.Series[CONTROL_POINT_SERIES].Points[i].MarkerBorderColor = Color.DarkOrange;
        chart.Series[CONTROL_POINT_SERIES].Points[i].MarkerBorderWidth = 2;

        lamp_min_max_axis_limits[0] = Math.Min(lamp_min_max_axis_limits[0], mm_x);
        lamp_min_max_axis_limits[1] = Math.Max(lamp_min_max_axis_limits[1], mm_x);

        lamp_min_max_axis_limits[2] = Math.Min(lamp_min_max_axis_limits[2], mm_y);
        lamp_min_max_axis_limits[3] = Math.Max(lamp_min_max_axis_limits[3], mm_y);
      }

      chart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.00}";
      chart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.00}";

      lamp_min_max_axis_limits[0] *= expand_limtis;
      lamp_min_max_axis_limits[1] *= expand_limtis;
      lamp_min_max_axis_limits[2] *= expand_limtis;
      lamp_min_max_axis_limits[3] *= expand_limtis;

      chart.ChartAreas[0].AxisX.Minimum = lamp_min_max_axis_limits[0];
      chart.ChartAreas[0].AxisX.Maximum = lamp_min_max_axis_limits[1];

      chart.ChartAreas[0].AxisY.Minimum = lamp_min_max_axis_limits[2];
      chart.ChartAreas[0].AxisY.Maximum = lamp_min_max_axis_limits[3];

      chart.ChartAreas[0].AxisX.Interval = (lamp_min_max_axis_limits[1] - lamp_min_max_axis_limits[0]) / (double)axis_number_of_intervals;
      chart.ChartAreas[0].AxisY.Interval = (lamp_min_max_axis_limits[3] - lamp_min_max_axis_limits[2]) / (double)axis_number_of_intervals;
                                            
      //Update selectedPoints
      ///////////////////////////////////////////////////////
      if (selectedPoints.Count > 0)
        selectedPoints.Clear();
      ///////////////////////////////////////////////////////
    }

    private void UpdateLAMPProjection (int pid_init, int pid_end)
    {
      //Console.Out.WriteLine("UpdateLAMPProjection");
      double[,] pts_control = new double[lamp_n_variants, 2];
      for (int p = 0; p < chart1.Series[CONTROL_POINT_SERIES].Points.Count; p ++)
      {
        pts_control[p, 0] = chart1.Series[CONTROL_POINT_SERIES].Points[p].XValue;
        pts_control[p, 1] = chart1.Series[CONTROL_POINT_SERIES].Points[p].YValues[0];
      }

      double[,] proj = data_prov_wrapper.DataProviderCasesLAMP(pid_init
        , pid_end
        , lamp_n_variants
        , lamp_control_points_id
        , pts_control
      );
      
      if (proj == null) return;

      for (int i = 0; i < (pid_end - pid_init); i++)
      {
        double mm_x = proj[lamp_n_variants + i, 0];
        double mm_y = proj[lamp_n_variants + i, 1];

        int series_id = data_prov_wrapper.GetCaseEndInfo(pid_init + i);

        hst_cases_to_points.Add((pid_init + i).ToString(), chart1.Series[series_id].Points.Count);

        int id_point = chart1.Series[series_id].Points.Count;

        chart1.Series[series_id].Points.AddXY(mm_x, mm_y);
        chart1.Series[series_id].Points[id_point].LegendToolTip = "loadedpoint";
        chart1.Series[series_id].Points[id_point].Tag = (pid_init + i + 1).ToString();
        chart1.Series[series_id].Points[id_point].ToolTip = data_prov_wrapper.GetCaseDataInfo(i);


        //if (mm_x < lamp_min_max_axis_limits[0])
        //  lamp_min_max_axis_limits[0] = mm_x;
        //if (mm_x > lamp_min_max_axis_limits[1])
        //  lamp_min_max_axis_limits[1] = mm_x;
        //
        //if (mm_y < lamp_min_max_axis_limits[2])
        //  lamp_min_max_axis_limits[2] = mm_y;
        //if (mm_y > lamp_min_max_axis_limits[3])
        //  lamp_min_max_axis_limits[3] = mm_y;
      }

      //chart1.ChartAreas[0].AxisX.Minimum = lamp_min_max_axis_limits[0];
      //chart1.ChartAreas[0].AxisX.Maximum = lamp_min_max_axis_limits[1];
      //
      //chart1.ChartAreas[0].AxisY.Minimum = lamp_min_max_axis_limits[2];
      //chart1.ChartAreas[0].AxisY.Maximum = lamp_min_max_axis_limits[3];
      //
      //chart1.ChartAreas[0].AxisX.Interval = (lamp_min_max_axis_limits[1] - lamp_min_max_axis_limits[0]) / (double)axis_number_of_intervals;
      //chart1.ChartAreas[0].AxisY.Interval = (lamp_min_max_axis_limits[3] - lamp_min_max_axis_limits[2]) / (double)axis_number_of_intervals;
    }
    
    private void button2_Click(object sender, EventArgs e)
    {
      UpdateInterfaceElements();
      double[,] arrayMDS = data_prov_wrapper.DataProviderMDSEditDist();

      Chart chart = chart1;
      for (int v = 0; v < chart.Series.Count; v++)
        chart.Series[v].Points.Clear();

      chart.Series[0].Enabled = tgl_vis_peding_series.Checked;
      chart.Series[1].Enabled = tgl_vis_denied_series.Checked;
      chart.Series[2].Enabled = tgl_vis_cancelled_series.Checked;
      chart.Series[3].Enabled = tgl_vis_undefined_series.Checked;
      chart.Series[CONTROL_POINT_SERIES].Enabled = false;

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

      chart.ChartAreas[0].AxisX.Interval = (min_max_axis_limits[1] - min_max_axis_limits[0]) / (double)axis_number_of_intervals;
      chart.ChartAreas[0].AxisY.Interval = (min_max_axis_limits[3] - min_max_axis_limits[2]) / (double)axis_number_of_intervals;

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
    }

    private void MDSMenuItem_Click(object sender, EventArgs e)
    {
      project_mode = ProjectionMode.MDS;

      tkb_ninputpoints.Value = param_number_of_cases;

      double npoints = param_number_of_cases;
      tooltiptrackbar.SetToolTip(tkb_ninputpoints, npoints.ToString());

      UpdateCurrentChartProjection();
    }

    private void LAMPMenuItem_Click(object sender, EventArgs e)
    {
      project_mode = ProjectionMode.LAMP;

      lamp_projected_points = 0;
      tkb_ninputpoints.Value = lamp_projected_points;

      double n_proj_points = lamp_projected_points;
      tooltiptrackbar.SetToolTip(tkb_ninputpoints, n_proj_points.ToString());

      UpdateCurrentChartProjection();
    }

    private void tkb_ninputpoints_Scroll(object sender, EventArgs e)
    {
      if (project_mode == ProjectionMode.MDS)
      {
        double npoints = tkb_ninputpoints.Value;
        tooltiptrackbar.SetToolTip(tkb_ninputpoints, npoints.ToString());

        param_number_of_cases = (int)npoints;

        data_prov_wrapper.SetNumberOfCases(param_number_of_cases);
      }else if (project_mode == ProjectionMode.LAMP)
      {
        double n_proj_points = tkb_ninputpoints.Value;

        tooltiptrackbar.SetToolTip(tkb_ninputpoints, n_proj_points.ToString());

        UpdateLAMPProjection(lamp_projected_points, (int)n_proj_points);

        if (lamp_projected_points < (int)n_proj_points)
          lamp_projected_points = (int)n_proj_points;
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        UpdateInterfaceElements();
        double[,] arrayMDS = data_prov_wrapper.DataProviderMDSJaccard();

        Chart chart = chart1;
        for (int v = 0; v < chart.Series.Count; v++)
            chart.Series[v].Points.Clear();

        chart.Series[0].Enabled = tgl_vis_peding_series.Checked;
        chart.Series[1].Enabled = tgl_vis_denied_series.Checked;
        chart.Series[2].Enabled = tgl_vis_cancelled_series.Checked;
        chart.Series[3].Enabled = tgl_vis_undefined_series.Checked;
        chart.Series[CONTROL_POINT_SERIES].Enabled = false;

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

        chart.ChartAreas[0].AxisX.Interval = (min_max_axis_limits[1] - min_max_axis_limits[0]) / (double)axis_number_of_intervals;
        chart.ChartAreas[0].AxisY.Interval = (min_max_axis_limits[3] - min_max_axis_limits[2]) / (double)axis_number_of_intervals;

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
    }

    private void trackBar1_Scroll_3(object sender, EventArgs e)
    {
        double norm_edit = (trackBar1.Value - trackBar1.Minimum) / (double)trackBar1.Maximum;
        data_prov_wrapper.SetEditCoeficientValue(norm_edit);
        tooltiptrackbar.SetToolTip(trackBar1, norm_edit.ToString());
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
        double norm_jaccard = (trackBar2.Value - trackBar2.Minimum) / (double)trackBar2.Maximum;
        data_prov_wrapper.SetJaccardCoeficientValue(norm_jaccard);
        tooltiptrackbar.SetToolTip(trackBar2, norm_jaccard.ToString());
    }

    private void disableControlPointsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      disableControlPointsToolStripMenuItem.Checked = !disableControlPointsToolStripMenuItem.Checked;
      chart1.Series[CONTROL_POINT_SERIES].Enabled = !disableControlPointsToolStripMenuItem.Checked;
    }
  };
}
