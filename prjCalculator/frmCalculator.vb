
Public Class frmCalculator
    Dim varRealNum1 As Double
    Dim varRealNum2 As Double
    Dim varRealAns As Double
    Dim varIntNum1 As Long
    Dim varIntNum2 As Long
    Dim varIntAns As Long

    Private Sub txtNum1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNum1.TextChanged
        varRealNum1 = Val(txtNum1.Text)
        varIntNum1 = Val(txtNum1.Text)
    End Sub

    Private Sub txtNum2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNum2.TextChanged
        varRealNum2 = Val(txtNum2.Text)
        varIntNum2 = Val(txtNum2.Text)
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        varRealAns = varRealNum1 + varRealNum2
        varIntAns = varIntNum1 + varIntNum2
        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub btnSub_Click(sender As System.Object, e As System.EventArgs) Handles btnSub.Click
        varRealAns = varRealNum1 - varRealNum2
        varIntAns = varIntNum1 - varIntNum2
        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub BtnMult_Click(sender As System.Object, e As System.EventArgs) Handles BtnMult.Click
        varRealAns = varRealNum1 * varRealNum2
        varIntAns = varIntNum1 * varIntNum2
        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub btnDiv_Click(sender As System.Object, e As System.EventArgs) Handles btnDiv.Click
        If Val(txtNum2.Text) = 0 Then
            MsgBox("Can not divide by zero", MsgBoxStyle.OkOnly, "Error")
        Else
            varRealAns = varRealNum1 / varRealNum2
            varIntAns = varIntNum1 / varIntNum2
        End If

        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub btnIntDiv_Click(sender As System.Object, e As System.EventArgs) Handles btnIntDiv.Click
        If Val(txtNum2.Text) = 0 Then
            MsgBox("Can not divide by zero", MsgBoxStyle.OkOnly, "Error")
        Else
            varRealAns = varRealNum1 \ varRealNum2
            varIntAns = varIntNum1 \ varIntNum2
        End If
        
        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub btnMod_Click(sender As System.Object, e As System.EventArgs) Handles btnMod.Click
        If Val(txtNum2.Text) = 0 Then
            MsgBox("Can not divide by zero", MsgBoxStyle.OkOnly, "Error")
        Else
            varRealAns = varRealNum1 Mod varRealNum2
            varIntAns = varIntNum1 Mod varIntNum2
        End If
        
        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub btnExponental_Click(sender As System.Object, e As System.EventArgs) Handles btnExponental.Click
        varRealAns = varRealNum1 ^ varRealNum2
        varIntAns = varIntNum1 ^ varIntNum2
        txtRealAns.Text = varRealAns
        txtIntAns.Text = varIntAns
    End Sub

    Private Sub frmCalculator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
