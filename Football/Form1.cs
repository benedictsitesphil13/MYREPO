using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var result = new FootieResult();

            result.HomeTeam = txtHomeTeam.Text;
            result.AwayTeam = txtAwayTeam.Text;

            result.HomeScore = (int)nudHomeScore.Value;
            result.AwayScore = (int)nudAwayScore.Value;

            string msg = result.HomeTeam + " " + result.HomeScore.ToString() +
                ", " + result.AwayTeam + " " + result.AwayScore.ToString() +
                "\n\n" +
                result.HomeTeam + ": " + result.HomePoints.ToString() + " point(s)" +
                "\n" +
                result.AwayTeam + ": " + result.AwayPoints.ToString() + " point(s)";

            MessageBox.Show(text: msg, caption: "LATEST RESULT");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        
    }
}