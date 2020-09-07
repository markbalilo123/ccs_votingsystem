Imports System.Data.SqlClient

Public Class student_voting
    Private Sub student_voting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label10.Text = Now.Date
        connect()
        fill_all_cmb()
        GroupBox3.Enabled = False
        GroupBox10.Enabled = False
        AcceptButton = Button2
    End Sub

    'we must add 2 label for function parameters
    Public Sub cmbfill(ByVal sql_pos As String, ByVal cmb_name As ComboBox)
        connect()

        sql = "Select id,fullname from tbl_candidates where position in" & sql_pos
        adp = New SqlDataAdapter(sql, con)
        dt = New DataTable
        '  adp.Parameters.AddWithValue("@pos", sql_pos.Text)
        adp.Fill(dt)
        If dt.Rows.Count > 0 Then
            ' Label10.Text = dt.Rows(0).Item("id")
            With cmb_name
                .Items.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    .Items.Add(dt.Rows(i).Item("fullname"))
                Next
                .SelectedIndex = -1
            End With
        End If

        'With con
        '.Close()
        '.Dispose()
        'End With
        'con = Nothing

        'dt.Dispose()

    End Sub

    Public Sub fill_all_cmb()
        connect()

        Dim pos_presinternal As String = "('President Internal')"
        'Label10.Text = dt.Rows(0).Item("id")
        Dim pos_presexternal As String = "('President External')"
        Dim pos_vpinternal As String = "('Vice President Internal')"
        Dim pos_vpexternal As String = "('Vice President External')"
        Dim pos_sec As String = "('Secretary')"
        Dim pos_aud As String = "('Auditor')"
        Dim pos_treas As String = "('Treasurer')"
        Dim pos_yr_one_rep As String = "('1st yr Representative')"
        Dim pos_yr_two_rep As String = "('2nd yr Representative')"
        Dim pos_yr_three_rep As String = "('3rd yr Representative')"
        Dim pos_yr_four_rep As String = "('1st yr Representative')"


        cmbfill(pos_presinternal, cmb_presinternal)
        cmbfill(pos_presexternal, cmb_presexternal)
        cmbfill(pos_vpinternal, cmb_vpinternal)
        cmbfill(pos_vpexternal, cmb_vpexternal)
        cmbfill(pos_sec, cmb_sec)
        cmbfill(pos_aud, cmb_auditor)
        cmbfill(pos_treas, cmb_treasurer)

        'With con
        '.Close()
        '.Dispose()
        'End With
        'con = Nothing

        'dt.Dispose()
    End Sub

    Public Sub clear_all_value_of_combobox()
        'for clearing president internal
        cmb_presinternal.ResetText()
        cmb_presinternal.SelectedIndex = -1


        cmb_presexternal.ResetText()
        cmb_presexternal.SelectedIndex = -1


        cmb_vpinternal.ResetText()
        cmb_vpinternal.SelectedIndex = -1

        cmb_vpexternal.ResetText()
        cmb_vpexternal.SelectedIndex = -1

        cmb_sec.ResetText()
        cmb_sec.SelectedIndex = -1

        cmb_auditor.ResetText()
        cmb_auditor.SelectedIndex = -1

        cmb_treasurer.ResetText()
        cmb_treasurer.SelectedIndex = -1

    End Sub




    Public Sub clear_std_info()
        txtstudent_no.Clear()
        txtstdlastname.Clear()
        txtstdfirstname.Clear()
        txtstdcourse.Clear()
        txtstdyrlevel.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If txtstudent_no.Text = "" Then
        'MsgBox("Fill up all fields!")
        'Else
        If load_dt("SELECT lastname,firstname, course, yrlevel,status from tbl_students WHERE student_id = '" & txtstudent_no.Text & "'", 0) = True Then
            ' MsgBox("Welcome students you may now cast your VOTE!")
            Dim stat_check As String
            Dim result As Integer

            'TextBox2.Text = dt.Rows(0).Item("lastname").ToString


            stat_check = dt.Rows(0).Item("status").ToString
            'txtstudent_no.Enabled = False
            'Button2.Enabled = False
            'TextBox2.Enabled = False
            result = String.Compare(stat_check, "VOTED")
            If result = 0 Then
                MsgBox("Already Voted!")
                txtstudent_no.Clear()
                'TextBox2.Clear()
                GroupBox2.Enabled = True
                GroupBox3.Enabled = False
            Else
                GroupBox10.Enabled = True
                txtstdlastname.Text = dt.Rows(0).Item("lastname").ToString
                txtstdfirstname.Text = dt.Rows(0).Item("firstname").ToString
                txtstdcourse.Text = dt.Rows(0).Item("course").ToString
                txtstdyrlevel.Text = dt.Rows(0).Item("yrlevel").ToString

                ' Disable the student information textbox
                txtstdlastname.Enabled = False
                txtstdfirstname.Enabled = False
                txtstdcourse.Enabled = False
                txtstdyrlevel.Enabled = False

                MsgBox("Welcome students you may now cast your VOTE!")

                txtstudent_no.Enabled = False
                Button2.Enabled = False
                'TextBox2.Enabled = False
                GroupBox3.Enabled = True
            End If
        Else
            MsgBox("Invalid student ID!")
        End If
    End Sub

    Public Sub add_votes_to_candidates(ByVal pos_of_candidates As ComboBox)
        If load_dt("SELECT vote_count from tbl_candidates WHERE fullname = '" & pos_of_candidates.Text & "'", 0) = True Then
            Dim add_vote1 As String = dt.Rows(0).Item("vote_count").ToString
            Dim vc_try As Integer = Val(add_vote1) + 1
            sql = "UPDATE tbl_candidates SET vote_count=@vca WHERE fullname=@fn"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@vca", vc_try)
            cmd.Parameters.AddWithValue("@fn", pos_of_candidates.Text)
            cmd.ExecuteNonQuery()

            ' GroupBox2.Enabled = True
        Else
            MsgBox("Error! no column vote_count")
        End If
    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cmb_presinternal.Text = "" Or cmb_presexternal.Text = "" Or cmb_vpinternal.Text = "" Or cmb_vpinternal.Text = "" Or cmb_sec.Text = "" Or cmb_auditor.Text = "" Then
            MsgBox("Fill up all fields!")
        ElseIf MsgBox("Are you sure you want to cast your vote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'GroupBox3.Enabled = False
            'txtstudent_no.Clear()
            'Button2.Enabled = True
            'TextBox2.Clear()
            ' cmb_presinternal.ResetText()
            ' cmb_presinternal.SelectedIndex = -1

            Dim status_voted As String = "VOTED"

            sql = "UPDATE tbl_students SET president_internal=@pi, president_external=@pex, vice_president_internal=@vpi, vice_president_external=@vpex, secretary=@sec, auditor=@aud, treasurer=@tr, status=@stat WHERE student_id=@id"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", txtstudent_no.Text)
            cmd.Parameters.AddWithValue("@pi", cmb_presinternal.Text)
            cmd.Parameters.AddWithValue("@pex", cmb_presexternal.Text)
            cmd.Parameters.AddWithValue("@vpi", cmb_vpinternal.Text)
            cmd.Parameters.AddWithValue("@vpex", cmb_vpexternal.Text)
            cmd.Parameters.AddWithValue("@sec", cmb_sec.Text)
            cmd.Parameters.AddWithValue("@aud", cmb_auditor.Text)
            cmd.Parameters.AddWithValue("@tr", cmb_treasurer.Text)
            cmd.Parameters.AddWithValue("@stat", status_voted)

            cmd.ExecuteNonQuery()

            MsgBox("Thank you for Voting!")
            ' This code will add vote to our candidates
            add_votes_to_candidates(cmb_presinternal)
            add_votes_to_candidates(cmb_presexternal)
            add_votes_to_candidates(cmb_vpinternal)
            add_votes_to_candidates(cmb_vpexternal)
            add_votes_to_candidates(cmb_sec)
            add_votes_to_candidates(cmb_auditor)
            add_votes_to_candidates(cmb_treasurer)

            ' make function clear all combo box
            clear_all_value_of_combobox()
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            clear_std_info()
            Button2.Enabled = True
            txtstudent_no.Enabled = True
            newdashboard.list()
            newdashboard.cd_list()
            'TextBox2.Clear()

        End If
         
    End Sub

   

    Private Sub txtstudent_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstudent_no.KeyPress
        Dim Validinputchar = "0123456789." + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label10.Text = Now.Date
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtstudent_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudent_no.TextChanged

    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            login.Show()
            Me.Hide()
        End If
        clear_all_value_of_combobox()
        txtstudent_no.Clear()
    End Sub
End Class
