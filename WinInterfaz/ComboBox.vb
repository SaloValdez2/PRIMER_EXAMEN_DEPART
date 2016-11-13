Public Class ComboBox
    Private Sub ComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_combo()
    End Sub
    Sub cargar_combo()
        Dim objcargar As New ABDExamen.ClsConsultas        Dim dt As New DataTable        dt = objcargar.Cargar_Combo_dep.Tables(0)        ComboBox1.DataSource = dt        ComboBox1.ValueMember = dt.Columns(0).ToString        ComboBox1.DisplayMember = dt.Columns(1).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objbuscar As New ABDExamen.ClsConsultas        Dim DT As New DataTable        DT = objbuscar.Buscar_Combo_dep(ComboBox1.SelectedValue).Tables(0)        If DT.Rows.Count > 0 Then            DataGridView1.DataSource = DT        End If
    End Sub
End Class