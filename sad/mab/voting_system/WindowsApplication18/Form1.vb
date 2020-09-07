
Imports System.Data.SqlClient

Public Class Form1

    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Function checkadmin()
        Try
            connect()
            Dim a As String = "admin"
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users WHERE username =@un and password =@ps and userlevel =@ul "

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", TextBox1.Text)
            cmd.Parameters.AddWithValue("@ps", TextBox2.Text)
            cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count >= 1 Then
                userlevel = dt.Rows(0).Item("userlevel")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function

    Private Function checkuser()
        Try
            connect()
            Dim a As String = "user"
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users WHERE username =@un and password =@ps and userlevel =@ul "

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", TextBox1.Text)
            cmd.Parameters.AddWithValue("@ps", TextBox2.Text)
            cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count >= 1 Then
                userlevel = dt.Rows(0).Item("userlevel")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        AcceptButton = Button1
    End Sub

  
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Fill up all fields!")
            Form2.Show()
            Me.Hide()


        ElseIf checkadmin() = True Then
            MsgBox("Successfully Logged In")
            Me.Hide()
            dashboard2.Show()
            clear()

        ElseIf checkuser() = True Then
            MsgBox("Successfully Logged In")
            Me.Hide()
            student_voting.Show()
            clear()
        Else
            MsgBox("Invalid username and password!")
        End If
    End Sub
End Class
