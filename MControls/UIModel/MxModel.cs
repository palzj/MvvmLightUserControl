using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MControls.UIModel
{
    public class MxModel : ObservableObject
    {
        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                if (content != value)
                {
                    content = value; RaisePropertyChanged(() => Content);
                }
            }
        }
    }
}
