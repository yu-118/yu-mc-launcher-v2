<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.リソースダウンローダーResourceDownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.使い方HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YuMCLauncherについてAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 111)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "yu MC Launcher v2-a3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minecraftのバージョン" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 141)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ゲームを起動する"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 141)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 27)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "設定を保存する"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Items.AddRange(New Object() {"config1", "config2", "config3"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 57)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(139, 32)
        Me.ListBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "設定を選択"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "割り当てるメモリ(最小)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "割り当てるメモリ(最大)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(159, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*設定別にすることはできません"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(319, 43)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 22)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "net.minecraft.client.Minecraft"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(316, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "メインクラス"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ユーザー名"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(319, 86)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 22)
        Me.TextBox3.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFileToolStripMenuItem, Me.ツールToolToolStripMenuItem, Me.ヘルプHelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(459, 25)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFileToolStripMenuItem
        '
        Me.ファイルFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.終了ExitToolStripMenuItem})
        Me.ファイルFileToolStripMenuItem.Name = "ファイルFileToolStripMenuItem"
        Me.ファイルFileToolStripMenuItem.Size = New System.Drawing.Size(53, 19)
        Me.ファイルFileToolStripMenuItem.Text = "ファイル"
        '
        '終了ExitToolStripMenuItem
        '
        Me.終了ExitToolStripMenuItem.Name = "終了ExitToolStripMenuItem"
        Me.終了ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.終了ExitToolStripMenuItem.Text = "終了"
        '
        'ツールToolToolStripMenuItem
        '
        Me.ツールToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.リソースダウンローダーResourceDownloaderToolStripMenuItem, Me.使い方HowToUseToolStripMenuItem})
        Me.ツールToolToolStripMenuItem.Name = "ツールToolToolStripMenuItem"
        Me.ツールToolToolStripMenuItem.Size = New System.Drawing.Size(46, 19)
        Me.ツールToolToolStripMenuItem.Text = "ツール"
        '
        'リソースダウンローダーResourceDownloaderToolStripMenuItem
        '
        Me.リソースダウンローダーResourceDownloaderToolStripMenuItem.Name = "リソースダウンローダーResourceDownloaderToolStripMenuItem"
        Me.リソースダウンローダーResourceDownloaderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.リソースダウンローダーResourceDownloaderToolStripMenuItem.Text = "リソースダウンローダー"
        '
        '使い方HowToUseToolStripMenuItem
        '
        Me.使い方HowToUseToolStripMenuItem.Name = "使い方HowToUseToolStripMenuItem"
        Me.使い方HowToUseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.使い方HowToUseToolStripMenuItem.Text = "使い方"
        '
        'ヘルプHelpToolStripMenuItem
        '
        Me.ヘルプHelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YuMCLauncherについてAboutToolStripMenuItem})
        Me.ヘルプHelpToolStripMenuItem.Name = "ヘルプHelpToolStripMenuItem"
        Me.ヘルプHelpToolStripMenuItem.Size = New System.Drawing.Size(48, 19)
        Me.ヘルプHelpToolStripMenuItem.Text = "ヘルプ"
        '
        'YuMCLauncherについてAboutToolStripMenuItem
        '
        Me.YuMCLauncherについてAboutToolStripMenuItem.Name = "YuMCLauncherについてAboutToolStripMenuItem"
        Me.YuMCLauncherについてAboutToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.YuMCLauncherについてAboutToolStripMenuItem.Text = "yu MC Launcher v2について"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(319, 116)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 18)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "ログを表示する"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(162, 43)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(63, 22)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(162, 87)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(63, 22)
        Me.TextBox5.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(231, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 14)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "MB"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "MB"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 186)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "yu MC Launcher v2-a2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ツールToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents リソースダウンローダーResourceDownloaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YuMCLauncherについてAboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 使い方HowToUseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
