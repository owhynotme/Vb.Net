Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click

Try

            If con.State = ConnectionState.Closed Then

                con.Open()

            End If

            command = New MySqlCommand("insert into student(id,first_name,ph_no)values(@id,@first_name,@ph_no)", con)
            command.Parameters.Add(New MySqlParameter("@id", Id_txt.Text))
            command.Parameters.Add(New MySqlParameter("@first_name", name_txt.Text))
            command.Parameters.Add(New MySqlParameter("@ph_no", ph_no.Text))

            da.InsertCommand = command

            da.InsertCommand.ExecuteNonQuery()
            Refreshs()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
            con.Close()

        End Try
        end sub