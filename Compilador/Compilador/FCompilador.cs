﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class FCompilador : Form
    {
        public FCompilador()
        {
            InitializeComponent();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            openFileDialogProcurar.ShowDialog();
        }
    }
}
