using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo.Model
{
    public class MainModel : ObservableObject
    {
        private string content = "主程序显示文本:";
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
