using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JFQScannerClient.Models;

namespace JFQScannerClient.Controlers
{
    public sealed class BatchViewControler
    {
        ObservableCollection<Photo> _photos;

        public BatchViewControler()
        {
            _photos = new ObservableCollection<Photo>();
        }

        public void AddPhoto()
        {

        }
    }
}
