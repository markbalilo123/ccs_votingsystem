
Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("Data Source=AWE-6C8F7D502C7\SQLEXPRESS;Initial Catalog=db_votingsystem;Integrated Security=True")
    Public adp As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public dt As New DataTable
    Public ds As New DataSet
    Public sql As String
    Public userlevel As String
    Public action As Boolean

    'This cd action is a new action fr our candidates
    ' this will be use instead of action in the up
    Public cd_action As Boolean
    Public param_name(10) As String
    Public param_values(10) As String
    Public Sub connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Public Function load_dt(ByVal query As String, ByVal number_of_parameter As Integer) As Boolean
        Try
            Using cmd
                Using adp
                    connect()
                    cmd = New SqlClient.SqlCommand(query, con)
                    With cmd.Parameters
                        .Clear()
                        For i = 0 To number_of_parameter - 1
                            .AddWithValue(param_name(i), param_values(i))
                        Next
                    End With
                    adp = New SqlClient.SqlDataAdapter(cmd)
                    Using dt
                        dt = New DataTable
                        adp.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Return True
                            Exit Function
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module