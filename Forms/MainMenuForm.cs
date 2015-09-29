using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HCI.Foundation;

namespace HCI.Forms
{
    public partial class MainMenuForm : BaseForm
    {
        public MainMenuForm(RootForm root, BaseForm prev = null)
        {
            InitializeComponent();
            InitializeAttribute(root, prev);
            UpdateNavigation("Menu");
        }
    }
}
