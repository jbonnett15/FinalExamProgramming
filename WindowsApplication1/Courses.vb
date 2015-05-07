Public Class Courses
    Private SemesterValue As String
    Private YearValue As Integer
    Private DepartmentValue As String
    Private NumberValue As Integer
    Private CourseNameValue As String
    Private SemesterHrsValue As Integer
    Private GradeValue As String
    Private MajorCourseValue As String
    Private RetakeCourseValue As String
    Sub New(ByVal SemesterVal As String, ByVal YearVal As Integer, ByVal DepartmentVal As String, _
            ByVal NumberVal As Integer, ByVal CourseNameVal As String, ByVal SemesterHrsVal As Integer, _
            ByVal GradeVal As String, ByVal MajorCourseVal As String, ByVal RetakeCourseVal As String)
        SemesterValue = SemesterVal
        YearValue = YearVal
        DepartmentValue = DepartmentVal
        NumberValue = NumberVal
        CourseNameValue = CourseNameVal
        SemesterHrsValue = SemesterHrsVal
        GradeValue = GradeVal
        MajorCourseValue = MajorCourseVal
        RetakeCourseValue = RetakeCourseVal
    End Sub

    Property Semester() As String
        Get
            Return SemesterValue
        End Get
        Set(ByVal value As String)
            SemesterValue = value
        End Set
    End Property

    Property Year() As Integer
        Get
            Return YearValue
        End Get
        Set(ByVal value As Integer)
            YearValue = value
        End Set
    End Property

    Property Department() As String
        Get
            Return DepartmentValue
        End Get
        Set(ByVal value As String)
            DepartmentValue = value
        End Set
    End Property

    Property Number() As Integer
        Get
            Return NumberValue
        End Get
        Set(ByVal value As Integer)
            NumberValue = value
        End Set
    End Property

    Property CopurseName() As String
        Get
            Return CourseNameValue
        End Get
        Set(ByVal value As String)
            CourseNameValue = value
        End Set
    End Property

    Property SemesterHrs() As Integer
        Get
            Return SemesterHrsValue
        End Get
        Set(ByVal value As Integer)
            SemesterHrsValue = value
        End Set
    End Property

    Property Grade() As String
        Get
            Return GradeValue
        End Get
        Set(ByVal value As String)
            GradeValue = value
        End Set
    End Property

    Property MajorCourse() As String
        Get
            Return MajorCourseValue
        End Get
        Set(ByVal value As String)
            MajorCourseValue = value
        End Set
    End Property

    Property RetakeCourse() As String
        Get
            Return RetakeCourseValue
        End Get
        Set(ByVal value As String)
            RetakeCourseValue = value
        End Set
    End Property

End Class
