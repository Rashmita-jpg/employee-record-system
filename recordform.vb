Public Class recordform
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Try
            create("INSERT INTO employee(firstname,lastname,age,address,phoneno,gmail,position) VALUES('" & firstname.Text & "','" & lastname.Text & "','" & age.Text & "','" & address.Text & "','" & phoneno.Text & "','" & gmail.Text & "','" & position.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        empid.Text = ""
        firstname.Clear()
        lastname.Clear()
        age.Clear()
        address.Clear()
        phoneno.Clear()
        gmail.Clear()
        position.Clear()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            updates("UPDATE employee SET firstname='" & firstname.Text & "', lastname='" & lastname.Text & "', age='" & age.Text & "', address='" & address.Text & "', phoneno='" & phoneno.Text & "', gmail='" & gmail.Text & "', position='" & position.Text & "' WHERE empid='" & empid.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            delete("DELETE FROM employee WHERE empid='" & empid.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        empid.Text = DataGridView1.CurrentRow.Cells(0).Value
        firstname.Text = DataGridView1.CurrentRow.Cells(1).Value
        lastname.Text = DataGridView1.CurrentRow.Cells(2).Value
        age.Text = DataGridView1.CurrentRow.Cells(3).Value
        address.Text = DataGridView1.CurrentRow.Cells(4).Value
        phoneno.Text = DataGridView1.CurrentRow.Cells(5).Value
        gmail.Text = DataGridView1.CurrentRow.Cells(6).Value
        position.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub

    Private Sub dateofbirth_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        Try
            reload("SELECT * FROM employee", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles firstname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lastname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub phoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneno.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub gmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gmail.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "@."
            If Not allowednos.Contains(e.KeyChar.ToString) And Not allowedchars.Contains(e.KeyChar.ToString) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a valid email")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub position_KeyPress(sender As Object, e As KeyPressEventArgs) Handles position.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles address.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub empid_TextChanged(sender As Object, e As EventArgs) Handles empid.TextChanged
        empid.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        loginform.Show()
        Me.Hide()
    End Sub
End Class
