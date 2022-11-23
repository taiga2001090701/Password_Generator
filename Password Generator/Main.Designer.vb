<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TUC = New System.Windows.Forms.TextBox()
        Me.BCA = New System.Windows.Forms.Button()
        Me.TUS = New System.Windows.Forms.TextBox()
        Me.TPL = New System.Windows.Forms.TextBox()
        Me.BPG = New System.Windows.Forms.Button()
        Me.TGP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BCD = New System.Windows.Forms.Button()
        Me.BCR = New System.Windows.Forms.Button()
        Me.CP = New System.Windows.Forms.ComboBox()
        Me.BPA = New System.Windows.Forms.Button()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BPD = New System.Windows.Forms.Button()
        Me.GB3 = New System.Windows.Forms.GroupBox()
        Me.GB5 = New System.Windows.Forms.GroupBox()
        Me.GB4 = New System.Windows.Forms.GroupBox()
        Me.GB1.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB3.SuspendLayout()
        Me.GB5.SuspendLayout()
        Me.GB4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TUC
        '
        Me.TUC.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.TUC.Location = New System.Drawing.Point(110, 12)
        Me.TUC.MaxLength = 1
        Me.TUC.Name = "TUC"
        Me.TUC.Size = New System.Drawing.Size(35, 29)
        Me.TUC.TabIndex = 0
        Me.TUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BCA
        '
        Me.BCA.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BCA.Location = New System.Drawing.Point(10, 47)
        Me.BCA.Name = "BCA"
        Me.BCA.Size = New System.Drawing.Size(100, 40)
        Me.BCA.TabIndex = 1
        Me.BCA.Text = "追加"
        Me.BCA.UseVisualStyleBackColor = True
        '
        'TUS
        '
        Me.TUS.BackColor = System.Drawing.Color.White
        Me.TUS.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.TUS.Location = New System.Drawing.Point(6, 129)
        Me.TUS.Multiline = True
        Me.TUS.Name = "TUS"
        Me.TUS.ReadOnly = True
        Me.TUS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TUS.Size = New System.Drawing.Size(716, 90)
        Me.TUS.TabIndex = 2
        '
        'TPL
        '
        Me.TPL.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.TPL.Location = New System.Drawing.Point(154, 12)
        Me.TPL.Name = "TPL"
        Me.TPL.Size = New System.Drawing.Size(100, 29)
        Me.TPL.TabIndex = 3
        '
        'BPG
        '
        Me.BPG.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BPG.Location = New System.Drawing.Point(622, 18)
        Me.BPG.Name = "BPG"
        Me.BPG.Size = New System.Drawing.Size(100, 40)
        Me.BPG.TabIndex = 4
        Me.BPG.Text = "生成"
        Me.BPG.UseVisualStyleBackColor = True
        '
        'TGP
        '
        Me.TGP.BackColor = System.Drawing.Color.White
        Me.TGP.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.TGP.Location = New System.Drawing.Point(6, 25)
        Me.TGP.Name = "TGP"
        Me.TGP.ReadOnly = True
        Me.TGP.Size = New System.Drawing.Size(610, 29)
        Me.TGP.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "使用文字"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "生成文字列長"
        '
        'BCD
        '
        Me.BCD.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BCD.Location = New System.Drawing.Point(116, 47)
        Me.BCD.Name = "BCD"
        Me.BCD.Size = New System.Drawing.Size(100, 40)
        Me.BCD.TabIndex = 8
        Me.BCD.Text = "削除"
        Me.BCD.UseVisualStyleBackColor = True
        '
        'BCR
        '
        Me.BCR.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BCR.Location = New System.Drawing.Point(622, 83)
        Me.BCR.Name = "BCR"
        Me.BCR.Size = New System.Drawing.Size(100, 40)
        Me.BCR.TabIndex = 9
        Me.BCR.Text = "全削除"
        Me.BCR.UseVisualStyleBackColor = True
        '
        'CP
        '
        Me.CP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CP.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.CP.FormattingEnabled = True
        Me.CP.Location = New System.Drawing.Point(112, 18)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(104, 29)
        Me.CP.TabIndex = 10
        '
        'BPA
        '
        Me.BPA.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BPA.Location = New System.Drawing.Point(10, 53)
        Me.BPA.Name = "BPA"
        Me.BPA.Size = New System.Drawing.Size(100, 40)
        Me.BPA.TabIndex = 11
        Me.BPA.Text = "追加"
        Me.BPA.UseVisualStyleBackColor = True
        '
        'GB1
        '
        Me.GB1.AutoSize = True
        Me.GB1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB1.Controls.Add(Me.Label1)
        Me.GB1.Controls.Add(Me.TUC)
        Me.GB1.Controls.Add(Me.BCA)
        Me.GB1.Controls.Add(Me.BCD)
        Me.GB1.Location = New System.Drawing.Point(6, 18)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(222, 105)
        Me.GB1.TabIndex = 13
        Me.GB1.TabStop = False
        '
        'GB2
        '
        Me.GB2.AutoSize = True
        Me.GB2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB2.Controls.Add(Me.Label3)
        Me.GB2.Controls.Add(Me.BPD)
        Me.GB2.Controls.Add(Me.CP)
        Me.GB2.Controls.Add(Me.BPA)
        Me.GB2.Location = New System.Drawing.Point(234, 12)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(222, 111)
        Me.GB2.TabIndex = 14
        Me.GB2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "標準設定"
        '
        'BPD
        '
        Me.BPD.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BPD.Location = New System.Drawing.Point(116, 53)
        Me.BPD.Name = "BPD"
        Me.BPD.Size = New System.Drawing.Size(100, 40)
        Me.BPD.TabIndex = 12
        Me.BPD.Text = "削除"
        Me.BPD.UseVisualStyleBackColor = True
        '
        'GB3
        '
        Me.GB3.AutoSize = True
        Me.GB3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB3.Controls.Add(Me.TGP)
        Me.GB3.Controls.Add(Me.BPG)
        Me.GB3.Location = New System.Drawing.Point(12, 255)
        Me.GB3.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(728, 76)
        Me.GB3.TabIndex = 15
        Me.GB3.TabStop = False
        '
        'GB5
        '
        Me.GB5.AutoSize = True
        Me.GB5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB5.Controls.Add(Me.GB4)
        Me.GB5.Controls.Add(Me.GB1)
        Me.GB5.Controls.Add(Me.GB2)
        Me.GB5.Controls.Add(Me.TUS)
        Me.GB5.Controls.Add(Me.BCR)
        Me.GB5.Location = New System.Drawing.Point(12, 12)
        Me.GB5.Name = "GB5"
        Me.GB5.Size = New System.Drawing.Size(728, 237)
        Me.GB5.TabIndex = 16
        Me.GB5.TabStop = False
        '
        'GB4
        '
        Me.GB4.AutoSize = True
        Me.GB4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB4.Controls.Add(Me.Label2)
        Me.GB4.Controls.Add(Me.TPL)
        Me.GB4.Location = New System.Drawing.Point(462, 18)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(260, 59)
        Me.GB4.TabIndex = 15
        Me.GB4.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(753, 344)
        Me.Controls.Add(Me.GB5)
        Me.Controls.Add(Me.GB3)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB3.ResumeLayout(False)
        Me.GB3.PerformLayout()
        Me.GB5.ResumeLayout(False)
        Me.GB5.PerformLayout()
        Me.GB4.ResumeLayout(False)
        Me.GB4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TUC As Windows.Forms.TextBox
    Friend WithEvents BCA As Windows.Forms.Button
    Friend WithEvents TUS As Windows.Forms.TextBox
    Friend WithEvents TPL As Windows.Forms.TextBox
    Friend WithEvents BPG As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents BCD As Windows.Forms.Button
    Friend WithEvents BCR As Windows.Forms.Button
    Friend WithEvents CP As Windows.Forms.ComboBox
    Friend WithEvents BPA As Windows.Forms.Button
    Friend WithEvents GB1 As Windows.Forms.GroupBox
    Friend WithEvents GB2 As Windows.Forms.GroupBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents BPD As Windows.Forms.Button
    Friend WithEvents GB3 As Windows.Forms.GroupBox
    Friend WithEvents GB5 As Windows.Forms.GroupBox
    Friend WithEvents GB4 As Windows.Forms.GroupBox
    Friend WithEvents TGP As Windows.Forms.TextBox
End Class
