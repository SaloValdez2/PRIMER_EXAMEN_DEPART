Public Class BuscarLike

    

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim objbuscar As New ABDExamen.ClsConsultas
        DataGridView1.DataSource = objbuscar.buscar_like_producto(Me.TextBox1.Text.Trim).Tables(0)
    End Sub
End Class