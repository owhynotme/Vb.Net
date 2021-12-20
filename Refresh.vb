 Public Sub Refreshs()

        Try

            inc = 0

            next_button.Visible = True

            If con.State = ConnectionState.Closed Then

                con.Open()

            End If

            command = New MySqlCommand("select id,first_name,ph_no from student", con)

            da = New MySqlDataAdapter(command)
            ds = New DataSet("stu")

            da.Fill(ds)

            DataGridView2.DataSource = ds.Tables(0)
            counts = ds.Tables(0).Rows.Count
            Display()
            combocheck()


        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
            con.Close()

        End Try

    End Sub