
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports MyMvpvmApplication.Model

Namespace MyMvpvmApplication.ViewModels
    Public Class TaskDetailViewModel
        Public Sub New()
            Messenger.[Default].Register(Of TaskMessage)(Me, AddressOf OnTaskMessage)
        End Sub

        Public Overridable Property Task() As Task

        Private Sub OnTaskMessage(message As TaskMessage)
            Task = message.Task
        End Sub

        Public Event TaskChanged As System.EventHandler

        Protected Overridable Sub OnTaskChanged()
            RaiseEvent TaskChanged(Me, System.EventArgs.Empty)
        End Sub

        <ServiceProperty> _
        Public Overridable ReadOnly Property MyNotificationService() As IMyNotificationService
            Get
                Throw New System.NotImplementedException()
            End Get
        End Property

        Public Sub ShowNotificaion()
            MyNotificationService.Notify(Task.Subject)
        End Sub
    End Class


End Namespace
