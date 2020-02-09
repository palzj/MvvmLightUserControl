using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MControls.UIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MControls.ViewModel
{
    public class MxViewModel : ViewModelBase
    {
        public MxViewModel()
        {
            mxInfo = new MxModel();
        }

        private MxModel mxInfo;
        public MxModel MxInfo
        {
            get { return mxInfo; }
            set { mxInfo = value; RaisePropertyChanged(() => MxInfo); }
        }

        #region 命令

        private RelayCommand submitCmd;
        public RelayCommand SubmitCmd
        {
            get
            {
                if (submitCmd == null) return new RelayCommand(() => SubmitCmdMethod());
                return submitCmd;
            }

            set
            {
                submitCmd = value;
            }
        }
        private void SubmitCmdMethod()
        {
            mxInfo.Content += "Hello McControl!\r\n";         
        }

        #endregion
    }
}
