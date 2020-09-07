<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbldate = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbcourse = New System.Windows.Forms.ComboBox
        Me.cmbyrlevel = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lvstudents = New System.Windows.Forms.ListView
        Me.student_id = New System.Windows.Forms.ColumnHeader
        Me.lastname = New System.Windows.Forms.ColumnHeader
        Me.firstname = New System.Windows.Forms.ColumnHeader
        Me.course = New System.Windows.Forms.ColumnHeader
        Me.yrlevel = New System.Windows.Forms.ColumnHeader
        Me.status = New System.Windows.Forms.ColumnHeader
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtlastname = New System.Windows.Forms.TextBox
        Me.txtfirstname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdedit = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lvcandidates = New System.Windows.Forms.ListView
        Me.cd_id = New System.Windows.Forms.ColumnHeader
        Me.cd_fullname = New System.Windows.Forms.ColumnHeader
        Me.cd_position = New System.Windows.Forms.ColumnHeader
        Me.cd_partylist = New System.Windows.Forms.ColumnHeader
        Me.cd_course = New System.Windows.Forms.ColumnHeader
        Me.cd_yrlevel = New System.Windows.Forms.ColumnHeader
        Me.cd_votecount = New System.Windows.Forms.ColumnHeader
        Me.cmb_cdcourse = New System.Windows.Forms.ComboBox
        Me.cmb_cdyrlevel = New System.Windows.Forms.ComboBox
        Me.cmb_cdposition = New System.Windows.Forms.ComboBox
        Me.cmb_cdpartylist = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_cdid = New System.Windows.Forms.TextBox
        Me.txt_cdfullname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cd_delete = New System.Windows.Forms.Button
        Me.cd_edit = New System.Windows.Forms.Button
        Me.cd_cancel = New System.Windows.Forms.Button
        Me.cd_save = New System.Windows.Forms.Button
        Me.cd_add = New System.Windows.Forms.Button
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.Label12 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 543)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(608, 16)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 17)
        Me.lbldate.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(763, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(883, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(875, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "STUDENT LIST"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmbcourse)
        Me.GroupBox2.Controls.Add(Me.cmbyrlevel)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lvstudents)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.txtlastname)
        Me.GroupBox2.Controls.Add(Me.txtfirstname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmddelete)
        Me.GroupBox2.Controls.Add(Me.cmdedit)
        Me.GroupBox2.Controls.Add(Me.cmdcancel)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdadd)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 369)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student information"
        '
        'cmbcourse
        '
        Me.cmbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BSIT", "BSCS", "ACT"})
        Me.cmbcourse.Location = New System.Drawing.Point(100, 154)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(128, 24)
        Me.cmbcourse.TabIndex = 28
        '
        'cmbyrlevel
        '
        Me.cmbyrlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyrlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbyrlevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbyrlevel.FormattingEnabled = True
        Me.cmbyrlevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbyrlevel.Location = New System.Drawing.Point(100, 190)
        Me.cmbyrlevel.Name = "cmbyrlevel"
        Me.cmbyrlevel.Size = New System.Drawing.Size(128, 24)
        Me.cmbyrlevel.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "ID:"
        '
        'lvstudents
        '
        Me.lvstudents.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvstudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvstudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.student_id, Me.lastname, Me.firstname, Me.course, Me.yrlevel, Me.status})
        Me.lvstudents.ForeColor = System.Drawing.Color.Black
        Me.lvstudents.FullRowSelect = True
        Me.lvstudents.Location = New System.Drawing.Point(280, 22)
        Me.lvstudents.Name = "lvstudents"
        Me.lvstudents.Size = New System.Drawing.Size(543, 325)
        Me.lvstudents.TabIndex = 25
        Me.lvstudents.UseCompatibleStateImageBehavior = False
        Me.lvstudents.View = System.Windows.Forms.View.Details
        '
        'student_id
        '
        Me.student_id.Text = "STUDENT ID"
        Me.student_id.Width = 111
        '
        'lastname
        '
        Me.lastname.Text = "LAST NAME"
        Me.lastname.Width = 96
        '
        'firstname
        '
        Me.firstname.Text = "FIRST NAME"
        Me.firstname.Width = 102
        '
        'course
        '
        Me.course.Text = "COURSE"
        Me.course.Width = 81
        '
        'yrlevel
        '
        Me.yrlevel.Text = "YR LEVEL"
        Me.yrlevel.Width = 76
        '
        'status
        '
        Me.status.Text = "STATUS"
        Me.status.Width = 78
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Location = New System.Drawing.Point(100, 40)
        Me.txtid.MaxLength = 255
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(128, 23)
        Me.txtid.TabIndex = 13
        '
        'txtlastname
        '
        Me.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlastname.Location = New System.Drawing.Point(100, 78)
        Me.txtlastname.MaxLength = 255
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(128, 23)
        Me.txtlastname.TabIndex = 1
        '
        'txtfirstname
        '
        Me.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfirstname.Location = New System.Drawing.Point(100, 112)
        Me.txtfirstname.MaxLength = 255
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(128, 23)
        Me.txtfirstname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Yr level:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Course:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Firstname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Lastname:"
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cmddelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmddelete.Location = New System.Drawing.Point(184, 263)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(73, 35)
        Me.cmddelete.TabIndex = 7
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdedit
        '
        Me.cmdedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cmdedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdedit.Location = New System.Drawing.Point(107, 263)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(66, 35)
        Me.cmdedit.TabIndex = 6
        Me.cmdedit.Text = "EDIT"
        Me.cmdedit.UseVisualStyleBackColor = False
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cmdcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdcancel.Location = New System.Drawing.Point(155, 304)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(73, 35)
        Me.cmdcancel.TabIndex = 9
        Me.cmdcancel.Text = "CANCEL"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cmdsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdsave.Location = New System.Drawing.Point(65, 304)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(73, 35)
        Me.cmdsave.TabIndex = 8
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdadd.Location = New System.Drawing.Point(25, 263)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(76, 35)
        Me.cmdadd.TabIndex = 5
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(875, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CANDIDATE LIST"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lvcandidates)
        Me.GroupBox3.Controls.Add(Me.cmb_cdcourse)
        Me.GroupBox3.Controls.Add(Me.cmb_cdyrlevel)
        Me.GroupBox3.Controls.Add(Me.cmb_cdposition)
        Me.GroupBox3.Controls.Add(Me.cmb_cdpartylist)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_cdid)
        Me.GroupBox3.Controls.Add(Me.txt_cdfullname)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cd_delete)
        Me.GroupBox3.Controls.Add(Me.cd_edit)
        Me.GroupBox3.Controls.Add(Me.cd_cancel)
        Me.GroupBox3.Controls.Add(Me.cd_save)
        Me.GroupBox3.Controls.Add(Me.cd_add)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(863, 384)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Candidate Information"
        '
        'lvcandidates
        '
        Me.lvcandidates.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cd_id, Me.cd_fullname, Me.cd_position, Me.cd_partylist, Me.cd_course, Me.cd_yrlevel, Me.cd_votecount})
        Me.lvcandidates.FullRowSelect = True
        Me.lvcandidates.Location = New System.Drawing.Point(262, 22)
        Me.lvcandidates.Name = "lvcandidates"
        Me.lvcandidates.Size = New System.Drawing.Size(595, 328)
        Me.lvcandidates.TabIndex = 38
        Me.lvcandidates.UseCompatibleStateImageBehavior = False
        Me.lvcandidates.View = System.Windows.Forms.View.Details
        '
        'cd_id
        '
        Me.cd_id.Text = "ID"
        '
        'cd_fullname
        '
        Me.cd_fullname.Text = "FULLNAME"
        Me.cd_fullname.Width = 100
        '
        'cd_position
        '
        Me.cd_position.Text = "POSITION"
        Me.cd_position.Width = 88
        '
        'cd_partylist
        '
        Me.cd_partylist.Text = "PARTYLIST"
        Me.cd_partylist.Width = 91
        '
        'cd_course
        '
        Me.cd_course.Text = "COURSE"
        Me.cd_course.Width = 89
        '
        'cd_yrlevel
        '
        Me.cd_yrlevel.Text = "YR LEVEL"
        Me.cd_yrlevel.Width = 104
        '
        'cd_votecount
        '
        Me.cd_votecount.Text = "VOTE COUNT"
        '
        'cmb_cdcourse
        '
        Me.cmb_cdcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cdcourse.FormattingEnabled = True
        Me.cmb_cdcourse.Items.AddRange(New Object() {"BSIT", "BSCS", "ACT"})
        Me.cmb_cdcourse.Location = New System.Drawing.Point(97, 114)
        Me.cmb_cdcourse.Name = "cmb_cdcourse"
        Me.cmb_cdcourse.Size = New System.Drawing.Size(128, 24)
        Me.cmb_cdcourse.TabIndex = 37
        '
        'cmb_cdyrlevel
        '
        Me.cmb_cdyrlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cdyrlevel.FormattingEnabled = True
        Me.cmb_cdyrlevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmb_cdyrlevel.Location = New System.Drawing.Point(97, 150)
        Me.cmb_cdyrlevel.Name = "cmb_cdyrlevel"
        Me.cmb_cdyrlevel.Size = New System.Drawing.Size(128, 24)
        Me.cmb_cdyrlevel.TabIndex = 36
        '
        'cmb_cdposition
        '
        Me.cmb_cdposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cdposition.FormattingEnabled = True
        Me.cmb_cdposition.Items.AddRange(New Object() {"President Internal", "President Enternal", "Vice President Internal", "Vice President Enternal", "Secretary", "Auditor", "Treasurer", "1st yr Representatives", "2nd yr Representatives", "3rd yr Representatives", "4th yr Representatives"})
        Me.cmb_cdposition.Location = New System.Drawing.Point(97, 185)
        Me.cmb_cdposition.Name = "cmb_cdposition"
        Me.cmb_cdposition.Size = New System.Drawing.Size(128, 24)
        Me.cmb_cdposition.TabIndex = 35
        '
        'cmb_cdpartylist
        '
        Me.cmb_cdpartylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cdpartylist.FormattingEnabled = True
        Me.cmb_cdpartylist.Items.AddRange(New Object() {"LP binay", "Duterter"})
        Me.cmb_cdpartylist.Location = New System.Drawing.Point(97, 220)
        Me.cmb_cdpartylist.Name = "cmb_cdpartylist"
        Me.cmb_cdpartylist.Size = New System.Drawing.Size(128, 24)
        Me.cmb_cdpartylist.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Partylist:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Position:"
        '
        'txt_cdid
        '
        Me.txt_cdid.Location = New System.Drawing.Point(97, 38)
        Me.txt_cdid.Name = "txt_cdid"
        Me.txt_cdid.Size = New System.Drawing.Size(128, 23)
        Me.txt_cdid.TabIndex = 28
        '
        'txt_cdfullname
        '
        Me.txt_cdfullname.Location = New System.Drawing.Point(97, 72)
        Me.txt_cdfullname.Name = "txt_cdfullname"
        Me.txt_cdfullname.Size = New System.Drawing.Size(128, 23)
        Me.txt_cdfullname.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Yr level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Course:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Fullname:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "ID:"
        '
        'cd_delete
        '
        Me.cd_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cd_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cd_delete.Location = New System.Drawing.Point(183, 274)
        Me.cd_delete.Name = "cd_delete"
        Me.cd_delete.Size = New System.Drawing.Size(73, 35)
        Me.cd_delete.TabIndex = 18
        Me.cd_delete.Text = "DELETE"
        Me.cd_delete.UseVisualStyleBackColor = False
        '
        'cd_edit
        '
        Me.cd_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cd_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cd_edit.Location = New System.Drawing.Point(106, 274)
        Me.cd_edit.Name = "cd_edit"
        Me.cd_edit.Size = New System.Drawing.Size(66, 35)
        Me.cd_edit.TabIndex = 17
        Me.cd_edit.Text = "EDIT"
        Me.cd_edit.UseVisualStyleBackColor = False
        '
        'cd_cancel
        '
        Me.cd_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cd_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cd_cancel.Location = New System.Drawing.Point(154, 315)
        Me.cd_cancel.Name = "cd_cancel"
        Me.cd_cancel.Size = New System.Drawing.Size(73, 35)
        Me.cd_cancel.TabIndex = 20
        Me.cd_cancel.Text = "CANCEL"
        Me.cd_cancel.UseVisualStyleBackColor = False
        '
        'cd_save
        '
        Me.cd_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cd_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cd_save.Location = New System.Drawing.Point(64, 315)
        Me.cd_save.Name = "cd_save"
        Me.cd_save.Size = New System.Drawing.Size(73, 35)
        Me.cd_save.TabIndex = 19
        Me.cd_save.Text = "SAVE"
        Me.cd_save.UseVisualStyleBackColor = False
        '
        'cd_add
        '
        Me.cd_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cd_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cd_add.Location = New System.Drawing.Point(24, 274)
        Me.cd_add.Name = "cd_add"
        Me.cd_add.Size = New System.Drawing.Size(76, 35)
        Me.cd_add.TabIndex = 16
        Me.cd_add.Text = "ADD"
        Me.cd_add.UseVisualStyleBackColor = False
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "PARTY LIST"
        Me.ColumnHeader15.Width = 95
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "POSITION"
        Me.ColumnHeader16.Width = 106
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "LAST NAME"
        Me.ColumnHeader17.Width = 103
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "FIRSTNAME"
        Me.ColumnHeader18.Width = 96
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "COURSE"
        Me.ColumnHeader19.Width = 99
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "YR LEVEL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(835, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Label12"
        '
        'Timer1
        '
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(68, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 18)
        Me.Label14.TabIndex = 4
        '
        'dashboard2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(920, 564)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdedit As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_cdpartylist As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cdid As System.Windows.Forms.TextBox
    Friend WithEvents txt_cdfullname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cd_delete As System.Windows.Forms.Button
    Friend WithEvents cd_edit As System.Windows.Forms.Button
    Friend WithEvents cd_cancel As System.Windows.Forms.Button
    Friend WithEvents cd_save As System.Windows.Forms.Button
    Friend WithEvents cd_add As System.Windows.Forms.Button
    Friend WithEvents cmb_cdposition As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lvstudents As System.Windows.Forms.ListView
    Friend WithEvents student_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents lastname As System.Windows.Forms.ColumnHeader
    Friend WithEvents firstname As System.Windows.Forms.ColumnHeader
    Friend WithEvents course As System.Windows.Forms.ColumnHeader
    Friend WithEvents yrlevel As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbyrlevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cdcourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cdyrlevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvcandidates As System.Windows.Forms.ListView
    Friend WithEvents cd_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents cd_fullname As System.Windows.Forms.ColumnHeader
    Friend WithEvents cd_position As System.Windows.Forms.ColumnHeader
    Friend WithEvents cd_partylist As System.Windows.Forms.ColumnHeader
    Friend WithEvents cd_course As System.Windows.Forms.ColumnHeader
    Friend WithEvents cd_yrlevel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cd_votecount As System.Windows.Forms.ColumnHeader
End Class
