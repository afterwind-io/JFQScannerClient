using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace JFQScannerClient.Models
{
    public enum PhotoType { Invoice, Others }

    public sealed class Photo
    {
        public string CompanyName { get; set; }
        public int Year { get; set; } = 2016;
        public int Month { get; set; } = 1;
        public string ImagePath { get; set; }
        public ImageSource Image { get; set; }
        public PhotoType Type { get; set; }
    }
}
