using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.SharpPreviewHandler;

namespace ShellPreviewHandlerz
{
    public partial class HTMLPreviewControl : PreviewHandlerControl
    {
        public HTMLPreviewControl()
        {
            InitializeComponent();
        }

        public string Input
        {
            set
            {
                this.webBrowser1.DocumentText = value;
            }
        }
    }
}
