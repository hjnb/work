Imports System.Data.OleDb
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1

    Public DB_work As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\yoshi\Desktop\Work2.mdb"
    'Public DB_work As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PRIMERGYTX100S1\Hakojun\事務\さかもと\Work2.mdb"

    Private bs As BindingSource

    Private disableCellStyle As DataGridViewCellStyle

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'セルのスタイルの設定
        disableCellStyle = New DataGridViewCellStyle()
        disableCellStyle.BackColor = Color.LightGray
        disableCellStyle.SelectionBackColor = Color.LightGray
        disableCellStyle.SelectionForeColor = Color.LightGray

        '年の選択値設定(直近2年)
        Dim today As DateTime = DateTime.Today
        cmbYear.Items.Add(today.Year - 1)
        cmbYear.Items.Add(today.Year)

        '年月の初期設定
        cmbYear.Text = today.Year
        cmbMonth.Text = If(today.Month < 10, "0" & today.Month, today.Month)

        'ダブルバッファリングを有効に
        EnableDoubleBuffering(DataGridView1)

        'DataGridViewの設定
        With DataGridView1
            '新規行追加禁止
            .AllowUserToAddRows = False
            '左端の列削除
            .RowHeadersVisible = False
            '列のヘッダー非表示
            .ColumnHeadersVisible = False
            '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeColumns = False
            '行の高さをユーザーが変更できないようにする
            .AllowUserToResizeRows = False
            '高さの自動調整を無効
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            'フォント設定
            .Font = New Font("メイリオ", 10)
        End With

        '初期表示
        resetWorkTable()

    End Sub

    ''' <summary>
    ''' コントロールのDoubleBufferedプロパティをTrueにする
    ''' </summary>
    ''' <param name="control">対象のコントロール</param>
    Public Shared Sub EnableDoubleBuffering(control As Control)
        control.GetType().InvokeMember("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetProperty, Nothing, control, New Object() {True})
    End Sub

    Private Sub resetWorkTable()
        bs = New BindingSource()
        For i = 0 To 20
            bs.Add(New workData())
            bs.Add(New workData())
        Next
        DataGridView1.DataSource = bs

        'DataGridView1(0, 1).ReadOnly = True
        'DataGridView1(0, 1).Style = disableCellStyle

    End Sub

    Private Sub displayWorkTable(type As String, year As String, month As String)
        Dim Cn As New OleDbConnection(DB_work)
        Dim SQLCm As OleDbCommand = Cn.CreateCommand
        Dim reader As System.Data.OleDb.OleDbDataReader
        Dim yoteiDay(31) As String
        Dim henkouDay(31) As String
        Dim ymStr As String = year & "/" & month

        bs = New BindingSource()

        SQLCm.CommandText = "SELECT * FROM KHyo WHERE Hyo='" & type & "' AND YM='" & ymStr & "'"
        Cn.Open()
        reader = SQLCm.ExecuteReader()
        While reader.Read() = True
            For i = 1 To 31
                yoteiDay(i) = reader("Y" & i)
                henkouDay(i) = reader("H" & i)
            Next
            bs.Add(New workData(reader("Syu"), reader("Nam"), "予", yoteiDay))
            bs.Add(New workData("", "", "変", henkouDay))
        End While
        reader.Close()
        Cn.Close()
        SQLCm.Dispose()
        Cn.Dispose()

        If bs.Count = 0 Then
            'まだ未入力の年月の場合は空のセルを表示
            resetWorkTable()
        Else
            'datasourceに設定
            DataGridView1.DataSource = bs
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim syu As String = ""
        Dim year As String = ""
        Dim month As String = ""

        If rbnIppannbyoutou.Checked = True Then
            syu = "一般"
        ElseIf rbnRyouyoubyoutou.Checked = True Then
            syu = "療養"
        ElseIf rbnGairai.Checked = True Then
            syu = "外来"
        ElseIf rbnByoutoujosyu.Checked = True Then
            syu = "助手"
        ElseIf rbnSityousitu.Checked = True Then
            syu = "師長"
        Else
            MsgBox("種別のラジオボタンにチェックを入れて下さい。")
        End If

        If cmbYear.Text = "" Then
            MsgBox("西暦を選択または入力してください")
        Else
            year = cmbYear.Text
        End If

        If cmbMonth.Text = "" Then
            MsgBox("月を選択または入力してください")
        Else
            month = cmbMonth.Text
        End If

        '指定された職種、年月の勤務表を表示
        displayWorkTable(syu, cmbYear.Text, cmbMonth.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        '選択されている行のインデックス取得
        Dim selectedRowIndex As Integer = DataGridView1.CurrentRow.Index
        MsgBox(selectedRowIndex)

        bs.Insert(2, New workData())
        bs.Insert(2, New workData())
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        'DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Selected = False
    End Sub
End Class

