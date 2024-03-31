<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConverterPage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ConverterPage))
        PictureBox2 = New PictureBox()
        BackTitleButton = New Button()
        ConvertButton = New Button()
        ClearButton = New Button()
        InputValue = New TextBox()
        BaseFrom = New ComboBox()
        OutputValue = New TextBox()
        BaseTo = New ComboBox()
        Subtitle = New Label()
        CopyButton = New Button()
        PasteButton = New Button()
        InputLabel = New Label()
        FromBaseLabel = New Label()
        OutputLabel = New Label()
        ToBaseLabel = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        PictureBox2.Location = New Point(12, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(760, 437)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' BackTitleButton
        ' 
        BackTitleButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        BackTitleButton.FlatStyle = FlatStyle.Popup
        BackTitleButton.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        BackTitleButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        BackTitleButton.Location = New Point(498, 386)
        BackTitleButton.Name = "BackTitleButton"
        BackTitleButton.Size = New Size(199, 43)
        BackTitleButton.TabIndex = 3
        BackTitleButton.Text = "TITLE"
        BackTitleButton.UseVisualStyleBackColor = False
        ' 
        ' ConvertButton
        ' 
        ConvertButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        ConvertButton.FlatStyle = FlatStyle.Popup
        ConvertButton.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConvertButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        ConvertButton.Location = New Point(293, 386)
        ConvertButton.Name = "ConvertButton"
        ConvertButton.Size = New Size(199, 43)
        ConvertButton.TabIndex = 4
        ConvertButton.Text = "CONVERT"
        ConvertButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        ClearButton.FlatStyle = FlatStyle.Popup
        ClearButton.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ClearButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        ClearButton.Location = New Point(88, 386)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(199, 43)
        ClearButton.TabIndex = 5
        ClearButton.Text = "CLEAR"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' InputValue
        ' 
        InputValue.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        InputValue.BorderStyle = BorderStyle.FixedSingle
        InputValue.CharacterCasing = CharacterCasing.Upper
        InputValue.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        InputValue.Location = New Point(88, 110)
        InputValue.Name = "InputValue"
        InputValue.ShortcutsEnabled = False
        InputValue.Size = New Size(404, 27)
        InputValue.TabIndex = 6
        ' 
        ' BaseFrom
        ' 
        BaseFrom.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        BaseFrom.DropDownStyle = ComboBoxStyle.DropDownList
        BaseFrom.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BaseFrom.FormattingEnabled = True
        BaseFrom.Items.AddRange(New Object() {"Decimal", "Binary", "Octal", "Hexadecimal"})
        BaseFrom.Location = New Point(576, 112)
        BaseFrom.MaxDropDownItems = 4
        BaseFrom.Name = "BaseFrom"
        BaseFrom.Size = New Size(121, 25)
        BaseFrom.TabIndex = 7
        ' 
        ' OutputValue
        ' 
        OutputValue.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        OutputValue.BorderStyle = BorderStyle.FixedSingle
        OutputValue.CharacterCasing = CharacterCasing.Upper
        OutputValue.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OutputValue.Location = New Point(88, 238)
        OutputValue.Name = "OutputValue"
        OutputValue.ReadOnly = True
        OutputValue.Size = New Size(404, 27)
        OutputValue.TabIndex = 8
        ' 
        ' BaseTo
        ' 
        BaseTo.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        BaseTo.DropDownStyle = ComboBoxStyle.DropDownList
        BaseTo.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BaseTo.FormattingEnabled = True
        BaseTo.Items.AddRange(New Object() {"Decimal", "Binary", "Octal", "Hexadecimal"})
        BaseTo.Location = New Point(576, 240)
        BaseTo.MaxDropDownItems = 4
        BaseTo.Name = "BaseTo"
        BaseTo.Size = New Size(121, 25)
        BaseTo.TabIndex = 9
        ' 
        ' Subtitle
        ' 
        Subtitle.AutoSize = True
        Subtitle.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        Subtitle.Font = New Font("Lucida Bright", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Subtitle.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        Subtitle.Location = New Point(289, 318)
        Subtitle.Name = "Subtitle"
        Subtitle.Size = New Size(206, 42)
        Subtitle.TabIndex = 10
        Subtitle.Text = "MorphLab"
        ' 
        ' CopyButton
        ' 
        CopyButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        CopyButton.FlatStyle = FlatStyle.Popup
        CopyButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CopyButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        CopyButton.Location = New Point(88, 273)
        CopyButton.Name = "CopyButton"
        CopyButton.Size = New Size(66, 31)
        CopyButton.TabIndex = 12
        CopyButton.Text = "Copy"
        CopyButton.UseVisualStyleBackColor = False
        ' 
        ' PasteButton
        ' 
        PasteButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        PasteButton.FlatStyle = FlatStyle.Popup
        PasteButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PasteButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        PasteButton.Location = New Point(88, 145)
        PasteButton.Name = "PasteButton"
        PasteButton.Size = New Size(66, 31)
        PasteButton.TabIndex = 13
        PasteButton.Text = "Paste"
        PasteButton.UseVisualStyleBackColor = False
        ' 
        ' InputLabel
        ' 
        InputLabel.AutoSize = True
        InputLabel.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        InputLabel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        InputLabel.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        InputLabel.Location = New Point(88, 86)
        InputLabel.Name = "InputLabel"
        InputLabel.Size = New Size(114, 19)
        InputLabel.TabIndex = 14
        InputLabel.Text = "Enter Number"
        ' 
        ' FromBaseLabel
        ' 
        FromBaseLabel.AutoSize = True
        FromBaseLabel.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        FromBaseLabel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FromBaseLabel.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        FromBaseLabel.Location = New Point(576, 86)
        FromBaseLabel.Name = "FromBaseLabel"
        FromBaseLabel.Size = New Size(88, 19)
        FromBaseLabel.TabIndex = 15
        FromBaseLabel.Text = "From Base"
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        OutputLabel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OutputLabel.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        OutputLabel.Location = New Point(88, 216)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(129, 19)
        OutputLabel.TabIndex = 16
        OutputLabel.Text = "Output Number"
        ' 
        ' ToBaseLabel
        ' 
        ToBaseLabel.AutoSize = True
        ToBaseLabel.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        ToBaseLabel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ToBaseLabel.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        ToBaseLabel.Location = New Point(576, 216)
        ToBaseLabel.Name = "ToBaseLabel"
        ToBaseLabel.Size = New Size(66, 19)
        ToBaseLabel.TabIndex = 17
        ToBaseLabel.Text = "To Base"
        ' 
        ' ConverterPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        ClientSize = New Size(784, 461)
        Controls.Add(ToBaseLabel)
        Controls.Add(OutputLabel)
        Controls.Add(FromBaseLabel)
        Controls.Add(InputLabel)
        Controls.Add(PasteButton)
        Controls.Add(CopyButton)
        Controls.Add(Subtitle)
        Controls.Add(BaseTo)
        Controls.Add(OutputValue)
        Controls.Add(BaseFrom)
        Controls.Add(InputValue)
        Controls.Add(ClearButton)
        Controls.Add(ConvertButton)
        Controls.Add(BackTitleButton)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ConverterPage"
        Text = "MorphLab"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackTitleButton As Button
    Friend WithEvents ConvertButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents InputValue As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BaseFrom As ComboBox
    Friend WithEvents OutputValue As TextBox
    Friend WithEvents BaseTo As ComboBox
    Friend WithEvents Subtitle As Label
    Friend WithEvents CopyButton As Button
    Friend WithEvents PasteButton As Button
    Friend WithEvents InputLabel As Label
    Friend WithEvents FromBaseLabel As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents ToBaseLabel As Label
End Class
