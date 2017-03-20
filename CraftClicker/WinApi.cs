using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimerTest
{
    public static class WinApi
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        internal const int WM_HOTKEY = 0x0312;

        public static void LeftClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        public static void MoveTo(int x, int y)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_MOVE, x, y, 0, 0);
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetActiveWindow(IntPtr hWnd);

        internal static Point ConvertCoordinates(int x, int y)
        {
            var inputXinPixels = x;
            var inputYinPixels = y;
            var screenBounds = Screen.PrimaryScreen.Bounds;
            var outputX = inputXinPixels * 65535 / screenBounds.Width;
            var outputY = inputYinPixels * 65535 / screenBounds.Height;
            return new Point(outputX, outputY);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        internal static void SetFocusToPoint(Point point)
        {
            var windowFromPoint = WindowFromPoint(point);
            SetActiveWindow(windowFromPoint);
        }


        [DllImport("user32.dll")]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point p);
    }
}
