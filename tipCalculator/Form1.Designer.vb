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
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblAmountv = New System.Windows.Forms.Label()
        Me.tipBox = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnTipServer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(279, 59)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(204, 25)
        Me.lblIntro.TabIndex = 0
        Me.lblIntro.Text = "Server's tipping App"
        '
        'lblAmountv
        '
        Me.lblAmountv.AutoSize = True
        Me.lblAmountv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountv.Location = New System.Drawing.Point(311, 129)
        Me.lblAmountv.Name = "lblAmountv"
        Me.lblAmountv.Size = New System.Drawing.Size(155, 24)
        Me.lblAmountv.TabIndex = 1
        Me.lblAmountv.Text = "Tip Amount(Ghc)"
        '
        'tipBox
        '
        Me.tipBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipBox.Location = New System.Drawing.Point(167, 173)
        Me.tipBox.Name = "tipBox"
        Me.tipBox.Size = New System.Drawing.Size(450, 31)
        Me.tipBox.TabIndex = 2
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(63, 256)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(92, 24)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.Text = "Message:"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTipServer
        '
        Me.btnTipServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipServer.Location = New System.Drawing.Point(164, 347)
        Me.btnTipServer.Name = "btnTipServer"
        Me.btnTipServer.Size = New System.Drawing.Size(377, 47)
        Me.btnTipServer.TabIndex = 4
        Me.btnTipServer.Text = "Tip Server"
        Me.btnTipServer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(547, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 42)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTipServer)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.tipBox)
        Me.Controls.Add(Me.lblAmountv)
        Me.Controls.Add(Me.lblIntro)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIntro As Label
    Friend WithEvents lblAmountv As Label
    Friend WithEvents tipBox As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnTipServer As Button
    Friend WithEvents btnExit As Button
End Class
