<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_uname = New TextBox()
        txt_pwd = New TextBox()
        btn_login = New Button()
        btn_close = New Button()
        combo_usertype = New ComboBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(139, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 37)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(35, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(35, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 21)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' txt_uname
        ' 
        txt_uname.Location = New Point(139, 92)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(182, 23)
        txt_uname.TabIndex = 3
        ' 
        ' txt_pwd
        ' 
        txt_pwd.Location = New Point(139, 127)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.Size = New Size(182, 23)
        txt_pwd.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.Location = New Point(139, 219)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 35)
        btn_login.TabIndex = 5
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_close
        ' 
        btn_close.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.Location = New Point(246, 219)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 35)
        btn_close.TabIndex = 6
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' combo_usertype
        ' 
        combo_usertype.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        combo_usertype.FormattingEnabled = True
        combo_usertype.Items.AddRange(New Object() {"admin", "user"})
        combo_usertype.Location = New Point(139, 165)
        combo_usertype.Name = "combo_usertype"
        combo_usertype.Size = New Size(182, 29)
        combo_usertype.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(35, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 21)
        Label4.TabIndex = 8
        Label4.Text = "USERTYPE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 284)
        Controls.Add(Label4)
        Controls.Add(combo_usertype)
        Controls.Add(btn_close)
        Controls.Add(btn_login)
        Controls.Add(txt_pwd)
        Controls.Add(txt_uname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents combo_usertype As ComboBox
    Friend WithEvents Label4 As Label
End Class
