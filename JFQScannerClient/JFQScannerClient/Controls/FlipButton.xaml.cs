using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JFQScannerClient.Controls
{
    /// <summary>
    /// FlipButton.xaml 的交互逻辑
    /// </summary>
    public partial class FlipButton : UserControl
    {
        public FlipButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsRoundStyleProperty =
            DependencyProperty.Register("IsRoundStyle", typeof(bool), typeof(FlipButton), new PropertyMetadata(false));
        public bool IsRoundStyle
        {
            get { return (bool)GetValue(IsRoundStyleProperty); }
            set { SetValue(IsRoundStyleProperty, value); }
        }

        public static readonly DependencyProperty IsUsingImageProperty =
            DependencyProperty.Register("IsUsingImage", typeof(bool), typeof(FlipButton), new PropertyMetadata(false));
        public bool IsUsingImage
        {
            get { return (bool)GetValue(IsUsingImageProperty); }
            set { SetValue(IsUsingImageProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(FlipButton));
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty GlyphProperty =
            DependencyProperty.Register("Glyph", typeof(string), typeof(FlipButton));
        public string Glyph
        {
            get { return (string)GetValue(GlyphProperty); }
            set { SetValue(GlyphProperty, value); }
        }

        public static readonly DependencyProperty GlyphFontFamilyProperty =
            DependencyProperty.Register(
                "GlyphFontFamily", typeof(FontFamily), typeof(FlipButton));
        public FontFamily GlyphFontFamily
        {
            get { return (FontFamily)GetValue(GlyphFontFamilyProperty); }
            set { SetValue(GlyphFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(FlipButton));
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
    }
}
