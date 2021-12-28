 
    Dim s As MsgBoxResult = MsgBox("Do you want to Delete ", MsgBoxStyle.YesNo)
    
            If s = MsgBoxResult.Yes Then

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                cmd = New MySqlCommand("delete from members where id = @id ", con)
                cmd.Parameters.Add(New MySqlParameter("@id", ID_txt.Text))

                da.DeleteCommand = cmd
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox("Deleted Successfully")

            Else

                MsgBox("Not deleted")

            End If