Imports System.Data.SqlClient

Public Class newdashboard

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(0)
        Label25.Text = "Dashboard"
        Panel6.Height = Button1.Height
        Panel6.Top = Button1.Top
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
        Label25.Text = "Student List"
        Panel6.Height = Button2.Height
        Panel6.Top = Button2.Top
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabControl1.SelectTab(2)
        Label25.Text = "Candidates List"
        Panel6.Height = Button3.Height
        Panel6.Top = Button3.Top
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectTab(3)
        Label25.Text = "Results"
        Panel6.Height = Button4.Height
        Panel6.Top = Button4.Top
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel6.Height = Button5.Height
        Panel6.Top = Button5.Top

        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            login.Show()
            Me.Hide()
        End If
    End Sub




    ' this code for student listview and add edit delete

    Private Sub newdashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.SelectTab(0)
        Label25.Text = "Dashboard"
        Panel6.Height = Button1.Height
        Panel6.Top = Button1.Top

        connect()
        userlevel = "admin"
        Label18.Text = Now.Date
        list()

        cd_list()

        connect()

        ' make function here
        lblno_of_pos.Text = 11

        Dim count As Integer
        sql = "Select fullname from tbl_candidates"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    count = count + 1
                End With
            Next
        End If
        lblno_of_cand.Text = count

        Dim count2 As Integer
        sql = "Select lastname, firstname from tbl_students"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    count2 = count2 + 1
                End With
            Next
        End If
        lblno_of_voters.Text = count2

        Dim count3 As Integer
        sql = "Select lastname, firstname from tbl_students where status='VOTED'"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    count3 = count3 + 1
                End With
            Next
        End If
        lblno_of_std_voted.Text = count3


        pbpres_int1.Maximum = lblno_of_voters.Text
        pbpres_int3.Maximum = lblno_of_voters.Text
        pbpres_ext1.Maximum = lblno_of_voters.Text
        pbpres_ext2.Maximum = lblno_of_voters.Text
        'make function for this
        connect()
        sql = "Select fullname, vote_count from tbl_candidates where position='President Internal'"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            ' For x = 0 To ds.Tables("a").Rows.Count - 1
            With ds.Tables("a")

                lblpres_int_1.Text = .Rows(0).Item("fullname").ToString
                pbpres_int1.Value = .Rows(0).Item("vote_count").ToString
                Label59.Text = .Rows(0).Item("vote_count").ToString

                lblpres_int_2.Text = .Rows(1).Item("fullname").ToString

                pbpres_int3.Value = .Rows(1).Item("vote_count").ToString
                Label61.Text = .Rows(1).Item("vote_count").ToString
            End With
            ' Next
        End If

        connect()
        sql = "Select fullname, vote_count from tbl_candidates where position='President External'"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            ' For x = 0 To ds.Tables("a").Rows.Count - 1
            With ds.Tables("a")
                lblpres_ext1.Text = .Rows(0).Item("fullname").ToString
                pbpres_ext1.Value = .Rows(0).Item("vote_count").ToString
                Label60.Text = .Rows(0).Item("vote_count").ToString

                lblpres_ext2.Text = .Rows(1).Item("fullname").ToString
                pbpres_ext2.Value = .Rows(1).Item("vote_count").ToString
                Label62.Text = .Rows(1).Item("vote_count").ToString
            End With
            ' Next
        End If





    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label18.Text = Now.Date
    End Sub

    Sub list()
        lvstudents.Items.Clear()
        connect()
        sql = "Select * from tbl_students"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    lvstudents.Items.Add(.Rows(x).Item("student_id").ToString)
                    lvstudents.Items(x).SubItems.Add(.Rows(x).Item("lastname").ToString)
                    lvstudents.Items(x).SubItems.Add(.Rows(x).Item("firstname").ToString)
                    lvstudents.Items(x).SubItems.Add(.Rows(x).Item("course").ToString)
                    lvstudents.Items(x).SubItems.Add(.Rows(x).Item("yrlevel").ToString)

                    Dim str_status As String
                    Dim result As Integer

                    str_status = .Rows(x).Item("status").ToString

                    result = String.Compare(str_status, "VOTED")
                    If result = 0 Then

                        lvstudents.Items(x).SubItems.Add(.Rows(x).Item("status").ToString)
                        lvstudents.Items(x).UseItemStyleForSubItems = False
                      
                        lvstudents.Items(x).SubItems(5).BackColor = Color.FromArgb(64, 255, 0)

                    Else
                        lvstudents.Items(x).SubItems.Add(.Rows(x).Item("status").ToString)
                        lvstudents.Items(x).UseItemStyleForSubItems = False
                        
                        lvstudents.Items(x).SubItems(5).BackColor = Color.Red
                    End If

                End With
            Next
        End If
    End Sub

    Sub locker()
        Try
            If cmdadd.Enabled = True Then
                cmdadd.Enabled = False
                cmdedit.Enabled = False
                cmddelete.Enabled = False
                cmdsave.Enabled = True
                cmdcancel.Enabled = True
                lvstudents.Enabled = False

                txtid.Enabled = True
                txtfirstname.Enabled = True
                txtlastname.Enabled = True
                cmbcourse.Enabled = True
                cmbyrlevel.Enabled = True
            Else
                cmdadd.Enabled = True
                cmdedit.Enabled = True
                cmddelete.Enabled = True
                cmdsave.Enabled = False
                cmdcancel.Enabled = False
                lvstudents.Enabled = True

                txtid.Enabled = False
                txtfirstname.Enabled = False
                txtlastname.Enabled = False
                cmbcourse.Enabled = False
                cmbyrlevel.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        locker()

        If (load_dt("SELECT student_id from tbl_students where student_id = (SELECT max(student_id) from tbl_students)", 0) = True) Then
            Dim std_id_tmp As String
            std_id_tmp = dt.Rows(0).Item("student_id").ToString
            std_id_tmp = Val(std_id_tmp) + 1
            txtid.Text = std_id_tmp

        End If


        action = True



    End Sub

    Sub clear()
        txtid.Clear()
        txtfirstname.Clear()
        txtlastname.Clear()

        cmbcourse.ResetText()
        cmbcourse.SelectedIndex = -1


        cmbyrlevel.ResetText()
        cmbyrlevel.SelectedIndex = -1

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If txtfirstname.Text = "" Or txtlastname.Text = "" Or cmbcourse.Text = "" Or cmbyrlevel.Text = "" Then
            MsgBox("Fill up all fields!")
        Else
            If action = True Then
                'ilalagay yung SAVE/ADD COMMAND MO NAINTINDIHAN?

                sql = "INSERT INTO tbl_students (lastname, firstname, course, yrlevel, status) VALUES (@ln,@fn,@c, @yrlv, @stat)"
                cmd = New SqlCommand(sql, con)

                Dim status_not_voted As String = "NOT VOTED"

                cmd.Parameters.AddWithValue("@ln", txtlastname.Text)
                cmd.Parameters.AddWithValue("@fn", txtfirstname.Text)
                cmd.Parameters.AddWithValue("@c", cmbcourse.Text)
                cmd.Parameters.AddWithValue("@yrlv", cmbyrlevel.Text)
                cmd.Parameters.AddWithValue("@stat", status_not_voted)
                'cmd.Parameters.AddWithValue("@c", txtcourse.Text)
                'cmd.Parameters.AddWithValue("@yrlv", txtyrlevel.Text)
                cmbcourse.Text = String.Empty
                cmbyrlevel.Text = String.Empty
                cmd.ExecuteNonQuery()
                'cmbcourse.Text = String.Empty
                'cmbyrlevel.Text = String.Empty
                list()
                'cmbcourse.Text = String.Empty
                'cmbyrlevel.Text = String.Empty
                'locker()

                clear()
                locker()
                MsgBox("Successfully Added!")
            Else
                'ilalagay mo yung EDIT/UPDATE COMMAND MO. NAINTINDIHAN?
                sql = "UPDATE tbl_students SET lastname=@fn1, firstname=@ln1, course=@un1, yrlevel=@ps1 WHERE student_id=@id"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@fn1", txtlastname.Text)
                cmd.Parameters.AddWithValue("@ln1", txtfirstname.Text)
                cmd.Parameters.AddWithValue("@un1", cmbcourse.Text)
                cmd.Parameters.AddWithValue("@ps1", cmbyrlevel.Text)
                cmd.Parameters.AddWithValue("@id", txtid.Text)
                cmd.ExecuteNonQuery()
                locker()
                clear()
                list()
                MsgBox("Successfully Updated!")
            End If
            End If
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        edit()
        locker()
        txtid.Enabled = False
        action = False
    End Sub

    Sub edit()
        Try
            If lvstudents.SelectedItems.Count >= 1 Then
                If load_dt("SELECT * from tbl_students WHERE student_id = '" & lvstudents.SelectedItems(0).Text & "'", 0) = True Then
                    txtid.Text = dt.Rows(0).Item("student_id").ToString
                    txtlastname.Text = dt.Rows(0).Item("lastname").ToString
                    txtfirstname.Text = dt.Rows(0).Item("firstname").ToString
                    cmbcourse.Text = dt.Rows(0).Item("course").ToString
                    cmbyrlevel.Text = dt.Rows(0).Item("yrlevel").ToString
                    'txtstatus.Text = dt.Rows(0).Item("status").ToString
                    'userlevel = dt.Rows(0).Item("userlevel").ToString
                End If
            Else
                MsgBox("Please Select Line", MsgBoxStyle.Exclamation)
                clear()
                locker()
                action = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If lvstudents.SelectedItems.Count <= 0 Then
            MsgBox("Please Select Line", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Delete Selected Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "DELETE tbl_students WHERE student_id ='" & lvstudents.SelectedItems(0).Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                list()
                MsgBox("Successfully Deleted", MsgBoxStyle.Information)
            Else
                clear()
            End If
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        If MsgBox("Discard Changes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clear()
            locker()
            action = True
        Else

        End If
    End Sub

    ' for the second listview Candidates
    ' --------------------------------=
    '
    '
    Sub cd_list()
        lvcandidates.Items.Clear()
        connect()
        sql = "Select * from tbl_candidates"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    lvcandidates.Items.Add(.Rows(x).Item("id").ToString)
                    lvcandidates.Items(x).SubItems.Add(.Rows(x).Item("fullname").ToString)
                    lvcandidates.Items(x).SubItems.Add(.Rows(x).Item("position").ToString)
                    lvcandidates.Items(x).SubItems.Add(.Rows(x).Item("partylist").ToString)
                    lvcandidates.Items(x).SubItems.Add(.Rows(x).Item("course").ToString)
                    lvcandidates.Items(x).SubItems.Add(.Rows(x).Item("yrlevel").ToString)
                    lvcandidates.Items(x).SubItems.Add(.Rows(x).Item("vote_count").ToString)
                End With
            Next
        End If
    End Sub

    Sub cd_locker()
        Try
            If cd_add.Enabled = True Then
                cd_add.Enabled = False
                cd_edit.Enabled = False
                cd_delete.Enabled = False
                cd_save.Enabled = True
                cd_cancel.Enabled = True
                lvcandidates.Enabled = False

                txt_cdid.Enabled = True
                txt_cdfullname.Enabled = True
                cmb_cdcourse.Enabled = True
                cmb_cdyrlevel.Enabled = True
                cmb_cdposition.Enabled = True
                cmb_cdpartylist.Enabled = True
            Else
                cd_add.Enabled = True
                cd_edit.Enabled = True
                cd_delete.Enabled = True
                cd_save.Enabled = False
                cd_cancel.Enabled = False
                lvcandidates.Enabled = True

                txt_cdid.Enabled = False
                txt_cdfullname.Enabled = False
                cmb_cdcourse.Enabled = False
                cmb_cdyrlevel.Enabled = False
                cmb_cdposition.Enabled = False
                cmb_cdpartylist.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd_add.Click
        cd_locker()

        cd_action = True

        If (load_dt("SELECT id from tbl_candidates where id = (SELECT max(id) from tbl_candidates)", 0) = True) Then
            Dim cd_id_tmp As String
            cd_id_tmp = dt.Rows(0).Item("id").ToString
            cd_id_tmp = Val(cd_id_tmp) + 1
            txt_cdid.Text = cd_id_tmp

        End If


    End Sub

    Sub cd_clear()
        txt_cdid.Clear()
        txt_cdfullname.Clear()

        cmb_cdcourse.ResetText()
        cmb_cdcourse.SelectedIndex = -1


        cmb_cdyrlevel.ResetText()
        cmb_cdyrlevel.SelectedIndex = -1


        cmb_cdposition.ResetText()
        cmb_cdposition.SelectedIndex = -1

        cmb_cdpartylist.ResetText()
        cmb_cdpartylist.SelectedIndex = -1
    End Sub

    Private Sub cd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd_save.Click
        If txt_cdfullname.Text = "" Or cmb_cdcourse.Text = "" Or cmb_cdyrlevel.Text = "" Or cmb_cdposition.Text = "" Or cmb_cdpartylist.Text = "" Then
            MsgBox("Fill up all fields!")
        Else
            If cd_action = True Then
                'ilalagay yung SAVE/ADD COMMAND MO NAINTINDIHAN?
                sql = "INSERT INTO tbl_candidates (fullname, course, yrlevel, position, partylist) VALUES (@fn,@co,@yrlv, @pos, @ptl)"
                cmd = New SqlCommand(sql, con)

                cmd.Parameters.AddWithValue("@fn", txt_cdfullname.Text)
                cmd.Parameters.AddWithValue("@co", cmb_cdcourse.Text)
                cmd.Parameters.AddWithValue("@yrlv", cmb_cdyrlevel.Text)
                cmd.Parameters.AddWithValue("@pos", cmb_cdposition.Text)
                cmd.Parameters.AddWithValue("@ptl", cmb_cdpartylist.Text)
                'cmd.Parameters.AddWithValue("@c", txtcourse.Text)
                'cmd.Parameters.AddWithValue("@yrlv", txtyrlevel.Text)

                cmd.ExecuteNonQuery()
                cd_list()
                cd_locker()
                cd_clear()
                MsgBox("Successfully Added!")
            Else
                'ilalagay mo yung EDIT/UPDATE COMMAND MO. NAINTINDIHAN?
                sql = "UPDATE tbl_candidates SET fullname=@fn1, course=@co1, yrlevel=@yrlv1, position=@pos1, partylist=@ptl1 WHERE id=@id"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@fn1", txt_cdfullname.Text)
                cmd.Parameters.AddWithValue("@co1", cmb_cdcourse.Text)
                cmd.Parameters.AddWithValue("@yrlv1", cmb_cdyrlevel.Text)
                cmd.Parameters.AddWithValue("@pos1", cmb_cdposition.Text)
                cmd.Parameters.AddWithValue("@ptl1", cmb_cdpartylist.Text)
                cmd.Parameters.AddWithValue("@id", txt_cdid.Text)
                cmd.ExecuteNonQuery()
                cd_locker()
                cd_clear()
                cd_list()
                MsgBox("Successfully Updated!")
            End If
        End If
    End Sub




    Private Sub cd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd_edit.Click
        func_cd_edit()
        cd_locker()
        txt_cdid.Enabled = False
        cd_action = False
    End Sub

    Sub func_cd_edit()
        Try
            If lvcandidates.SelectedItems.Count >= 1 Then
                If load_dt("SELECT * from tbl_candidates WHERE id = '" & lvcandidates.SelectedItems(0).Text & "'", 0) = True Then
                    txt_cdid.Text = dt.Rows(0).Item("id").ToString
                    txt_cdfullname.Text = dt.Rows(0).Item("fullname").ToString
                    cmb_cdcourse.Text = dt.Rows(0).Item("course").ToString
                    cmb_cdyrlevel.Text = dt.Rows(0).Item("yrlevel").ToString
                    cmb_cdposition.Text = dt.Rows(0).Item("position").ToString
                    cmb_cdpartylist.Text = dt.Rows(0).Item("partylist").ToString

                    'txtstatus.Text = dt.Rows(0).Item("status").ToString
                    'userlevel = dt.Rows(0).Item("userlevel").ToString
                End If
            Else
                MsgBox("Please Select Line", MsgBoxStyle.Exclamation)
                cd_clear()
                cd_locker()
                cd_action = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd_delete.Click
        If lvcandidates.SelectedItems.Count <= 0 Then
            MsgBox("Please Select Line", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Delete Selected Item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "DELETE tbl_candidates WHERE id ='" & lvcandidates.SelectedItems(0).Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                cd_list()
                MsgBox("Successfully Deleted", MsgBoxStyle.Information)
            Else
                cd_clear()
            End If
        End If
    End Sub


    Private Sub cd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd_cancel.Click
        If MsgBox("Discard Changes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cd_clear()
            cd_locker()
            cd_action = True
        Else

        End If
    End Sub



    Private Sub txtlastname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastname.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txtfirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstname.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_cdfullname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cdfullname.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_cdid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cdid.KeyPress
        Dim Validinputchar = "0123456789." + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        Dim Validinputchar = "0123456789." + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub



    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TabControl2.SelectTab(1)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        TabControl2.SelectTab(2)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        TabControl2.SelectTab(1)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        TabControl2.SelectTab(3)
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        TabControl2.SelectTab(2)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        TabControl2.SelectTab(4)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        TabControl2.SelectTab(3)
    End Sub
End Class