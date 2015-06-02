Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    'Conexion global a la BD
    Dim conexion As String = "Data Source=192.168.1.10;Initial Catalog=Bases2;Integrated Security=False;User ID=robson2013; password=123;"
    Dim con As New SqlConnection(conexion)


    'OPERACIONES A LA BASE DE DATOS, CON CONSULTAS EXPLICITAS
    Sub Insertar()
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

    Private Sub TabVisualizar_Enter(sender As Object, e As EventArgs) Handles TabVisualizar.Enter
        Consultar()
    End Sub
End Class
