using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debug_and_Bug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string location;



            // This code  help to Debug Code called Exception Handling

            try
            {
                location = "C:\\Users\\laxma\\OneDrive\\Pictures\\backiee-251946.jpg";
                System.IO.File.Delete(location);

            }
            catch(Exception exc) { 
            
            MessageBox.Show("Erroe is :"+ exc.ToString());
            
            }
          


        }
    }
}
