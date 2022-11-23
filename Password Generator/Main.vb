Imports System.Collections
Imports System.Windows.Forms

Public Class Main
    Dim ps As New ArrayList
    Dim r As New Random
    Dim pn As Integer
    Dim p0() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Dim p1() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim p2() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Dim p3() As String = {"`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=", "{", "}", "[", "]", "\", "|", ":", ";", """", "'", "<", ">", ",", ".", "?", "/"}
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ps.Clear()
        With CP
            .Items.Add("英小字")
            .Items.Add("英大字")
            .Items.Add("数字")
            .Items.Add("記号")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub BCA_Click(sender As Object, e As EventArgs) Handles BCA.Click
        If TUC.Text <> "" Then
            If ps.Contains(TUC.Text) Then
                MessageBox.Show("既に追加された文字です。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TUC.Clear()
            Else
                ps.Add(TUC.Text)
                ps.Sort()
                TUC.Clear()
                TUS.Clear()
                For i = 0 To ps.Count - 1
                    TUS.AppendText(ps(i))
                Next
            End If
        End If
    End Sub

    Private Sub BCD_Click(sender As Object, e As EventArgs) Handles BCD.Click
        If TUC.Text <> "" Then
            If ps.Contains(TUC.Text) Then
                ps.Remove(TUC.Text)
                TUC.Clear()
                TUS.Clear()
                For i = 0 To ps.Count - 1
                    TUS.AppendText(ps(i))
                Next
            Else
                MessageBox.Show("追加されていない文字です。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TUC.Clear()
            End If
        End If
    End Sub

    Private Sub BCR_Click(sender As Object, e As EventArgs) Handles BCR.Click
        ps.Clear()
        TUS.Clear()
    End Sub

    Private Sub BPA_Click(sender As Object, e As EventArgs) Handles BPA.Click
        If CP.SelectedIndex = 0 Then
            For Each s In p0
                If Not ps.Contains(s) Then
                    ps.Add(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        ElseIf CP.SelectedIndex = 1 Then
            For Each s In p1
                If Not ps.Contains(s) Then
                    ps.Add(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        ElseIf CP.SelectedIndex = 2 Then
            For Each s In p2
                If Not ps.Contains(s) Then
                    ps.Add(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        ElseIf CP.SelectedIndex = 3 Then
            For Each s In p3
                If Not ps.Contains(s) Then
                    ps.Add(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        End If
    End Sub

    Private Sub BPD_Click(sender As Object, e As EventArgs) Handles BPD.Click
        If CP.SelectedIndex = 0 Then
            For Each s In p0
                If ps.Contains(s) Then
                    ps.Remove(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        ElseIf CP.SelectedIndex = 1 Then
            For Each s In p1
                If ps.Contains(s) Then
                    ps.Remove(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        ElseIf CP.SelectedIndex = 2 Then
            For Each s In p2
                If ps.Contains(s) Then
                    ps.Remove(s)
                End If
            Next
            ps.Sort()
            TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        ElseIf CP.SelectedIndex = 3 Then
            For Each s In p3
                    If ps.Contains(s) Then
                        ps.Remove(s)
                    End If
                Next
                ps.Sort()
                TUS.Clear()
            For i = 0 To ps.Count - 1
                TUS.AppendText(ps(i))
            Next
        End If
    End Sub

    Private Sub BPG_Click(sender As Object, e As EventArgs) Handles BPG.Click
        TGP.Clear()
        If IsNumeric(TPL.Text) Then
            If ps.Count > 0 Then
                For i As Integer = 0 To CInt(TPL.Text) - 1
                    If i Mod 10 = 0 Then
                        Application.DoEvents()
                    End If
                    pn = r.Next(ps.Count)
                    TGP.AppendText(ps(pn))
                Next
            Else
                MessageBox.Show("使用する文字を一つ以上指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            MessageBox.Show("数字を入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub TUC_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles TUC.KeyDown
        If e.KeyData = Keys.Enter Then
            BCA.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            BCD.PerformClick()
        End If
    End Sub

    Private Sub TPL_KeyDown(sender As Object, e As KeyEventArgs) Handles TPL.KeyDown
        If e.KeyData = Keys.Enter Then
            BPG.PerformClick()
        End If
    End Sub
End Class