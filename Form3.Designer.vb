<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Info_form
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
        Me.regNumLabel = New System.Windows.Forms.Label()
        Me.RegistrationNumTextBox = New System.Windows.Forms.TextBox()
        Me.sNameLabel = New System.Windows.Forms.Label()
        Me.sNameTB = New System.Windows.Forms.TextBox()
        Me.oNamesLabel = New System.Windows.Forms.Label()
        Me.oNamesTB = New System.Windows.Forms.TextBox()
        Me.selProgLabel = New System.Windows.Forms.Label()
        Me.mobNumLabel = New System.Windows.Forms.Label()
        Me.selProgrammeCB = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.eMailTB = New System.Windows.Forms.TextBox()
        Me.mobNumTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'regNumLabel
        '
        Me.regNumLabel.AutoSize = True
        Me.regNumLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.regNumLabel.Location = New System.Drawing.Point(12, 63)
        Me.regNumLabel.Name = "regNumLabel"
        Me.regNumLabel.Size = New System.Drawing.Size(80, 13)
        Me.regNumLabel.TabIndex = 0
        Me.regNumLabel.Text = "Registration No"
        '
        'RegistrationNumTextBox
        '
        Me.RegistrationNumTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.RegistrationNumTextBox.Location = New System.Drawing.Point(98, 60)
        Me.RegistrationNumTextBox.Name = "RegistrationNumTextBox"
        Me.RegistrationNumTextBox.Size = New System.Drawing.Size(214, 20)
        Me.RegistrationNumTextBox.TabIndex = 1
        '
        'sNameLabel
        '
        Me.sNameLabel.AutoSize = True
        Me.sNameLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.sNameLabel.Location = New System.Drawing.Point(12, 137)
        Me.sNameLabel.Name = "sNameLabel"
        Me.sNameLabel.Size = New System.Drawing.Size(49, 13)
        Me.sNameLabel.TabIndex = 0
        Me.sNameLabel.Text = "Surname"
        '
        'sNameTB
        '
        Me.sNameTB.BackColor = System.Drawing.SystemColors.Info
        Me.sNameTB.Location = New System.Drawing.Point(98, 130)
        Me.sNameTB.Name = "sNameTB"
        Me.sNameTB.Size = New System.Drawing.Size(214, 20)
        Me.sNameTB.TabIndex = 1
        '
        'oNamesLabel
        '
        Me.oNamesLabel.AutoSize = True
        Me.oNamesLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.oNamesLabel.Location = New System.Drawing.Point(12, 175)
        Me.oNamesLabel.Name = "oNamesLabel"
        Me.oNamesLabel.Size = New System.Drawing.Size(69, 13)
        Me.oNamesLabel.TabIndex = 0
        Me.oNamesLabel.Text = "Other Names"
        '
        'oNamesTB
        '
        Me.oNamesTB.BackColor = System.Drawing.SystemColors.Info
        Me.oNamesTB.Location = New System.Drawing.Point(98, 172)
        Me.oNamesTB.Name = "oNamesTB"
        Me.oNamesTB.Size = New System.Drawing.Size(214, 20)
        Me.oNamesTB.TabIndex = 1
        '
        'selProgLabel
        '
        Me.selProgLabel.AutoSize = True
        Me.selProgLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.selProgLabel.Location = New System.Drawing.Point(12, 287)
        Me.selProgLabel.Name = "selProgLabel"
        Me.selProgLabel.Size = New System.Drawing.Size(60, 13)
        Me.selProgLabel.TabIndex = 0
        Me.selProgLabel.Text = "Programme"
        '
        'mobNumLabel
        '
        Me.mobNumLabel.AutoSize = True
        Me.mobNumLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.mobNumLabel.Location = New System.Drawing.Point(12, 217)
        Me.mobNumLabel.Name = "mobNumLabel"
        Me.mobNumLabel.Size = New System.Drawing.Size(55, 13)
        Me.mobNumLabel.TabIndex = 0
        Me.mobNumLabel.Text = "Mobile No"
        '
        'selProgrammeCB
        '
        Me.selProgrammeCB.BackColor = System.Drawing.SystemColors.Info
        Me.selProgrammeCB.FormattingEnabled = True
        Me.selProgrammeCB.Items.AddRange(New Object() {"INFORMATION SYSTEM", "SOFTWARE ENGINEERING", "COMPUTER ENGINEERING ", "COMPUTER SCIENCE", "INTELLIGENT SYSTEMS ENGINEERING"})
        Me.selProgrammeCB.Location = New System.Drawing.Point(98, 287)
        Me.selProgrammeCB.Name = "selProgrammeCB"
        Me.selProgrammeCB.Size = New System.Drawing.Size(214, 21)
        Me.selProgrammeCB.TabIndex = 2
        Me.selProgrammeCB.Text = "Select Programme"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.Location = New System.Drawing.Point(226, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Font = New System.Drawing.Font("Playbill", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 33)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Student Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label7.Location = New System.Drawing.Point(12, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sex"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(209, 102)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Female"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(98, 102)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Male"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.emailLabel.Location = New System.Drawing.Point(12, 254)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(32, 13)
        Me.emailLabel.TabIndex = 0
        Me.emailLabel.Text = "Email"
        '
        'eMailTB
        '
        Me.eMailTB.BackColor = System.Drawing.SystemColors.Info
        Me.eMailTB.Location = New System.Drawing.Point(98, 247)
        Me.eMailTB.Name = "eMailTB"
        Me.eMailTB.Size = New System.Drawing.Size(214, 20)
        Me.eMailTB.TabIndex = 1
        '
        'mobNumTB
        '
        Me.mobNumTB.BackColor = System.Drawing.SystemColors.Info
        Me.mobNumTB.Location = New System.Drawing.Point(98, 210)
        Me.mobNumTB.Name = "mobNumTB"
        Me.mobNumTB.Size = New System.Drawing.Size(214, 20)
        Me.mobNumTB.TabIndex = 1
        '
        'Student_Info_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(406, 393)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.selProgrammeCB)
        Me.Controls.Add(Me.mobNumTB)
        Me.Controls.Add(Me.eMailTB)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.mobNumLabel)
        Me.Controls.Add(Me.selProgLabel)
        Me.Controls.Add(Me.oNamesTB)
        Me.Controls.Add(Me.oNamesLabel)
        Me.Controls.Add(Me.sNameTB)
        Me.Controls.Add(Me.sNameLabel)
        Me.Controls.Add(Me.RegistrationNumTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.regNumLabel)
        Me.Name = "Student_Info_form"
        Me.Text = "Student_Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents regNumLabel As System.Windows.Forms.Label
    Friend WithEvents RegistrationNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sNameLabel As System.Windows.Forms.Label
    Friend WithEvents sNameTB As System.Windows.Forms.TextBox
    Friend WithEvents oNamesLabel As System.Windows.Forms.Label
    Friend WithEvents oNamesTB As System.Windows.Forms.TextBox
    Friend WithEvents selProgLabel As System.Windows.Forms.Label
    Friend WithEvents mobNumLabel As System.Windows.Forms.Label
    Friend WithEvents selProgrammeCB As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents emailLabel As System.Windows.Forms.Label
    Friend WithEvents eMailTB As System.Windows.Forms.TextBox
    Friend WithEvents mobNumTB As System.Windows.Forms.TextBox
End Class
