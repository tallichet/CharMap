using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace CharMap.Model
{
    public class DispalyedChar
    {
        public DispalyedChar(int code, FontFamily fontFamily)
        {
            RenderString = char.ConvertFromUtf32(code);
            DisplayName = $"&#x{code.ToString("x")};";
            FontFamily = fontFamily;
        }

        public string RenderString { get; set; }

        public string DisplayName { get; set; }

        public FontFamily FontFamily { get; set; }
    }
}
