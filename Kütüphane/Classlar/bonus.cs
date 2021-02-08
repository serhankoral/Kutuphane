using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace Kütüphane.Classlar
{
    class bonus
    {
        public static void PopupShow(Popup send_popop)
        {
            send_popop.IsOpen = true;
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(2)
            };
            timer.Tick += delegate (object sender, EventArgs e)
             {
                 ((DispatcherTimer)timer).Stop();
                 if (send_popop.IsOpen) send_popop.IsOpen = false;
             };
            timer.Start();
        }
    }
}
