using System.Windows.Forms;

namespace FrogGame.WinForms
{
    /// <summary>
    /// Moves between screens and exits the application once the last screen is closed.
    /// </summary>
    internal sealed class Navigator : ApplicationContext
    {
        private static Navigator current;

        private int openScreens;

        public Navigator(Form firstScreen)
        {
            current = this;
            Open(firstScreen);
        }

        /// <summary>
        /// Shows <paramref name="next"/> and closes <paramref name="from"/>.
        /// </summary>
        public static void GoTo(Form from, Form next)
        {
            // Open the next screen first so the open-screen count never drops to zero in between.
            current.Open(next);
            from.Close();
        }

        private void Open(Form screen)
        {
            openScreens++;
            screen.FormClosed += (sender, e) =>
            {
                openScreens--;
                if (openScreens == 0)
                {
                    ExitThread();
                }
            };
            screen.Show();
        }
    }
}
