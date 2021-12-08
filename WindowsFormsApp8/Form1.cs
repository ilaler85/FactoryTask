using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.UserControls;
using System.Configuration;

namespace WindowsFormsApp8
{
    
    public partial class Main : Form
    {
        public string connectionString;
        public Main()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Factory"].ConnectionString;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            factoryUserControl1.BoundControl(connectionString);
        }
    }
}
