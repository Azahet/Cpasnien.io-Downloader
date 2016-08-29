<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FormSkin1 = New WindowsApplication5.FormSkin()
        Me.FlatButton3 = New WindowsApplication5.FlatButton()
        Me.FlatButton2 = New WindowsApplication5.FlatButton()
        Me.FlatListBox1 = New WindowsApplication5.FlatListBox()
        Me.FlatContextMenuStrip1 = New WindowsApplication5.FlatContextMenuStrip()
        Me.TéléchargerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TélécharerLaSaisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlatTextBox1 = New WindowsApplication5.FlatTextBox()
        Me.FlatButton1 = New WindowsApplication5.FlatButton()
        Me.FlatMini1 = New WindowsApplication5.FlatMini()
        Me.FlatClose1 = New WindowsApplication5.FlatClose()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSkin1.SuspendLayout
        Me.FlatContextMenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.FlatListBox1)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.FormSkin1.HeaderMaximize = false
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(275, 460)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Cpasbien.io Downloader"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.FlatButton3.Location = New System.Drawing.Point(150, 418)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = false
        Me.FlatButton3.Size = New System.Drawing.Size(112, 24)
        Me.FlatButton3.TabIndex = 7
        Me.FlatButton3.Text = ">>"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.FlatButton2.Location = New System.Drawing.Point(12, 418)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = false
        Me.FlatButton2.Size = New System.Drawing.Size(112, 24)
        Me.FlatButton2.TabIndex = 6
        Me.FlatButton2.Text = "<<"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'FlatListBox1
        '
        Me.FlatListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
        Me.FlatListBox1.ContextMenuStrip = Me.FlatContextMenuStrip1
        Me.FlatListBox1.items = New String() {""}
        Me.FlatListBox1.Location = New System.Drawing.Point(12, 144)
        Me.FlatListBox1.Name = "FlatListBox1"
        Me.FlatListBox1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.FlatListBox1.Size = New System.Drawing.Size(250, 268)
        Me.FlatListBox1.TabIndex = 4
        Me.FlatListBox1.Text = "FlatListBox1"
        '
        'FlatContextMenuStrip1
        '
        Me.FlatContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.FlatContextMenuStrip1.ForeColor = System.Drawing.Color.White
        Me.FlatContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TéléchargerToolStripMenuItem, Me.TélécharerLaSaisonToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.FlatContextMenuStrip1.Name = "FlatContextMenuStrip1"
        Me.FlatContextMenuStrip1.ShowImageMargin = false
        Me.FlatContextMenuStrip1.Size = New System.Drawing.Size(149, 92)
        '
        'TéléchargerToolStripMenuItem
        '
        Me.TéléchargerToolStripMenuItem.Name = "TéléchargerToolStripMenuItem"
        Me.TéléchargerToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TéléchargerToolStripMenuItem.Text = "Télécharger"
        '
        'TélécharerLaSaisonToolStripMenuItem
        '
        Me.TélécharerLaSaisonToolStripMenuItem.Name = "TélécharerLaSaisonToolStripMenuItem"
        Me.TélécharerLaSaisonToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TélécharerLaSaisonToolStripMenuItem.Text = "Télécharer la saison"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(12, 78)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = false
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = false
        Me.FlatTextBox1.Size = New System.Drawing.Size(250, 29)
        Me.FlatTextBox1.TabIndex = 3
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = false
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 113)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = false
        Me.FlatButton1.Size = New System.Drawing.Size(250, 24)
        Me.FlatButton1.TabIndex = 2
        Me.FlatButton1.Text = "Chercher"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12!)
        Me.FlatMini1.Location = New System.Drawing.Point(221, 10)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 12!)
        Me.FlatClose1.Location = New System.Drawing.Point(245, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer), CType(CType(220,Byte),Integer))
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 460)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cpasbien.io Downloader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(false)
        Me.FlatContextMenuStrip1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatListBox1 As FlatListBox
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatContextMenuStrip1 As FlatContextMenuStrip
    Friend WithEvents TéléchargerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TélécharerLaSaisonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
End Class
