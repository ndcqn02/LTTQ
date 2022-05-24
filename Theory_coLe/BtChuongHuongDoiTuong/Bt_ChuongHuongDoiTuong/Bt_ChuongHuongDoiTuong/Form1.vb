Public Class Form1


End Class

Public Class PHANSO
    Private tu As Integer
    Private mau As Integer

    Public Sub New()
        tu = 0
        mau = 0
    End Sub

    Public Sub New(tu1 As Integer, mau1 As Integer)
        If mau1 <= 0 Then
            MsgBox("Phân số không hợp lệ")
        Else
            tu = tu1
            mau = mau1
        End If

    End Sub

    Public Sub New(ps As PHANSO)
        tu = ps.tu
        mau = ps.mau
    End Sub

    Public Property P_tu() As Integer
        Get
            Return tu
        End Get
        Set(value As Integer)
            tu = value
        End Set
    End Property


    Public Property P_mau() As Integer
        Get
            Return tu
        End Get
        Set(value As Integer)
            mau = value
        End Set
    End Property


End Class


Public Class TAMGIAC
    Private a As Double
    Private b As Double
    Private c As Double

    Public Sub New()
        a = 0
        b = 0
        c = 0
    End Sub

    Public Sub New(A As Double, B As Double, C As Double)
        If A + B < C Then
            MsgBox("Khong phai tam giac")
        ElseIf A + C < B Then
            MsgBox("Khong phai tam giac")
        End If
        End If

        If C + B < A Then
            MsgBox("Khong phai tam giac")
        End If





    End Sub
End Class
