public class External
    {
        // ---------------------------------------------------------------------------------------------
        // UI Lock
        // ---------------------------------------------------------------------------------------------

        [DllImport("user32.dll")] // import lockwindow to remove flashing
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        public static void LockWindowUpdateBlock(Control target, Action action) {
            try {
                LockWindowUpdate(target.Handle);
                action();
            }
            finally {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        public static void LockWindowAndKeepScrollPosition(Control target, Action action) {
            LockWindowUpdateBlock(target, () => 
            {
                // Get Scroll
                var scroll = new Point();
                SendMessage(target.Handle, EM_GETSCROLLPOS, 0, ref scroll);

                // Change Content
                action();

                // Restore Scroll
                SendMessage(target.Handle, EM_SETSCROLLPOS, 0, ref scroll);
            });
        }

        // ---------------------------------------------------------------------------------------------
        // Send Message
        // ---------------------------------------------------------------------------------------------

        public const int WM_USER = 0x400;
        public const int EM_GETSCROLLPOS = WM_USER + 221;
        public const int EM_SETSCROLLPOS = WM_USER + 222;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);
    }
