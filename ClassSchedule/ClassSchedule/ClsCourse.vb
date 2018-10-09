Public Class ClsCourse

#Region "members"

    Private course_id As Integer
    Private course_code As String
    Private course_title As String
    Private course_crHr As Integer
    Private course_contactHr As Integer

#End Region

#Region "Properties"

    Public Property pCourse_id As Integer
        Get
            Return course_id
        End Get
        Set(ByVal value As Integer)
            course_id = value
        End Set
    End Property

    Public Property pCourse_code As String
        Get
            Return course_code
        End Get
        Set(ByVal value As String)
            course_code = value
        End Set
    End Property

    Public Property pCourse_title As String
        Get
            Return course_title
        End Get
        Set(ByVal value As String)
            course_title = value
        End Set
    End Property

    Public Property pCourse_crHr As Integer
        Get
            Return course_crHr
        End Get
        Set(ByVal value As Integer)
            course_crHr = value
        End Set
    End Property

    Public Property pContactHr As Integer
        Get
            Return course_contactHr
        End Get
        Set(ByVal value As Integer)
            course_contactHr = value
        End Set
    End Property

#End Region


#Region "Methods"

    Public Sub Insert()

    End Sub

    Public Sub Delete()

    End Sub

    Public Sub Update()

    End Sub

    Public Sub Select_by_primary_key()

    End Sub

    Public Sub Select_all()

    End Sub

#End Region

End Class
