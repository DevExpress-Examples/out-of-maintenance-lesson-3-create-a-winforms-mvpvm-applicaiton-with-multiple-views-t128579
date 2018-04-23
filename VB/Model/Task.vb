
Namespace MyMvpvmApplication.Model
    Public Class Task
        Public Property Subject() As String
            Get
                Return m_Subject
            End Get
            Set(value As String)
                m_Subject = Value
            End Set
        End Property
        Private m_Subject As String
        Public Property Description() As String
            Get
                Return m_Description
            End Get
            Set(value As String)
                m_Description = Value
            End Set
        End Property
        Private m_Description As String
    End Class

    Public Class TaskMessage
        Public Property Task() As Task
            Get
                Return m_Task
            End Get
            Set(value As Task)
                m_Task = Value
            End Set
        End Property
        Private m_Task As Task
    End Class
End Namespace
