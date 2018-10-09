<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRoomId = New System.Windows.Forms.TextBox
        Me.txtRoomNumber = New System.Windows.Forms.TextBox
        Me.txtRoomSize = New System.Windows.Forms.TextBox
        Me.btnRoomAdd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room Size"
        '
        'txtRoomId
        '
        Me.txtRoomId.Location = New System.Drawing.Point(159, 46)
        Me.txtRoomId.Name = "txtRoomId"
        Me.txtRoomId.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomId.TabIndex = 4
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(159, 86)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomNumber.TabIndex = 5
        '
        'txtRoomSize
        '
        Me.txtRoomSize.Location = New System.Drawing.Point(159, 129)
        Me.txtRoomSize.Name = "txtRoomSize"
        Me.txtRoomSize.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomSize.TabIndex = 6
        '
        'btnRoomAdd
        '
        Me.btnRoomAdd.Location = New System.Drawing.Point(122, 185)
        Me.btnRoomAdd.Name = "btnRoomAdd"
        Me.btnRoomAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnRoomAdd.TabIndex = 7
        Me.btnRoomAdd.Text = "Add Room"
        Me.btnRoomAdd.UseVisualStyleBackColor = True
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 255)
        Me.Controls.Add(Me.btnRoomAdd)
        Me.Controls.Add(Me.txtRoomSize)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.txtRoomId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRoom"
        Me.Text = "ClSc - Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRoomId As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomSize As System.Windows.Forms.TextBox
    Friend WithEvents btnRoomAdd As System.Windows.Forms.Button

End Class
