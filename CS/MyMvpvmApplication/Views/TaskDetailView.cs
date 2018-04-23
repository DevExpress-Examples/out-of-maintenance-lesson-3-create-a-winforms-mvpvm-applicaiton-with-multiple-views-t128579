using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using MyMvpvmApplication.ViewModels;

namespace MyMvpvmApplication.Views {
    public partial class TaskDetailView : UserControl {
        public TaskDetailView() {
            InitializeComponent();
            viewModelCore = ViewModelSource.Create<TaskDetailViewModel>();
            presenterCore = new TaskPresenter(taskBindingSource, ViewModel);
            simpleButton1.BindCommand(() => ViewModel.ShowNotificaion(), ViewModel);
        }

        TaskDetailViewModel viewModelCore;
        public TaskDetailViewModel ViewModel {
            get { return viewModelCore; }
        }

        TaskPresenter presenterCore;
        public TaskPresenter Presenter {
            get { return presenterCore; }
        }
    }

    public class TaskPresenter {
        BindingSource bs;
        public TaskPresenter(BindingSource bs, TaskDetailViewModel viewModel) {
            viewModelCore = viewModel;
            this.bs = bs;
            ViewModel.TaskChanged += ViewModel_TaskChanged;
        }

        void ViewModel_TaskChanged(object sender, System.EventArgs e) {
             if (ViewModel.Task != null)
                 bs.DataSource = ViewModel.Task;
        }    
        
        TaskDetailViewModel viewModelCore;
        public TaskDetailViewModel ViewModel {
            get { return viewModelCore; }
        }
    }
}
