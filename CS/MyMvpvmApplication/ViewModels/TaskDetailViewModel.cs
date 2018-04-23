using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using MyMvpvmApplication.Model;

namespace MyMvpvmApplication.ViewModels {
    public class TaskDetailViewModel {
        public TaskDetailViewModel() {
            Messenger.Default.Register<TaskMessage>(this, OnTaskMessage);
        }

        public virtual Task Task { get; set; }

        void OnTaskMessage(TaskMessage message) {
            Task = message.Task;
        }

        public event EventHandler TaskChanged;

        protected virtual void OnTaskChanged() {
            if (TaskChanged != null)
                TaskChanged(this, EventArgs.Empty);
        }

        [ServiceProperty]
        public virtual IMyNotificationService MyNotificationService {
            get { throw new NotImplementedException(); }
        }

        public void ShowNotificaion() {
            MyNotificationService.Notify(Task.Subject);
        }
    }

    
}
