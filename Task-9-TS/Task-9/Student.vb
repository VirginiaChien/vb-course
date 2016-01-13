Public Class Student

    Private mFirstName As String
    Public Property FirstName() As String
        Get
            Return mFirstName
        End Get
        Set(ByVal value As String)
            mFirstName = value
        End Set
    End Property

    Private mLastName As String
    Public Property LastName() As String
        Get
            Return mLastName
        End Get
        Set(ByVal value As String)
            mLastName = value
        End Set
    End Property

    Private mNumber As String
    Public Property Number() As String
        Get
            Return mNumber
        End Get
        Set(ByVal value As String)
            mNumber = value
        End Set
    End Property
    'mNext link to next student
    Private mNext As Student
    Public Property StNext() As Student
        Get
            Return mNext
        End Get
        Set(ByVal value As Student)
            mNext = value
        End Set
    End Property
    'mPre link to previous student
    Private mPre As Student
    Public Property StPre() As Student
        Get
            Return mPre
        End Get
        Set(ByVal value As Student)
            mPre = value
        End Set
    End Property

End Class
