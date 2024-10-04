using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Example14Project
{
    static class FormConfig
    {
        public static Window FrmSolid {  get; set; } = new SolidWindow();
        public static Window FrmLinearGradient { get; set; } = new LinearGradient();
        public static Window FrmRadialGradient { get; set; } = new Radial_Gradient_Window();
        public static Window FrmImage { get; set; } = new Image_Window();
        public static Window FrmVisual { get; set; } = new Visual_Window();
        public static Window FrmSatck { get; set; } = new StackWindow();
        public static Window FrmWrap { get; set; } = new WrapWindow();

        public static Window FrmCanvas { get; set; } = new CanvasWindow();
        public static Window FrmGrid { get; set; } = new GridWindow();
        public static Window FrmDock { get; set ; } = new DockWindow();
                

    }
}
