Imports Microsoft.VisualBasic
Imports System
Namespace MyMvpvmApplication
	Public Partial Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.taskCollectionView1 = New MyMvpvmApplication.Views.TaskCollectionView()
			Me.taskDetailView1 = New MyMvpvmApplication.Views.TaskDetailView()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top
			Me.splitContainerControl1.Panel1.Controls.Add(Me.taskCollectionView1)
			Me.splitContainerControl1.Panel1.Text = "Main View"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.taskDetailView1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(581, 243)
			Me.splitContainerControl1.SplitterPosition = 377
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' taskCollectionView1
			' 
			Me.taskCollectionView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.taskCollectionView1.Location = New System.Drawing.Point(0, 0)
			Me.taskCollectionView1.Name = "taskCollectionView1"
			Me.taskCollectionView1.Size = New System.Drawing.Size(377, 243)
			Me.taskCollectionView1.TabIndex = 0
			' 
			' taskDetailView1
			' 
			Me.taskDetailView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.taskDetailView1.Location = New System.Drawing.Point(0, 0)
			Me.taskDetailView1.Name = "taskDetailView1"
			Me.taskDetailView1.Size = New System.Drawing.Size(192, 243)
			Me.taskDetailView1.TabIndex = 0
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(581, 243)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "MainForm"
			Me.Text = "Form1"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private taskCollectionView1 As Views.TaskCollectionView
		Private taskDetailView1 As Views.TaskDetailView
	End Class
End Namespace

