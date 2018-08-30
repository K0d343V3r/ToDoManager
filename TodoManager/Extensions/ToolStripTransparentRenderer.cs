using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoManager.Extensions
{
    public class ToolStripTransparentRenderer : ToolStripProfessionalRenderer
    {
        private class CustomProfessionalColorTable : ProfessionalColorTable
        {
            public override Color ToolStripGradientBegin
            {
                get { return Color.Transparent; }
            }

            public override Color ToolStripGradientMiddle
            {
                get { return Color.Transparent; }
            }

            public override Color ToolStripGradientEnd
            {
                get { return Color.Transparent; }
            }
        }

        public ToolStripTransparentRenderer() 
            : base(new CustomProfessionalColorTable())
        {
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // do not draw border
        }
    }
}
