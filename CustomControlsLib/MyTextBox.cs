using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsLib
{
    public enum WorkMode
    {
        Normal,
        Harf,
        Sayi
    }
    public class MyTextBox : TextBox
    {
        int[] dizi = { 231, 199, 351, 350, 287, 286, 252, 220, 304, 305, 246, 214, 8, 32 };


        public WorkMode CalismaModu { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (CalismaModu)
            {
                case WorkMode.Normal:
                    base.OnKeyPress(e);
                    break;
                case WorkMode.Harf:
                    if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || dizi.Contains(e.KeyChar))
                    {
                        base.OnKeyPress(e);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case WorkMode.Sayi:
                    if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                    {
                        base.OnKeyPress(e);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
