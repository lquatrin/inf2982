﻿using System;
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

using CppWrapper;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClassCppToCS_CS
{
  public partial class Form1 : Form
  {
    public CppWrapper.CppMDSWrapper data_prov_wrapper;

    Hashtable hst_cases_to_points = new Hashtable();

    public Form1()
    {
      InitializeComponent();

      data_prov_wrapper = new CppWrapper.CppMDSWrapper();

      hst_cases_to_points = new Hashtable();
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

    private void chart1_Click(object sender, EventArgs e)
    {
      double[,] arrayMDS = data_prov_wrapper.DataProviderMDS();

      Chart chart = chart1;
      for(int v = 0; v < chart.Series.Count; v++)
        chart.Series[v].Points.Clear();

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

        hst_cases_to_points.Add(i, chart.Series[series_id].Points.Count);
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
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      double norm_creditscore = (creditscoretrackbar.Value - creditscoretrackbar.Minimum) / (double)creditscoretrackbar.Maximum;
      data_prov_wrapper.SetCreditScoreCoeficientValue(norm_creditscore);
    }

    private void trackBar1_Scroll_1(object sender, EventArgs e)
    {
      double norm_requestamount = (requestamounttrackbar.Value - requestamounttrackbar.Minimum) / (double)requestamounttrackbar.Maximum;
      data_prov_wrapper.SetRequestAmountCoeficientValue(norm_requestamount);
    }

    private void numberofofferstrackbar_Scroll(object sender, EventArgs e)
    {
      double norm_numberofoffers = (numberofofferstrackbar.Value - numberofofferstrackbar.Minimum) / (double)numberofofferstrackbar.Maximum;
      data_prov_wrapper.SetNumberOfOffersCoeficientValue(norm_numberofoffers);
    }

    private void trackBar1_Scroll_2(object sender, EventArgs e)
    {
      double norm_loangoal = (loangoaltrackbar.Value - loangoaltrackbar.Minimum) / (double)loangoaltrackbar.Maximum;
      data_prov_wrapper.SetLoanGoalCoeficientValue(norm_loangoal);
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
  };
}
