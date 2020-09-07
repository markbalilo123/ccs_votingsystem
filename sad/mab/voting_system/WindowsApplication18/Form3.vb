
'import system.text

Public Class Form3
    
    'InitializeComponent()
    ' panelLeft.Height = Button1.Height
    'panelLeft.Top = Button1.Top
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Now.Date
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        panelLeft.Height = Button1.Height
        panelLeft.Top = Button1.Top
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        panelLeft.Height = Button2.Height
        panelLeft.Top = Button2.Top

        dashboard2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        panelLeft.Height = Button3.Height
        panelLeft.Top = Button3.Top
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        panelLeft.Height = Button4.Height
        panelLeft.Top = Button4.Top
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        panelLeft.Height = Button5.Height
        panelLeft.Top = Button5.Top

        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            login.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Now.Date

        


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class