using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Moonbase Alpha First Simulation code by Akil B.
// CSC 202 - C# Programming
// University of Advancing Technology (UAT)

namespace CSC202_Moonbase_Alpha_First_Simulation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BTNabout_Click(object sender, EventArgs e)
        {
            // Display message about Moonbase command center
            MessageBox.Show(
                "The Moonbase Command Center is the central hub for all operations on the Moonbase. It houses critical systems for monitoring, control, and communication. From the Command Center, astronauts oversee vital functions such as life support, habitat control, and communication with Earth.",
                "Moonbase Command Center",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information); // Display information icon

        }
    }
}
