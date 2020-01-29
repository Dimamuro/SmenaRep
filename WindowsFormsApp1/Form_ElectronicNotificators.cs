using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_ElectronicNotificators : Form
    {
        public string ElectricNotificators;
        public Form_ElectronicNotificators(string str)
        {
            InitializeComponent();
            ElectricNotificators = str;
        }


    }
}
