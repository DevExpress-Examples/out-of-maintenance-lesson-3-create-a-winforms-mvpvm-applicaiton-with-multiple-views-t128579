
Imports System.Windows.Forms
Imports DevExpress.Mvvm.POCO
Imports MyMvpvmApplication.ViewModels

Namespace MyMvpvmApplication.Views
    Partial Public Class TaskDetailView
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
            viewModelCore = ViewModelSource.Create(Of TaskDetailViewModel)()
            presenterCore = New TaskPresenter(taskBindingSource, ViewModel)
            simpleButton1.BindCommand(Sub() ViewModel.ShowNotificaion(), ViewModel)
        End Sub

        Private viewModelCore As TaskDetailViewModel
        Public ReadOnly Property ViewModel() As TaskDetailViewModel
            Get
                Return viewModelCore
            End Get
        End Property

        Private presenterCore As TaskPresenter
        Public ReadOnly Property Presenter() As TaskPresenter
            Get
                Return presenterCore
            End Get
        End Property
    End Class

    Public Class TaskPresenter
        Private bs As BindingSource
        Public Sub New(bs As BindingSource, viewModel__1 As TaskDetailViewModel)
            viewModelCore = viewModel__1
            Me.bs = bs
            AddHandler ViewModel.TaskChanged, AddressOf ViewModel_TaskChanged
        End Sub

        Private Sub ViewModel_TaskChanged(sender As Object, e As System.EventArgs)
            If ViewModel.Task IsNot Nothing Then
                bs.DataSource = ViewModel.Task
            End If
        End Sub

        Private viewModelCore As TaskDetailViewModel
        Public ReadOnly Property ViewModel() As TaskDetailViewModel
            Get
                Return viewModelCore
            End Get
        End Property
    End Class
End Namespace