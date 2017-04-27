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

using CppWrapper;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClassCppToCS_CS
{
  public partial class Form1 : Form
  {
    public CppWrapper.CppMDSWrapper data_prov_wrapper;
    public Form1()
    {
      InitializeComponent();

      data_prov_wrapper = new CppWrapper.CppMDSWrapper();
       
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void chart1_Click(object sender, EventArgs e)
    {
      double[,] arrayMDS = data_prov_wrapper.TestDataProvider();
       
      Chart chart = chart1;
      chart.Series[0].Points.Clear();
        
      double[] min_max_axis_limits = new Double[4];
      min_max_axis_limits[0] = Double.MaxValue;
      min_max_axis_limits[1] = Double.MinValue;
      min_max_axis_limits[2] = Double.MaxValue;
      min_max_axis_limits[3] = Double.MinValue;
      
      double expand_limtis = 1.2;
        
      for (int i = 0; i < 20; i++)
      {
        double mm_x = arrayMDS[i, 0]; //Math.Round(arrayMDS[i, 0], 5);
        double mm_y = arrayMDS[i, 1]; //Math.Round(arrayMDS[i, 1], 5);

        Console.Out.WriteLine(i + " [" + mm_x + ", " + mm_y + "]");
      
        chart.Series[0].Points.AddXY(mm_x, mm_y);
      
        chart.Series[0].Points[i].LegendToolTip = "loadedpoint";
        chart.Series[0].Points[i].Tag = (i + 1).ToString();
        chart.Series[0].Points[i].ToolTip = "Case " + (i+1) + "\n X= " + arrayMDS[i, 0] + " Y = " + arrayMDS[i, 1];
        chart.Series[0].Points[i].Color = Color.Blue;
      
        min_max_axis_limits[0] = Math.Min(min_max_axis_limits[0], mm_x);
        min_max_axis_limits[1] = Math.Max(min_max_axis_limits[1], mm_x);
      
        min_max_axis_limits[2] = Math.Min(min_max_axis_limits[2], mm_y);
        min_max_axis_limits[3] = Math.Max(min_max_axis_limits[3], mm_y);
      }
        
      min_max_axis_limits[0] *= expand_limtis;
      min_max_axis_limits[1] *= expand_limtis;
      
      min_max_axis_limits[2] *= expand_limtis;
      min_max_axis_limits[3] *= expand_limtis;
      
      chart.ChartAreas[0].AxisX.Minimum = min_max_axis_limits[0];
      chart.ChartAreas[0].AxisX.Maximum = min_max_axis_limits[1];
      
      chart.ChartAreas[0].AxisY.Minimum = min_max_axis_limits[2];
      chart.ChartAreas[0].AxisY.Maximum = min_max_axis_limits[3];
    }
  };
}
