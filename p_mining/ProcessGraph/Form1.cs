using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CppWrapper;

namespace ProcessGraph
{
    public partial class Form1 : Form
    {
      public CppWrapper.CppDataProviderWrapper data_prov_wrapper;

      public Form1()
      {
          InitializeComponent();
      }

      private void chart1_Click(object sender, EventArgs e)
      {
        Console.Out.WriteLine("Click Chart1");
        data_prov_wrapper = new CppWrapper.CppDataProviderWrapper();
        data_prov_wrapper.TestDataProvider();
      }
    }
}
