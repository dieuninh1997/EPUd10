﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menuform
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation11 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuform))
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation12 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnKhach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnhome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhaCC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChucVu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnmenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.tranlogo = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChucVuForm1 = New WindowsApplication2.ChucVuForm()
        Me.KhachHangForm1 = New WindowsApplication2.KhachHangForm()
        Me.NhaCCform1 = New WindowsApplication2.NhaCCform()
        Me.tranpanel = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tranNhaCC = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranChucVu = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranKhachhang = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btnNhanVien = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NhanVien1 = New WindowsApplication2.NhanVien()
        Me.tranNhanVien = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranNhanVien.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 46)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tranNhanVien.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.ErrorImage = Nothing
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1129, 8)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox1
        '
        Me.tranKhachhang.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.tranNhanVien.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(77, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(125, 24)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Shop Parada"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tranNhanVien.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.ErrorImage = Nothing
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1165, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Panel4)
        Me.pnlMenu.Controls.Add(Me.btnmenu)
        Me.pnlMenu.Controls.Add(Me.pcb1)
        Me.tranNhanVien.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 46)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(237, 694)
        Me.pnlMenu.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnNhanVien)
        Me.Panel4.Controls.Add(Me.btnKhach)
        Me.Panel4.Controls.Add(Me.btnhome)
        Me.Panel4.Controls.Add(Me.btnNhaCC)
        Me.Panel4.Controls.Add(Me.btnChucVu)
        Me.tranNhanVien.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(0, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 500)
        Me.Panel4.TabIndex = 4
        '
        'btnKhach
        '
        Me.btnKhach.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnKhach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnKhach.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKhach.BorderRadius = 0
        Me.btnKhach.ButtonText = "Customer"
        Me.btnKhach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranKhachhang.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.btnKhach.DisabledColor = System.Drawing.Color.Gray
        Me.btnKhach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnKhach.Iconimage = CType(resources.GetObject("btnKhach.Iconimage"), System.Drawing.Image)
        Me.btnKhach.Iconimage_right = Nothing
        Me.btnKhach.Iconimage_right_Selected = Nothing
        Me.btnKhach.Iconimage_Selected = Nothing
        Me.btnKhach.IconMarginLeft = 0
        Me.btnKhach.IconMarginRight = 0
        Me.btnKhach.IconRightVisible = True
        Me.btnKhach.IconRightZoom = 0R
        Me.btnKhach.IconVisible = True
        Me.btnKhach.IconZoom = 50.0R
        Me.btnKhach.IsTab = False
        Me.btnKhach.Location = New System.Drawing.Point(13, 51)
        Me.btnKhach.Name = "btnKhach"
        Me.btnKhach.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKhach.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKhach.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnKhach.selected = False
        Me.btnKhach.Size = New System.Drawing.Size(218, 36)
        Me.btnKhach.TabIndex = 6
        Me.btnKhach.Text = "Customer"
        Me.btnKhach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnKhach.Textcolor = System.Drawing.Color.White
        Me.btnKhach.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnhome
        '
        Me.btnhome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnhome.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhome.BorderRadius = 0
        Me.btnhome.ButtonText = "Home"
        Me.btnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranKhachhang.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.btnhome.DisabledColor = System.Drawing.Color.Gray
        Me.btnhome.Iconcolor = System.Drawing.Color.Transparent
        Me.btnhome.Iconimage = CType(resources.GetObject("btnhome.Iconimage"), System.Drawing.Image)
        Me.btnhome.Iconimage_right = Nothing
        Me.btnhome.Iconimage_right_Selected = Nothing
        Me.btnhome.Iconimage_Selected = Nothing
        Me.btnhome.IconMarginLeft = 0
        Me.btnhome.IconMarginRight = 0
        Me.btnhome.IconRightVisible = True
        Me.btnhome.IconRightZoom = 0R
        Me.btnhome.IconVisible = True
        Me.btnhome.IconZoom = 50.0R
        Me.btnhome.IsTab = False
        Me.btnhome.Location = New System.Drawing.Point(13, 3)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnhome.selected = False
        Me.btnhome.Size = New System.Drawing.Size(218, 33)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Home"
        Me.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnhome.Textcolor = System.Drawing.Color.Silver
        Me.btnhome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNhaCC
        '
        Me.btnNhaCC.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhaCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhaCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhaCC.BorderRadius = 0
        Me.btnNhaCC.ButtonText = "Supplier"
        Me.btnNhaCC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranKhachhang.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhaCC.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhaCC.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhaCC.Iconimage = CType(resources.GetObject("btnNhaCC.Iconimage"), System.Drawing.Image)
        Me.btnNhaCC.Iconimage_right = Nothing
        Me.btnNhaCC.Iconimage_right_Selected = Nothing
        Me.btnNhaCC.Iconimage_Selected = Nothing
        Me.btnNhaCC.IconMarginLeft = 0
        Me.btnNhaCC.IconMarginRight = 0
        Me.btnNhaCC.IconRightVisible = True
        Me.btnNhaCC.IconRightZoom = 0R
        Me.btnNhaCC.IconVisible = True
        Me.btnNhaCC.IconZoom = 40.0R
        Me.btnNhaCC.IsTab = False
        Me.btnNhaCC.Location = New System.Drawing.Point(13, 104)
        Me.btnNhaCC.Name = "btnNhaCC"
        Me.btnNhaCC.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhaCC.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhaCC.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhaCC.selected = False
        Me.btnNhaCC.Size = New System.Drawing.Size(218, 35)
        Me.btnNhaCC.TabIndex = 4
        Me.btnNhaCC.Text = "Supplier"
        Me.btnNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhaCC.Textcolor = System.Drawing.Color.White
        Me.btnNhaCC.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnChucVu
        '
        Me.btnChucVu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChucVu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChucVu.BorderRadius = 0
        Me.btnChucVu.ButtonText = "Regency"
        Me.btnChucVu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranKhachhang.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.btnChucVu.DisabledColor = System.Drawing.Color.Gray
        Me.btnChucVu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnChucVu.Iconimage = CType(resources.GetObject("btnChucVu.Iconimage"), System.Drawing.Image)
        Me.btnChucVu.Iconimage_right = Nothing
        Me.btnChucVu.Iconimage_right_Selected = Nothing
        Me.btnChucVu.Iconimage_Selected = Nothing
        Me.btnChucVu.IconMarginLeft = 0
        Me.btnChucVu.IconMarginRight = 0
        Me.btnChucVu.IconRightVisible = True
        Me.btnChucVu.IconRightZoom = 0R
        Me.btnChucVu.IconVisible = True
        Me.btnChucVu.IconZoom = 50.0R
        Me.btnChucVu.IsTab = False
        Me.btnChucVu.Location = New System.Drawing.Point(13, 155)
        Me.btnChucVu.Name = "btnChucVu"
        Me.btnChucVu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChucVu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChucVu.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChucVu.selected = False
        Me.btnChucVu.Size = New System.Drawing.Size(218, 36)
        Me.btnChucVu.TabIndex = 5
        Me.btnChucVu.Text = "Regency"
        Me.btnChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChucVu.Textcolor = System.Drawing.Color.White
        Me.btnChucVu.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranNhanVien.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnmenu.ErrorImage = Nothing
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.ImageActive = Nothing
        Me.btnmenu.InitialImage = Nothing
        Me.btnmenu.Location = New System.Drawing.Point(167, 60)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(25, 25)
        Me.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmenu.TabIndex = 3
        Me.btnmenu.TabStop = False
        Me.btnmenu.Zoom = 10
        '
        'pcb1
        '
        Me.tranKhachhang.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.pcb1.Image = CType(resources.GetObject("pcb1.Image"), System.Drawing.Image)
        Me.pcb1.Location = New System.Drawing.Point(38, 49)
        Me.pcb1.Name = "pcb1"
        Me.pcb1.Size = New System.Drawing.Size(104, 42)
        Me.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb1.TabIndex = 2
        Me.pcb1.TabStop = False
        '
        'tranlogo
        '
        Me.tranlogo.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.tranlogo.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(30)
        Animation10.RotateCoeff = 0.5!
        Animation10.RotateLimit = 0.2!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 0!
        Me.tranlogo.DefaultAnimation = Animation10
        Me.tranlogo.TimeStep = 0.01!
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.tranNhanVien.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(237, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 694)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.NhanVien1)
        Me.Panel3.Controls.Add(Me.ChucVuForm1)
        Me.Panel3.Controls.Add(Me.KhachHangForm1)
        Me.Panel3.Controls.Add(Me.NhaCCform1)
        Me.tranNhanVien.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(46, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(887, 676)
        Me.Panel3.TabIndex = 0
        '
        'ChucVuForm1
        '
        Me.ChucVuForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tranNhaCC.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.ChucVuForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChucVuForm1.Location = New System.Drawing.Point(0, 0)
        Me.ChucVuForm1.Name = "ChucVuForm1"
        Me.ChucVuForm1.Size = New System.Drawing.Size(887, 676)
        Me.ChucVuForm1.TabIndex = 3
        '
        'KhachHangForm1
        '
        Me.KhachHangForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tranNhaCC.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.KhachHangForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KhachHangForm1.Location = New System.Drawing.Point(0, 0)
        Me.KhachHangForm1.Name = "KhachHangForm1"
        Me.KhachHangForm1.Size = New System.Drawing.Size(887, 676)
        Me.KhachHangForm1.TabIndex = 2
        Me.KhachHangForm1.Visible = False
        '
        'NhaCCform1
        '
        Me.tranNhaCC.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.NhaCCform1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NhaCCform1.Location = New System.Drawing.Point(0, 0)
        Me.NhaCCform1.Name = "NhaCCform1"
        Me.NhaCCform1.Size = New System.Drawing.Size(887, 676)
        Me.NhaCCform1.TabIndex = 1
        Me.NhaCCform1.Visible = False
        '
        'tranpanel
        '
        Me.tranpanel.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tranpanel.Cursor = Nothing
        Animation11.AnimateOnlyDifferences = True
        Animation11.BlindCoeff = CType(resources.GetObject("Animation11.BlindCoeff"), System.Drawing.PointF)
        Animation11.LeafCoeff = 1.0!
        Animation11.MaxTime = 1.0!
        Animation11.MinTime = 0!
        Animation11.MosaicCoeff = CType(resources.GetObject("Animation11.MosaicCoeff"), System.Drawing.PointF)
        Animation11.MosaicShift = CType(resources.GetObject("Animation11.MosaicShift"), System.Drawing.PointF)
        Animation11.MosaicSize = 0
        Animation11.Padding = New System.Windows.Forms.Padding(0)
        Animation11.RotateCoeff = 0!
        Animation11.RotateLimit = 0!
        Animation11.ScaleCoeff = CType(resources.GetObject("Animation11.ScaleCoeff"), System.Drawing.PointF)
        Animation11.SlideCoeff = CType(resources.GetObject("Animation11.SlideCoeff"), System.Drawing.PointF)
        Animation11.TimeCoeff = 0!
        Animation11.TransparencyCoeff = 0!
        Me.tranpanel.DefaultAnimation = Animation11
        Me.tranpanel.TimeStep = 0.01!
        '
        'tranNhaCC
        '
        Me.tranNhaCC.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tranNhaCC.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 1.0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.tranNhaCC.DefaultAnimation = Animation7
        '
        'tranChucVu
        '
        Me.tranChucVu.AnimationType = BunifuAnimatorNS.AnimationType.Custom
        Me.tranChucVu.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 0!
        Me.tranChucVu.DefaultAnimation = Animation8
        '
        'tranKhachhang
        '
        Me.tranKhachhang.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranKhachhang.Cursor = Nothing
        Animation12.AnimateOnlyDifferences = True
        Animation12.BlindCoeff = CType(resources.GetObject("Animation12.BlindCoeff"), System.Drawing.PointF)
        Animation12.LeafCoeff = 0!
        Animation12.MaxTime = 1.0!
        Animation12.MinTime = 0!
        Animation12.MosaicCoeff = CType(resources.GetObject("Animation12.MosaicCoeff"), System.Drawing.PointF)
        Animation12.MosaicShift = CType(resources.GetObject("Animation12.MosaicShift"), System.Drawing.PointF)
        Animation12.MosaicSize = 0
        Animation12.Padding = New System.Windows.Forms.Padding(0)
        Animation12.RotateCoeff = 0!
        Animation12.RotateLimit = 0!
        Animation12.ScaleCoeff = CType(resources.GetObject("Animation12.ScaleCoeff"), System.Drawing.PointF)
        Animation12.SlideCoeff = CType(resources.GetObject("Animation12.SlideCoeff"), System.Drawing.PointF)
        Animation12.TimeCoeff = 0!
        Animation12.TransparencyCoeff = 0!
        Me.tranKhachhang.DefaultAnimation = Animation12
        '
        'btnNhanVien
        '
        Me.btnNhanVien.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhanVien.BorderRadius = 0
        Me.btnNhanVien.ButtonText = "Salesman"
        Me.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranKhachhang.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhanVien.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhanVien.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhanVien.Iconimage = CType(resources.GetObject("btnNhanVien.Iconimage"), System.Drawing.Image)
        Me.btnNhanVien.Iconimage_right = Nothing
        Me.btnNhanVien.Iconimage_right_Selected = Nothing
        Me.btnNhanVien.Iconimage_Selected = Nothing
        Me.btnNhanVien.IconMarginLeft = 0
        Me.btnNhanVien.IconMarginRight = 0
        Me.btnNhanVien.IconRightVisible = True
        Me.btnNhanVien.IconRightZoom = 0R
        Me.btnNhanVien.IconVisible = True
        Me.btnNhanVien.IconZoom = 50.0R
        Me.btnNhanVien.IsTab = False
        Me.btnNhanVien.Location = New System.Drawing.Point(13, 210)
        Me.btnNhanVien.Name = "btnNhanVien"
        Me.btnNhanVien.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhanVien.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhanVien.selected = False
        Me.btnNhanVien.Size = New System.Drawing.Size(218, 36)
        Me.btnNhanVien.TabIndex = 7
        Me.btnNhanVien.Text = "Salesman"
        Me.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhanVien.Textcolor = System.Drawing.Color.White
        Me.btnNhanVien.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NhanVien1
        '
        Me.NhanVien1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.tranNhaCC.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NhanVien1.Location = New System.Drawing.Point(0, 0)
        Me.NhanVien1.Name = "NhanVien1"
        Me.NhanVien1.Size = New System.Drawing.Size(887, 676)
        Me.NhanVien1.TabIndex = 4
        Me.NhanVien1.Visible = False
        '
        'tranNhanVien
        '
        Me.tranNhanVien.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranNhanVien.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation9.RotateCoeff = 0!
        Animation9.RotateLimit = 0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0!
        Animation9.TransparencyCoeff = 0!
        Me.tranNhanVien.DefaultAnimation = Animation9
        '
        'Menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 740)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.Panel1)
        Me.tranNhanVien.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menuform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnKhach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnhome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhaCC As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnChucVu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnmenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pcb1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tranlogo As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranpanel As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tranChucVu As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranNhaCC As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tranKhachhang As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KhachHangForm1 As KhachHangForm
    Friend WithEvents NhaCCform1 As NhaCCform
    Friend WithEvents ChucVuForm1 As ChucVuForm
    Friend WithEvents btnNhanVien As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents NhanVien1 As NhanVien
    Friend WithEvents tranNhanVien As BunifuAnimatorNS.BunifuTransition
End Class
