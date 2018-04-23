namespace MyMvpvmApplication.Model {
    public class Task {
        public string Subject { get; set; }
        public string Description { get; set; }
    }

    public class TaskMessage {
        public Task Task { get; set; }
    }
}
