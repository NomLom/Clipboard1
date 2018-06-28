using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clipboard
{
    public static class ClipboardMonitor
    {
        public static event EventHandler ClipboardUpdate;

        private static ClipboardMonitorWindow _window = new ClipboardMonitorWindow();
        public static void Start() => _window.Start();
        public static void Stop() => _window.Stop();

        private class ClipboardMonitorWindow : Form
        {
            public ClipboardMonitorWindow()
            {
                // Set this window as a message-only window.
                NativeMethods.SetParent(Handle, new IntPtr(-3)); // HWND_MESSAGE

                Start();
            }

            public void Start()
            {
                NativeMethods.AddClipboardFormatListener(Handle);
            }

            public void Stop()
            {
                NativeMethods.RemoveClipboardFormatListener(Handle);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x031D) // WM_CLIPBOARDUPDATE
                {
                    ClipboardUpdate?.Invoke(null, EventArgs.Empty);
                }

                base.WndProc(ref m);
            }

            private static class NativeMethods
            {
                [DllImport("user32.dll", SetLastError = true)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool AddClipboardFormatListener(IntPtr hwnd);

                [DllImport("user32.dll", SetLastError = true)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

                [DllImport("user32.dll", SetLastError = true)]
                public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
            }
        }
    }

}
