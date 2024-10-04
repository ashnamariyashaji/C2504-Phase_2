using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CounterProject
{
    static class CounterConfig
    {
        public static Window FrmCounterWindow { get; set; }
        public static CounterViewModel VueModel { get; set; }

        static CounterConfig()
        {
            VueModel = new CounterViewModel();
            FrmCounterWindow = new CounterWindow();
        }
    }
}
