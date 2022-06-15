Imports MySql.Data.MySqlClient

Module modDataAccesslayer
    Public con As New MySqlConnection("server=localhost;database=dbcrud;uid=root;pwd='';")

    Public Sub Connect()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        Else
            con.Open()
        End If
    End Sub
    Public Function login(username As String, password As String)
        Connect()
        Dim cmd As New MySqlCommand("select * from tbl_users where username=@1 and password=@2", con)
        cmd.Parameters.AddWithValue("@1", username)
        cmd.Parameters.AddWithValue("@2", password)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt
    End Function
    Public Function register(user As String, password As String)
        Connect()
        Dim cmd As New MySqlCommand("Insert into tbl_users(username,password) values (@1,@2)", con)
        With cmd
            .Parameters.AddWithValue("@1", user)
            .Parameters.AddWithValue("@2", password)
            .ExecuteNonQuery()
        End With
        Return True
    End Function
End Module
