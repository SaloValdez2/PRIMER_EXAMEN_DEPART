Public Class Listar1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New ABDExamen.ClsConsultas
        DataGridView1.DataSource = obj.LISTAR_1.Tables(0)
    End Sub
End Class
