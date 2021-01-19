Public Class Form1
    Dim basla As Integer = 0
    Private Sub kaydet_menu_Click(sender As Object, e As EventArgs) Handles kaydet_menu.Click
        Dim s As Object
        SaveFileDialog1.Filter = "doc dosyaları|*.doc|docx dosyaları|*.docx| metin dosyaları|*.txt|tüm dosyalar|*.*"
        SaveFileDialog1.DefaultExt = "*.docx"
        SaveFileDialog1.Title = "Dosyayı Kaydet"
        SaveFileDialog1.ShowDialog()
        'RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        s = RichTextBox1.Text
        Print(1, s)
        FileClose()
    End Sub

    Private Sub menu_aç_Click(sender As Object, e As EventArgs) Handles menu_aç.Click

        Dim s As Object
        OpenFileDialog1.Title = "Dosyayı AÇ"
        OpenFileDialog1.Filter = "doc dosyaları|*.doc|docx dosyaları|*.docx| metin dosyaları|*.txt|tüm dosyalar|*.*"
        OpenFileDialog1.ShowDialog()
        'RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        RichTextBox1.Clear()
        While Not EOF(1)
            s = LineInput(1)
            RichTextBox1.Text = RichTextBox1.Text + s & Chr(13) & Chr(10)
        End While
        FileClose(1)
    End Sub

    Private Sub Yazdır_Menu_Click(sender As Object, e As EventArgs) Handles Yazdır_Menu.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub Kapat_Menu_Click(sender As Object, e As EventArgs) Handles Kapat_Menu.Click
        Application.Exit()
    End Sub

    Private Sub YeniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub KopyalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopyalaToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub KesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KesToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(RichTextBox1.SelectedText)
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub YapıştırToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YapıştırToolStripMenuItem.Click
        RichTextBox1.SelectedText = Clipboard.GetText

    End Sub

    Private Sub GerialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerialToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub YieleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YieleToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub Kopyala_kısaYol_Click(sender As Object, e As EventArgs) Handles Kopyala_kısaYol.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub Kes_kısaYol_Click(sender As Object, e As EventArgs) Handles Kes_kısaYol.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub Yapıştır_kısaYol_Click(sender As Object, e As EventArgs) Handles Yapıştır_kısaYol.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub Yinele_kısaYol_Click(sender As Object, e As EventArgs) Handles Yinele_kısaYol.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub BüyükHarfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BüyükHarfToolStripMenuItem.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToUpper
    End Sub

    Private Sub KüçükHarfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KüçükHarfToolStripMenuItem.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToLower
    End Sub

    Private Sub YazıTipiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazıTipiToolStripMenuItem.Click
        FontDialog1.ShowColor = True
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = (FontDialog1.Font)
        RichTextBox1.SelectionColor = FontDialog1.Color


    End Sub

    Private Sub YazıRengiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazıRengiToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub ZeminRengiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZeminRengiToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionBackColor = ColorDialog1.Color

    End Sub

    Private Sub aracb1_Click(sender As Object, e As EventArgs) Handles aracb1.Click
        Dim s As Object
        OpenFileDialog1.Title = "Dosyayı AÇ"
        OpenFileDialog1.Filter = "doc dosyaları|*.doc|docx dosyaları|*.docx| metin dosyaları|*.txt|tüm dosyalar|*.*"
        OpenFileDialog1.ShowDialog()
        'RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        RichTextBox1.Clear()
        While Not EOF(1)
            s = LineInput(1)
            RichTextBox1.Text = RichTextBox1.Text + s & Chr(13) & Chr(10)
        End While
        FileClose(1)
    End Sub

    Private Sub aracb2_Click(sender As Object, e As EventArgs) Handles aracb2.Click
        Dim s As Object
        SaveFileDialog1.Filter = "doc dosyaları|*.doc|docx dosyaları|*.docx| metin dosyaları|*.txt|tüm dosyalar|*.*"
        SaveFileDialog1.DefaultExt = "*.docx"
        SaveFileDialog1.Title = "Dosyayı Kaydet"
        SaveFileDialog1.ShowDialog()
        'RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        s = RichTextBox1.Text
        Print(1, s)
        FileClose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RichTextBox1.SelectionFont = New Font(ComboBox1.Text.ToString, 11, RichTextBox1.SelectionFont.Style)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim yb As Integer
        yb = Convert.ToInt32(ComboBox2.Text)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, yb, RichTextBox1.SelectionFont.Style)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Bold)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Xor FontStyle.Bold)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Italic)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Xor FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Underline)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Xor FontStyle.Underline)
        End If
    End Sub

    Private Sub aracb3_Click(sender As Object, e As EventArgs) Handles aracb3.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub aracb4_Click(sender As Object, e As EventArgs) Handles aracb4.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub araç_ComboBox1_Click(sender As Object, e As EventArgs) Handles araç_ComboBox1.Click
        Dim yt As FontFamily
        For Each yt In System.Drawing.FontFamily.Families
            araç_ComboBox1.Items.Add(yt.Name)
        Next
        araç_ComboBox1.SelectedIndex = 5
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 8 To 12
            ComboBox2.Items.Add(i)
        Next
        For y = 14 To 28 Step 2
            ComboBox2.Items.Add(y)
        Next
        For a = 30 To 100 Step 5
            ComboBox2.Items.Add(a)
        Next
        ComboBox2.SelectedIndex = 3
        For a = 30 To 100 Step 5
            ComboBox2.Items.Add(a)
        Next
        ComboBox2.SelectedIndex = 3
        'yazı tipi küyüphanesini kullanacagı fontFamiliy
        Dim yt As FontFamily
        For Each yt In System.Drawing.FontFamily.Families
            ComboBox1.Items.Add(yt.Name)
        Next
        ComboBox1.SelectedIndex = 19
    End Sub

    Private Sub araç_ComboBox2_Click(sender As Object, e As EventArgs) Handles araç_ComboBox2.Click
        For i = 8 To 12
            araç_ComboBox2.Items.Add(i)
        Next
        For y = 14 To 28 Step 2
            araç_ComboBox2.Items.Add(y)
        Next
        For a = 30 To 100 Step 5
            araç_ComboBox2.Items.Add(a)
        Next
        araç_ComboBox2.SelectedIndex = 3

    End Sub

    Private Sub ara_araç_text_Click(sender As Object, e As EventArgs) Handles ara_araç_text.Click


    End Sub

    Private Sub araButton1_Click(sender As Object, e As EventArgs) Handles araButton1.Click
        Dim ara As String = ara_araç_text.Text
        Dim bastext As Integer = 0
        Dim sontext As Integer
        sontext = RichTextBox1.Text.LastIndexOf(ara)
        While bastext < sontext
            RichTextBox1.Find(ara, bastext, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Blue
            bastext = RichTextBox1.Text.IndexOf(ara, bastext) + 1
        End While

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim ara As String = ara_araç_text.Text
        Dim bastext As Integer = 0
        Dim sontext As Integer
        sontext = RichTextBox1.Text.LastIndexOf(ara)
        While bastext < sontext
            RichTextBox1.Find(ara, bastext, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Yellow
            bastext = RichTextBox1.Text.IndexOf(ara, bastext) + 1
        End While
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim ara As String = ara_araç_text.Text
        RichTextBox1.Focus() ' richtextbox ı seçmeye yarar
        basla = RichTextBox1.Find(ara, basla, RichTextBoxFinds.MatchCase)
        RichTextBox1.Select(basla, ara.Length)
        basla = basla + ara.Length
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.Clear()
        OpenFileDialog1.ShowDialog()
        Dim resim As Image
        resim = Image.FromFile(OpenFileDialog1.FileName) 'dosyanın adını resim değişkenine yükledi
        Clipboard.SetImage(resim)
        Me.RichTextBox1.Paste()

    End Sub

    Private Sub ResimEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResimEkleToolStripMenuItem.Click
        Clipboard.Clear()
        OpenFileDialog1.ShowDialog()
        Dim resim1 As Bitmap = Image.FromFile(OpenFileDialog1.FileName)
        Clipboard.SetDataObject(resim1)
        Dim tur As DataFormats.Format
        tur = DataFormats.GetFormat(DataFormats.Bitmap)
        If RichTextBox1.CanPaste(tur) Then
            Me.RichTextBox1.Paste()
        Else
            MsgBox("nesne resim türünde değildir")
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color

    End Sub
End Class
