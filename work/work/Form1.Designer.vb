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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnGyoSakujo1 = New System.Windows.Forms.Button()
        Me.btnGyoTuika1 = New System.Windows.Forms.Button()
        Me.rbnSityousitu = New System.Windows.Forms.RadioButton()
        Me.btnKojinninnsatu = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbnPreview = New System.Windows.Forms.RadioButton()
        Me.rbnInnsatu = New System.Windows.Forms.RadioButton()
        Me.rbnByoutoujosyu = New System.Windows.Forms.RadioButton()
        Me.rbnRyouyoubyoutou = New System.Windows.Forms.RadioButton()
        Me.rbnGairai = New System.Windows.Forms.RadioButton()
        Me.rbnIppannbyoutou = New System.Windows.Forms.RadioButton()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.btnInnsatu = New System.Windows.Forms.Button()
        Me.btnSakujo = New System.Windows.Forms.Button()
        Me.btnTouroku = New System.Windows.Forms.Button()
        Me.btnSyuukannhyou = New System.Windows.Forms.Button()
        Me.btnSyuukei = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(63, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(1277, 495)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 599)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(153, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(67, 32)
        Me.btnDisplay.TabIndex = 50145
        Me.btnDisplay.Text = "表示"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnGyoSakujo1
        '
        Me.btnGyoSakujo1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGyoSakujo1.Location = New System.Drawing.Point(1030, 11)
        Me.btnGyoSakujo1.Name = "btnGyoSakujo1"
        Me.btnGyoSakujo1.Size = New System.Drawing.Size(49, 26)
        Me.btnGyoSakujo1.TabIndex = 50170
        Me.btnGyoSakujo1.Text = "行削除"
        Me.btnGyoSakujo1.UseVisualStyleBackColor = True
        '
        'btnGyoTuika1
        '
        Me.btnGyoTuika1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGyoTuika1.Location = New System.Drawing.Point(975, 10)
        Me.btnGyoTuika1.Name = "btnGyoTuika1"
        Me.btnGyoTuika1.Size = New System.Drawing.Size(49, 26)
        Me.btnGyoTuika1.TabIndex = 50169
        Me.btnGyoTuika1.Text = "行追加"
        Me.btnGyoTuika1.UseVisualStyleBackColor = True
        '
        'rbnSityousitu
        '
        Me.rbnSityousitu.AutoSize = True
        Me.rbnSityousitu.Location = New System.Drawing.Point(307, 25)
        Me.rbnSityousitu.Name = "rbnSityousitu"
        Me.rbnSityousitu.Size = New System.Drawing.Size(59, 16)
        Me.rbnSityousitu.TabIndex = 50167
        Me.rbnSityousitu.TabStop = True
        Me.rbnSityousitu.Text = "師長室"
        Me.rbnSityousitu.UseVisualStyleBackColor = True
        '
        'btnKojinninnsatu
        '
        Me.btnKojinninnsatu.Location = New System.Drawing.Point(798, 8)
        Me.btnKojinninnsatu.Name = "btnKojinninnsatu"
        Me.btnKojinninnsatu.Size = New System.Drawing.Size(63, 32)
        Me.btnKojinninnsatu.TabIndex = 50165
        Me.btnKojinninnsatu.Text = "個人印刷"
        Me.btnKojinninnsatu.UseVisualStyleBackColor = True
        Me.btnKojinninnsatu.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbnPreview)
        Me.Panel4.Controls.Add(Me.rbnInnsatu)
        Me.Panel4.Location = New System.Drawing.Point(876, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(85, 47)
        Me.Panel4.TabIndex = 50164
        '
        'rbnPreview
        '
        Me.rbnPreview.AutoSize = True
        Me.rbnPreview.Location = New System.Drawing.Point(8, 23)
        Me.rbnPreview.Name = "rbnPreview"
        Me.rbnPreview.Size = New System.Drawing.Size(67, 16)
        Me.rbnPreview.TabIndex = 1
        Me.rbnPreview.Text = "プレビュー"
        Me.rbnPreview.UseVisualStyleBackColor = True
        Me.rbnPreview.Visible = False
        '
        'rbnInnsatu
        '
        Me.rbnInnsatu.AutoSize = True
        Me.rbnInnsatu.Checked = True
        Me.rbnInnsatu.Location = New System.Drawing.Point(8, 3)
        Me.rbnInnsatu.Name = "rbnInnsatu"
        Me.rbnInnsatu.Size = New System.Drawing.Size(47, 16)
        Me.rbnInnsatu.TabIndex = 0
        Me.rbnInnsatu.TabStop = True
        Me.rbnInnsatu.Text = "印刷"
        Me.rbnInnsatu.UseVisualStyleBackColor = True
        Me.rbnInnsatu.Visible = False
        '
        'rbnByoutoujosyu
        '
        Me.rbnByoutoujosyu.AutoSize = True
        Me.rbnByoutoujosyu.Location = New System.Drawing.Point(381, 5)
        Me.rbnByoutoujosyu.Name = "rbnByoutoujosyu"
        Me.rbnByoutoujosyu.Size = New System.Drawing.Size(71, 16)
        Me.rbnByoutoujosyu.TabIndex = 50162
        Me.rbnByoutoujosyu.TabStop = True
        Me.rbnByoutoujosyu.Text = "病棟助手"
        Me.rbnByoutoujosyu.UseVisualStyleBackColor = True
        '
        'rbnRyouyoubyoutou
        '
        Me.rbnRyouyoubyoutou.AutoSize = True
        Me.rbnRyouyoubyoutou.Location = New System.Drawing.Point(307, 4)
        Me.rbnRyouyoubyoutou.Name = "rbnRyouyoubyoutou"
        Me.rbnRyouyoubyoutou.Size = New System.Drawing.Size(71, 16)
        Me.rbnRyouyoubyoutou.TabIndex = 50161
        Me.rbnRyouyoubyoutou.TabStop = True
        Me.rbnRyouyoubyoutou.Text = "療養病棟"
        Me.rbnRyouyoubyoutou.UseVisualStyleBackColor = True
        '
        'rbnGairai
        '
        Me.rbnGairai.AutoSize = True
        Me.rbnGairai.Location = New System.Drawing.Point(235, 25)
        Me.rbnGairai.Name = "rbnGairai"
        Me.rbnGairai.Size = New System.Drawing.Size(47, 16)
        Me.rbnGairai.TabIndex = 50160
        Me.rbnGairai.Text = "外来"
        Me.rbnGairai.UseVisualStyleBackColor = True
        '
        'rbnIppannbyoutou
        '
        Me.rbnIppannbyoutou.AutoSize = True
        Me.rbnIppannbyoutou.Checked = True
        Me.rbnIppannbyoutou.Location = New System.Drawing.Point(235, 4)
        Me.rbnIppannbyoutou.Name = "rbnIppannbyoutou"
        Me.rbnIppannbyoutou.Size = New System.Drawing.Size(71, 16)
        Me.rbnIppannbyoutou.TabIndex = 50159
        Me.rbnIppannbyoutou.TabStop = True
        Me.rbnIppannbyoutou.Text = "一般病棟"
        Me.rbnIppannbyoutou.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMonth.Location = New System.Drawing.Point(91, 16)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(47, 20)
        Me.cmbMonth.TabIndex = 50153
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(29, 16)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(54, 20)
        Me.cmbYear.TabIndex = 50152
        '
        'btnInnsatu
        '
        Me.btnInnsatu.Location = New System.Drawing.Point(729, 8)
        Me.btnInnsatu.Name = "btnInnsatu"
        Me.btnInnsatu.Size = New System.Drawing.Size(63, 32)
        Me.btnInnsatu.TabIndex = 50150
        Me.btnInnsatu.Text = "一面印刷"
        Me.btnInnsatu.UseVisualStyleBackColor = True
        Me.btnInnsatu.Visible = False
        '
        'btnSakujo
        '
        Me.btnSakujo.Location = New System.Drawing.Point(1292, 9)
        Me.btnSakujo.Name = "btnSakujo"
        Me.btnSakujo.Size = New System.Drawing.Size(48, 32)
        Me.btnSakujo.TabIndex = 50149
        Me.btnSakujo.Text = "削除"
        Me.btnSakujo.UseVisualStyleBackColor = True
        Me.btnSakujo.Visible = False
        '
        'btnTouroku
        '
        Me.btnTouroku.Location = New System.Drawing.Point(615, 8)
        Me.btnTouroku.Name = "btnTouroku"
        Me.btnTouroku.Size = New System.Drawing.Size(48, 32)
        Me.btnTouroku.TabIndex = 50148
        Me.btnTouroku.Text = "登録"
        Me.btnTouroku.UseVisualStyleBackColor = True
        Me.btnTouroku.Visible = False
        '
        'btnSyuukannhyou
        '
        Me.btnSyuukannhyou.Location = New System.Drawing.Point(459, 8)
        Me.btnSyuukannhyou.Name = "btnSyuukannhyou"
        Me.btnSyuukannhyou.Size = New System.Drawing.Size(61, 32)
        Me.btnSyuukannhyou.TabIndex = 50146
        Me.btnSyuukannhyou.Text = "週間表"
        Me.btnSyuukannhyou.UseVisualStyleBackColor = True
        '
        'btnSyuukei
        '
        Me.btnSyuukei.ForeColor = System.Drawing.Color.Coral
        Me.btnSyuukei.Location = New System.Drawing.Point(534, 8)
        Me.btnSyuukei.Name = "btnSyuukei"
        Me.btnSyuukei.Size = New System.Drawing.Size(63, 32)
        Me.btnSyuukei.TabIndex = 50151
        Me.btnSyuukei.Text = "夜勤集計"
        Me.btnSyuukei.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1442, 691)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnGyoSakujo1)
        Me.Controls.Add(Me.btnGyoTuika1)
        Me.Controls.Add(Me.rbnSityousitu)
        Me.Controls.Add(Me.btnKojinninnsatu)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.rbnByoutoujosyu)
        Me.Controls.Add(Me.rbnRyouyoubyoutou)
        Me.Controls.Add(Me.rbnGairai)
        Me.Controls.Add(Me.rbnIppannbyoutou)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.btnInnsatu)
        Me.Controls.Add(Me.btnSakujo)
        Me.Controls.Add(Me.btnTouroku)
        Me.Controls.Add(Me.btnSyuukannhyou)
        Me.Controls.Add(Me.btnSyuukei)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnGyoSakujo1 As System.Windows.Forms.Button
    Friend WithEvents btnGyoTuika1 As System.Windows.Forms.Button
    Friend WithEvents rbnSityousitu As System.Windows.Forms.RadioButton
    Friend WithEvents btnKojinninnsatu As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbnPreview As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInnsatu As System.Windows.Forms.RadioButton
    Friend WithEvents rbnByoutoujosyu As System.Windows.Forms.RadioButton
    Friend WithEvents rbnRyouyoubyoutou As System.Windows.Forms.RadioButton
    Friend WithEvents rbnGairai As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIppannbyoutou As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnInnsatu As System.Windows.Forms.Button
    Friend WithEvents btnSakujo As System.Windows.Forms.Button
    Friend WithEvents btnTouroku As System.Windows.Forms.Button
    Friend WithEvents btnSyuukannhyou As System.Windows.Forms.Button
    Friend WithEvents btnSyuukei As System.Windows.Forms.Button

End Class
