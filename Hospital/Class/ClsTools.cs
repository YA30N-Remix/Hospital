using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Class
{
    public static class ClsTools
    {

        public static string ShamsiDate()
        {
            PersianCalendar p = new PersianCalendar();
            var Emruz = p.GetYear(DateTime.Now).ToString() + "/" + p.GetMonth(DateTime.Now).ToString("0#") + "/" + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            return Emruz;
        }
    
             
        public static string Time()
        {
            var Saat = "";

            Saat = DateTime.Now.Hour.ToString("0#");
            Saat += ":";
            Saat += DateTime.Now.Minute.ToString("0#");
            Saat += ":";
            Saat += DateTime.Now.Second.ToString("0#");

            return Saat;
        }
           

        public static void ClearContent(Control Content)
        {
            foreach (var item in Content.Controls)
            {
                if (item is TextBox)
                    (item as TextBox).Clear();

                if (item is MaskedTextBox)
                    (item as MaskedTextBox).Clear();

                if (item is PictureBox)
                    (item as PictureBox).Image = null;

                if (item is RadioButton)
                    (item as RadioButton).Checked = false;

                if (item is NumericUpDown)
                    (item as NumericUpDown).ResetText();

                if (item is ComboBox)
                    (item as ComboBox).ResetText();

            }
        }

        public static bool CheckValidation(Control Content)
        {
            foreach (var item in Content.Controls)
            {

                if (item is TextBox)
                {
                    if ((item as TextBox).Name.ToString().LastIndexOf("_") > 0)
                    {
                        if ((item as TextBox).Text.Trim().Length == 0)
                        {
                            return false;
                        }
                    }

                }

                if (item is ComboBox)
                {
                    if ((item as ComboBox).Name.ToString().LastIndexOf("_") > 0)
                    {
                        if ((item as ComboBox).Text.Trim().Length == 0)
                        {
                            return false;
                        }
                    }
                }

                if (item is MaskedTextBox)
                {
                    if ((item as MaskedTextBox).Name.ToString().LastIndexOf("_") > 0)
                    {
                        if ((item as MaskedTextBox).Text.Trim().Length == 0)
                        {
                            return false;
                        }
                    }
                }

                if (item is PictureBox)
                {
                    if ((item as PictureBox).Name.ToString().LastIndexOf("_") > 0)
                    {
                        if ((item as PictureBox).Image == null)
                        {
                            return false;
                        }
                    }
                }


                if (item is NumericUpDown)
                {
                    if ((item as NumericUpDown).Name.ToString().LastIndexOf("_") > 0)
                    {
                        if ((item as NumericUpDown).Text.Trim().Length == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
          
    }

}

