Imports Microsoft.VisualBasic
Imports System
Namespace MyMvpvmApplication.Views
	Public Partial Class TaskDetailView
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.SubjectTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.ItemForSubject = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.taskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dataLayoutControl1.SuspendLayout()
			CType(Me.SubjectTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForSubject, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.taskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataLayoutControl1
			' 
			Me.dataLayoutControl1.Controls.Add(Me.simpleButton1)
			Me.dataLayoutControl1.Controls.Add(Me.SubjectTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.DescriptionTextEdit)
			Me.dataLayoutControl1.DataSource = Me.taskBindingSource
			Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.dataLayoutControl1.Name = "dataLayoutControl1"
			Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(425, 198, 450, 350)
            Me.dataLayoutControl1.OptionsView.AutoSizeModeInLayoutControl = System.Windows.Forms.AutoSizeMode.GrowOnly
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
			Me.dataLayoutControl1.Size = New System.Drawing.Size(306, 197)
			Me.dataLayoutControl1.TabIndex = 0
			Me.dataLayoutControl1.Text = "dataLayoutControl1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 60)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(282, 22)
			Me.simpleButton1.StyleController = Me.dataLayoutControl1
			Me.simpleButton1.TabIndex = 6
			Me.simpleButton1.Text = "Show Notification"
			' 
			' SubjectTextEdit
			' 
			Me.SubjectTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.taskBindingSource, "Subject", True))
			Me.SubjectTextEdit.Location = New System.Drawing.Point(68, 12)
			Me.SubjectTextEdit.Name = "SubjectTextEdit"
			Me.SubjectTextEdit.Size = New System.Drawing.Size(226, 20)
			Me.SubjectTextEdit.StyleController = Me.dataLayoutControl1
			Me.SubjectTextEdit.TabIndex = 4
			' 
			' DescriptionTextEdit
			' 
			Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.taskBindingSource, "Description", True))
			Me.DescriptionTextEdit.Location = New System.Drawing.Point(68, 36)
			Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
			Me.DescriptionTextEdit.Size = New System.Drawing.Size(226, 20)
			Me.DescriptionTextEdit.StyleController = Me.dataLayoutControl1
			Me.DescriptionTextEdit.TabIndex = 5
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(306, 197)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.AllowDrawBackground = False
			Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
			Me.layoutControlGroup2.GroupBordersVisible = False
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForSubject, Me.ItemForDescription, Me.layoutControlItem1})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(286, 177)
			Me.layoutControlGroup2.Text = "autoGeneratedGroup0"
			' 
			' ItemForSubject
			' 
			Me.ItemForSubject.Control = Me.SubjectTextEdit
			Me.ItemForSubject.CustomizationFormText = "Subject"
			Me.ItemForSubject.Location = New System.Drawing.Point(0, 0)
			Me.ItemForSubject.Name = "ItemForSubject"
			Me.ItemForSubject.Size = New System.Drawing.Size(286, 24)
			Me.ItemForSubject.Text = "Subject"
			Me.ItemForSubject.TextSize = New System.Drawing.Size(53, 13)
			' 
			' ItemForDescription
			' 
			Me.ItemForDescription.Control = Me.DescriptionTextEdit
			Me.ItemForDescription.CustomizationFormText = "Description"
			Me.ItemForDescription.Location = New System.Drawing.Point(0, 24)
			Me.ItemForDescription.Name = "ItemForDescription"
			Me.ItemForDescription.Size = New System.Drawing.Size(286, 24)
			Me.ItemForDescription.Text = "Description"
			Me.ItemForDescription.TextSize = New System.Drawing.Size(53, 13)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.simpleButton1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(286, 129)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' taskBindingSource
			' 
			Me.taskBindingSource.DataSource = GetType(MyMvpvmApplication.Model.Task)
			' 
			' TaskDetailView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dataLayoutControl1)
			Me.Name = "TaskDetailView"
			Me.Size = New System.Drawing.Size(306, 197)
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dataLayoutControl1.ResumeLayout(False)
			CType(Me.SubjectTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForSubject, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.taskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		Private taskBindingSource As System.Windows.Forms.BindingSource
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private SubjectTextEdit As DevExpress.XtraEditors.TextEdit
		Private DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private ItemForSubject As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForDescription As DevExpress.XtraLayout.LayoutControlItem
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

	End Class
End Namespace
