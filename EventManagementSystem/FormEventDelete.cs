using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class FormEventDelete : Form
    {
        public FormEventDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            // clear all text box and close form add event without saving
            this.Close();
        }

        private void btnDeleteOK_Click(object sender, EventArgs e)
        {

        }
    }
}
