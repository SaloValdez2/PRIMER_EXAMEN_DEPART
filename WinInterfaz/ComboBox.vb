﻿Public Class ComboBox
    Private Sub ComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_combo()
    End Sub
    Sub cargar_combo()
        Dim objcargar As New ABDExamen.ClsConsultas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objbuscar As New ABDExamen.ClsConsultas
    End Sub
End Class