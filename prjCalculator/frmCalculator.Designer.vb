<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.BtnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnIntDiv = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnExponental = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblEqualReal = New System.Windows.Forms.Label()
        Me.lblEqualInt = New System.Windows.Forms.Label()
        Me.txtRealAns = New System.Windows.Forms.TextBox()
        Me.txtIntAns = New System.Windows.Forms.TextBox()
        Me.lblReal = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(17, 123)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(71, 20)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(186, 123)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(71, 20)
        Me.txtNum2.TabIndex = 1
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(120, 55)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(43, 28)
        Me.btnSub.TabIndex = 2
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'BtnMult
        '
        Me.BtnMult.Location = New System.Drawing.Point(120, 89)
        Me.BtnMult.Name = "BtnMult"
        Me.BtnMult.Size = New System.Drawing.Size(43, 28)
        Me.BtnMult.TabIndex = 3
        Me.BtnMult.Text = "x"
        Me.BtnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(120, 123)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(43, 28)
        Me.btnDiv.TabIndex = 4
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnIntDiv
        '
        Me.btnIntDiv.Location = New System.Drawing.Point(120, 157)
        Me.btnIntDiv.Name = "btnIntDiv"
        Me.btnIntDiv.Size = New System.Drawing.Size(43, 28)
        Me.btnIntDiv.TabIndex = 5
        Me.btnIntDiv.Text = "\"
        Me.btnIntDiv.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(120, 191)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(43, 28)
        Me.btnMod.TabIndex = 6
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnExponental
        '
        Me.btnExponental.Location = New System.Drawing.Point(120, 225)
        Me.btnExponental.Name = "btnExponental"
        Me.btnExponental.Size = New System.Drawing.Size(43, 28)
        Me.btnExponental.TabIndex = 7
        Me.btnExponental.Text = "^"
        Me.btnExponental.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(120, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(43, 28)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblEqualReal
        '
        Me.lblEqualReal.AutoSize = True
        Me.lblEqualReal.Location = New System.Drawing.Point(289, 107)
        Me.lblEqualReal.Name = "lblEqualReal"
        Me.lblEqualReal.Size = New System.Drawing.Size(13, 13)
        Me.lblEqualReal.TabIndex = 10
        Me.lblEqualReal.Text = "="
        '
        'lblEqualInt
        '
        Me.lblEqualInt.AutoSize = True
        Me.lblEqualInt.Location = New System.Drawing.Point(289, 147)
        Me.lblEqualInt.Name = "lblEqualInt"
        Me.lblEqualInt.Size = New System.Drawing.Size(13, 13)
        Me.lblEqualInt.TabIndex = 11
        Me.lblEqualInt.Text = "="
        '
        'txtRealAns
        '
        Me.txtRealAns.BackColor = System.Drawing.SystemColors.Control
        Me.txtRealAns.Location = New System.Drawing.Point(308, 104)
        Me.txtRealAns.Name = "txtRealAns"
        Me.txtRealAns.ReadOnly = True
        Me.txtRealAns.Size = New System.Drawing.Size(71, 20)
        Me.txtRealAns.TabIndex = 12
        '
        'txtIntAns
        '
        Me.txtIntAns.BackColor = System.Drawing.SystemColors.Control
        Me.txtIntAns.Location = New System.Drawing.Point(308, 147)
        Me.txtIntAns.Name = "txtIntAns"
        Me.txtIntAns.ReadOnly = True
        Me.txtIntAns.Size = New System.Drawing.Size(71, 20)
        Me.txtIntAns.TabIndex = 13
        '
        'lblReal
        '
        Me.lblReal.AutoSize = True
        Me.lblReal.Location = New System.Drawing.Point(385, 107)
        Me.lblReal.Name = "lblReal"
        Me.lblReal.Size = New System.Drawing.Size(29, 13)
        Me.lblReal.TabIndex = 14
        Me.lblReal.Text = "Real"
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Location = New System.Drawing.Point(385, 150)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(40, 13)
        Me.lblInt.TabIndex = 15
        Me.lblInt.Text = "Integer"
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 275)
        Me.Controls.Add(Me.lblInt)
        Me.Controls.Add(Me.lblReal)
        Me.Controls.Add(Me.txtIntAns)
        Me.Controls.Add(Me.txtRealAns)
        Me.Controls.Add(Me.lblEqualInt)
        Me.Controls.Add(Me.lblEqualReal)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExponental)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIntDiv)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.BtnMult)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator V1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents BtnMult As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnIntDiv As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnExponental As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblEqualReal As System.Windows.Forms.Label
    Friend WithEvents lblEqualInt As System.Windows.Forms.Label
    Friend WithEvents txtRealAns As System.Windows.Forms.TextBox
    Friend WithEvents txtIntAns As System.Windows.Forms.TextBox
    Friend WithEvents lblReal As System.Windows.Forms.Label
    Friend WithEvents lblInt As System.Windows.Forms.Label

End Class
