using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public class BufferedDataGridView : DataGridView
    {
        private const int ScrollSensitivity = 50; // Adjust this value to make horizontal scrolling more sensitive
        private const int WM_MOUSEHWHEEL = 0x020E; // Message for horizontal mouse wheel scroll

        public BufferedDataGridView()
        {
            DoubleBuffered = true;
            this.MouseWheel += BufferedDataGridView_MouseWheel;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEHWHEEL)
            {
                int delta = (short)((m.WParam.ToInt64() >> 16) & 0xffff); // Correctly handle the delta value for horizontal scroll
                OnMouseHWheel(new MouseEventArgs(MouseButtons.None, 0, 0, 0, delta));
                return;
            }
            base.WndProc(ref m);
        }

        private void OnMouseHWheel(MouseEventArgs e)
        {
            try
            {
                // Scroll horizontally
                int horizontalOffset = e.Delta > 0 ? ScrollSensitivity : -ScrollSensitivity; // Invert the scrolling direction
                int newHorizontalOffset = this.HorizontalScrollingOffset + horizontalOffset;

                // Ensure the new offset is within valid range
                newHorizontalOffset = Math.Max(0, newHorizontalOffset);
                this.HorizontalScrollingOffset = newHorizontalOffset;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error in MouseHWheel event: " + ex.Message);
            }
        }

        private void BufferedDataGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                // Check if Shift key is pressed to enable horizontal scrolling
                if (ModifierKeys.HasFlag(Keys.Shift))
                {
                    // Scroll horizontally
                    int horizontalOffset = e.Delta > 0 ? ScrollSensitivity : -ScrollSensitivity; // Invert the scrolling direction
                    int newHorizontalOffset = this.HorizontalScrollingOffset + horizontalOffset;

                    // Ensure the new offset is within valid range
                    newHorizontalOffset = Math.Max(0, newHorizontalOffset);
                    this.HorizontalScrollingOffset = newHorizontalOffset;

                    // Prevent vertical scrolling
                    ((HandledMouseEventArgs)e).Handled = true;
                }
                else
                {
                    // Scroll vertically
                    int verticalOffset = e.Delta > 0 ? -SystemInformation.MouseWheelScrollLines : SystemInformation.MouseWheelScrollLines;
                    int newVerticalOffset = this.FirstDisplayedScrollingRowIndex + verticalOffset;

                    // Ensure the new offset is within valid range
                    newVerticalOffset = Math.Max(0, newVerticalOffset);
                    newVerticalOffset = Math.Min(newVerticalOffset, this.RowCount - 1);
                    this.FirstDisplayedScrollingRowIndex = newVerticalOffset;

                    // Prevent horizontal scrolling
                    ((HandledMouseEventArgs)e).Handled = true;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error in MouseWheel event: " + ex.Message);
            }
        }
    }
}
