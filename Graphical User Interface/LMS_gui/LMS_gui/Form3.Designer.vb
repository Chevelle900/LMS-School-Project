﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_course1 = New System.Windows.Forms.Button()
        Me.btn_course2 = New System.Windows.Forms.Button()
        Me.btn_course3 = New System.Windows.Forms.Button()
        Me.btn_course4 = New System.Windows.Forms.Button()
        Me.Course1Label = New System.Windows.Forms.Label()
        Me.Course2Label = New System.Windows.Forms.Label()
        Me.Course3Label = New System.Windows.Forms.Label()
        Me.Course4Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(339, 289)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 23)
        Me.btn_logout.TabIndex = 0
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_course1
        '
        Me.btn_course1.Location = New System.Drawing.Point(194, 41)
        Me.btn_course1.Name = "btn_course1"
        Me.btn_course1.Size = New System.Drawing.Size(137, 38)
        Me.btn_course1.TabIndex = 1
        Me.btn_course1.Text = "Theory of Computation"
        Me.btn_course1.UseVisualStyleBackColor = True
        '
        'btn_course2
        '
        Me.btn_course2.Location = New System.Drawing.Point(194, 97)
        Me.btn_course2.Name = "btn_course2"
        Me.btn_course2.Size = New System.Drawing.Size(137, 38)
        Me.btn_course2.TabIndex = 2
        Me.btn_course2.Text = "Digital Logic"
        Me.btn_course2.UseVisualStyleBackColor = True
        '
        'btn_course3
        '
        Me.btn_course3.Location = New System.Drawing.Point(194, 154)
        Me.btn_course3.Name = "btn_course3"
        Me.btn_course3.Size = New System.Drawing.Size(137, 38)
        Me.btn_course3.TabIndex = 3
        Me.btn_course3.Text = "Software Engineering"
        Me.btn_course3.UseVisualStyleBackColor = True
        '
        'btn_course4
        '
        Me.btn_course4.Location = New System.Drawing.Point(194, 213)
        Me.btn_course4.Name = "btn_course4"
        Me.btn_course4.Size = New System.Drawing.Size(137, 38)
        Me.btn_course4.TabIndex = 4
        Me.btn_course4.Text = "Operating Systems"
        Me.btn_course4.UseVisualStyleBackColor = True
        '
        'Course1Label
        '
        Me.Course1Label.AutoSize = True
        Me.Course1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course1Label.Location = New System.Drawing.Point(78, 49)
        Me.Course1Label.Name = "Course1Label"
        Me.Course1Label.Size = New System.Drawing.Size(110, 20)
        Me.Course1Label.TabIndex = 5
        Me.Course1Label.Text = "Course Name:"
        '
        'Course2Label
        '
        Me.Course2Label.AutoSize = True
        Me.Course2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course2Label.Location = New System.Drawing.Point(78, 105)
        Me.Course2Label.Name = "Course2Label"
        Me.Course2Label.Size = New System.Drawing.Size(110, 20)
        Me.Course2Label.TabIndex = 6
        Me.Course2Label.Text = "Course Name:"
        '
        'Course3Label
        '
        Me.Course3Label.AutoSize = True
        Me.Course3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course3Label.Location = New System.Drawing.Point(78, 162)
        Me.Course3Label.Name = "Course3Label"
        Me.Course3Label.Size = New System.Drawing.Size(110, 20)
        Me.Course3Label.TabIndex = 7
        Me.Course3Label.Text = "Course Name:"
        '
        'Course4Label
        '
        Me.Course4Label.AutoSize = True
        Me.Course4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course4Label.Location = New System.Drawing.Point(78, 221)
        Me.Course4Label.Name = "Course4Label"
        Me.Course4Label.Size = New System.Drawing.Size(110, 20)
        Me.Course4Label.TabIndex = 8
        Me.Course4Label.Text = "Course Name:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 337)
        Me.Controls.Add(Me.Course4Label)
        Me.Controls.Add(Me.Course3Label)
        Me.Controls.Add(Me.Course2Label)
        Me.Controls.Add(Me.Course1Label)
        Me.Controls.Add(Me.btn_course4)
        Me.Controls.Add(Me.btn_course3)
        Me.Controls.Add(Me.btn_course2)
        Me.Controls.Add(Me.btn_course1)
        Me.Controls.Add(Me.btn_logout)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_course1 As Button
    Friend WithEvents btn_course2 As Button
    Friend WithEvents btn_course3 As Button
    Friend WithEvents btn_course4 As Button
    Friend WithEvents Course1Label As Label
    Friend WithEvents Course2Label As Label
    Friend WithEvents Course3Label As Label
    Friend WithEvents Course4Label As Label
End Class
