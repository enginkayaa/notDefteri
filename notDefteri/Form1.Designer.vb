<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_aç = New System.Windows.Forms.ToolStripMenuItem()
        Me.kaydet_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yazdır_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Kapat_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YieleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YapıştırToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiçimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YazıTipiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YazıRengiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HarfDönüştürToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BüyükHarfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KüçükHarfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZeminRengiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResimEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Kes_kısaYol = New System.Windows.Forms.ToolStripMenuItem()
        Me.Kopyala_kısaYol = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yapıştır_kısaYol = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yazı_kısaYol = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gerial_kısaYol = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yinele_kısaYol = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.aracb1 = New System.Windows.Forms.ToolStripButton()
        Me.aracb2 = New System.Windows.Forms.ToolStripButton()
        Me.aracb3 = New System.Windows.Forms.ToolStripButton()
        Me.aracb4 = New System.Windows.Forms.ToolStripButton()
        Me.aracb5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.araç_ComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.araç_ComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ara_araç_text = New System.Windows.Forms.ToolStripTextBox()
        Me.araButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 90)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(656, 321)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.DüzenleToolStripMenuItem, Me.BiçimToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(744, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniToolStripMenuItem, Me.menu_aç, Me.kaydet_menu, Me.Yazdır_Menu, Me.Kapat_Menu})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.DosyaToolStripMenuItem.Text = "&dosya"
        '
        'YeniToolStripMenuItem
        '
        Me.YeniToolStripMenuItem.Image = CType(resources.GetObject("YeniToolStripMenuItem.Image"), System.Drawing.Image)
        Me.YeniToolStripMenuItem.Name = "YeniToolStripMenuItem"
        Me.YeniToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.YeniToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.YeniToolStripMenuItem.Text = "yeni"
        '
        'menu_aç
        '
        Me.menu_aç.Image = CType(resources.GetObject("menu_aç.Image"), System.Drawing.Image)
        Me.menu_aç.Name = "menu_aç"
        Me.menu_aç.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menu_aç.Size = New System.Drawing.Size(151, 22)
        Me.menu_aç.Text = "aç"
        '
        'kaydet_menu
        '
        Me.kaydet_menu.Image = CType(resources.GetObject("kaydet_menu.Image"), System.Drawing.Image)
        Me.kaydet_menu.Name = "kaydet_menu"
        Me.kaydet_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.kaydet_menu.Size = New System.Drawing.Size(151, 22)
        Me.kaydet_menu.Text = "kaydet"
        '
        'Yazdır_Menu
        '
        Me.Yazdır_Menu.Image = CType(resources.GetObject("Yazdır_Menu.Image"), System.Drawing.Image)
        Me.Yazdır_Menu.Name = "Yazdır_Menu"
        Me.Yazdır_Menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.Yazdır_Menu.Size = New System.Drawing.Size(151, 22)
        Me.Yazdır_Menu.Text = "yazdır"
        '
        'Kapat_Menu
        '
        Me.Kapat_Menu.Name = "Kapat_Menu"
        Me.Kapat_Menu.Size = New System.Drawing.Size(151, 22)
        Me.Kapat_Menu.Text = "kapat"
        '
        'DüzenleToolStripMenuItem
        '
        Me.DüzenleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YieleToolStripMenuItem, Me.GerialToolStripMenuItem, Me.KesToolStripMenuItem, Me.KopyalaToolStripMenuItem, Me.YapıştırToolStripMenuItem})
        Me.DüzenleToolStripMenuItem.Name = "DüzenleToolStripMenuItem"
        Me.DüzenleToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DüzenleToolStripMenuItem.Text = "Dü&zen"
        '
        'YieleToolStripMenuItem
        '
        Me.YieleToolStripMenuItem.Image = CType(resources.GetObject("YieleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.YieleToolStripMenuItem.Name = "YieleToolStripMenuItem"
        Me.YieleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.YieleToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.YieleToolStripMenuItem.Text = "yinele"
        '
        'GerialToolStripMenuItem
        '
        Me.GerialToolStripMenuItem.Image = CType(resources.GetObject("GerialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerialToolStripMenuItem.Name = "GerialToolStripMenuItem"
        Me.GerialToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.GerialToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GerialToolStripMenuItem.Text = "gerial"
        '
        'KesToolStripMenuItem
        '
        Me.KesToolStripMenuItem.Image = CType(resources.GetObject("KesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KesToolStripMenuItem.Name = "KesToolStripMenuItem"
        Me.KesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.KesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KesToolStripMenuItem.Text = "kes"
        '
        'KopyalaToolStripMenuItem
        '
        Me.KopyalaToolStripMenuItem.Image = CType(resources.GetObject("KopyalaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopyalaToolStripMenuItem.Name = "KopyalaToolStripMenuItem"
        Me.KopyalaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopyalaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KopyalaToolStripMenuItem.Text = "kopyala"
        '
        'YapıştırToolStripMenuItem
        '
        Me.YapıştırToolStripMenuItem.Image = CType(resources.GetObject("YapıştırToolStripMenuItem.Image"), System.Drawing.Image)
        Me.YapıştırToolStripMenuItem.Name = "YapıştırToolStripMenuItem"
        Me.YapıştırToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.YapıştırToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.YapıştırToolStripMenuItem.Text = "yapıştır"
        '
        'BiçimToolStripMenuItem
        '
        Me.BiçimToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YazıTipiToolStripMenuItem, Me.YazıRengiToolStripMenuItem, Me.HarfDönüştürToolStripMenuItem, Me.ZeminRengiToolStripMenuItem, Me.ResimEkleToolStripMenuItem})
        Me.BiçimToolStripMenuItem.Name = "BiçimToolStripMenuItem"
        Me.BiçimToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.BiçimToolStripMenuItem.Text = "&Biçim"
        '
        'YazıTipiToolStripMenuItem
        '
        Me.YazıTipiToolStripMenuItem.Name = "YazıTipiToolStripMenuItem"
        Me.YazıTipiToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.YazıTipiToolStripMenuItem.Text = "yazı tipi"
        '
        'YazıRengiToolStripMenuItem
        '
        Me.YazıRengiToolStripMenuItem.Name = "YazıRengiToolStripMenuItem"
        Me.YazıRengiToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.YazıRengiToolStripMenuItem.Text = "yazı rengi"
        '
        'HarfDönüştürToolStripMenuItem
        '
        Me.HarfDönüştürToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BüyükHarfToolStripMenuItem, Me.KüçükHarfToolStripMenuItem})
        Me.HarfDönüştürToolStripMenuItem.Name = "HarfDönüştürToolStripMenuItem"
        Me.HarfDönüştürToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.HarfDönüştürToolStripMenuItem.Text = "harf dönüştür"
        '
        'BüyükHarfToolStripMenuItem
        '
        Me.BüyükHarfToolStripMenuItem.Name = "BüyükHarfToolStripMenuItem"
        Me.BüyükHarfToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BüyükHarfToolStripMenuItem.Text = "Büyük harf"
        '
        'KüçükHarfToolStripMenuItem
        '
        Me.KüçükHarfToolStripMenuItem.Name = "KüçükHarfToolStripMenuItem"
        Me.KüçükHarfToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.KüçükHarfToolStripMenuItem.Text = "küçük harf"
        '
        'ZeminRengiToolStripMenuItem
        '
        Me.ZeminRengiToolStripMenuItem.Name = "ZeminRengiToolStripMenuItem"
        Me.ZeminRengiToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ZeminRengiToolStripMenuItem.Text = "zemin rengi"
        '
        'ResimEkleToolStripMenuItem
        '
        Me.ResimEkleToolStripMenuItem.Name = "ResimEkleToolStripMenuItem"
        Me.ResimEkleToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ResimEkleToolStripMenuItem.Text = "&resim ekle"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Kes_kısaYol, Me.Kopyala_kısaYol, Me.Yapıştır_kısaYol, Me.Yazı_kısaYol, Me.Gerial_kısaYol, Me.Yinele_kısaYol})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 136)
        '
        'Kes_kısaYol
        '
        Me.Kes_kısaYol.Name = "Kes_kısaYol"
        Me.Kes_kısaYol.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Kes_kısaYol.Size = New System.Drawing.Size(157, 22)
        Me.Kes_kısaYol.Text = "kes"
        '
        'Kopyala_kısaYol
        '
        Me.Kopyala_kısaYol.Name = "Kopyala_kısaYol"
        Me.Kopyala_kısaYol.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Kopyala_kısaYol.Size = New System.Drawing.Size(157, 22)
        Me.Kopyala_kısaYol.Text = "kopyala"
        '
        'Yapıştır_kısaYol
        '
        Me.Yapıştır_kısaYol.Name = "Yapıştır_kısaYol"
        Me.Yapıştır_kısaYol.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.Yapıştır_kısaYol.Size = New System.Drawing.Size(157, 22)
        Me.Yapıştır_kısaYol.Text = "yapıştır"
        '
        'Yazı_kısaYol
        '
        Me.Yazı_kısaYol.Name = "Yazı_kısaYol"
        Me.Yazı_kısaYol.Size = New System.Drawing.Size(157, 22)
        Me.Yazı_kısaYol.Text = "yazı tipi"
        '
        'Gerial_kısaYol
        '
        Me.Gerial_kısaYol.Name = "Gerial_kısaYol"
        Me.Gerial_kısaYol.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.Gerial_kısaYol.Size = New System.Drawing.Size(157, 22)
        Me.Gerial_kısaYol.Text = "gerial"
        '
        'Yinele_kısaYol
        '
        Me.Yinele_kısaYol.Name = "Yinele_kısaYol"
        Me.Yinele_kısaYol.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.Yinele_kısaYol.Size = New System.Drawing.Size(157, 22)
        Me.Yinele_kısaYol.Text = "yinele"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Text = "Baskı önizleme"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aracb1, Me.aracb2, Me.aracb3, Me.aracb4, Me.aracb5, Me.ToolStripLabel1, Me.araç_ComboBox1, Me.ToolStripLabel2, Me.araç_ComboBox2, Me.ToolStripLabel3, Me.ara_araç_text, Me.araButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'aracb1
        '
        Me.aracb1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.aracb1.Image = CType(resources.GetObject("aracb1.Image"), System.Drawing.Image)
        Me.aracb1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aracb1.Name = "aracb1"
        Me.aracb1.Size = New System.Drawing.Size(23, 22)
        Me.aracb1.Text = "araç_Button1"
        '
        'aracb2
        '
        Me.aracb2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.aracb2.Image = CType(resources.GetObject("aracb2.Image"), System.Drawing.Image)
        Me.aracb2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aracb2.Name = "aracb2"
        Me.aracb2.Size = New System.Drawing.Size(23, 22)
        Me.aracb2.Text = "araç_Button2"
        '
        'aracb3
        '
        Me.aracb3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.aracb3.Image = CType(resources.GetObject("aracb3.Image"), System.Drawing.Image)
        Me.aracb3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aracb3.Name = "aracb3"
        Me.aracb3.Size = New System.Drawing.Size(23, 22)
        Me.aracb3.Text = "araç_Button3"
        '
        'aracb4
        '
        Me.aracb4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.aracb4.Image = CType(resources.GetObject("aracb4.Image"), System.Drawing.Image)
        Me.aracb4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aracb4.Name = "aracb4"
        Me.aracb4.Size = New System.Drawing.Size(23, 22)
        Me.aracb4.Text = "araç_Button4"
        '
        'aracb5
        '
        Me.aracb5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.aracb5.Image = CType(resources.GetObject("aracb5.Image"), System.Drawing.Image)
        Me.aracb5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aracb5.Name = "aracb5"
        Me.aracb5.Size = New System.Drawing.Size(23, 22)
        Me.aracb5.Text = "araç_Button5"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel1.Text = "yazı tipi"
        '
        'araç_ComboBox1
        '
        Me.araç_ComboBox1.Name = "araç_ComboBox1"
        Me.araç_ComboBox1.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel2.Text = "yazı boyutu"
        '
        'araç_ComboBox2
        '
        Me.araç_ComboBox2.Name = "araç_ComboBox2"
        Me.araç_ComboBox2.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel3.Text = "ara"
        '
        'ara_araç_text
        '
        Me.ara_araç_text.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ara_araç_text.Name = "ara_araç_text"
        Me.ara_araç_text.Size = New System.Drawing.Size(100, 25)
        '
        'araButton1
        '
        Me.araButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.araButton1.Image = CType(resources.GetObject("araButton1.Image"), System.Drawing.Image)
        Me.araButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.araButton1.Name = "araButton1"
        Me.araButton1.Size = New System.Drawing.Size(23, 22)
        Me.araButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(413, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "yazı tipi"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(59, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(86, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(217, 61)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "yazı boyutu"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(596, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 25)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Image = CType(resources.GetObject("CheckBox1.Image"), System.Drawing.Image)
        Me.CheckBox1.Location = New System.Drawing.Point(315, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(25, 26)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Image = CType(resources.GetObject("CheckBox2.Image"), System.Drawing.Image)
        Me.CheckBox2.Location = New System.Drawing.Point(346, 57)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(28, 28)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Image = CType(resources.GetObject("CheckBox3.Image"), System.Drawing.Image)
        Me.CheckBox3.Location = New System.Drawing.Point(380, 56)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(27, 31)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(674, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 62)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Image = CType(resources.GetObject("RadioButton1.Image"), System.Drawing.Image)
        Me.RadioButton1.Location = New System.Drawing.Point(446, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(28, 29)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Image = CType(resources.GetObject("RadioButton2.Image"), System.Drawing.Image)
        Me.RadioButton2.Location = New System.Drawing.Point(480, 57)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(29, 26)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Image = CType(resources.GetObject("RadioButton3.Image"), System.Drawing.Image)
        Me.RadioButton3.Location = New System.Drawing.Point(515, 57)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(28, 26)
        Me.RadioButton3.TabIndex = 17
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(549, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 27)
        Me.Button4.TabIndex = 18
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(744, 378)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_aç As ToolStripMenuItem
    Friend WithEvents kaydet_menu As ToolStripMenuItem
    Friend WithEvents Yazdır_Menu As ToolStripMenuItem
    Friend WithEvents DüzenleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YieleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopyalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YapıştırToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BiçimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YazıTipiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YazıRengiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HarfDönüştürToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BüyükHarfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KüçükHarfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZeminRengiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Kes_kısaYol As ToolStripMenuItem
    Friend WithEvents Kopyala_kısaYol As ToolStripMenuItem
    Friend WithEvents Yapıştır_kısaYol As ToolStripMenuItem
    Friend WithEvents Yazı_kısaYol As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Kapat_Menu As ToolStripMenuItem
    Friend WithEvents Gerial_kısaYol As ToolStripMenuItem
    Friend WithEvents Yinele_kısaYol As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents aracb1 As ToolStripButton
    Friend WithEvents aracb2 As ToolStripButton
    Friend WithEvents aracb3 As ToolStripButton
    Friend WithEvents aracb4 As ToolStripButton
    Friend WithEvents aracb5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents araç_ComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents araç_ComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ara_araç_text As ToolStripTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents araButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ResimEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button4 As Button
End Class
