Public Class RadioButton

    Private Sub Bai_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tinhBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tinhBtn.Click
        Dim so1 As String
        Dim so2 As String
        Dim ketqua As Double

        so1 = sothu1.Text
        so2 = sothu2.Text



        Dim sothunhat As Integer = Convert.ToInt32(so1)
        Dim sothuhai As Integer = Convert.ToInt32(so2)


        If congRB.Checked = True Then
            ' ============ PHÉP CỘNG  ==============
            ' ======================================
            ketqua = Integer.Parse(so1) + Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""

        ElseIf truRB.Checked = True Then
            ' ============ PHÉP TRỪ  ==============
            ' ======================================
            ketqua = Integer.Parse(so1) - Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""

        ElseIf nhanRB.Checked = True Then
            ' ============ PHÉP NHÂN  ==============
            ' ======================================
            ketqua = Integer.Parse(so1) * Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""

        ElseIf chiaRB.Checked = True Then
            ' ============ PHÉP CHIA  ==============
            ' ======================================
            ketqua = Integer.Parse(so1) / Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""

        ElseIf chialayduRB.Checked = True Then
            ' =========== PHÉP CHIA LẤY DƯ  ========
            ' ======================================
            ketqua = Integer.Parse(so1) Mod Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""

        ElseIf luythuaRB.Checked = True Then
            ' ========= PHÉP  LŨY THỪA ======
            ' ======================================
            ketqua = Integer.Parse(so1) ^ Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""

        ElseIf chialaynguyenRB.Checked = True Then
            ' =========== PHÉP  CHIA LẤY NGUYÊN  ===========
            ' ======================================
            ketqua = Integer.Parse(so1) \ Integer.Parse(so2)
            b1Lb.Text = ketqua.ToString()

            sothu1.Text = ""
            sothu2.Text = ""
        ElseIf sothu2.Text = String.Empty Then
            b1Lb.Text = "NHẬP ĐỦ 2 ĐỂ THỰC HIỆN !!!"
        ElseIf sothu1.Text = String.Empty Then
            b1Lb.Text = "NHẬP ĐỦ 2 ĐỂ THỰC HIỆN !!!"
        Else
            b1Lb.Text = "CHỌN PHÉP TOÁN BẤT KÌ ĐỂ THỰC HIỆN !!!"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ketquaDT As Double
        Dim nuaChuvi As Double


        Dim canh_1 As Double
        Dim canh_2 As Double
        Dim canh_3 As Double
        Dim canh_4 As Double

        ' ============ HÌNH CHỮ NHẬT  ==========
        ' ======================================
        If cnCb.Checked = True Then
            canh_1 = CDbl(canh1.Text)
            canh_2 = CDbl(canh2.Text)
            canh_3 = CDbl(canh3.Text)
            canh_4 = CDbl(canh4.Text)

            If canh_1 <> canh_3 Or canh_2 <> canh_4 Then
                kqHinh.Text = "Độ dài không phù hợp hình chữ nhật"
            Else
                ketquaDT = canh_1 * canh_2
                kqHinh.Text = ketquaDT.ToString()

            End If
            ' ============ HÌNH VUÔNG  ==========
            ' ======================================
        ElseIf vuongCb.Checked = True Then
            canh_1 = CDbl(canh1.Text)
            canh_2 = CDbl(canh2.Text)
            canh_3 = CDbl(canh3.Text)
            canh_4 = CDbl(canh4.Text)

            If canh_1 <> canh_2 Or canh_1 <> canh_3 Or canh_1 <> canh_4 Then
                kqHinh.Text = "Độ dài không phù hợp hình vuông"
            Else
                ketquaDT = canh_1 * canh_2
                kqHinh.Text = ketquaDT.ToString()

            End If
            ' ============ HÌNH TAM GIÁC  ==========
            ' ======================================
        ElseIf tgCb.Checked = True Then
            canh_1 = CDbl(canh1.Text)
            canh_2 = CDbl(canh2.Text)
            canh_3 = CDbl(canh3.Text)

            If canh_1 + canh_2 < canh_3 Or canh_1 + canh_3 < canh_2 Or canh_2 + canh_3 < canh_1 Then
                kqHinh.Text = "Độ dài không tạo thành tam giác"
            Else
                nuaChuvi = (canh_1 + canh_2 + canh_3) / 2
                ketquaDT = Math.Sqrt(nuaChuvi * (nuaChuvi - canh_1) * (nuaChuvi - canh_2) * (nuaChuvi - canh_3))
                kqHinh.Text = ketquaDT.ToString()

            End If

            ' ============ HÌNH TRÒN  ==========
            ' ======================================
        ElseIf tronCb.Checked = True Then
            canh_1 = CDbl(canh1.Text)

            If canh_1 < 0 Then
                kqHinh.Text = "Bán kính không phù hợp"
            Else
                ketquaDT = (canh_1 ^ 2) * 3.14
                kqHinh.Text = ketquaDT.ToString()

            End If
        Else

        End If

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnChuyenTab_Click(sender As System.Object, e As System.EventArgs) Handles btnChuyenTab.Click
        CheckListBox.Show()

    End Sub
End Class
