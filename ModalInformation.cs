using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleCodeREST
{
    public partial class ModalInformation : Form
    {
        public ModalInformation()
        {
            InitializeComponent();
        }

        public void CallingForm(string _TextInfo)
        {
            TxtInfo.Text = _TextInfo;
        }

        private void TxtInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
