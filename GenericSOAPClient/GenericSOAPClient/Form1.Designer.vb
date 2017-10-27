<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbService = New System.Windows.Forms.TextBox()
        Me.tbBinding = New System.Windows.Forms.TextBox()
        Me.tbRequest = New System.Windows.Forms.TextBox()
        Me.tbUserID = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbTenant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRespons = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbService
        '
        Me.tbService.Location = New System.Drawing.Point(187, 11)
        Me.tbService.Name = "tbService"
        Me.tbService.Size = New System.Drawing.Size(520, 22)
        Me.tbService.TabIndex = 0
        Me.tbService.Text = "https://wd5-impl-services1.workday.com/ccx/service/elliemae/Integrations/v29.0"
        '
        'tbBinding
        '
        Me.tbBinding.Location = New System.Drawing.Point(187, 56)
        Me.tbBinding.Name = "tbBinding"
        Me.tbBinding.Size = New System.Drawing.Size(405, 22)
        Me.tbBinding.TabIndex = 1
        Me.tbBinding.Text = "Get_References"
        '
        'tbRequest
        '
        Me.tbRequest.Location = New System.Drawing.Point(12, 142)
        Me.tbRequest.Multiline = True
        Me.tbRequest.Name = "tbRequest"
        Me.tbRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbRequest.Size = New System.Drawing.Size(994, 226)
        Me.tbRequest.TabIndex = 2
        Me.tbRequest.Text = "message body"
        '
        'tbUserID
        '
        Me.tbUserID.Location = New System.Drawing.Point(187, 88)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(168, 22)
        Me.tbUserID.TabIndex = 3
        Me.tbUserID.Text = "bthill@elliemae"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(516, 91)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(169, 22)
        Me.tbPassword.TabIndex = 4
        '
        'tbTenant
        '
        Me.tbTenant.Location = New System.Drawing.Point(820, 91)
        Me.tbTenant.Name = "tbTenant"
        Me.tbTenant.Size = New System.Drawing.Size(161, 22)
        Me.tbTenant.TabIndex = 5
        Me.tbTenant.Text = "elliemae"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Service Endpoint"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Binding"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Message Body"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "UserName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(730, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tenant"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'tbRespons
        '
        Me.tbRespons.Location = New System.Drawing.Point(15, 391)
        Me.tbRespons.Multiline = True
        Me.tbRespons.Name = "tbRespons"
        Me.tbRespons.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbRespons.Size = New System.Drawing.Size(991, 102)
        Me.tbRespons.TabIndex = 12
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(463, 506)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(91, 33)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Message Response"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 551)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.tbRespons)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTenant)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUserID)
        Me.Controls.Add(Me.tbRequest)
        Me.Controls.Add(Me.tbBinding)
        Me.Controls.Add(Me.tbService)
        Me.Name = "Form1"
        Me.Text = "Generic WWS SOAP Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbService As TextBox
    Friend WithEvents tbBinding As TextBox
    Friend WithEvents tbRequest As TextBox
    Friend WithEvents tbUserID As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbTenant As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbRespons As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
End Class
