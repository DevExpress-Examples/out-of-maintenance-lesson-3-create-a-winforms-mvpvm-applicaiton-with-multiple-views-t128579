using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyMvpvmApplication {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
            DevExpress.Mvvm.ServiceContainer.Default.RegisterService(new MyNotificationService());
        }
    }

    public interface IMyNotificationService {
        void Notify(string message);
    }

    class MyNotificationService : IMyNotificationService {
        public void Notify(string message) {
            System.Windows.Forms.MessageBox.Show("You have seleted " + message, "Notification");
        }
    }
}
