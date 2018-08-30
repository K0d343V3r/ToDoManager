using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoManager.Extensions
{
    public static class ToolStripExtensions
    {
        public static void MakeTransparent(this ToolStrip toolStrip)
        {
            toolStrip.Renderer = new ToolStripTransparentRenderer();
        }
    }
}
