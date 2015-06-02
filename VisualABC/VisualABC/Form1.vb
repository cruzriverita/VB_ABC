Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    'Conexion global a la BD
    Dim conexion As String = "Data Source=192.168.1.10;Initial Catalog=Bases2;Integrated Security=False;User ID=robson2013; password=123;"
    Dim con As New SqlConnection(conexion)


    'OPERACIONES A LA BASE DE DATOS, CON CONSULTAS EXPLICITAS
    Sub Insertar()
        Try

            Dim query As String = "INSERT INTO Cliente (nombre,dpi) VALUES (@nombre,@dpi)"
            Dim command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@nombre", TextNombre.Text)
            command.Parameters.AddWithValue("@dpi", TextDPI.Text)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Exito!!")

        Catch ex As Exception
            MessageBox.Show("error" + ex.ToString())
        End Try



    End Sub

    Sub Consultar()
        con.Open()
        Dim strQuery As String = "select * from cliente"
        Dim cmd As New SqlCommand(strQuery)
        Dim DA As New SqlDataAdapter(strQuery, conexion)
        Dim DT As New DataTable
        DA.Fill(DT)
        DataGridView1.DataSource = DT
        con.Close()
    End Sub

    Sub actualizar()
        Try
            Dim query As String = "update cliente set nombre=@nombre, dpi = @dpi where id=@id"

            Dim command As New SqlCommand(query, con)

            command.Parameters.AddWithValue("@nombre", TextBox2.Text)

            command.Parameters.AddWithValue("@dpi", TextBox1.Text)

            command.Parameters.AddWithValue("@id", TextBox3.Text)

            con.Open()
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("ACTUALIZADO!!")

        Catch ex As Exception
            MessageBox.Show("error" + ex.ToString())
        End Try

    End Sub

    Sub eliminar()

        Try

            Dim query As String = "DELETE FROM cliente WHERE id=@id;"

            Dim command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@id", TextBox4.Text)

            Dim result As Integer = MessageBox.Show("Eliminar Registro?", "Warning", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                con.Open()
                command.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("BORRADO!!!!")
            End If



        Catch ex As Exception

            MessageBox.Show("error" + ex.ToString())
        End Try
    End Sub
    Sub cargar(ByVal combo As ComboBox, ByVal consulta As String)
        Dim comando As New SqlCommand()
        Dim lector As SqlDataReader
        combo.Items.Clear()
        Try

            comando.Connection = con
            comando.CommandText = consulta
            con.Open()
            lector = comando.ExecuteReader()
            While (lector.Read())

                Try
                    combo.Items.Add(lector.GetString(0))
                Catch ex As Exception

                End Try


            End While
            con.Close()
            comando.Dispose()

        Catch ex As SqlException

            MessageBox.Show("error de lectura" + ex.ToString())
        End Try


    End Sub


    Private Sub TabVisualizar_Enter(sender As Object, e As EventArgs) Handles TabVisualizar.Enter
        Consultar()
    End Sub

    Private Sub ButtonInsertar_Click(sender As Object, e As EventArgs) Handles ButtonInsertar.Click
        Insertar()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar()
    End Sub

    Private Sub ComboActualizar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboActualizar.SelectedIndexChanged
        Try

            Dim adapter As SqlDataAdapter
            Dim command As New SqlCommand()
            Dim param As SqlParameter
            Dim ds As New DataSet()

            command.Connection = con
            command.CommandType = CommandType.Text
            command.CommandText = "select id,nombre,dpi from cliente where nombre = @nombre"

            'parametros 
            param = New SqlParameter("@nombre", ComboActualizar.Text)
            param.Direction = ParameterDirection.Input
            param.DbType = DbType.String
            command.Parameters.Add(param)

            'llenar adaptador
            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)

            TextBox3.Text = ds.Tables(0).Rows(0)(0).ToString()
            TextBox2.Text = ds.Tables(0).Rows(0)(1).ToString()
            TextBox1.Text = ds.Tables(0).Rows(0)(2).ToString()

        Catch Ex As Exception
        End Try

    End Sub

    Private Sub TabActualizar_Enter(sender As Object, e As EventArgs) Handles TabActualizar.Enter
        cargar(ComboActualizar, "select nombre from cliente")
    End Sub

    Private Sub TabEliminar_Enter(sender As Object, e As EventArgs) Handles TabEliminar.Enter
        cargar(ComboDelete, "select nombre from cliente")
    End Sub

    Private Sub ComboDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDelete.SelectedIndexChanged
        Try

            Dim adapter As SqlDataAdapter
            Dim command As New SqlCommand()
            Dim param As SqlParameter
            Dim ds As New DataSet()

            command.Connection = con
            command.CommandType = CommandType.Text
            command.CommandText = "select id,nombre,dpi from cliente where nombre = @nombre"

            'parametros 
            param = New SqlParameter("@nombre", ComboDelete.Text)
            param.Direction = ParameterDirection.Input
            param.DbType = DbType.String
            command.Parameters.Add(param)

            'llenar adaptador
            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)

            TextBox4.Text = ds.Tables(0).Rows(0)(0).ToString()
            TextBox6.Text = ds.Tables(0).Rows(0)(1).ToString()
            TextBox5.Text = ds.Tables(0).Rows(0)(2).ToString()

        Catch Ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        eliminar()

    End Sub
End Class
