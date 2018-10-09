<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.btnCourseAdd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCourseId = New System.Windows.Forms.TextBox
        Me.txtCourseCode = New System.Windows.Forms.TextBox
        Me.txtCourseTitle = New System.Windows.Forms.TextBox
        Me.txtCrHr = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.txtTeacherID = New System.Windows.Forms.TextBox
        Me.txtStudentsID = New System.Windows.Forms.TextBox
        Me.txtRoomID = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnCourseAdd
        '
        Me.btnCourseAdd.Location = New System.Drawing.Point(149, 319)
        Me.btnCourseAdd.Name = "btnCourseAdd"
        Me.btnCourseAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCourseAdd.TabIndex = 0
        Me.btnCourseAdd.Text = "Add Course"
        Me.btnCourseAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Course ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Course Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Credit Hour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact Hour"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Teacher ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Students ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Room ID"
        '
        'txtCourseId
        '
        Me.txtCourseId.Location = New System.Drawing.Point(183, 21)
        Me.txtCourseId.Name = "txtCourseId"
        Me.txtCourseId.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseId.TabIndex = 9
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Location = New System.Drawing.Point(183, 56)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseCode.TabIndex = 10
        '
        'txtCourseTitle
        '
        Me.txtCourseTitle.Location = New System.Drawing.Point(183, 89)
        Me.txtCourseTitle.Name = "txtCourseTitle"
        Me.txtCourseTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseTitle.TabIndex = 11
        '
        'txtCrHr
        '
        Me.txtCrHr.Location = New System.Drawing.Point(183, 120)
        Me.txtCrHr.Name = "txtCrHr"
        Me.txtCrHr.Size = New System.Drawing.Size(100, 20)
        Me.txtCrHr.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(183, 152)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 13
        '
        'txtTeacherID
        '
        Me.txtTeacherID.Location = New System.Drawing.Point(183, 186)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Size = New System.Drawing.Size(100, 20)
        Me.txtTeacherID.TabIndex = 14
        '
        'txtStudentsID
        '
        Me.txtStudentsID.Location = New System.Drawing.Point(183, 228)
        Me.txtStudentsID.Name = "txtStudentsID"
        Me.txtStudentsID.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentsID.TabIndex = 15
        '
        'txtRoomID
        '
        Me.txtRoomID.Location = New System.Drawing.Point(183, 265)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomID.TabIndex = 16
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 374)
        Me.Controls.Add(Me.txtRoomID)
        Me.Controls.Add(Me.txtStudentsID)
        Me.Controls.Add(Me.txtTeacherID)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.txtCrHr)
        Me.Controls.Add(Me.txtCourseTitle)
        Me.Controls.Add(Me.txtCourseCode)
        Me.Controls.Add(Me.txtCourseId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCourseAdd)
        Me.Name = "frmCourse"
        Me.Text = "ClSc - Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCourseAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCourseId As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtCrHr As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTeacherID As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentsID As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomID As System.Windows.Forms.TextBox
End Class
