Public Class loginform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim user, pass As String
            user = TextBox1.Text
            pass = TextBox2.Text
            Dim dt As DataTable = login(user, pass)
            If dt.Rows.Count > 0 Then
                MsgBox("sucessfully login", vbInformation)
                Me.Dispose()
                recordform.ShowDialog()
            Else
                MsgBox("Invalid username or password", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        registerform.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class