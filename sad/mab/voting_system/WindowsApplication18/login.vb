Imports System.Data.SqlClient
Public Class login

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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Fill up all fields!")

        ElseIf checkadmin() = True Then
            MsgBox("Successfully Logged In")

            newdashboard.Show()
            newdashboard.TabControl1.SelectTab(0)
            newdashboard.Label25.Text = "Dashboard"
            newdashboard.Panel6.Height = newdashboard.Button1.Height
            newdashboard.Panel6.Top = newdashboard.Button1.Top

            Me.Hide()
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Now.Date
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
        Label4.Text = Now.Date
    End Sub
End Class