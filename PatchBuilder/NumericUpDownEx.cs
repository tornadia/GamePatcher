using System;
using System.Globalization;
using System.Windows.Forms;

namespace PatchBuilder
{
    public class NumericUpDownEx : NumericUpDown
    {
        public string _Text;

        public NumericUpDownEx()
        {
        }

        protected override void UpdateEditText()
        {
            decimal patch = this.Value % 1000;
            decimal minor = this.Value > 1000 ? Math.Floor(this.Value/1000) % 100  : 0;
            decimal major = this.Value > 100000 ? Math.Floor(this.Value / 100000) : 0;

            // Append the units to the end of the numeric value
            _Text = major + "." + minor + "." + patch;
            this.Text = _Text;
        }
    }
}