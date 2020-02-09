using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MControls.ViewModel;
using MyDemo.Model;

namespace MyDemo.ViewModel
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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///

            mainInfo = new MainModel();
            //mInfo = new MxViewModel();
        }

        #region SubViewModel

        //private MxViewModel mInfo;
        //public MxViewModel MInfo
        //{
        //    get { return mInfo; }
        //    set { mInfo = value; RaisePropertyChanged(() => MInfo); }
        //}

        public static readonly MxViewModel MInfo = new MxViewModel()
        {
            MxInfo = new MControls.UIModel.MxModel()
            { Content = "I love you" },
            SubmitCmd = null
        };

        #endregion

        private MainModel mainInfo;
        public MainModel MainInfo
        {
            get { return mainInfo; }
            set { mainInfo = value; RaisePropertyChanged(() => MainInfo); }
        }

        #region È«¾ÖÃüÁî

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
            MainInfo.Content += "Hello MainControl!\r\n";
        }
        #endregion

    }
}