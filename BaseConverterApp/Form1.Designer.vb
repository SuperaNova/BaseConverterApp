<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TitlePage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TitlePage))
        StartButton = New Button()
        PictureBox1 = New PictureBox()
        Title = New Label()
        Creator = New Label()
        ExitButton = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StartButton
        ' 
        StartButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        StartButton.Cursor = Cursors.Hand
        StartButton.FlatStyle = FlatStyle.Popup
        StartButton.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        StartButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        StartButton.Location = New Point(189, 387)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(199, 43)
        StartButton.TabIndex = 0
        StartButton.Text = "START" & vbCrLf
        StartButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(760, 437)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        Title.Font = New Font("Lucida Bright", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        Title.Location = New Point(215, 130)
        Title.Name = "Title"
        Title.Size = New Size(355, 72)
        Title.TabIndex = 4
        Title.Text = "MorphLab"
        ' 
        ' Creator
        ' 
        Creator.AutoSize = True
        Creator.BackColor = Color.FromArgb(CByte(199), CByte(183), CByte(163))
        Creator.Font = New Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Creator.ForeColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        Creator.Location = New Point(311, 219)
        Creator.Name = "Creator"
        Creator.Size = New Size(163, 13)
        Creator.TabIndex = 5
        Creator.Text = "By Jared Sheohn Acebes"
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        ExitButton.Cursor = Cursors.Hand
        ExitButton.FlatStyle = FlatStyle.Popup
        ExitButton.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.ForeColor = Color.FromArgb(CByte(232), CByte(216), CByte(196))
        ExitButton.Location = New Point(394, 387)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(199, 43)
        ExitButton.TabIndex = 6
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' TitlePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(86), CByte(28), CByte(36))
        ClientSize = New Size(784, 461)
        Controls.Add(ExitButton)
        Controls.Add(Creator)
        Controls.Add(Title)
        Controls.Add(StartButton)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "TitlePage"
        Text = "CS132 Midterm Project"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Creator As Label
    Friend WithEvents ExitButton As Button
End Class
