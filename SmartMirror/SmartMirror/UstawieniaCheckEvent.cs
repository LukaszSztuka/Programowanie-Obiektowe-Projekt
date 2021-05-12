using System;


namespace SmartMirror
{
    public class CheckEventArgs2 : EventArgs
    {  
        public bool pogodaChecked { get; set; }
        public bool czasChecked { get; set; }
    }

    public class CheckEventArgs : EventArgs
    {
        public static bool Checked { get; set; }
    }
}