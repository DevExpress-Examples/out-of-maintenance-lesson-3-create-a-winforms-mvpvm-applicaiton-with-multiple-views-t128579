Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace MyMvpvmApplication
	Public Partial Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			DevExpress.Mvvm.ServiceContainer.Default.RegisterService(New MyNotificationService())
		End Sub
	End Class

	Public Interface IMyNotificationService
		Sub Notify(ByVal message As String)
	End Interface

	Friend Class MyNotificationService
		Implements IMyNotificationService
		Public Sub Notify(ByVal message As String) Implements IMyNotificationService.Notify
			System.Windows.Forms.MessageBox.Show("You have seleted " & message, "Notification")
		End Sub
	End Class
End Namespace
