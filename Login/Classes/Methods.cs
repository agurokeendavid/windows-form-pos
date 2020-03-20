using Login.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;
using WindowsFormsControlLibrary1;
using XanderUI;
using System.Drawing;

namespace Login.Classes
{
    public static class Methods
    {
        public static void ClearItems(Control group)
        {
            foreach (Control control in group.Controls)
            {
                if (control is BunifuMaterialTextbox)
                    ((BunifuMaterialTextbox)control).Text = String.Empty;
                else if (control is MetroComboBox)
                    ((MetroComboBox)control).SelectedIndex = -1;
                else if (control is BunifuDatepicker)
                    ((BunifuDatepicker)control).Value = DateTime.Today;
                else if (control is BunifuCustomTextbox)
                    ((BunifuCustomTextbox)control).Text = String.Empty;
                else if (control is BunifuCustomTextbox)
                    ((BunifuCustomTextbox)control).Text = String.Empty;
                else if (control is XUICustomPictureBox)
                    ((XUICustomPictureBox)control).Image = Resources.picdefault;
                else if (control is BunifuMetroTextbox)
                    ((BunifuMetroTextbox)control).Text = $"File Name :";

            }
        }
        //public static void ClearItems(Control group)
        //{
        //    foreach (var control in group.Controls)
        //    {
        //        if (control is TextBox)
        //            ((TextBox)control).Text = String.Empty;
        //        else if (control is Bunifu.Framework.UI.BunifuMaterialTextbox)
        //            ((Bunifu.Framework.UI.BunifuMaterialTextbox)control).Text = String.Empty;
        //        else if (control is ComboBox)
        //            ((ComboBox)control).ResetText();
        //        else if (control is DateTimePicker)
        //            ((DateTimePicker)control).ResetText();
        //        else if (control is PictureBox)
        //            ((PictureBox)control).Image = Resources.picdefault;
        //        else
        //            return;
        //    }
        //}
    }
}
