using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__ExamWinForm
{
    public partial class aboutProgram : Form
    {
        public aboutProgram()
        {
            InitializeComponent();
            buttonOK.Click += ButtonOK_Click;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
