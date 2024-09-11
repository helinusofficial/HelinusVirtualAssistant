using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelinusVirtualAssistant
{
    public enum TypeOfMessage
    {
        Success,
        Warning,
        Error,
    }
    public class SplashSrv
    {
        static FormSplash sf = null;

        public static void ShowSplashScreen()
        {
            if (sf == null)
            {
                sf = new FormSplash();
                sf.ShowSplashScreen();
            }
        }
        public static void UdpateStatusText(string Text)
        {
            if (sf != null)
               sf.UdpateStatusText(Text);
        }
        public static void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {

            if (sf != null)
                sf.UdpateStatusTextWithStatus(Text, tom);
        }
        public static void CloseSplashScreen()
        {
            if (sf != null)
            {
                sf.CloseSplashScreen();
                sf = null;
            }
        }
    }
}
