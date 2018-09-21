Public Class Hero
    Private _Name As String
    Private _Quote As String
    Private _Move1 As String
    Private _Move2 As String
    Private _Move3 As String
    Private _Move4 As String
    Private _Miss As String
    Private _PowerMove As String


    Sub New(ByVal Name As String, Quote As String, M1 As String, M2 As String, M3 As String, M4 As String, Power As String, Miss As String)
        _Name = Name
        _Quote = Quote
        _Move1 = M1
        _Move2 = M2
        _Move3 = M3
        _Move4 = M4
        _PowerMove = Power
        _Miss = Miss


    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property
    Public ReadOnly Property Quote As String
        Get
            Return _Quote
        End Get
    End Property
    Public ReadOnly Property M1 As String
        Get
            Return _Move1
        End Get
    End Property
    Public ReadOnly Property M2 As String
        Get
            Return _Move2
        End Get
    End Property
    Public ReadOnly Property M3 As String
        Get
            Return _Move3
        End Get
    End Property
    Public ReadOnly Property M4 As String
        Get
            Return _Move4
        End Get
    End Property
    Public ReadOnly Property Power As String
        Get
            Return _PowerMove
        End Get
    End Property
    Public ReadOnly Property Miss As String
        Get
            Return _Miss
        End Get
    End Property

End Class
