using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreTeacher
{

    public partial class BigMessageBox : Form
    {
        public string content 
        {
            set { contentLabel.Text = value; } 
        }

        public BigMessageBox()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("SimSun.ttf");
            contentLabel.Font = new Font(pfc.Families[0], 72, FontStyle.Bold);
        }
    }
}
