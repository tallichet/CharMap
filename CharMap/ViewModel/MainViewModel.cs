using CharMap.Model;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using Windows.UI.Xaml.Media;

namespace CharMap.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private List<DispalyedChar> _chars;
        private FontFamily _fontFamily;


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            FontFamily = new FontFamily("Segoe MDL2 Assets");
            initChars();
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private void initChars()
        {
            var list = new List<DispalyedChar>();

            for (int i = 0xE001; i <= 0xEBC3; i++)
            {
                list.Add(new DispalyedChar(i, FontFamily));
            }

            Chars = list;
        }


        public FontFamily FontFamily
        {
            get { return _fontFamily; }
            set { Set(ref _fontFamily, value); }
        }

        public List<DispalyedChar> Chars
        {
            get { return _chars; }
            set
            {
                Set(ref _chars, value);                
            }
        }
    }
}