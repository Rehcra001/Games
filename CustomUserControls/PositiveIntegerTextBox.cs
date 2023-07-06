namespace CustomUserControls
{
    public partial class PositiveIntegerTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '0')
            {
                if (this.SelectionStart == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
