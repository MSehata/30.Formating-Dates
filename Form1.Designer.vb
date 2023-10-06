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
        txtGeneralDate = New TextBox()
        txtLongDate = New TextBox()
        txtShortDate = New TextBox()
        txtLongTime = New TextBox()
        txtShortTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnFormat = New Button()
        btnClose = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtGeneralDate
        ' 
        txtGeneralDate.Location = New Point(396, 80)
        txtGeneralDate.Name = "txtGeneralDate"
        txtGeneralDate.Size = New Size(190, 27)
        txtGeneralDate.TabIndex = 1
        ' 
        ' txtLongDate
        ' 
        txtLongDate.Location = New Point(396, 136)
        txtLongDate.Name = "txtLongDate"
        txtLongDate.Size = New Size(190, 27)
        txtLongDate.TabIndex = 1
        ' 
        ' txtShortDate
        ' 
        txtShortDate.Location = New Point(396, 197)
        txtShortDate.Name = "txtShortDate"
        txtShortDate.Size = New Size(190, 27)
        txtShortDate.TabIndex = 1
        ' 
        ' txtLongTime
        ' 
        txtLongTime.Location = New Point(396, 261)
        txtLongTime.Name = "txtLongTime"
        txtLongTime.Size = New Size(190, 27)
        txtLongTime.TabIndex = 1
        ' 
        ' txtShortTime
        ' 
        txtShortTime.Location = New Point(396, 329)
        txtShortTime.Name = "txtShortTime"
        txtShortTime.Size = New Size(190, 27)
        txtShortTime.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(228, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 2
        Label1.Text = "General Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(228, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 2
        Label2.Text = "Long Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(228, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 2
        Label3.Text = "Short Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(228, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 2
        Label4.Text = "Short Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(228, 264)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 2
        Label5.Text = "Long Time"
        ' 
        ' btnFormat
        ' 
        btnFormat.Location = New Point(268, 396)
        btnFormat.Name = "btnFormat"
        btnFormat.Size = New Size(94, 29)
        btnFormat.TabIndex = 3
        btnFormat.Text = "Format"
        btnFormat.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(426, 396)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.Highlight
        Label6.Location = New Point(61, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(717, 36)
        Label6.TabIndex = 2
        Label6.Text = "Click Format to see today's date formats"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnFormat)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(txtShortTime)
        Controls.Add(txtLongTime)
        Controls.Add(txtShortDate)
        Controls.Add(txtLongDate)
        Controls.Add(txtGeneralDate)
        Name = "Form1"
        Text = "Date Formats"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGeneralDate As TextBox
    Friend WithEvents txtLongDate As TextBox
    Friend WithEvents txtShortDate As TextBox
    Friend WithEvents txtLongTime As TextBox
    Friend WithEvents txtShortTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFormat As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label6 As Label
End Class
