Imports System.Data.SqlClient

Public Class ClsConsultas
    'CREANDO FUNCION "LISTAR_1
    Public Function LISTAR_1() As DataSet
        Dim Ds As New DataSet
        Dim OBJ As New ClsConexionA
        Using Cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using Cmd As New SqlCommand
                    Cn.ConnectionString = OBJ.Conexion()
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.CommandText = "usp_listar_1"
                    Cmd.Connection = Cn
                    da.SelectCommand = Cmd
                    Cn.Open()
                    da.Fill(Ds)
                    Cn.Close()
                End Using
            End Using
        End Using
        Return Ds
    End Function
    'fin listar 1

    'BUSCAR LIKE
    Public Function buscar_like_producto(ByVal Buscar As String) As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexionA
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.Conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "buscar_like"
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Buscar
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function
    'CARGAR_COMBO_depar
    Public Function Cargar_Combo_dep() As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexionA
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.Conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "pa_cargar_combo_dep"
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function
    'BUSCAR_combo_id_dep
    Public Function Buscar_Combo_dep(ByVal iddep As Integer) As DataSet
        Dim ds As New DataSet
        Dim objconexion As New ClsConexionA
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.Conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "buscar_instalacion"
                    cmd.Parameters.Add("@id_departamento", SqlDbType.Int).Value = iddep
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function
End Class
