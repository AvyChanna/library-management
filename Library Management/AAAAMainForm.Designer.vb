﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AAAAMainForm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AAAAMainFormSkin = New Library_Management.FormSkin()
        Me.AAAAMiniButtonMain = New Library_Management.MyMini()
        Me.AAAALogoutButton = New Library_Management.MyButton()
        Me.AAAAExitButton = New Library_Management.MyButton()
        Me.StatusBar = New Library_Management.MyStatusBar()
        Me.TabControlMain = New Library_Management.MyTabControl()
        Me.SearchBooksTab = New System.Windows.Forms.TabPage()
        Me.AlertBox1 = New Library_Management.MyAlertBox()
        Me.SearchBookButton = New Library_Management.MyButton()
        Me.AAAAALabel11 = New Library_Management.MyLabel()
        Me.MyLabel25 = New Library_Management.MyLabel()
        Me.AAAAALabel10 = New Library_Management.MyLabel()
        Me.AAAAALabel3 = New Library_Management.MyLabel()
        Me.AAAAALabel2 = New Library_Management.MyLabel()
        Me.AAAAALabel9 = New Library_Management.MyLabel()
        Me.SearchBookAuthorTextBox = New Library_Management.MyTextBox()
        Me.SearchBookGenreTextBox = New Library_Management.MyTextBox()
        Me.SearchBookNameTextBox = New Library_Management.MyTextBox()
        Me.SearchBookIDTextBox = New Library_Management.MyTextBox()
        Me.SearchBookISBNTextBox = New Library_Management.MyTextBox()
        Me.BrowseBooksTab = New System.Windows.Forms.TabPage()
        Me.AlertBox2 = New Library_Management.MyAlertBox()
        Me.BrowseBooksDataGrid = New System.Windows.Forms.DataGridView()
        Me.BrowseBooksContextMenu = New Library_Management.MyContextMenuStrip()
        Me.IssueSelectedBookToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyBookNameToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyISBNNumberToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyBookIDToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBookTab = New System.Windows.Forms.TabPage()
        Me.AlertBox3 = New Library_Management.MyAlertBox()
        Me.ReturnGroupbox = New Library_Management.MyGroupBox()
        Me.ReturnBookInfoTextBox = New Library_Management.MyTextBox()
        Me.AAAAALabel18 = New Library_Management.MyLabel()
        Me.ReturnButton = New Library_Management.MyButton()
        Me.ReturnBookSearchDropDown = New Library_Management.MyComboBox()
        Me.AAIssueGroupBox = New Library_Management.MyGroupBox()
        Me.IssueBookInfoTextBox = New Library_Management.MyTextBox()
        Me.MyLabel1 = New Library_Management.MyLabel()
        Me.IssueButton = New Library_Management.MyButton()
        Me.IssueBookSearchDropDown = New Library_Management.MyComboBox()
        Me.SummaryTab = New System.Windows.Forms.TabPage()
        Me.AlertBox4 = New Library_Management.MyAlertBox()
        Me.AASummaryChangePasswordGroupBox = New Library_Management.MyGroupBox()
        Me.ProfileChangeAlert = New Library_Management.MyAlertBox()
        Me.SummaryChangePasswordButton = New Library_Management.MyButton()
        Me.AAASummaryConfirmPasswordPicture = New System.Windows.Forms.PictureBox()
        Me.AAASummaryNewPasswordPicture = New System.Windows.Forms.PictureBox()
        Me.SummaryOldPasswordPicture = New System.Windows.Forms.PictureBox()
        Me.SummaryOldPasswordTextbox = New Library_Management.MyTextBox()
        Me.SummaryConfirmPasswordTextBox = New Library_Management.MyTextBox()
        Me.AAAAALabel15 = New Library_Management.MyLabel()
        Me.AAAAALabel17 = New Library_Management.MyLabel()
        Me.AAAAALabel16 = New Library_Management.MyLabel()
        Me.SummaryNewPasswordTextBox = New Library_Management.MyTextBox()
        Me.AAAProfileGroupBox = New Library_Management.MyGroupBox()
        Me.AAAAALabel22 = New Library_Management.MyLabel()
        Me.SummaryProfileDropDownBox = New Library_Management.MyComboBox()
        Me.SummaryFullnameTextBox = New Library_Management.MyTextBox()
        Me.SummaryEditProfileButton = New Library_Management.MyButton()
        Me.SummaryUsernameTextBox = New Library_Management.MyTextBox()
        Me.AAAAALabel20 = New Library_Management.MyLabel()
        Me.AAAAALabel21 = New Library_Management.MyLabel()
        Me.AASummaryGroupBox = New Library_Management.MyGroupBox()
        Me.SummaryViewIssuedBooks = New Library_Management.MyButton()
        Me.SummaryBooksIssuedTextBox = New Library_Management.MyTextBox()
        Me.SummaryDueTextBox = New Library_Management.MyTextBox()
        Me.AAAAALabel13 = New Library_Management.MyLabel()
        Me.AAAAALabel14 = New Library_Management.MyLabel()
        Me.AdminOptionsTab = New System.Windows.Forms.TabPage()
        Me.AdminTabControl = New Library_Management.MyTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AlertBox5 = New Library_Management.MyAlertBox()
        Me.MyGroupBox5 = New Library_Management.MyGroupBox()
        Me.AdminDeleteAccButton = New Library_Management.MyButton()
        Me.MyLabel13 = New Library_Management.MyLabel()
        Me.AdminDeleteAccUsernameTextBox = New Library_Management.MyTextBox()
        Me.MyGroupBox1 = New Library_Management.MyGroupBox()
        Me.AdminAddAccDropDown = New Library_Management.MyComboBox()
        Me.AdminAddAccButton = New Library_Management.MyButton()
        Me.AdminAddAccFullnameTextBox = New Library_Management.MyTextBox()
        Me.AdminAddAccConfirmPasswordTextBox = New Library_Management.MyTextBox()
        Me.AdminAddAccPasswordTextBox = New Library_Management.MyTextBox()
        Me.AdminAddAccUsernameTextBox = New Library_Management.MyTextBox()
        Me.MyLabel24 = New Library_Management.MyLabel()
        Me.MyLabel5 = New Library_Management.MyLabel()
        Me.MyLabel4 = New Library_Management.MyLabel()
        Me.MyLabel3 = New Library_Management.MyLabel()
        Me.MyLabel2 = New Library_Management.MyLabel()
        Me.MyGroupBox2 = New Library_Management.MyGroupBox()
        Me.AdminEditAccButton = New Library_Management.MyButton()
        Me.AdminEditAccNewPasswordTextBox = New Library_Management.MyTextBox()
        Me.AdminEditAccNewFullnameTextBox = New Library_Management.MyTextBox()
        Me.MyLabel10 = New Library_Management.MyLabel()
        Me.MyLabel6 = New Library_Management.MyLabel()
        Me.AdminEditAccConfirmPasswordTextBox = New Library_Management.MyTextBox()
        Me.MyLabel7 = New Library_Management.MyLabel()
        Me.MyLabel8 = New Library_Management.MyLabel()
        Me.AdminEditAccOldUsernameTextBox = New Library_Management.MyTextBox()
        Me.AdminEditAccNewUsernameTextBox = New Library_Management.MyTextBox()
        Me.MyLabel9 = New Library_Management.MyLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AlertBox7 = New Library_Management.MyAlertBox()
        Me.MyGroupBox6 = New Library_Management.MyGroupBox()
        Me.AdminRemoveBookIDTextBox = New Library_Management.MyTextBox()
        Me.AdminRemoveBookButton = New Library_Management.MyButton()
        Me.MyLabel17 = New Library_Management.MyLabel()
        Me.MyGroupBox3 = New Library_Management.MyGroupBox()
        Me.AdminEditBookName = New Library_Management.MyTextBox()
        Me.AdminEditBookGenreTextBox = New Library_Management.MyTextBox()
        Me.AdminEditBookCopies = New Library_Management.MyTextBox()
        Me.MyLabel22 = New Library_Management.MyLabel()
        Me.AdminEditBookAuthor = New Library_Management.MyTextBox()
        Me.MyLabel11 = New Library_Management.MyLabel()
        Me.AdminEditBookID = New Library_Management.MyTextBox()
        Me.AdminEditBookISBN = New Library_Management.MyTextBox()
        Me.MyLabel12 = New Library_Management.MyLabel()
        Me.MyLabel21 = New Library_Management.MyLabel()
        Me.MyLabel14 = New Library_Management.MyLabel()
        Me.MyLabel15 = New Library_Management.MyLabel()
        Me.MyButton3 = New Library_Management.MyButton()
        Me.MyGroupBox4 = New Library_Management.MyGroupBox()
        Me.AdminAddBookButton = New Library_Management.MyButton()
        Me.AdminAddBookName = New Library_Management.MyTextBox()
        Me.AdminAddBookCopies = New Library_Management.MyTextBox()
        Me.AdminAddBookGenre = New Library_Management.MyTextBox()
        Me.MyLabel23 = New Library_Management.MyLabel()
        Me.AdminAddBookAuthor = New Library_Management.MyTextBox()
        Me.MyLabel20 = New Library_Management.MyLabel()
        Me.AdminAddBookISBN = New Library_Management.MyTextBox()
        Me.MyLabel16 = New Library_Management.MyLabel()
        Me.MyLabel18 = New Library_Management.MyLabel()
        Me.MyLabel19 = New Library_Management.MyLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AlertBox8 = New Library_Management.MyAlertBox()
        Me.Admin = New System.Windows.Forms.RichTextBox()
        Me.AdminMySQLExecuteButton = New Library_Management.MyButton()
        Me.AdminMySQLQueryType = New Library_Management.MyComboBox()
        Me.AdminMySQLQueryTextBox = New Library_Management.MyTextBox()
        Me.LoginSignupTab = New System.Windows.Forms.TabPage()
        Me.AlertBox6 = New Library_Management.MyAlertBox()
        Me.AASignupGroupBox = New Library_Management.MyGroupBox()
        Me.AAAAALabel12 = New Library_Management.MyLabel()
        Me.SignupDropDownBox = New Library_Management.MyComboBox()
        Me.AAASignupConfirmPasswordPicture = New System.Windows.Forms.PictureBox()
        Me.AAASignupPasswordPicture = New System.Windows.Forms.PictureBox()
        Me.AAAAALabel4 = New Library_Management.MyLabel()
        Me.SignupConfirmPasswordTextBox = New Library_Management.MyTextBox()
        Me.AAAAALabel6 = New Library_Management.MyLabel()
        Me.SignupButton = New Library_Management.MyButton()
        Me.SignupPasswordTextBox = New Library_Management.MyTextBox()
        Me.AAAAALabel8 = New Library_Management.MyLabel()
        Me.AAAAALabel7 = New Library_Management.MyLabel()
        Me.SignupFullnameTextBox = New Library_Management.MyTextBox()
        Me.SignupUsernameTextBox = New Library_Management.MyTextBox()
        Me.AALoginGroupBox = New Library_Management.MyGroupBox()
        Me.AAALoginPasswordPicture = New System.Windows.Forms.PictureBox()
        Me.LoginUsernameTextBox = New Library_Management.MyTextBox()
        Me.LoginButton = New Library_Management.MyButton()
        Me.AAAAALabel1 = New Library_Management.MyLabel()
        Me.AAAAALabel5 = New Library_Management.MyLabel()
        Me.LoginPasswordTextBox = New Library_Management.MyTextBox()
        Me.AAAACloseButtonMain = New Library_Management.MyClose()
        Me.AAAAMainFormSkin.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.SearchBooksTab.SuspendLayout()
        Me.BrowseBooksTab.SuspendLayout()
        CType(Me.BrowseBooksDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrowseBooksContextMenu.SuspendLayout()
        Me.IssueBookTab.SuspendLayout()
        Me.ReturnGroupbox.SuspendLayout()
        Me.AAIssueGroupBox.SuspendLayout()
        Me.SummaryTab.SuspendLayout()
        Me.AASummaryChangePasswordGroupBox.SuspendLayout()
        CType(Me.AAASummaryConfirmPasswordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAASummaryNewPasswordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SummaryOldPasswordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AAAProfileGroupBox.SuspendLayout()
        Me.AASummaryGroupBox.SuspendLayout()
        Me.AdminOptionsTab.SuspendLayout()
        Me.AdminTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MyGroupBox5.SuspendLayout()
        Me.MyGroupBox1.SuspendLayout()
        Me.MyGroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MyGroupBox6.SuspendLayout()
        Me.MyGroupBox3.SuspendLayout()
        Me.MyGroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.LoginSignupTab.SuspendLayout()
        Me.AASignupGroupBox.SuspendLayout()
        CType(Me.AAASignupConfirmPasswordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAASignupPasswordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AALoginGroupBox.SuspendLayout()
        CType(Me.AAALoginPasswordPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AAAAMainFormSkin
        '
        Me.AAAAMainFormSkin.BackColor = System.Drawing.Color.White
        Me.AAAAMainFormSkin.Controls.Add(Me.AAAAMiniButtonMain)
        Me.AAAAMainFormSkin.Controls.Add(Me.AAAALogoutButton)
        Me.AAAAMainFormSkin.Controls.Add(Me.AAAAExitButton)
        Me.AAAAMainFormSkin.Controls.Add(Me.StatusBar)
        Me.AAAAMainFormSkin.Controls.Add(Me.TabControlMain)
        Me.AAAAMainFormSkin.Controls.Add(Me.AAAACloseButtonMain)
        Me.AAAAMainFormSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AAAAMainFormSkin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAMainFormSkin.Location = New System.Drawing.Point(0, 0)
        Me.AAAAMainFormSkin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAAAMainFormSkin.Name = "AAAAMainFormSkin"
        Me.AAAAMainFormSkin.Size = New System.Drawing.Size(1272, 846)
        Me.AAAAMainFormSkin.TabIndex = 0
        Me.AAAAMainFormSkin.Text = "Library Management System"
        '
        'AAAAMiniButtonMain
        '
        Me.AAAAMiniButtonMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AAAAMiniButtonMain.BackColor = System.Drawing.Color.White
        Me.AAAAMiniButtonMain.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.AAAAMiniButtonMain.Location = New System.Drawing.Point(1185, 20)
        Me.AAAAMiniButtonMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAAAMiniButtonMain.Name = "AAAAMiniButtonMain"
        Me.AAAAMiniButtonMain.Size = New System.Drawing.Size(18, 18)
        Me.AAAAMiniButtonMain.TabIndex = 5
        Me.AAAAMiniButtonMain.Text = "MyMini1"
        '
        'AAAALogoutButton
        '
        Me.AAAALogoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAAALogoutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAAALogoutButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAALogoutButton.Location = New System.Drawing.Point(357, 794)
        Me.AAAALogoutButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAAALogoutButton.Name = "AAAALogoutButton"
        Me.AAAALogoutButton.Size = New System.Drawing.Size(132, 42)
        Me.AAAALogoutButton.TabIndex = 4
        Me.AAAALogoutButton.Text = "Logout"
        '
        'AAAAExitButton
        '
        Me.AAAAExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAAAExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAAAExitButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAExitButton.Location = New System.Drawing.Point(814, 794)
        Me.AAAAExitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAAAExitButton.Name = "AAAAExitButton"
        Me.AAAAExitButton.Size = New System.Drawing.Size(102, 42)
        Me.AAAAExitButton.TabIndex = 4
        Me.AAAAExitButton.Text = "Exit"
        '
        'StatusBar
        '
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.StatusBar.ForeColor = System.Drawing.Color.White
        Me.StatusBar.Location = New System.Drawing.Point(0, 784)
        Me.StatusBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1272, 62)
        Me.StatusBar.TabIndex = 3
        Me.StatusBar.Text = "Not Logged In"
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.SearchBooksTab)
        Me.TabControlMain.Controls.Add(Me.BrowseBooksTab)
        Me.TabControlMain.Controls.Add(Me.IssueBookTab)
        Me.TabControlMain.Controls.Add(Me.SummaryTab)
        Me.TabControlMain.Controls.Add(Me.AdminOptionsTab)
        Me.TabControlMain.Controls.Add(Me.LoginSignupTab)
        Me.TabControlMain.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControlMain.ItemSize = New System.Drawing.Size(120, 40)
        Me.TabControlMain.Location = New System.Drawing.Point(0, 69)
        Me.TabControlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControlMain.Multiline = True
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(1272, 714)
        Me.TabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlMain.TabIndex = 2
        Me.TabControlMain.Tag = ""
        '
        'SearchBooksTab
        '
        Me.SearchBooksTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.SearchBooksTab.Controls.Add(Me.AlertBox1)
        Me.SearchBooksTab.Controls.Add(Me.SearchBookButton)
        Me.SearchBooksTab.Controls.Add(Me.AAAAALabel11)
        Me.SearchBooksTab.Controls.Add(Me.MyLabel25)
        Me.SearchBooksTab.Controls.Add(Me.AAAAALabel10)
        Me.SearchBooksTab.Controls.Add(Me.AAAAALabel3)
        Me.SearchBooksTab.Controls.Add(Me.AAAAALabel2)
        Me.SearchBooksTab.Controls.Add(Me.AAAAALabel9)
        Me.SearchBooksTab.Controls.Add(Me.SearchBookAuthorTextBox)
        Me.SearchBooksTab.Controls.Add(Me.SearchBookGenreTextBox)
        Me.SearchBooksTab.Controls.Add(Me.SearchBookNameTextBox)
        Me.SearchBooksTab.Controls.Add(Me.SearchBookIDTextBox)
        Me.SearchBooksTab.Controls.Add(Me.SearchBookISBNTextBox)
        Me.SearchBooksTab.Location = New System.Drawing.Point(4, 44)
        Me.SearchBooksTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBooksTab.Name = "SearchBooksTab"
        Me.SearchBooksTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBooksTab.Size = New System.Drawing.Size(1264, 666)
        Me.SearchBooksTab.TabIndex = 0
        Me.SearchBooksTab.Text = "Search Books"
        '
        'AlertBox1
        '
        Me.AlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox1.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox1.Location = New System.Drawing.Point(20, 554)
        Me.AlertBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox1.Name = "AlertBox1"
        Me.AlertBox1.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox1.TabIndex = 3
        Me.AlertBox1.Text = "AlertBox"
        Me.AlertBox1.Visible = False
        '
        'SearchBookButton
        '
        Me.SearchBookButton.BackColor = System.Drawing.Color.Transparent
        Me.SearchBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBookButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SearchBookButton.Location = New System.Drawing.Point(498, 426)
        Me.SearchBookButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBookButton.Name = "SearchBookButton"
        Me.SearchBookButton.Size = New System.Drawing.Size(264, 82)
        Me.SearchBookButton.TabIndex = 2
        Me.SearchBookButton.Text = "Search"
        '
        'AAAAALabel11
        '
        Me.AAAAALabel11.AutoSize = True
        Me.AAAAALabel11.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel11.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel11.Location = New System.Drawing.Point(344, 360)
        Me.AAAAALabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel11.Name = "AAAAALabel11"
        Me.AAAAALabel11.Size = New System.Drawing.Size(88, 32)
        Me.AAAAALabel11.TabIndex = 1
        Me.AAAAALabel11.Text = "Author"
        '
        'MyLabel25
        '
        Me.MyLabel25.AutoSize = True
        Me.MyLabel25.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel25.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel25.ForeColor = System.Drawing.Color.White
        Me.MyLabel25.Location = New System.Drawing.Point(344, 303)
        Me.MyLabel25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel25.Name = "MyLabel25"
        Me.MyLabel25.Size = New System.Drawing.Size(79, 32)
        Me.MyLabel25.TabIndex = 1
        Me.MyLabel25.Text = "Genre"
        '
        'AAAAALabel10
        '
        Me.AAAAALabel10.AutoSize = True
        Me.AAAAALabel10.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel10.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel10.Location = New System.Drawing.Point(344, 246)
        Me.AAAAALabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel10.Name = "AAAAALabel10"
        Me.AAAAALabel10.Size = New System.Drawing.Size(133, 32)
        Me.AAAAALabel10.TabIndex = 1
        Me.AAAAALabel10.Text = "BookName"
        '
        'AAAAALabel3
        '
        Me.AAAAALabel3.AutoSize = True
        Me.AAAAALabel3.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAAAALabel3.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel3.Location = New System.Drawing.Point(430, 58)
        Me.AAAAALabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel3.Name = "AAAAALabel3"
        Me.AAAAALabel3.Size = New System.Drawing.Size(383, 45)
        Me.AAAAALabel3.TabIndex = 1
        Me.AAAAALabel3.Text = "Enter Search Parameters"
        '
        'AAAAALabel2
        '
        Me.AAAAALabel2.AutoSize = True
        Me.AAAAALabel2.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAAAALabel2.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel2.Location = New System.Drawing.Point(344, 132)
        Me.AAAAALabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel2.Name = "AAAAALabel2"
        Me.AAAAALabel2.Size = New System.Drawing.Size(92, 32)
        Me.AAAAALabel2.TabIndex = 1
        Me.AAAAALabel2.Text = "BookID"
        '
        'AAAAALabel9
        '
        Me.AAAAALabel9.AutoSize = True
        Me.AAAAALabel9.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAAAALabel9.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel9.Location = New System.Drawing.Point(344, 189)
        Me.AAAAALabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel9.Name = "AAAAALabel9"
        Me.AAAAALabel9.Size = New System.Drawing.Size(105, 32)
        Me.AAAAALabel9.TabIndex = 1
        Me.AAAAALabel9.Text = "ISBN No"
        '
        'SearchBookAuthorTextBox
        '
        Me.SearchBookAuthorTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBookAuthorTextBox.Location = New System.Drawing.Point(560, 354)
        Me.SearchBookAuthorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBookAuthorTextBox.MaxLength = 32767
        Me.SearchBookAuthorTextBox.Multiline = False
        Me.SearchBookAuthorTextBox.Name = "SearchBookAuthorTextBox"
        Me.SearchBookAuthorTextBox.ReadOnly = False
        Me.SearchBookAuthorTextBox.Size = New System.Drawing.Size(357, 38)
        Me.SearchBookAuthorTextBox.TabIndex = 0
        Me.SearchBookAuthorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBookAuthorTextBox.UseSystemPasswordChar = False
        '
        'SearchBookGenreTextBox
        '
        Me.SearchBookGenreTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBookGenreTextBox.Location = New System.Drawing.Point(560, 297)
        Me.SearchBookGenreTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBookGenreTextBox.MaxLength = 32767
        Me.SearchBookGenreTextBox.Multiline = False
        Me.SearchBookGenreTextBox.Name = "SearchBookGenreTextBox"
        Me.SearchBookGenreTextBox.ReadOnly = False
        Me.SearchBookGenreTextBox.Size = New System.Drawing.Size(357, 38)
        Me.SearchBookGenreTextBox.TabIndex = 0
        Me.SearchBookGenreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBookGenreTextBox.UseSystemPasswordChar = False
        '
        'SearchBookNameTextBox
        '
        Me.SearchBookNameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBookNameTextBox.Location = New System.Drawing.Point(560, 240)
        Me.SearchBookNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBookNameTextBox.MaxLength = 32767
        Me.SearchBookNameTextBox.Multiline = False
        Me.SearchBookNameTextBox.Name = "SearchBookNameTextBox"
        Me.SearchBookNameTextBox.ReadOnly = False
        Me.SearchBookNameTextBox.Size = New System.Drawing.Size(357, 38)
        Me.SearchBookNameTextBox.TabIndex = 0
        Me.SearchBookNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBookNameTextBox.UseSystemPasswordChar = False
        '
        'SearchBookIDTextBox
        '
        Me.SearchBookIDTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBookIDTextBox.Location = New System.Drawing.Point(560, 126)
        Me.SearchBookIDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBookIDTextBox.MaxLength = 32767
        Me.SearchBookIDTextBox.Multiline = False
        Me.SearchBookIDTextBox.Name = "SearchBookIDTextBox"
        Me.SearchBookIDTextBox.ReadOnly = False
        Me.SearchBookIDTextBox.Size = New System.Drawing.Size(357, 38)
        Me.SearchBookIDTextBox.TabIndex = 0
        Me.SearchBookIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBookIDTextBox.UseSystemPasswordChar = False
        '
        'SearchBookISBNTextBox
        '
        Me.SearchBookISBNTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBookISBNTextBox.Location = New System.Drawing.Point(560, 183)
        Me.SearchBookISBNTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBookISBNTextBox.MaxLength = 20
        Me.SearchBookISBNTextBox.Multiline = False
        Me.SearchBookISBNTextBox.Name = "SearchBookISBNTextBox"
        Me.SearchBookISBNTextBox.ReadOnly = False
        Me.SearchBookISBNTextBox.Size = New System.Drawing.Size(357, 38)
        Me.SearchBookISBNTextBox.TabIndex = 0
        Me.SearchBookISBNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBookISBNTextBox.UseSystemPasswordChar = False
        '
        'BrowseBooksTab
        '
        Me.BrowseBooksTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BrowseBooksTab.Controls.Add(Me.AlertBox2)
        Me.BrowseBooksTab.Controls.Add(Me.BrowseBooksDataGrid)
        Me.BrowseBooksTab.Location = New System.Drawing.Point(4, 44)
        Me.BrowseBooksTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BrowseBooksTab.Name = "BrowseBooksTab"
        Me.BrowseBooksTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BrowseBooksTab.Size = New System.Drawing.Size(1264, 666)
        Me.BrowseBooksTab.TabIndex = 1
        Me.BrowseBooksTab.Text = "Browse Books"
        '
        'AlertBox2
        '
        Me.AlertBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox2.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox2.Location = New System.Drawing.Point(20, 554)
        Me.AlertBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox2.Name = "AlertBox2"
        Me.AlertBox2.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox2.TabIndex = 4
        Me.AlertBox2.Text = "AlertBox"
        Me.AlertBox2.Visible = False
        '
        'BrowseBooksDataGrid
        '
        Me.BrowseBooksDataGrid.AllowUserToAddRows = False
        Me.BrowseBooksDataGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseBooksDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.BrowseBooksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BrowseBooksDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.BrowseBooksDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BrowseBooksDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrowseBooksDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.BrowseBooksDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseBooksDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.BrowseBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrowseBooksDataGrid.ContextMenuStrip = Me.BrowseBooksContextMenu
        Me.BrowseBooksDataGrid.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseBooksDataGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.BrowseBooksDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseBooksDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BrowseBooksDataGrid.Location = New System.Drawing.Point(4, 5)
        Me.BrowseBooksDataGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BrowseBooksDataGrid.Name = "BrowseBooksDataGrid"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseBooksDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.BrowseBooksDataGrid.RowHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseBooksDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BrowseBooksDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseBooksDataGrid.RowTemplate.ReadOnly = True
        Me.BrowseBooksDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.BrowseBooksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BrowseBooksDataGrid.ShowCellErrors = False
        Me.BrowseBooksDataGrid.ShowEditingIcon = False
        Me.BrowseBooksDataGrid.ShowRowErrors = False
        Me.BrowseBooksDataGrid.Size = New System.Drawing.Size(1256, 656)
        Me.BrowseBooksDataGrid.TabIndex = 0
        '
        'BrowseBooksContextMenu
        '
        Me.BrowseBooksContextMenu.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BrowseBooksContextMenu.ForeColor = System.Drawing.Color.White
        Me.BrowseBooksContextMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BrowseBooksContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssueSelectedBookToolStrip, Me.CopyBookNameToolStrip, Me.CopyISBNNumberToolStrip, Me.CopyBookIDToolStrip})
        Me.BrowseBooksContextMenu.Name = "BrowseBooksContextMenu"
        Me.BrowseBooksContextMenu.ShowCheckMargin = True
        Me.BrowseBooksContextMenu.ShowImageMargin = False
        Me.BrowseBooksContextMenu.Size = New System.Drawing.Size(217, 108)
        '
        'IssueSelectedBookToolStrip
        '
        Me.IssueSelectedBookToolStrip.Name = "IssueSelectedBookToolStrip"
        Me.IssueSelectedBookToolStrip.Size = New System.Drawing.Size(216, 26)
        Me.IssueSelectedBookToolStrip.Text = "Issue Selected Book"
        '
        'CopyBookNameToolStrip
        '
        Me.CopyBookNameToolStrip.Name = "CopyBookNameToolStrip"
        Me.CopyBookNameToolStrip.Size = New System.Drawing.Size(216, 26)
        Me.CopyBookNameToolStrip.Text = "Copy Book Name"
        '
        'CopyISBNNumberToolStrip
        '
        Me.CopyISBNNumberToolStrip.Name = "CopyISBNNumberToolStrip"
        Me.CopyISBNNumberToolStrip.Size = New System.Drawing.Size(216, 26)
        Me.CopyISBNNumberToolStrip.Text = "Copy ISBN Number"
        '
        'CopyBookIDToolStrip
        '
        Me.CopyBookIDToolStrip.Name = "CopyBookIDToolStrip"
        Me.CopyBookIDToolStrip.Size = New System.Drawing.Size(216, 26)
        Me.CopyBookIDToolStrip.Text = "Copy Book ID"
        '
        'IssueBookTab
        '
        Me.IssueBookTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.IssueBookTab.Controls.Add(Me.AlertBox3)
        Me.IssueBookTab.Controls.Add(Me.ReturnGroupbox)
        Me.IssueBookTab.Controls.Add(Me.AAIssueGroupBox)
        Me.IssueBookTab.Location = New System.Drawing.Point(4, 44)
        Me.IssueBookTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IssueBookTab.Name = "IssueBookTab"
        Me.IssueBookTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IssueBookTab.Size = New System.Drawing.Size(1264, 666)
        Me.IssueBookTab.TabIndex = 2
        Me.IssueBookTab.Text = "Issue/Return Book"
        '
        'AlertBox3
        '
        Me.AlertBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox3.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox3.Location = New System.Drawing.Point(20, 554)
        Me.AlertBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox3.Name = "AlertBox3"
        Me.AlertBox3.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox3.TabIndex = 6
        Me.AlertBox3.Text = "AlertBox"
        Me.AlertBox3.Visible = False
        '
        'ReturnGroupbox
        '
        Me.ReturnGroupbox.BackColor = System.Drawing.Color.Transparent
        Me.ReturnGroupbox.Controls.Add(Me.ReturnBookInfoTextBox)
        Me.ReturnGroupbox.Controls.Add(Me.AAAAALabel18)
        Me.ReturnGroupbox.Controls.Add(Me.ReturnButton)
        Me.ReturnGroupbox.Controls.Add(Me.ReturnBookSearchDropDown)
        Me.ReturnGroupbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReturnGroupbox.Location = New System.Drawing.Point(675, 85)
        Me.ReturnGroupbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReturnGroupbox.Name = "ReturnGroupbox"
        Me.ReturnGroupbox.Size = New System.Drawing.Size(482, 412)
        Me.ReturnGroupbox.TabIndex = 5
        Me.ReturnGroupbox.Text = "Return Book"
        '
        'ReturnBookInfoTextBox
        '
        Me.ReturnBookInfoTextBox.BackColor = System.Drawing.Color.Transparent
        Me.ReturnBookInfoTextBox.Location = New System.Drawing.Point(110, 203)
        Me.ReturnBookInfoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReturnBookInfoTextBox.MaxLength = 32767
        Me.ReturnBookInfoTextBox.Multiline = False
        Me.ReturnBookInfoTextBox.Name = "ReturnBookInfoTextBox"
        Me.ReturnBookInfoTextBox.ReadOnly = False
        Me.ReturnBookInfoTextBox.Size = New System.Drawing.Size(302, 38)
        Me.ReturnBookInfoTextBox.TabIndex = 2
        Me.ReturnBookInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ReturnBookInfoTextBox.UseSystemPasswordChar = False
        '
        'AAAAALabel18
        '
        Me.AAAAALabel18.AutoSize = True
        Me.AAAAALabel18.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel18.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel18.Location = New System.Drawing.Point(69, 126)
        Me.AAAAALabel18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel18.Name = "AAAAALabel18"
        Me.AAAAALabel18.Size = New System.Drawing.Size(152, 32)
        Me.AAAAALabel18.TabIndex = 0
        Me.AAAAALabel18.Text = "Return Using"
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.Color.Transparent
        Me.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReturnButton.Location = New System.Drawing.Point(138, 272)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(243, 74)
        Me.ReturnButton.TabIndex = 3
        Me.ReturnButton.Text = "Return Book"
        '
        'ReturnBookSearchDropDown
        '
        Me.ReturnBookSearchDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ReturnBookSearchDropDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnBookSearchDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ReturnBookSearchDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReturnBookSearchDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBookSearchDropDown.ForeColor = System.Drawing.Color.White
        Me.ReturnBookSearchDropDown.FormattingEnabled = True
        Me.ReturnBookSearchDropDown.ItemHeight = 18
        Me.ReturnBookSearchDropDown.Items.AddRange(New Object() {"ISBN", "BookID"})
        Me.ReturnBookSearchDropDown.Location = New System.Drawing.Point(230, 123)
        Me.ReturnBookSearchDropDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReturnBookSearchDropDown.Name = "ReturnBookSearchDropDown"
        Me.ReturnBookSearchDropDown.Size = New System.Drawing.Size(180, 24)
        Me.ReturnBookSearchDropDown.TabIndex = 1
        '
        'AAIssueGroupBox
        '
        Me.AAIssueGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AAIssueGroupBox.Controls.Add(Me.IssueBookInfoTextBox)
        Me.AAIssueGroupBox.Controls.Add(Me.MyLabel1)
        Me.AAIssueGroupBox.Controls.Add(Me.IssueButton)
        Me.AAIssueGroupBox.Controls.Add(Me.IssueBookSearchDropDown)
        Me.AAIssueGroupBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAIssueGroupBox.Location = New System.Drawing.Point(104, 85)
        Me.AAIssueGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAIssueGroupBox.Name = "AAIssueGroupBox"
        Me.AAIssueGroupBox.Size = New System.Drawing.Size(482, 412)
        Me.AAIssueGroupBox.TabIndex = 4
        Me.AAIssueGroupBox.Text = "Issue Book"
        '
        'IssueBookInfoTextBox
        '
        Me.IssueBookInfoTextBox.BackColor = System.Drawing.Color.Transparent
        Me.IssueBookInfoTextBox.Location = New System.Drawing.Point(110, 203)
        Me.IssueBookInfoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IssueBookInfoTextBox.MaxLength = 32767
        Me.IssueBookInfoTextBox.Multiline = False
        Me.IssueBookInfoTextBox.Name = "IssueBookInfoTextBox"
        Me.IssueBookInfoTextBox.ReadOnly = False
        Me.IssueBookInfoTextBox.Size = New System.Drawing.Size(302, 38)
        Me.IssueBookInfoTextBox.TabIndex = 2
        Me.IssueBookInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.IssueBookInfoTextBox.UseSystemPasswordChar = False
        '
        'MyLabel1
        '
        Me.MyLabel1.AutoSize = True
        Me.MyLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel1.ForeColor = System.Drawing.Color.White
        Me.MyLabel1.Location = New System.Drawing.Point(87, 125)
        Me.MyLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel1.Name = "MyLabel1"
        Me.MyLabel1.Size = New System.Drawing.Size(135, 32)
        Me.MyLabel1.TabIndex = 0
        Me.MyLabel1.Text = "Issue Using"
        '
        'IssueButton
        '
        Me.IssueButton.BackColor = System.Drawing.Color.Transparent
        Me.IssueButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IssueButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.IssueButton.Location = New System.Drawing.Point(138, 272)
        Me.IssueButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IssueButton.Name = "IssueButton"
        Me.IssueButton.Size = New System.Drawing.Size(243, 74)
        Me.IssueButton.TabIndex = 3
        Me.IssueButton.Text = "Issue Book"
        '
        'IssueBookSearchDropDown
        '
        Me.IssueBookSearchDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.IssueBookSearchDropDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IssueBookSearchDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.IssueBookSearchDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IssueBookSearchDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssueBookSearchDropDown.ForeColor = System.Drawing.Color.White
        Me.IssueBookSearchDropDown.FormattingEnabled = True
        Me.IssueBookSearchDropDown.ItemHeight = 18
        Me.IssueBookSearchDropDown.Items.AddRange(New Object() {"ISBN", "BookID"})
        Me.IssueBookSearchDropDown.Location = New System.Drawing.Point(230, 122)
        Me.IssueBookSearchDropDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IssueBookSearchDropDown.Name = "IssueBookSearchDropDown"
        Me.IssueBookSearchDropDown.Size = New System.Drawing.Size(180, 24)
        Me.IssueBookSearchDropDown.TabIndex = 1
        '
        'SummaryTab
        '
        Me.SummaryTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.SummaryTab.Controls.Add(Me.AlertBox4)
        Me.SummaryTab.Controls.Add(Me.AASummaryChangePasswordGroupBox)
        Me.SummaryTab.Controls.Add(Me.AAAProfileGroupBox)
        Me.SummaryTab.Controls.Add(Me.AASummaryGroupBox)
        Me.SummaryTab.Location = New System.Drawing.Point(4, 44)
        Me.SummaryTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryTab.Name = "SummaryTab"
        Me.SummaryTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryTab.Size = New System.Drawing.Size(1264, 666)
        Me.SummaryTab.TabIndex = 6
        Me.SummaryTab.Text = "DashBoard"
        '
        'AlertBox4
        '
        Me.AlertBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox4.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox4.Location = New System.Drawing.Point(20, 554)
        Me.AlertBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox4.Name = "AlertBox4"
        Me.AlertBox4.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox4.TabIndex = 5
        Me.AlertBox4.Text = "AlertBox"
        Me.AlertBox4.Visible = False
        '
        'AASummaryChangePasswordGroupBox
        '
        Me.AASummaryChangePasswordGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.ProfileChangeAlert)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.SummaryChangePasswordButton)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.AAASummaryConfirmPasswordPicture)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.AAASummaryNewPasswordPicture)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.SummaryOldPasswordPicture)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.SummaryOldPasswordTextbox)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.SummaryConfirmPasswordTextBox)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.AAAAALabel15)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.AAAAALabel17)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.AAAAALabel16)
        Me.AASummaryChangePasswordGroupBox.Controls.Add(Me.SummaryNewPasswordTextBox)
        Me.AASummaryChangePasswordGroupBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AASummaryChangePasswordGroupBox.Location = New System.Drawing.Point(634, 0)
        Me.AASummaryChangePasswordGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AASummaryChangePasswordGroupBox.Name = "AASummaryChangePasswordGroupBox"
        Me.AASummaryChangePasswordGroupBox.Size = New System.Drawing.Size(628, 335)
        Me.AASummaryChangePasswordGroupBox.TabIndex = 2
        Me.AASummaryChangePasswordGroupBox.Text = "Change Password"
        '
        'ProfileChangeAlert
        '
        Me.ProfileChangeAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ProfileChangeAlert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfileChangeAlert.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ProfileChangeAlert.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.ProfileChangeAlert.Location = New System.Drawing.Point(322, 522)
        Me.ProfileChangeAlert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProfileChangeAlert.Name = "ProfileChangeAlert"
        Me.ProfileChangeAlert.Size = New System.Drawing.Size(298, 42)
        Me.ProfileChangeAlert.TabIndex = 3
        Me.ProfileChangeAlert.Text = "ProfileChangeAlert"
        Me.ProfileChangeAlert.Visible = False
        '
        'SummaryChangePasswordButton
        '
        Me.SummaryChangePasswordButton.BackColor = System.Drawing.Color.Transparent
        Me.SummaryChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SummaryChangePasswordButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SummaryChangePasswordButton.Location = New System.Drawing.Point(192, 254)
        Me.SummaryChangePasswordButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryChangePasswordButton.Name = "SummaryChangePasswordButton"
        Me.SummaryChangePasswordButton.Size = New System.Drawing.Size(244, 65)
        Me.SummaryChangePasswordButton.TabIndex = 2
        Me.SummaryChangePasswordButton.Text = "Change Password"
        '
        'AAASummaryConfirmPasswordPicture
        '
        Me.AAASummaryConfirmPasswordPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAASummaryConfirmPasswordPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AAASummaryConfirmPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAASummaryConfirmPasswordPicture.Image = Global.Library_Management.My.Resources.Resources.hide
        Me.AAASummaryConfirmPasswordPicture.InitialImage = Nothing
        Me.AAASummaryConfirmPasswordPicture.Location = New System.Drawing.Point(520, 185)
        Me.AAASummaryConfirmPasswordPicture.Margin = New System.Windows.Forms.Padding(0, 5, 4, 5)
        Me.AAASummaryConfirmPasswordPicture.Name = "AAASummaryConfirmPasswordPicture"
        Me.AAASummaryConfirmPasswordPicture.Size = New System.Drawing.Size(42, 44)
        Me.AAASummaryConfirmPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAASummaryConfirmPasswordPicture.TabIndex = 1
        Me.AAASummaryConfirmPasswordPicture.TabStop = False
        '
        'AAASummaryNewPasswordPicture
        '
        Me.AAASummaryNewPasswordPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAASummaryNewPasswordPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AAASummaryNewPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAASummaryNewPasswordPicture.Image = Global.Library_Management.My.Resources.Resources.hide
        Me.AAASummaryNewPasswordPicture.InitialImage = Nothing
        Me.AAASummaryNewPasswordPicture.Location = New System.Drawing.Point(520, 131)
        Me.AAASummaryNewPasswordPicture.Margin = New System.Windows.Forms.Padding(0, 5, 4, 5)
        Me.AAASummaryNewPasswordPicture.Name = "AAASummaryNewPasswordPicture"
        Me.AAASummaryNewPasswordPicture.Size = New System.Drawing.Size(42, 44)
        Me.AAASummaryNewPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAASummaryNewPasswordPicture.TabIndex = 1
        Me.AAASummaryNewPasswordPicture.TabStop = False
        '
        'SummaryOldPasswordPicture
        '
        Me.SummaryOldPasswordPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.SummaryOldPasswordPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SummaryOldPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SummaryOldPasswordPicture.Image = Global.Library_Management.My.Resources.Resources.hide
        Me.SummaryOldPasswordPicture.InitialImage = Nothing
        Me.SummaryOldPasswordPicture.Location = New System.Drawing.Point(520, 77)
        Me.SummaryOldPasswordPicture.Margin = New System.Windows.Forms.Padding(0, 5, 4, 5)
        Me.SummaryOldPasswordPicture.Name = "SummaryOldPasswordPicture"
        Me.SummaryOldPasswordPicture.Size = New System.Drawing.Size(42, 44)
        Me.SummaryOldPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SummaryOldPasswordPicture.TabIndex = 1
        Me.SummaryOldPasswordPicture.TabStop = False
        '
        'SummaryOldPasswordTextbox
        '
        Me.SummaryOldPasswordTextbox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryOldPasswordTextbox.Location = New System.Drawing.Point(272, 77)
        Me.SummaryOldPasswordTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.SummaryOldPasswordTextbox.MaxLength = 32767
        Me.SummaryOldPasswordTextbox.Multiline = False
        Me.SummaryOldPasswordTextbox.Name = "SummaryOldPasswordTextbox"
        Me.SummaryOldPasswordTextbox.ReadOnly = False
        Me.SummaryOldPasswordTextbox.Size = New System.Drawing.Size(249, 38)
        Me.SummaryOldPasswordTextbox.TabIndex = 0
        Me.SummaryOldPasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SummaryOldPasswordTextbox.UseSystemPasswordChar = True
        '
        'SummaryConfirmPasswordTextBox
        '
        Me.SummaryConfirmPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryConfirmPasswordTextBox.Location = New System.Drawing.Point(272, 185)
        Me.SummaryConfirmPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.SummaryConfirmPasswordTextBox.MaxLength = 32767
        Me.SummaryConfirmPasswordTextBox.Multiline = False
        Me.SummaryConfirmPasswordTextBox.Name = "SummaryConfirmPasswordTextBox"
        Me.SummaryConfirmPasswordTextBox.ReadOnly = False
        Me.SummaryConfirmPasswordTextBox.Size = New System.Drawing.Size(249, 38)
        Me.SummaryConfirmPasswordTextBox.TabIndex = 0
        Me.SummaryConfirmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SummaryConfirmPasswordTextBox.UseSystemPasswordChar = True
        '
        'AAAAALabel15
        '
        Me.AAAAALabel15.AutoSize = True
        Me.AAAAALabel15.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel15.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel15.Location = New System.Drawing.Point(64, 83)
        Me.AAAAALabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel15.Name = "AAAAALabel15"
        Me.AAAAALabel15.Size = New System.Drawing.Size(157, 32)
        Me.AAAAALabel15.TabIndex = 0
        Me.AAAAALabel15.Text = "Old Password"
        '
        'AAAAALabel17
        '
        Me.AAAAALabel17.AutoSize = True
        Me.AAAAALabel17.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel17.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel17.Location = New System.Drawing.Point(64, 191)
        Me.AAAAALabel17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel17.Name = "AAAAALabel17"
        Me.AAAAALabel17.Size = New System.Drawing.Size(205, 32)
        Me.AAAAALabel17.TabIndex = 0
        Me.AAAAALabel17.Text = "Confirm Password"
        '
        'AAAAALabel16
        '
        Me.AAAAALabel16.AutoSize = True
        Me.AAAAALabel16.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel16.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel16.Location = New System.Drawing.Point(64, 137)
        Me.AAAAALabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel16.Name = "AAAAALabel16"
        Me.AAAAALabel16.Size = New System.Drawing.Size(167, 32)
        Me.AAAAALabel16.TabIndex = 0
        Me.AAAAALabel16.Text = "New Password"
        '
        'SummaryNewPasswordTextBox
        '
        Me.SummaryNewPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryNewPasswordTextBox.Location = New System.Drawing.Point(272, 131)
        Me.SummaryNewPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.SummaryNewPasswordTextBox.MaxLength = 32767
        Me.SummaryNewPasswordTextBox.Multiline = False
        Me.SummaryNewPasswordTextBox.Name = "SummaryNewPasswordTextBox"
        Me.SummaryNewPasswordTextBox.ReadOnly = False
        Me.SummaryNewPasswordTextBox.Size = New System.Drawing.Size(249, 38)
        Me.SummaryNewPasswordTextBox.TabIndex = 0
        Me.SummaryNewPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SummaryNewPasswordTextBox.UseSystemPasswordChar = True
        '
        'AAAProfileGroupBox
        '
        Me.AAAProfileGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AAAProfileGroupBox.Controls.Add(Me.AAAAALabel22)
        Me.AAAProfileGroupBox.Controls.Add(Me.SummaryProfileDropDownBox)
        Me.AAAProfileGroupBox.Controls.Add(Me.SummaryFullnameTextBox)
        Me.AAAProfileGroupBox.Controls.Add(Me.SummaryEditProfileButton)
        Me.AAAProfileGroupBox.Controls.Add(Me.SummaryUsernameTextBox)
        Me.AAAProfileGroupBox.Controls.Add(Me.AAAAALabel20)
        Me.AAAProfileGroupBox.Controls.Add(Me.AAAAALabel21)
        Me.AAAProfileGroupBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAProfileGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.AAAProfileGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAAProfileGroupBox.Name = "AAAProfileGroupBox"
        Me.AAAProfileGroupBox.Size = New System.Drawing.Size(628, 335)
        Me.AAAProfileGroupBox.TabIndex = 1
        Me.AAAProfileGroupBox.Text = "Profile"
        '
        'AAAAALabel22
        '
        Me.AAAAALabel22.AutoSize = True
        Me.AAAAALabel22.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel22.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel22.Location = New System.Drawing.Point(32, 191)
        Me.AAAAALabel22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel22.Name = "AAAAALabel22"
        Me.AAAAALabel22.Size = New System.Drawing.Size(117, 32)
        Me.AAAAALabel22.TabIndex = 3
        Me.AAAAALabel22.Text = "Apply For"
        '
        'SummaryProfileDropDownBox
        '
        Me.SummaryProfileDropDownBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SummaryProfileDropDownBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SummaryProfileDropDownBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SummaryProfileDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SummaryProfileDropDownBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryProfileDropDownBox.ForeColor = System.Drawing.Color.White
        Me.SummaryProfileDropDownBox.FormattingEnabled = True
        Me.SummaryProfileDropDownBox.ItemHeight = 18
        Me.SummaryProfileDropDownBox.Items.AddRange(New Object() {"Student", "Teacher", "Admin"})
        Me.SummaryProfileDropDownBox.Location = New System.Drawing.Point(224, 188)
        Me.SummaryProfileDropDownBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryProfileDropDownBox.Name = "SummaryProfileDropDownBox"
        Me.SummaryProfileDropDownBox.Size = New System.Drawing.Size(306, 24)
        Me.SummaryProfileDropDownBox.TabIndex = 4
        '
        'SummaryFullnameTextBox
        '
        Me.SummaryFullnameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryFullnameTextBox.Location = New System.Drawing.Point(224, 131)
        Me.SummaryFullnameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryFullnameTextBox.MaxLength = 32767
        Me.SummaryFullnameTextBox.Multiline = False
        Me.SummaryFullnameTextBox.Name = "SummaryFullnameTextBox"
        Me.SummaryFullnameTextBox.ReadOnly = False
        Me.SummaryFullnameTextBox.Size = New System.Drawing.Size(308, 38)
        Me.SummaryFullnameTextBox.TabIndex = 1
        Me.SummaryFullnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SummaryFullnameTextBox.UseSystemPasswordChar = False
        '
        'SummaryEditProfileButton
        '
        Me.SummaryEditProfileButton.BackColor = System.Drawing.Color.Transparent
        Me.SummaryEditProfileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SummaryEditProfileButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SummaryEditProfileButton.Location = New System.Drawing.Point(156, 254)
        Me.SummaryEditProfileButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryEditProfileButton.Name = "SummaryEditProfileButton"
        Me.SummaryEditProfileButton.Size = New System.Drawing.Size(244, 65)
        Me.SummaryEditProfileButton.TabIndex = 2
        Me.SummaryEditProfileButton.Text = "Save Changes"
        '
        'SummaryUsernameTextBox
        '
        Me.SummaryUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryUsernameTextBox.Location = New System.Drawing.Point(224, 77)
        Me.SummaryUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryUsernameTextBox.MaxLength = 32767
        Me.SummaryUsernameTextBox.Multiline = False
        Me.SummaryUsernameTextBox.Name = "SummaryUsernameTextBox"
        Me.SummaryUsernameTextBox.ReadOnly = False
        Me.SummaryUsernameTextBox.Size = New System.Drawing.Size(308, 38)
        Me.SummaryUsernameTextBox.TabIndex = 1
        Me.SummaryUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SummaryUsernameTextBox.UseSystemPasswordChar = False
        '
        'AAAAALabel20
        '
        Me.AAAAALabel20.AutoSize = True
        Me.AAAAALabel20.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel20.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel20.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel20.Location = New System.Drawing.Point(36, 83)
        Me.AAAAALabel20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel20.Name = "AAAAALabel20"
        Me.AAAAALabel20.Size = New System.Drawing.Size(122, 32)
        Me.AAAAALabel20.TabIndex = 0
        Me.AAAAALabel20.Text = "Username"
        '
        'AAAAALabel21
        '
        Me.AAAAALabel21.AutoSize = True
        Me.AAAAALabel21.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel21.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel21.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel21.Location = New System.Drawing.Point(36, 137)
        Me.AAAAALabel21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel21.Name = "AAAAALabel21"
        Me.AAAAALabel21.Size = New System.Drawing.Size(113, 32)
        Me.AAAAALabel21.TabIndex = 0
        Me.AAAAALabel21.Text = "Fullname"
        '
        'AASummaryGroupBox
        '
        Me.AASummaryGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AASummaryGroupBox.Controls.Add(Me.SummaryViewIssuedBooks)
        Me.AASummaryGroupBox.Controls.Add(Me.SummaryBooksIssuedTextBox)
        Me.AASummaryGroupBox.Controls.Add(Me.SummaryDueTextBox)
        Me.AASummaryGroupBox.Controls.Add(Me.AAAAALabel13)
        Me.AASummaryGroupBox.Controls.Add(Me.AAAAALabel14)
        Me.AASummaryGroupBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AASummaryGroupBox.Location = New System.Drawing.Point(0, 345)
        Me.AASummaryGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AASummaryGroupBox.Name = "AASummaryGroupBox"
        Me.AASummaryGroupBox.Size = New System.Drawing.Size(1260, 291)
        Me.AASummaryGroupBox.TabIndex = 1
        Me.AASummaryGroupBox.Text = "Summary"
        '
        'SummaryViewIssuedBooks
        '
        Me.SummaryViewIssuedBooks.BackColor = System.Drawing.Color.Transparent
        Me.SummaryViewIssuedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SummaryViewIssuedBooks.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SummaryViewIssuedBooks.Location = New System.Drawing.Point(826, 137)
        Me.SummaryViewIssuedBooks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryViewIssuedBooks.Name = "SummaryViewIssuedBooks"
        Me.SummaryViewIssuedBooks.Size = New System.Drawing.Size(264, 69)
        Me.SummaryViewIssuedBooks.TabIndex = 2
        Me.SummaryViewIssuedBooks.Text = "View Issued Books"
        '
        'SummaryBooksIssuedTextBox
        '
        Me.SummaryBooksIssuedTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryBooksIssuedTextBox.Enabled = False
        Me.SummaryBooksIssuedTextBox.Location = New System.Drawing.Point(338, 182)
        Me.SummaryBooksIssuedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryBooksIssuedTextBox.MaxLength = 32767
        Me.SummaryBooksIssuedTextBox.Multiline = False
        Me.SummaryBooksIssuedTextBox.Name = "SummaryBooksIssuedTextBox"
        Me.SummaryBooksIssuedTextBox.ReadOnly = False
        Me.SummaryBooksIssuedTextBox.Size = New System.Drawing.Size(261, 38)
        Me.SummaryBooksIssuedTextBox.TabIndex = 1
        Me.SummaryBooksIssuedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SummaryBooksIssuedTextBox.UseSystemPasswordChar = False
        '
        'SummaryDueTextBox
        '
        Me.SummaryDueTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SummaryDueTextBox.Enabled = False
        Me.SummaryDueTextBox.Location = New System.Drawing.Point(338, 126)
        Me.SummaryDueTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SummaryDueTextBox.MaxLength = 32767
        Me.SummaryDueTextBox.Multiline = False
        Me.SummaryDueTextBox.Name = "SummaryDueTextBox"
        Me.SummaryDueTextBox.ReadOnly = False
        Me.SummaryDueTextBox.Size = New System.Drawing.Size(261, 38)
        Me.SummaryDueTextBox.TabIndex = 1
        Me.SummaryDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SummaryDueTextBox.UseSystemPasswordChar = False
        '
        'AAAAALabel13
        '
        Me.AAAAALabel13.AutoSize = True
        Me.AAAAALabel13.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel13.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel13.Location = New System.Drawing.Point(48, 132)
        Me.AAAAALabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel13.Name = "AAAAALabel13"
        Me.AAAAALabel13.Size = New System.Drawing.Size(208, 32)
        Me.AAAAALabel13.TabIndex = 0
        Me.AAAAALabel13.Text = "Fine Due ( If Any )"
        '
        'AAAAALabel14
        '
        Me.AAAAALabel14.AutoSize = True
        Me.AAAAALabel14.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel14.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel14.Location = New System.Drawing.Point(48, 188)
        Me.AAAAALabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel14.Name = "AAAAALabel14"
        Me.AAAAALabel14.Size = New System.Drawing.Size(277, 32)
        Me.AAAAALabel14.TabIndex = 0
        Me.AAAAALabel14.Text = "Number of books Issued"
        '
        'AdminOptionsTab
        '
        Me.AdminOptionsTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AdminOptionsTab.Controls.Add(Me.AdminTabControl)
        Me.AdminOptionsTab.Location = New System.Drawing.Point(4, 44)
        Me.AdminOptionsTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminOptionsTab.Name = "AdminOptionsTab"
        Me.AdminOptionsTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminOptionsTab.Size = New System.Drawing.Size(1264, 666)
        Me.AdminOptionsTab.TabIndex = 5
        Me.AdminOptionsTab.Text = "Admin Options"
        '
        'AdminTabControl
        '
        Me.AdminTabControl.Controls.Add(Me.TabPage1)
        Me.AdminTabControl.Controls.Add(Me.TabPage2)
        Me.AdminTabControl.Controls.Add(Me.TabPage3)
        Me.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminTabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AdminTabControl.ItemSize = New System.Drawing.Size(120, 40)
        Me.AdminTabControl.Location = New System.Drawing.Point(4, 5)
        Me.AdminTabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminTabControl.Multiline = True
        Me.AdminTabControl.Name = "AdminTabControl"
        Me.AdminTabControl.SelectedIndex = 0
        Me.AdminTabControl.Size = New System.Drawing.Size(1256, 656)
        Me.AdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.AdminTabControl.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.AlertBox5)
        Me.TabPage1.Controls.Add(Me.MyGroupBox5)
        Me.TabPage1.Controls.Add(Me.MyGroupBox1)
        Me.TabPage1.Controls.Add(Me.MyGroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1248, 608)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Management"
        '
        'AlertBox5
        '
        Me.AlertBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox5.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox5.Location = New System.Drawing.Point(9, 482)
        Me.AlertBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox5.Name = "AlertBox5"
        Me.AlertBox5.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox5.TabIndex = 5
        Me.AlertBox5.Text = "AlertBox"
        Me.AlertBox5.Visible = False
        '
        'MyGroupBox5
        '
        Me.MyGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.MyGroupBox5.Controls.Add(Me.AdminDeleteAccButton)
        Me.MyGroupBox5.Controls.Add(Me.MyLabel13)
        Me.MyGroupBox5.Controls.Add(Me.AdminDeleteAccUsernameTextBox)
        Me.MyGroupBox5.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MyGroupBox5.Location = New System.Drawing.Point(0, 434)
        Me.MyGroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyGroupBox5.Name = "MyGroupBox5"
        Me.MyGroupBox5.Size = New System.Drawing.Size(622, 122)
        Me.MyGroupBox5.TabIndex = 7
        Me.MyGroupBox5.Text = "Delete Account"
        '
        'AdminDeleteAccButton
        '
        Me.AdminDeleteAccButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminDeleteAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminDeleteAccButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AdminDeleteAccButton.Location = New System.Drawing.Point(459, 78)
        Me.AdminDeleteAccButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminDeleteAccButton.Name = "AdminDeleteAccButton"
        Me.AdminDeleteAccButton.Size = New System.Drawing.Size(159, 45)
        Me.AdminDeleteAccButton.TabIndex = 2
        Me.AdminDeleteAccButton.Text = "Delete"
        '
        'MyLabel13
        '
        Me.MyLabel13.AutoSize = True
        Me.MyLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLabel13.ForeColor = System.Drawing.Color.White
        Me.MyLabel13.Location = New System.Drawing.Point(21, 85)
        Me.MyLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel13.Name = "MyLabel13"
        Me.MyLabel13.Size = New System.Drawing.Size(122, 32)
        Me.MyLabel13.TabIndex = 1
        Me.MyLabel13.Text = "Username"
        '
        'AdminDeleteAccUsernameTextBox
        '
        Me.AdminDeleteAccUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminDeleteAccUsernameTextBox.Location = New System.Drawing.Point(147, 78)
        Me.AdminDeleteAccUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminDeleteAccUsernameTextBox.MaxLength = 32767
        Me.AdminDeleteAccUsernameTextBox.Multiline = False
        Me.AdminDeleteAccUsernameTextBox.Name = "AdminDeleteAccUsernameTextBox"
        Me.AdminDeleteAccUsernameTextBox.ReadOnly = False
        Me.AdminDeleteAccUsernameTextBox.Size = New System.Drawing.Size(302, 38)
        Me.AdminDeleteAccUsernameTextBox.TabIndex = 0
        Me.AdminDeleteAccUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminDeleteAccUsernameTextBox.UseSystemPasswordChar = False
        '
        'MyGroupBox1
        '
        Me.MyGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.MyGroupBox1.Controls.Add(Me.AdminAddAccDropDown)
        Me.MyGroupBox1.Controls.Add(Me.AdminAddAccButton)
        Me.MyGroupBox1.Controls.Add(Me.AdminAddAccFullnameTextBox)
        Me.MyGroupBox1.Controls.Add(Me.AdminAddAccConfirmPasswordTextBox)
        Me.MyGroupBox1.Controls.Add(Me.AdminAddAccPasswordTextBox)
        Me.MyGroupBox1.Controls.Add(Me.AdminAddAccUsernameTextBox)
        Me.MyGroupBox1.Controls.Add(Me.MyLabel24)
        Me.MyGroupBox1.Controls.Add(Me.MyLabel5)
        Me.MyGroupBox1.Controls.Add(Me.MyLabel4)
        Me.MyGroupBox1.Controls.Add(Me.MyLabel3)
        Me.MyGroupBox1.Controls.Add(Me.MyLabel2)
        Me.MyGroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MyGroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.MyGroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyGroupBox1.Name = "MyGroupBox1"
        Me.MyGroupBox1.Size = New System.Drawing.Size(609, 420)
        Me.MyGroupBox1.TabIndex = 6
        Me.MyGroupBox1.Text = "Add Account"
        '
        'AdminAddAccDropDown
        '
        Me.AdminAddAccDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.AdminAddAccDropDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminAddAccDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.AdminAddAccDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AdminAddAccDropDown.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AdminAddAccDropDown.ForeColor = System.Drawing.Color.White
        Me.AdminAddAccDropDown.FormattingEnabled = True
        Me.AdminAddAccDropDown.ItemHeight = 18
        Me.AdminAddAccDropDown.Items.AddRange(New Object() {"Student", "Teacher", "Admin"})
        Me.AdminAddAccDropDown.Location = New System.Drawing.Point(238, 294)
        Me.AdminAddAccDropDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddAccDropDown.Name = "AdminAddAccDropDown"
        Me.AdminAddAccDropDown.Size = New System.Drawing.Size(346, 24)
        Me.AdminAddAccDropDown.TabIndex = 3
        '
        'AdminAddAccButton
        '
        Me.AdminAddAccButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminAddAccButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AdminAddAccButton.Location = New System.Drawing.Point(196, 349)
        Me.AdminAddAccButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddAccButton.Name = "AdminAddAccButton"
        Me.AdminAddAccButton.Size = New System.Drawing.Size(218, 66)
        Me.AdminAddAccButton.TabIndex = 2
        Me.AdminAddAccButton.Text = "Add Account"
        '
        'AdminAddAccFullnameTextBox
        '
        Me.AdminAddAccFullnameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddAccFullnameTextBox.Location = New System.Drawing.Point(238, 132)
        Me.AdminAddAccFullnameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddAccFullnameTextBox.MaxLength = 32767
        Me.AdminAddAccFullnameTextBox.Multiline = False
        Me.AdminAddAccFullnameTextBox.Name = "AdminAddAccFullnameTextBox"
        Me.AdminAddAccFullnameTextBox.ReadOnly = False
        Me.AdminAddAccFullnameTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddAccFullnameTextBox.TabIndex = 1
        Me.AdminAddAccFullnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddAccFullnameTextBox.UseSystemPasswordChar = False
        '
        'AdminAddAccConfirmPasswordTextBox
        '
        Me.AdminAddAccConfirmPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddAccConfirmPasswordTextBox.Location = New System.Drawing.Point(238, 240)
        Me.AdminAddAccConfirmPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddAccConfirmPasswordTextBox.MaxLength = 32767
        Me.AdminAddAccConfirmPasswordTextBox.Multiline = False
        Me.AdminAddAccConfirmPasswordTextBox.Name = "AdminAddAccConfirmPasswordTextBox"
        Me.AdminAddAccConfirmPasswordTextBox.ReadOnly = False
        Me.AdminAddAccConfirmPasswordTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddAccConfirmPasswordTextBox.TabIndex = 1
        Me.AdminAddAccConfirmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddAccConfirmPasswordTextBox.UseSystemPasswordChar = False
        '
        'AdminAddAccPasswordTextBox
        '
        Me.AdminAddAccPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddAccPasswordTextBox.Location = New System.Drawing.Point(238, 186)
        Me.AdminAddAccPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddAccPasswordTextBox.MaxLength = 32767
        Me.AdminAddAccPasswordTextBox.Multiline = False
        Me.AdminAddAccPasswordTextBox.Name = "AdminAddAccPasswordTextBox"
        Me.AdminAddAccPasswordTextBox.ReadOnly = False
        Me.AdminAddAccPasswordTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddAccPasswordTextBox.TabIndex = 1
        Me.AdminAddAccPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddAccPasswordTextBox.UseSystemPasswordChar = False
        '
        'AdminAddAccUsernameTextBox
        '
        Me.AdminAddAccUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddAccUsernameTextBox.Location = New System.Drawing.Point(238, 78)
        Me.AdminAddAccUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddAccUsernameTextBox.MaxLength = 32767
        Me.AdminAddAccUsernameTextBox.Multiline = False
        Me.AdminAddAccUsernameTextBox.Name = "AdminAddAccUsernameTextBox"
        Me.AdminAddAccUsernameTextBox.ReadOnly = False
        Me.AdminAddAccUsernameTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddAccUsernameTextBox.TabIndex = 1
        Me.AdminAddAccUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddAccUsernameTextBox.UseSystemPasswordChar = False
        '
        'MyLabel24
        '
        Me.MyLabel24.AutoSize = True
        Me.MyLabel24.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel24.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel24.ForeColor = System.Drawing.Color.White
        Me.MyLabel24.Location = New System.Drawing.Point(22, 297)
        Me.MyLabel24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel24.Name = "MyLabel24"
        Me.MyLabel24.Size = New System.Drawing.Size(160, 32)
        Me.MyLabel24.TabIndex = 0
        Me.MyLabel24.Text = "Account Type"
        '
        'MyLabel5
        '
        Me.MyLabel5.AutoSize = True
        Me.MyLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel5.ForeColor = System.Drawing.Color.White
        Me.MyLabel5.Location = New System.Drawing.Point(22, 246)
        Me.MyLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel5.Name = "MyLabel5"
        Me.MyLabel5.Size = New System.Drawing.Size(205, 32)
        Me.MyLabel5.TabIndex = 0
        Me.MyLabel5.Text = "Confirm Password"
        '
        'MyLabel4
        '
        Me.MyLabel4.AutoSize = True
        Me.MyLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel4.ForeColor = System.Drawing.Color.White
        Me.MyLabel4.Location = New System.Drawing.Point(22, 192)
        Me.MyLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel4.Name = "MyLabel4"
        Me.MyLabel4.Size = New System.Drawing.Size(112, 32)
        Me.MyLabel4.TabIndex = 0
        Me.MyLabel4.Text = "Password"
        '
        'MyLabel3
        '
        Me.MyLabel3.AutoSize = True
        Me.MyLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel3.ForeColor = System.Drawing.Color.White
        Me.MyLabel3.Location = New System.Drawing.Point(22, 138)
        Me.MyLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel3.Name = "MyLabel3"
        Me.MyLabel3.Size = New System.Drawing.Size(113, 32)
        Me.MyLabel3.TabIndex = 0
        Me.MyLabel3.Text = "Fullname"
        '
        'MyLabel2
        '
        Me.MyLabel2.AutoSize = True
        Me.MyLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel2.ForeColor = System.Drawing.Color.White
        Me.MyLabel2.Location = New System.Drawing.Point(22, 85)
        Me.MyLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel2.Name = "MyLabel2"
        Me.MyLabel2.Size = New System.Drawing.Size(122, 32)
        Me.MyLabel2.TabIndex = 0
        Me.MyLabel2.Text = "Username"
        '
        'MyGroupBox2
        '
        Me.MyGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.MyGroupBox2.Controls.Add(Me.AdminEditAccButton)
        Me.MyGroupBox2.Controls.Add(Me.AdminEditAccNewPasswordTextBox)
        Me.MyGroupBox2.Controls.Add(Me.AdminEditAccNewFullnameTextBox)
        Me.MyGroupBox2.Controls.Add(Me.MyLabel10)
        Me.MyGroupBox2.Controls.Add(Me.MyLabel6)
        Me.MyGroupBox2.Controls.Add(Me.AdminEditAccConfirmPasswordTextBox)
        Me.MyGroupBox2.Controls.Add(Me.MyLabel7)
        Me.MyGroupBox2.Controls.Add(Me.MyLabel8)
        Me.MyGroupBox2.Controls.Add(Me.AdminEditAccOldUsernameTextBox)
        Me.MyGroupBox2.Controls.Add(Me.AdminEditAccNewUsernameTextBox)
        Me.MyGroupBox2.Controls.Add(Me.MyLabel9)
        Me.MyGroupBox2.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MyGroupBox2.Location = New System.Drawing.Point(632, 5)
        Me.MyGroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyGroupBox2.Name = "MyGroupBox2"
        Me.MyGroupBox2.Size = New System.Drawing.Size(609, 468)
        Me.MyGroupBox2.TabIndex = 6
        Me.MyGroupBox2.Text = "Edit Account"
        '
        'AdminEditAccButton
        '
        Me.AdminEditAccButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminEditAccButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AdminEditAccButton.Location = New System.Drawing.Point(196, 380)
        Me.AdminEditAccButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditAccButton.Name = "AdminEditAccButton"
        Me.AdminEditAccButton.Size = New System.Drawing.Size(218, 66)
        Me.AdminEditAccButton.TabIndex = 2
        Me.AdminEditAccButton.Text = "Edit Existing Account"
        '
        'AdminEditAccNewPasswordTextBox
        '
        Me.AdminEditAccNewPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditAccNewPasswordTextBox.Location = New System.Drawing.Point(243, 271)
        Me.AdminEditAccNewPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditAccNewPasswordTextBox.MaxLength = 32767
        Me.AdminEditAccNewPasswordTextBox.Multiline = False
        Me.AdminEditAccNewPasswordTextBox.Name = "AdminEditAccNewPasswordTextBox"
        Me.AdminEditAccNewPasswordTextBox.ReadOnly = False
        Me.AdminEditAccNewPasswordTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditAccNewPasswordTextBox.TabIndex = 1
        Me.AdminEditAccNewPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditAccNewPasswordTextBox.UseSystemPasswordChar = False
        '
        'AdminEditAccNewFullnameTextBox
        '
        Me.AdminEditAccNewFullnameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditAccNewFullnameTextBox.Location = New System.Drawing.Point(243, 217)
        Me.AdminEditAccNewFullnameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditAccNewFullnameTextBox.MaxLength = 32767
        Me.AdminEditAccNewFullnameTextBox.Multiline = False
        Me.AdminEditAccNewFullnameTextBox.Name = "AdminEditAccNewFullnameTextBox"
        Me.AdminEditAccNewFullnameTextBox.ReadOnly = False
        Me.AdminEditAccNewFullnameTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditAccNewFullnameTextBox.TabIndex = 1
        Me.AdminEditAccNewFullnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditAccNewFullnameTextBox.UseSystemPasswordChar = False
        '
        'MyLabel10
        '
        Me.MyLabel10.AutoSize = True
        Me.MyLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel10.ForeColor = System.Drawing.Color.White
        Me.MyLabel10.Location = New System.Drawing.Point(27, 115)
        Me.MyLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel10.Name = "MyLabel10"
        Me.MyLabel10.Size = New System.Drawing.Size(167, 32)
        Me.MyLabel10.TabIndex = 0
        Me.MyLabel10.Text = "Old Username"
        '
        'MyLabel6
        '
        Me.MyLabel6.AutoSize = True
        Me.MyLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel6.ForeColor = System.Drawing.Color.White
        Me.MyLabel6.Location = New System.Drawing.Point(27, 169)
        Me.MyLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel6.Name = "MyLabel6"
        Me.MyLabel6.Size = New System.Drawing.Size(177, 32)
        Me.MyLabel6.TabIndex = 0
        Me.MyLabel6.Text = "New Username"
        '
        'AdminEditAccConfirmPasswordTextBox
        '
        Me.AdminEditAccConfirmPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditAccConfirmPasswordTextBox.Location = New System.Drawing.Point(243, 325)
        Me.AdminEditAccConfirmPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditAccConfirmPasswordTextBox.MaxLength = 32767
        Me.AdminEditAccConfirmPasswordTextBox.Multiline = False
        Me.AdminEditAccConfirmPasswordTextBox.Name = "AdminEditAccConfirmPasswordTextBox"
        Me.AdminEditAccConfirmPasswordTextBox.ReadOnly = False
        Me.AdminEditAccConfirmPasswordTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditAccConfirmPasswordTextBox.TabIndex = 1
        Me.AdminEditAccConfirmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditAccConfirmPasswordTextBox.UseSystemPasswordChar = False
        '
        'MyLabel7
        '
        Me.MyLabel7.AutoSize = True
        Me.MyLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel7.ForeColor = System.Drawing.Color.White
        Me.MyLabel7.Location = New System.Drawing.Point(27, 223)
        Me.MyLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel7.Name = "MyLabel7"
        Me.MyLabel7.Size = New System.Drawing.Size(168, 32)
        Me.MyLabel7.TabIndex = 0
        Me.MyLabel7.Text = "New Fullname"
        '
        'MyLabel8
        '
        Me.MyLabel8.AutoSize = True
        Me.MyLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel8.ForeColor = System.Drawing.Color.White
        Me.MyLabel8.Location = New System.Drawing.Point(27, 277)
        Me.MyLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel8.Name = "MyLabel8"
        Me.MyLabel8.Size = New System.Drawing.Size(167, 32)
        Me.MyLabel8.TabIndex = 0
        Me.MyLabel8.Text = "New Password"
        '
        'AdminEditAccOldUsernameTextBox
        '
        Me.AdminEditAccOldUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditAccOldUsernameTextBox.Location = New System.Drawing.Point(243, 109)
        Me.AdminEditAccOldUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditAccOldUsernameTextBox.MaxLength = 32767
        Me.AdminEditAccOldUsernameTextBox.Multiline = False
        Me.AdminEditAccOldUsernameTextBox.Name = "AdminEditAccOldUsernameTextBox"
        Me.AdminEditAccOldUsernameTextBox.ReadOnly = False
        Me.AdminEditAccOldUsernameTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditAccOldUsernameTextBox.TabIndex = 1
        Me.AdminEditAccOldUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditAccOldUsernameTextBox.UseSystemPasswordChar = False
        '
        'AdminEditAccNewUsernameTextBox
        '
        Me.AdminEditAccNewUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditAccNewUsernameTextBox.Location = New System.Drawing.Point(243, 163)
        Me.AdminEditAccNewUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditAccNewUsernameTextBox.MaxLength = 32767
        Me.AdminEditAccNewUsernameTextBox.Multiline = False
        Me.AdminEditAccNewUsernameTextBox.Name = "AdminEditAccNewUsernameTextBox"
        Me.AdminEditAccNewUsernameTextBox.ReadOnly = False
        Me.AdminEditAccNewUsernameTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditAccNewUsernameTextBox.TabIndex = 1
        Me.AdminEditAccNewUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditAccNewUsernameTextBox.UseSystemPasswordChar = False
        '
        'MyLabel9
        '
        Me.MyLabel9.AutoSize = True
        Me.MyLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel9.ForeColor = System.Drawing.Color.White
        Me.MyLabel9.Location = New System.Drawing.Point(27, 331)
        Me.MyLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel9.Name = "MyLabel9"
        Me.MyLabel9.Size = New System.Drawing.Size(205, 32)
        Me.MyLabel9.TabIndex = 0
        Me.MyLabel9.Text = "Confirm Password"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.AlertBox7)
        Me.TabPage2.Controls.Add(Me.MyGroupBox6)
        Me.TabPage2.Controls.Add(Me.MyGroupBox3)
        Me.TabPage2.Controls.Add(Me.MyGroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1248, 608)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Books Management"
        '
        'AlertBox7
        '
        Me.AlertBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox7.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox7.Location = New System.Drawing.Point(9, 482)
        Me.AlertBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox7.Name = "AlertBox7"
        Me.AlertBox7.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox7.TabIndex = 6
        Me.AlertBox7.Text = "AlertBox"
        Me.AlertBox7.Visible = False
        '
        'MyGroupBox6
        '
        Me.MyGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.MyGroupBox6.Controls.Add(Me.AdminRemoveBookIDTextBox)
        Me.MyGroupBox6.Controls.Add(Me.AdminRemoveBookButton)
        Me.MyGroupBox6.Controls.Add(Me.MyLabel17)
        Me.MyGroupBox6.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MyGroupBox6.Location = New System.Drawing.Point(8, 426)
        Me.MyGroupBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyGroupBox6.Name = "MyGroupBox6"
        Me.MyGroupBox6.Size = New System.Drawing.Size(606, 137)
        Me.MyGroupBox6.TabIndex = 9
        Me.MyGroupBox6.Text = "Remove Book"
        '
        'AdminRemoveBookIDTextBox
        '
        Me.AdminRemoveBookIDTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminRemoveBookIDTextBox.Location = New System.Drawing.Point(180, 83)
        Me.AdminRemoveBookIDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminRemoveBookIDTextBox.MaxLength = 32767
        Me.AdminRemoveBookIDTextBox.Multiline = False
        Me.AdminRemoveBookIDTextBox.Name = "AdminRemoveBookIDTextBox"
        Me.AdminRemoveBookIDTextBox.ReadOnly = False
        Me.AdminRemoveBookIDTextBox.Size = New System.Drawing.Size(234, 38)
        Me.AdminRemoveBookIDTextBox.TabIndex = 2
        Me.AdminRemoveBookIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminRemoveBookIDTextBox.UseSystemPasswordChar = False
        '
        'AdminRemoveBookButton
        '
        Me.AdminRemoveBookButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminRemoveBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminRemoveBookButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AdminRemoveBookButton.Location = New System.Drawing.Point(426, 83)
        Me.AdminRemoveBookButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminRemoveBookButton.Name = "AdminRemoveBookButton"
        Me.AdminRemoveBookButton.Size = New System.Drawing.Size(159, 45)
        Me.AdminRemoveBookButton.TabIndex = 1
        Me.AdminRemoveBookButton.Text = "Remove"
        '
        'MyLabel17
        '
        Me.MyLabel17.AutoSize = True
        Me.MyLabel17.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel17.ForeColor = System.Drawing.Color.White
        Me.MyLabel17.Location = New System.Drawing.Point(50, 89)
        Me.MyLabel17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel17.Name = "MyLabel17"
        Me.MyLabel17.Size = New System.Drawing.Size(99, 32)
        Me.MyLabel17.TabIndex = 0
        Me.MyLabel17.Text = "Book ID"
        '
        'MyGroupBox3
        '
        Me.MyGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.MyGroupBox3.Controls.Add(Me.AdminEditBookName)
        Me.MyGroupBox3.Controls.Add(Me.AdminEditBookGenreTextBox)
        Me.MyGroupBox3.Controls.Add(Me.AdminEditBookCopies)
        Me.MyGroupBox3.Controls.Add(Me.MyLabel22)
        Me.MyGroupBox3.Controls.Add(Me.AdminEditBookAuthor)
        Me.MyGroupBox3.Controls.Add(Me.MyLabel11)
        Me.MyGroupBox3.Controls.Add(Me.AdminEditBookID)
        Me.MyGroupBox3.Controls.Add(Me.AdminEditBookISBN)
        Me.MyGroupBox3.Controls.Add(Me.MyLabel12)
        Me.MyGroupBox3.Controls.Add(Me.MyLabel21)
        Me.MyGroupBox3.Controls.Add(Me.MyLabel14)
        Me.MyGroupBox3.Controls.Add(Me.MyLabel15)
        Me.MyGroupBox3.Controls.Add(Me.MyButton3)
        Me.MyGroupBox3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MyGroupBox3.Location = New System.Drawing.Point(624, 6)
        Me.MyGroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyGroupBox3.Name = "MyGroupBox3"
        Me.MyGroupBox3.Size = New System.Drawing.Size(609, 540)
        Me.MyGroupBox3.TabIndex = 7
        Me.MyGroupBox3.Text = "Edit BookInfo"
        '
        'AdminEditBookName
        '
        Me.AdminEditBookName.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditBookName.Location = New System.Drawing.Point(238, 212)
        Me.AdminEditBookName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditBookName.MaxLength = 32767
        Me.AdminEditBookName.Multiline = False
        Me.AdminEditBookName.Name = "AdminEditBookName"
        Me.AdminEditBookName.ReadOnly = False
        Me.AdminEditBookName.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditBookName.TabIndex = 8
        Me.AdminEditBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditBookName.UseSystemPasswordChar = False
        '
        'AdminEditBookGenreTextBox
        '
        Me.AdminEditBookGenreTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditBookGenreTextBox.Location = New System.Drawing.Point(238, 320)
        Me.AdminEditBookGenreTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditBookGenreTextBox.MaxLength = 32767
        Me.AdminEditBookGenreTextBox.Multiline = False
        Me.AdminEditBookGenreTextBox.Name = "AdminEditBookGenreTextBox"
        Me.AdminEditBookGenreTextBox.ReadOnly = False
        Me.AdminEditBookGenreTextBox.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditBookGenreTextBox.TabIndex = 9
        Me.AdminEditBookGenreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditBookGenreTextBox.UseSystemPasswordChar = False
        '
        'AdminEditBookCopies
        '
        Me.AdminEditBookCopies.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditBookCopies.Location = New System.Drawing.Point(238, 372)
        Me.AdminEditBookCopies.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditBookCopies.MaxLength = 32767
        Me.AdminEditBookCopies.Multiline = False
        Me.AdminEditBookCopies.Name = "AdminEditBookCopies"
        Me.AdminEditBookCopies.ReadOnly = False
        Me.AdminEditBookCopies.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditBookCopies.TabIndex = 9
        Me.AdminEditBookCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditBookCopies.UseSystemPasswordChar = False
        '
        'MyLabel22
        '
        Me.MyLabel22.AutoSize = True
        Me.MyLabel22.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel22.ForeColor = System.Drawing.Color.White
        Me.MyLabel22.Location = New System.Drawing.Point(22, 326)
        Me.MyLabel22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel22.Name = "MyLabel22"
        Me.MyLabel22.Size = New System.Drawing.Size(134, 32)
        Me.MyLabel22.TabIndex = 3
        Me.MyLabel22.Text = "New Genre"
        '
        'AdminEditBookAuthor
        '
        Me.AdminEditBookAuthor.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditBookAuthor.Location = New System.Drawing.Point(238, 266)
        Me.AdminEditBookAuthor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditBookAuthor.MaxLength = 32767
        Me.AdminEditBookAuthor.Multiline = False
        Me.AdminEditBookAuthor.Name = "AdminEditBookAuthor"
        Me.AdminEditBookAuthor.ReadOnly = False
        Me.AdminEditBookAuthor.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditBookAuthor.TabIndex = 11
        Me.AdminEditBookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditBookAuthor.UseSystemPasswordChar = False
        '
        'MyLabel11
        '
        Me.MyLabel11.AutoSize = True
        Me.MyLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel11.ForeColor = System.Drawing.Color.White
        Me.MyLabel11.Location = New System.Drawing.Point(22, 378)
        Me.MyLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel11.Name = "MyLabel11"
        Me.MyLabel11.Size = New System.Drawing.Size(145, 32)
        Me.MyLabel11.TabIndex = 3
        Me.MyLabel11.Text = "Total Copies"
        '
        'AdminEditBookID
        '
        Me.AdminEditBookID.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditBookID.Location = New System.Drawing.Point(238, 105)
        Me.AdminEditBookID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditBookID.MaxLength = 32767
        Me.AdminEditBookID.Multiline = False
        Me.AdminEditBookID.Name = "AdminEditBookID"
        Me.AdminEditBookID.ReadOnly = False
        Me.AdminEditBookID.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditBookID.TabIndex = 12
        Me.AdminEditBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditBookID.UseSystemPasswordChar = False
        '
        'AdminEditBookISBN
        '
        Me.AdminEditBookISBN.BackColor = System.Drawing.Color.Transparent
        Me.AdminEditBookISBN.Location = New System.Drawing.Point(238, 158)
        Me.AdminEditBookISBN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminEditBookISBN.MaxLength = 32767
        Me.AdminEditBookISBN.Multiline = False
        Me.AdminEditBookISBN.Name = "AdminEditBookISBN"
        Me.AdminEditBookISBN.ReadOnly = False
        Me.AdminEditBookISBN.Size = New System.Drawing.Size(348, 38)
        Me.AdminEditBookISBN.TabIndex = 12
        Me.AdminEditBookISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminEditBookISBN.UseSystemPasswordChar = False
        '
        'MyLabel12
        '
        Me.MyLabel12.AutoSize = True
        Me.MyLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel12.ForeColor = System.Drawing.Color.White
        Me.MyLabel12.Location = New System.Drawing.Point(22, 272)
        Me.MyLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel12.Name = "MyLabel12"
        Me.MyLabel12.Size = New System.Drawing.Size(204, 32)
        Me.MyLabel12.TabIndex = 4
        Me.MyLabel12.Text = "New Book Author"
        '
        'MyLabel21
        '
        Me.MyLabel21.AutoSize = True
        Me.MyLabel21.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel21.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel21.ForeColor = System.Drawing.Color.White
        Me.MyLabel21.Location = New System.Drawing.Point(22, 111)
        Me.MyLabel21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel21.Name = "MyLabel21"
        Me.MyLabel21.Size = New System.Drawing.Size(99, 32)
        Me.MyLabel21.TabIndex = 7
        Me.MyLabel21.Text = "Book ID"
        '
        'MyLabel14
        '
        Me.MyLabel14.AutoSize = True
        Me.MyLabel14.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel14.ForeColor = System.Drawing.Color.White
        Me.MyLabel14.Location = New System.Drawing.Point(22, 218)
        Me.MyLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel14.Name = "MyLabel14"
        Me.MyLabel14.Size = New System.Drawing.Size(195, 32)
        Me.MyLabel14.TabIndex = 6
        Me.MyLabel14.Text = "New Book Name"
        '
        'MyLabel15
        '
        Me.MyLabel15.AutoSize = True
        Me.MyLabel15.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel15.ForeColor = System.Drawing.Color.White
        Me.MyLabel15.Location = New System.Drawing.Point(22, 165)
        Me.MyLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel15.Name = "MyLabel15"
        Me.MyLabel15.Size = New System.Drawing.Size(121, 32)
        Me.MyLabel15.TabIndex = 7
        Me.MyLabel15.Text = "New ISBN"
        '
        'MyButton3
        '
        Me.MyButton3.BackColor = System.Drawing.Color.Transparent
        Me.MyButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MyButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyButton3.Location = New System.Drawing.Point(150, 440)
        Me.MyButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(309, 82)
        Me.MyButton3.TabIndex = 2
        Me.MyButton3.Text = "Edit Existing Book Record"
        '
        'MyGroupBox4
        '
        Me.MyGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.MyGroupBox4.Controls.Add(Me.AdminAddBookButton)
        Me.MyGroupBox4.Controls.Add(Me.AdminAddBookName)
        Me.MyGroupBox4.Controls.Add(Me.AdminAddBookCopies)
        Me.MyGroupBox4.Controls.Add(Me.AdminAddBookGenre)
        Me.MyGroupBox4.Controls.Add(Me.MyLabel23)
        Me.MyGroupBox4.Controls.Add(Me.AdminAddBookAuthor)
        Me.MyGroupBox4.Controls.Add(Me.MyLabel20)
        Me.MyGroupBox4.Controls.Add(Me.AdminAddBookISBN)
        Me.MyGroupBox4.Controls.Add(Me.MyLabel16)
        Me.MyGroupBox4.Controls.Add(Me.MyLabel18)
        Me.MyGroupBox4.Controls.Add(Me.MyLabel19)
        Me.MyGroupBox4.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MyGroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.MyGroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MyGroupBox4.Name = "MyGroupBox4"
        Me.MyGroupBox4.Size = New System.Drawing.Size(609, 411)
        Me.MyGroupBox4.TabIndex = 8
        Me.MyGroupBox4.Text = "Add Book"
        '
        'AdminAddBookButton
        '
        Me.AdminAddBookButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminAddBookButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AdminAddBookButton.Location = New System.Drawing.Point(198, 345)
        Me.AdminAddBookButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddBookButton.Name = "AdminAddBookButton"
        Me.AdminAddBookButton.Size = New System.Drawing.Size(218, 66)
        Me.AdminAddBookButton.TabIndex = 2
        Me.AdminAddBookButton.Text = "Add Book"
        '
        'AdminAddBookName
        '
        Me.AdminAddBookName.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddBookName.Location = New System.Drawing.Point(238, 129)
        Me.AdminAddBookName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddBookName.MaxLength = 32767
        Me.AdminAddBookName.Multiline = False
        Me.AdminAddBookName.Name = "AdminAddBookName"
        Me.AdminAddBookName.ReadOnly = False
        Me.AdminAddBookName.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddBookName.TabIndex = 1
        Me.AdminAddBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddBookName.UseSystemPasswordChar = False
        '
        'AdminAddBookCopies
        '
        Me.AdminAddBookCopies.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddBookCopies.Location = New System.Drawing.Point(238, 291)
        Me.AdminAddBookCopies.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddBookCopies.MaxLength = 32767
        Me.AdminAddBookCopies.Multiline = False
        Me.AdminAddBookCopies.Name = "AdminAddBookCopies"
        Me.AdminAddBookCopies.ReadOnly = False
        Me.AdminAddBookCopies.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddBookCopies.TabIndex = 1
        Me.AdminAddBookCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddBookCopies.UseSystemPasswordChar = False
        '
        'AdminAddBookGenre
        '
        Me.AdminAddBookGenre.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddBookGenre.Location = New System.Drawing.Point(238, 237)
        Me.AdminAddBookGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddBookGenre.MaxLength = 32767
        Me.AdminAddBookGenre.Multiline = False
        Me.AdminAddBookGenre.Name = "AdminAddBookGenre"
        Me.AdminAddBookGenre.ReadOnly = False
        Me.AdminAddBookGenre.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddBookGenre.TabIndex = 1
        Me.AdminAddBookGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddBookGenre.UseSystemPasswordChar = False
        '
        'MyLabel23
        '
        Me.MyLabel23.AutoSize = True
        Me.MyLabel23.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel23.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel23.ForeColor = System.Drawing.Color.White
        Me.MyLabel23.Location = New System.Drawing.Point(22, 297)
        Me.MyLabel23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel23.Name = "MyLabel23"
        Me.MyLabel23.Size = New System.Drawing.Size(87, 32)
        Me.MyLabel23.TabIndex = 0
        Me.MyLabel23.Text = "Copies"
        '
        'AdminAddBookAuthor
        '
        Me.AdminAddBookAuthor.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddBookAuthor.Location = New System.Drawing.Point(238, 183)
        Me.AdminAddBookAuthor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddBookAuthor.MaxLength = 32767
        Me.AdminAddBookAuthor.Multiline = False
        Me.AdminAddBookAuthor.Name = "AdminAddBookAuthor"
        Me.AdminAddBookAuthor.ReadOnly = False
        Me.AdminAddBookAuthor.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddBookAuthor.TabIndex = 1
        Me.AdminAddBookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddBookAuthor.UseSystemPasswordChar = False
        '
        'MyLabel20
        '
        Me.MyLabel20.AutoSize = True
        Me.MyLabel20.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel20.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel20.ForeColor = System.Drawing.Color.White
        Me.MyLabel20.Location = New System.Drawing.Point(22, 243)
        Me.MyLabel20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel20.Name = "MyLabel20"
        Me.MyLabel20.Size = New System.Drawing.Size(79, 32)
        Me.MyLabel20.TabIndex = 0
        Me.MyLabel20.Text = "Genre"
        '
        'AdminAddBookISBN
        '
        Me.AdminAddBookISBN.BackColor = System.Drawing.Color.Transparent
        Me.AdminAddBookISBN.Location = New System.Drawing.Point(238, 75)
        Me.AdminAddBookISBN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminAddBookISBN.MaxLength = 32767
        Me.AdminAddBookISBN.Multiline = False
        Me.AdminAddBookISBN.Name = "AdminAddBookISBN"
        Me.AdminAddBookISBN.ReadOnly = False
        Me.AdminAddBookISBN.Size = New System.Drawing.Size(348, 38)
        Me.AdminAddBookISBN.TabIndex = 1
        Me.AdminAddBookISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminAddBookISBN.UseSystemPasswordChar = False
        '
        'MyLabel16
        '
        Me.MyLabel16.AutoSize = True
        Me.MyLabel16.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel16.ForeColor = System.Drawing.Color.White
        Me.MyLabel16.Location = New System.Drawing.Point(22, 189)
        Me.MyLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel16.Name = "MyLabel16"
        Me.MyLabel16.Size = New System.Drawing.Size(149, 32)
        Me.MyLabel16.TabIndex = 0
        Me.MyLabel16.Text = "Book Author"
        '
        'MyLabel18
        '
        Me.MyLabel18.AutoSize = True
        Me.MyLabel18.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel18.ForeColor = System.Drawing.Color.White
        Me.MyLabel18.Location = New System.Drawing.Point(22, 135)
        Me.MyLabel18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel18.Name = "MyLabel18"
        Me.MyLabel18.Size = New System.Drawing.Size(140, 32)
        Me.MyLabel18.TabIndex = 0
        Me.MyLabel18.Text = "Book Name"
        '
        'MyLabel19
        '
        Me.MyLabel19.AutoSize = True
        Me.MyLabel19.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel19.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyLabel19.ForeColor = System.Drawing.Color.White
        Me.MyLabel19.Location = New System.Drawing.Point(22, 82)
        Me.MyLabel19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyLabel19.Name = "MyLabel19"
        Me.MyLabel19.Size = New System.Drawing.Size(66, 32)
        Me.MyLabel19.TabIndex = 0
        Me.MyLabel19.Text = "ISBN"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.AlertBox8)
        Me.TabPage3.Controls.Add(Me.Admin)
        Me.TabPage3.Controls.Add(Me.AdminMySQLExecuteButton)
        Me.TabPage3.Controls.Add(Me.AdminMySQLQueryType)
        Me.TabPage3.Controls.Add(Me.AdminMySQLQueryTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Size = New System.Drawing.Size(1248, 608)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MySQL"
        '
        'AlertBox8
        '
        Me.AlertBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox8.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox8.Location = New System.Drawing.Point(9, 482)
        Me.AlertBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox8.Name = "AlertBox8"
        Me.AlertBox8.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox8.TabIndex = 6
        Me.AlertBox8.Text = "AlertBox"
        Me.AlertBox8.Visible = False
        '
        'Admin
        '
        Me.Admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Admin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Admin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.HideSelection = False
        Me.Admin.Location = New System.Drawing.Point(58, 129)
        Me.Admin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(1143, 402)
        Me.Admin.TabIndex = 10
        Me.Admin.Text = ""
        Me.Admin.WordWrap = False
        '
        'AdminMySQLExecuteButton
        '
        Me.AdminMySQLExecuteButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminMySQLExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminMySQLExecuteButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AdminMySQLExecuteButton.Location = New System.Drawing.Point(1042, 83)
        Me.AdminMySQLExecuteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminMySQLExecuteButton.Name = "AdminMySQLExecuteButton"
        Me.AdminMySQLExecuteButton.Size = New System.Drawing.Size(159, 37)
        Me.AdminMySQLExecuteButton.TabIndex = 9
        Me.AdminMySQLExecuteButton.Text = "Execute"
        '
        'AdminMySQLQueryType
        '
        Me.AdminMySQLQueryType.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.AdminMySQLQueryType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminMySQLQueryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.AdminMySQLQueryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AdminMySQLQueryType.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AdminMySQLQueryType.ForeColor = System.Drawing.Color.White
        Me.AdminMySQLQueryType.FormattingEnabled = True
        Me.AdminMySQLQueryType.ItemHeight = 18
        Me.AdminMySQLQueryType.Items.AddRange(New Object() {"Execute Query", "Execute Non-Query"})
        Me.AdminMySQLQueryType.Location = New System.Drawing.Point(762, 83)
        Me.AdminMySQLQueryType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminMySQLQueryType.Name = "AdminMySQLQueryType"
        Me.AdminMySQLQueryType.Size = New System.Drawing.Size(270, 24)
        Me.AdminMySQLQueryType.TabIndex = 8
        '
        'AdminMySQLQueryTextBox
        '
        Me.AdminMySQLQueryTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AdminMySQLQueryTextBox.Location = New System.Drawing.Point(58, 29)
        Me.AdminMySQLQueryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminMySQLQueryTextBox.MaxLength = 32767
        Me.AdminMySQLQueryTextBox.Multiline = False
        Me.AdminMySQLQueryTextBox.Name = "AdminMySQLQueryTextBox"
        Me.AdminMySQLQueryTextBox.ReadOnly = False
        Me.AdminMySQLQueryTextBox.Size = New System.Drawing.Size(1143, 38)
        Me.AdminMySQLQueryTextBox.TabIndex = 7
        Me.AdminMySQLQueryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminMySQLQueryTextBox.UseSystemPasswordChar = False
        '
        'LoginSignupTab
        '
        Me.LoginSignupTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LoginSignupTab.Controls.Add(Me.AlertBox6)
        Me.LoginSignupTab.Controls.Add(Me.AASignupGroupBox)
        Me.LoginSignupTab.Controls.Add(Me.AALoginGroupBox)
        Me.LoginSignupTab.Location = New System.Drawing.Point(4, 44)
        Me.LoginSignupTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoginSignupTab.Name = "LoginSignupTab"
        Me.LoginSignupTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoginSignupTab.Size = New System.Drawing.Size(1264, 666)
        Me.LoginSignupTab.TabIndex = 4
        Me.LoginSignupTab.Text = "Login/Signup"
        '
        'AlertBox6
        '
        Me.AlertBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AlertBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlertBox6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AlertBox6.Kind = Library_Management.MyAlertBox._Kind.Success
        Me.AlertBox6.Location = New System.Drawing.Point(20, 554)
        Me.AlertBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlertBox6.Name = "AlertBox6"
        Me.AlertBox6.Size = New System.Drawing.Size(1221, 42)
        Me.AlertBox6.TabIndex = 5
        Me.AlertBox6.Text = "AlertBox"
        Me.AlertBox6.Visible = False
        '
        'AASignupGroupBox
        '
        Me.AASignupGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AASignupGroupBox.Controls.Add(Me.AAAAALabel12)
        Me.AASignupGroupBox.Controls.Add(Me.SignupDropDownBox)
        Me.AASignupGroupBox.Controls.Add(Me.AAASignupConfirmPasswordPicture)
        Me.AASignupGroupBox.Controls.Add(Me.AAASignupPasswordPicture)
        Me.AASignupGroupBox.Controls.Add(Me.AAAAALabel4)
        Me.AASignupGroupBox.Controls.Add(Me.SignupConfirmPasswordTextBox)
        Me.AASignupGroupBox.Controls.Add(Me.AAAAALabel6)
        Me.AASignupGroupBox.Controls.Add(Me.SignupButton)
        Me.AASignupGroupBox.Controls.Add(Me.SignupPasswordTextBox)
        Me.AASignupGroupBox.Controls.Add(Me.AAAAALabel8)
        Me.AASignupGroupBox.Controls.Add(Me.AAAAALabel7)
        Me.AASignupGroupBox.Controls.Add(Me.SignupFullnameTextBox)
        Me.AASignupGroupBox.Controls.Add(Me.SignupUsernameTextBox)
        Me.AASignupGroupBox.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.AASignupGroupBox.Location = New System.Drawing.Point(668, 9)
        Me.AASignupGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AASignupGroupBox.Name = "AASignupGroupBox"
        Me.AASignupGroupBox.Size = New System.Drawing.Size(580, 535)
        Me.AASignupGroupBox.TabIndex = 4
        Me.AASignupGroupBox.Text = "Signup"
        '
        'AAAAALabel12
        '
        Me.AAAAALabel12.AutoSize = True
        Me.AAAAALabel12.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AAAAALabel12.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel12.Location = New System.Drawing.Point(129, 432)
        Me.AAAAALabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel12.Name = "AAAAALabel12"
        Me.AAAAALabel12.Size = New System.Drawing.Size(113, 32)
        Me.AAAAALabel12.TabIndex = 5
        Me.AAAAALabel12.Text = "Apply for"
        '
        'SignupDropDownBox
        '
        Me.SignupDropDownBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SignupDropDownBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupDropDownBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SignupDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SignupDropDownBox.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SignupDropDownBox.ForeColor = System.Drawing.Color.White
        Me.SignupDropDownBox.FormattingEnabled = True
        Me.SignupDropDownBox.ItemHeight = 18
        Me.SignupDropDownBox.Items.AddRange(New Object() {"Student", "Teacher", "Admin"})
        Me.SignupDropDownBox.Location = New System.Drawing.Point(249, 429)
        Me.SignupDropDownBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SignupDropDownBox.Name = "SignupDropDownBox"
        Me.SignupDropDownBox.Size = New System.Drawing.Size(200, 24)
        Me.SignupDropDownBox.TabIndex = 4
        '
        'AAASignupConfirmPasswordPicture
        '
        Me.AAASignupConfirmPasswordPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAASignupConfirmPasswordPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AAASignupConfirmPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAASignupConfirmPasswordPicture.Image = Global.Library_Management.My.Resources.Resources.hide
        Me.AAASignupConfirmPasswordPicture.Location = New System.Drawing.Point(408, 374)
        Me.AAASignupConfirmPasswordPicture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAASignupConfirmPasswordPicture.Name = "AAASignupConfirmPasswordPicture"
        Me.AAASignupConfirmPasswordPicture.Size = New System.Drawing.Size(42, 44)
        Me.AAASignupConfirmPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAASignupConfirmPasswordPicture.TabIndex = 3
        Me.AAASignupConfirmPasswordPicture.TabStop = False
        '
        'AAASignupPasswordPicture
        '
        Me.AAASignupPasswordPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAASignupPasswordPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AAASignupPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAASignupPasswordPicture.Image = Global.Library_Management.My.Resources.Resources.hide
        Me.AAASignupPasswordPicture.Location = New System.Drawing.Point(408, 291)
        Me.AAASignupPasswordPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.AAASignupPasswordPicture.Name = "AAASignupPasswordPicture"
        Me.AAASignupPasswordPicture.Size = New System.Drawing.Size(42, 44)
        Me.AAASignupPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAASignupPasswordPicture.TabIndex = 3
        Me.AAASignupPasswordPicture.TabStop = False
        '
        'AAAAALabel4
        '
        Me.AAAAALabel4.AutoSize = True
        Me.AAAAALabel4.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AAAAALabel4.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel4.Location = New System.Drawing.Point(128, 95)
        Me.AAAAALabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel4.Name = "AAAAALabel4"
        Me.AAAAALabel4.Size = New System.Drawing.Size(81, 21)
        Me.AAAAALabel4.TabIndex = 1
        Me.AAAAALabel4.Text = "Username"
        '
        'SignupConfirmPasswordTextBox
        '
        Me.SignupConfirmPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SignupConfirmPasswordTextBox.Location = New System.Drawing.Point(128, 374)
        Me.SignupConfirmPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.SignupConfirmPasswordTextBox.MaxLength = 32767
        Me.SignupConfirmPasswordTextBox.Multiline = False
        Me.SignupConfirmPasswordTextBox.Name = "SignupConfirmPasswordTextBox"
        Me.SignupConfirmPasswordTextBox.ReadOnly = False
        Me.SignupConfirmPasswordTextBox.Size = New System.Drawing.Size(280, 38)
        Me.SignupConfirmPasswordTextBox.TabIndex = 2
        Me.SignupConfirmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SignupConfirmPasswordTextBox.UseSystemPasswordChar = True
        '
        'AAAAALabel6
        '
        Me.AAAAALabel6.AutoSize = True
        Me.AAAAALabel6.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AAAAALabel6.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel6.Location = New System.Drawing.Point(128, 262)
        Me.AAAAALabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel6.Name = "AAAAALabel6"
        Me.AAAAALabel6.Size = New System.Drawing.Size(76, 21)
        Me.AAAAALabel6.TabIndex = 1
        Me.AAAAALabel6.Text = "Password"
        '
        'SignupButton
        '
        Me.SignupButton.BackColor = System.Drawing.Color.Transparent
        Me.SignupButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SignupButton.Location = New System.Drawing.Point(212, 488)
        Me.SignupButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SignupButton.Name = "SignupButton"
        Me.SignupButton.Size = New System.Drawing.Size(156, 48)
        Me.SignupButton.TabIndex = 0
        Me.SignupButton.Text = "Signup"
        '
        'SignupPasswordTextBox
        '
        Me.SignupPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SignupPasswordTextBox.Location = New System.Drawing.Point(128, 291)
        Me.SignupPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.SignupPasswordTextBox.MaxLength = 32767
        Me.SignupPasswordTextBox.Multiline = False
        Me.SignupPasswordTextBox.Name = "SignupPasswordTextBox"
        Me.SignupPasswordTextBox.ReadOnly = False
        Me.SignupPasswordTextBox.Size = New System.Drawing.Size(280, 38)
        Me.SignupPasswordTextBox.TabIndex = 2
        Me.SignupPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SignupPasswordTextBox.UseSystemPasswordChar = True
        '
        'AAAAALabel8
        '
        Me.AAAAALabel8.AutoSize = True
        Me.AAAAALabel8.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AAAAALabel8.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel8.Location = New System.Drawing.Point(128, 178)
        Me.AAAAALabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel8.Name = "AAAAALabel8"
        Me.AAAAALabel8.Size = New System.Drawing.Size(74, 21)
        Me.AAAAALabel8.TabIndex = 1
        Me.AAAAALabel8.Text = "Fullname"
        '
        'AAAAALabel7
        '
        Me.AAAAALabel7.AutoSize = True
        Me.AAAAALabel7.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AAAAALabel7.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel7.Location = New System.Drawing.Point(128, 345)
        Me.AAAAALabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel7.Name = "AAAAALabel7"
        Me.AAAAALabel7.Size = New System.Drawing.Size(137, 21)
        Me.AAAAALabel7.TabIndex = 1
        Me.AAAAALabel7.Text = "Confirm Password"
        '
        'SignupFullnameTextBox
        '
        Me.SignupFullnameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SignupFullnameTextBox.Location = New System.Drawing.Point(128, 208)
        Me.SignupFullnameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SignupFullnameTextBox.MaxLength = 32767
        Me.SignupFullnameTextBox.Multiline = False
        Me.SignupFullnameTextBox.Name = "SignupFullnameTextBox"
        Me.SignupFullnameTextBox.ReadOnly = False
        Me.SignupFullnameTextBox.Size = New System.Drawing.Size(324, 38)
        Me.SignupFullnameTextBox.TabIndex = 2
        Me.SignupFullnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SignupFullnameTextBox.UseSystemPasswordChar = False
        '
        'SignupUsernameTextBox
        '
        Me.SignupUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.SignupUsernameTextBox.Location = New System.Drawing.Point(128, 125)
        Me.SignupUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SignupUsernameTextBox.MaxLength = 32767
        Me.SignupUsernameTextBox.Multiline = False
        Me.SignupUsernameTextBox.Name = "SignupUsernameTextBox"
        Me.SignupUsernameTextBox.ReadOnly = False
        Me.SignupUsernameTextBox.Size = New System.Drawing.Size(324, 38)
        Me.SignupUsernameTextBox.TabIndex = 2
        Me.SignupUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SignupUsernameTextBox.UseSystemPasswordChar = False
        '
        'AALoginGroupBox
        '
        Me.AALoginGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AALoginGroupBox.Controls.Add(Me.AAALoginPasswordPicture)
        Me.AALoginGroupBox.Controls.Add(Me.LoginUsernameTextBox)
        Me.AALoginGroupBox.Controls.Add(Me.LoginButton)
        Me.AALoginGroupBox.Controls.Add(Me.AAAAALabel1)
        Me.AALoginGroupBox.Controls.Add(Me.AAAAALabel5)
        Me.AALoginGroupBox.Controls.Add(Me.LoginPasswordTextBox)
        Me.AALoginGroupBox.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.AALoginGroupBox.Location = New System.Drawing.Point(12, 9)
        Me.AALoginGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AALoginGroupBox.Name = "AALoginGroupBox"
        Me.AALoginGroupBox.Size = New System.Drawing.Size(582, 603)
        Me.AALoginGroupBox.TabIndex = 3
        Me.AALoginGroupBox.Text = "Login"
        '
        'AAALoginPasswordPicture
        '
        Me.AAALoginPasswordPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AAALoginPasswordPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AAALoginPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAALoginPasswordPicture.Image = Global.Library_Management.My.Resources.Resources.hide
        Me.AAALoginPasswordPicture.Location = New System.Drawing.Point(410, 317)
        Me.AAALoginPasswordPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.AAALoginPasswordPicture.Name = "AAALoginPasswordPicture"
        Me.AAALoginPasswordPicture.Size = New System.Drawing.Size(42, 44)
        Me.AAALoginPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAALoginPasswordPicture.TabIndex = 3
        Me.AAALoginPasswordPicture.TabStop = False
        '
        'LoginUsernameTextBox
        '
        Me.LoginUsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.LoginUsernameTextBox.Location = New System.Drawing.Point(129, 212)
        Me.LoginUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoginUsernameTextBox.MaxLength = 32767
        Me.LoginUsernameTextBox.Multiline = False
        Me.LoginUsernameTextBox.Name = "LoginUsernameTextBox"
        Me.LoginUsernameTextBox.ReadOnly = False
        Me.LoginUsernameTextBox.Size = New System.Drawing.Size(324, 38)
        Me.LoginUsernameTextBox.TabIndex = 2
        Me.LoginUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LoginUsernameTextBox.UseSystemPasswordChar = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LoginButton.Location = New System.Drawing.Point(213, 382)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(148, 45)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "Login"
        '
        'AAAAALabel1
        '
        Me.AAAAALabel1.AutoSize = True
        Me.AAAAALabel1.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AAAAALabel1.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel1.Location = New System.Drawing.Point(129, 177)
        Me.AAAAALabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel1.Name = "AAAAALabel1"
        Me.AAAAALabel1.Size = New System.Drawing.Size(81, 21)
        Me.AAAAALabel1.TabIndex = 1
        Me.AAAAALabel1.Text = "Username"
        '
        'AAAAALabel5
        '
        Me.AAAAALabel5.AutoSize = True
        Me.AAAAALabel5.BackColor = System.Drawing.Color.Transparent
        Me.AAAAALabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AAAAALabel5.ForeColor = System.Drawing.Color.White
        Me.AAAAALabel5.Location = New System.Drawing.Point(129, 282)
        Me.AAAAALabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AAAAALabel5.Name = "AAAAALabel5"
        Me.AAAAALabel5.Size = New System.Drawing.Size(76, 21)
        Me.AAAAALabel5.TabIndex = 1
        Me.AAAAALabel5.Text = "Password"
        '
        'LoginPasswordTextBox
        '
        Me.LoginPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(129, 317)
        Me.LoginPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.LoginPasswordTextBox.MaxLength = 32767
        Me.LoginPasswordTextBox.Multiline = False
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.ReadOnly = False
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(280, 38)
        Me.LoginPasswordTextBox.TabIndex = 2
        Me.LoginPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LoginPasswordTextBox.UseSystemPasswordChar = True
        '
        'AAAACloseButtonMain
        '
        Me.AAAACloseButtonMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AAAACloseButtonMain.BackColor = System.Drawing.Color.White
        Me.AAAACloseButtonMain.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.AAAACloseButtonMain.Location = New System.Drawing.Point(1221, 20)
        Me.AAAACloseButtonMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AAAACloseButtonMain.Name = "AAAACloseButtonMain"
        Me.AAAACloseButtonMain.Size = New System.Drawing.Size(18, 18)
        Me.AAAACloseButtonMain.TabIndex = 0
        Me.AAAACloseButtonMain.Text = "MyClose1"
        '
        'AAAAMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 846)
        Me.Controls.Add(Me.AAAAMainFormSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AAAAMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AAAAMainFormSkin.ResumeLayout(False)
        Me.TabControlMain.ResumeLayout(False)
        Me.SearchBooksTab.ResumeLayout(False)
        Me.SearchBooksTab.PerformLayout()
        Me.BrowseBooksTab.ResumeLayout(False)
        CType(Me.BrowseBooksDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrowseBooksContextMenu.ResumeLayout(False)
        Me.IssueBookTab.ResumeLayout(False)
        Me.ReturnGroupbox.ResumeLayout(False)
        Me.ReturnGroupbox.PerformLayout()
        Me.AAIssueGroupBox.ResumeLayout(False)
        Me.AAIssueGroupBox.PerformLayout()
        Me.SummaryTab.ResumeLayout(False)
        Me.AASummaryChangePasswordGroupBox.ResumeLayout(False)
        Me.AASummaryChangePasswordGroupBox.PerformLayout()
        CType(Me.AAASummaryConfirmPasswordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAASummaryNewPasswordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SummaryOldPasswordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AAAProfileGroupBox.ResumeLayout(False)
        Me.AAAProfileGroupBox.PerformLayout()
        Me.AASummaryGroupBox.ResumeLayout(False)
        Me.AASummaryGroupBox.PerformLayout()
        Me.AdminOptionsTab.ResumeLayout(False)
        Me.AdminTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MyGroupBox5.ResumeLayout(False)
        Me.MyGroupBox5.PerformLayout()
        Me.MyGroupBox1.ResumeLayout(False)
        Me.MyGroupBox1.PerformLayout()
        Me.MyGroupBox2.ResumeLayout(False)
        Me.MyGroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.MyGroupBox6.ResumeLayout(False)
        Me.MyGroupBox6.PerformLayout()
        Me.MyGroupBox3.ResumeLayout(False)
        Me.MyGroupBox3.PerformLayout()
        Me.MyGroupBox4.ResumeLayout(False)
        Me.MyGroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.LoginSignupTab.ResumeLayout(False)
        Me.AASignupGroupBox.ResumeLayout(False)
        Me.AASignupGroupBox.PerformLayout()
        CType(Me.AAASignupConfirmPasswordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAASignupPasswordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AALoginGroupBox.ResumeLayout(False)
        Me.AALoginGroupBox.PerformLayout()
        CType(Me.AAALoginPasswordPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

	End Sub

	Friend WithEvents AAAAMainFormSkin As FormSkin
	Friend WithEvents AAAACloseButtonMain As MyClose
	Friend WithEvents StatusBar As MyStatusBar
	Friend WithEvents AAAAExitButton As MyButton
	Friend WithEvents AAAALogoutButton As MyButton
	Friend WithEvents AAAAMiniButtonMain As MyMini
	Friend WithEvents BrowseBooksContextMenu As MyContextMenuStrip
	Friend WithEvents IssueSelectedBookToolStrip As ToolStripMenuItem
	Friend WithEvents CopyBookNameToolStrip As ToolStripMenuItem
	Friend WithEvents CopyISBNNumberToolStrip As ToolStripMenuItem
	Friend WithEvents CopyBookIDToolStrip As ToolStripMenuItem
	Friend WithEvents TabControlMain As MyTabControl
	Friend WithEvents SearchBooksTab As TabPage
	Friend WithEvents AlertBox1 As MyAlertBox
	Friend WithEvents SearchBookButton As MyButton
	Friend WithEvents AAAAALabel11 As MyLabel
	Friend WithEvents AAAAALabel10 As MyLabel
	Friend WithEvents AAAAALabel3 As MyLabel
	Friend WithEvents AAAAALabel2 As MyLabel
	Friend WithEvents AAAAALabel9 As MyLabel
	Friend WithEvents SearchBookAuthorTextBox As MyTextBox
	Friend WithEvents SearchBookNameTextBox As MyTextBox
	Friend WithEvents SearchBookIDTextBox As MyTextBox
	Friend WithEvents SearchBookISBNTextBox As MyTextBox
	Friend WithEvents BrowseBooksTab As TabPage
	Friend WithEvents AlertBox2 As MyAlertBox
	Friend WithEvents BrowseBooksDataGrid As DataGridView
	Friend WithEvents IssueBookTab As TabPage
	Friend WithEvents AlertBox3 As MyAlertBox
	Friend WithEvents ReturnGroupbox As MyGroupBox
	Friend WithEvents ReturnBookInfoTextBox As MyTextBox
	Friend WithEvents ReturnButton As MyButton
	Friend WithEvents AAIssueGroupBox As MyGroupBox
	Friend WithEvents IssueBookInfoTextBox As MyTextBox
	Friend WithEvents AAAAALabel18 As MyLabel
	Friend WithEvents ReturnBookSearchDropDown As MyComboBox
	Friend WithEvents IssueButton As MyButton
	Friend WithEvents SummaryTab As TabPage
	Friend WithEvents AlertBox4 As MyAlertBox
	Friend WithEvents AASummaryChangePasswordGroupBox As MyGroupBox
	Friend WithEvents ProfileChangeAlert As MyAlertBox
	Friend WithEvents SummaryChangePasswordButton As MyButton
	Friend WithEvents AAASummaryConfirmPasswordPicture As PictureBox
	Friend WithEvents AAASummaryNewPasswordPicture As PictureBox
	Friend WithEvents SummaryOldPasswordPicture As PictureBox
	Friend WithEvents SummaryOldPasswordTextbox As MyTextBox
	Friend WithEvents SummaryConfirmPasswordTextBox As MyTextBox
	Friend WithEvents AAAAALabel15 As MyLabel
	Friend WithEvents AAAAALabel17 As MyLabel
	Friend WithEvents AAAAALabel16 As MyLabel
	Friend WithEvents SummaryNewPasswordTextBox As MyTextBox
	Friend WithEvents AAAProfileGroupBox As MyGroupBox
	Friend WithEvents AAAAALabel22 As MyLabel
	Friend WithEvents SummaryProfileDropDownBox As MyComboBox
	Friend WithEvents SummaryFullnameTextBox As MyTextBox
	Friend WithEvents SummaryEditProfileButton As MyButton
	Friend WithEvents SummaryUsernameTextBox As MyTextBox
	Friend WithEvents AAAAALabel20 As MyLabel
	Friend WithEvents AAAAALabel21 As MyLabel
	Friend WithEvents AASummaryGroupBox As MyGroupBox
	Friend WithEvents SummaryBooksIssuedTextBox As MyTextBox
	Friend WithEvents SummaryDueTextBox As MyTextBox
	Friend WithEvents AAAAALabel13 As MyLabel
	Friend WithEvents AAAAALabel14 As MyLabel
	Friend WithEvents AdminOptionsTab As TabPage
	Friend WithEvents AdminTabControl As MyTabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents AlertBox5 As MyAlertBox
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents LoginSignupTab As TabPage
	Friend WithEvents AlertBox6 As MyAlertBox
	Friend WithEvents AASignupGroupBox As MyGroupBox
	Friend WithEvents AAAAALabel12 As MyLabel
	Friend WithEvents SignupDropDownBox As MyComboBox
	Friend WithEvents AAASignupConfirmPasswordPicture As PictureBox
	Friend WithEvents AAASignupPasswordPicture As PictureBox
	Friend WithEvents AAAAALabel4 As MyLabel
	Friend WithEvents SignupConfirmPasswordTextBox As MyTextBox
	Friend WithEvents AAAAALabel6 As MyLabel
	Friend WithEvents SignupButton As MyButton
	Friend WithEvents SignupPasswordTextBox As MyTextBox
	Friend WithEvents AAAAALabel8 As MyLabel
	Friend WithEvents AAAAALabel7 As MyLabel
	Friend WithEvents SignupFullnameTextBox As MyTextBox
	Friend WithEvents SignupUsernameTextBox As MyTextBox
	Friend WithEvents AALoginGroupBox As MyGroupBox
	Friend WithEvents AAALoginPasswordPicture As PictureBox
	Friend WithEvents LoginUsernameTextBox As MyTextBox
	Friend WithEvents LoginButton As MyButton
	Friend WithEvents AAAAALabel1 As MyLabel
	Friend WithEvents AAAAALabel5 As MyLabel
	Friend WithEvents LoginPasswordTextBox As MyTextBox
	Friend WithEvents MyLabel1 As MyLabel
	Friend WithEvents IssueBookSearchDropDown As MyComboBox
	Friend WithEvents AlertBox7 As MyAlertBox
	Friend WithEvents AlertBox8 As MyAlertBox
	Friend WithEvents SummaryViewIssuedBooks As MyButton
	Friend WithEvents MyGroupBox2 As MyGroupBox
	Friend WithEvents MyGroupBox1 As MyGroupBox
	Friend WithEvents AdminAddAccFullnameTextBox As MyTextBox
	Friend WithEvents AdminAddAccPasswordTextBox As MyTextBox
	Friend WithEvents AdminAddAccUsernameTextBox As MyTextBox
	Friend WithEvents MyLabel5 As MyLabel
	Friend WithEvents MyLabel4 As MyLabel
	Friend WithEvents MyLabel3 As MyLabel
	Friend WithEvents MyLabel2 As MyLabel
	Friend WithEvents AdminEditAccNewPasswordTextBox As MyTextBox
	Friend WithEvents AdminEditAccNewFullnameTextBox As MyTextBox
	Friend WithEvents MyLabel6 As MyLabel
	Friend WithEvents AdminEditAccConfirmPasswordTextBox As MyTextBox
	Friend WithEvents MyLabel7 As MyLabel
	Friend WithEvents MyLabel8 As MyLabel
	Friend WithEvents AdminEditAccNewUsernameTextBox As MyTextBox
	Friend WithEvents MyLabel9 As MyLabel
	Friend WithEvents AdminAddAccButton As MyButton
	Friend WithEvents AdminAddAccConfirmPasswordTextBox As MyTextBox
	Friend WithEvents AdminEditAccButton As MyButton
	Friend WithEvents MyLabel10 As MyLabel
	Friend WithEvents AdminEditAccOldUsernameTextBox As MyTextBox
	Friend WithEvents MyGroupBox3 As MyGroupBox
	Friend WithEvents AdminEditBookName As MyTextBox
	Friend WithEvents AdminEditBookCopies As MyTextBox
	Friend WithEvents AdminEditBookAuthor As MyTextBox
	Friend WithEvents MyLabel11 As MyLabel
	Friend WithEvents AdminEditBookID As MyTextBox
	Friend WithEvents AdminEditBookISBN As MyTextBox
	Friend WithEvents MyLabel12 As MyLabel
	Friend WithEvents MyLabel21 As MyLabel
	Friend WithEvents MyLabel14 As MyLabel
	Friend WithEvents MyLabel15 As MyLabel
	Friend WithEvents MyButton3 As MyButton
	Friend WithEvents MyGroupBox4 As MyGroupBox
	Friend WithEvents AdminAddBookButton As MyButton
	Friend WithEvents AdminAddBookName As MyTextBox
	Friend WithEvents AdminAddBookGenre As MyTextBox
	Friend WithEvents AdminAddBookAuthor As MyTextBox
	Friend WithEvents MyLabel20 As MyLabel
	Friend WithEvents AdminAddBookISBN As MyTextBox
	Friend WithEvents MyLabel16 As MyLabel
	Friend WithEvents MyLabel18 As MyLabel
	Friend WithEvents MyLabel19 As MyLabel
	Friend WithEvents AdminMySQLQueryTextBox As MyTextBox
	Friend WithEvents AdminMySQLExecuteButton As MyButton
	Friend WithEvents AdminMySQLQueryType As MyComboBox
	Friend WithEvents Admin As RichTextBox
	Friend WithEvents MyGroupBox5 As MyGroupBox
	Friend WithEvents AdminDeleteAccButton As MyButton
	Friend WithEvents MyLabel13 As MyLabel
	Friend WithEvents AdminDeleteAccUsernameTextBox As MyTextBox
	Friend WithEvents MyGroupBox6 As MyGroupBox
	Friend WithEvents AdminRemoveBookIDTextBox As MyTextBox
	Friend WithEvents AdminRemoveBookButton As MyButton
	Friend WithEvents MyLabel17 As MyLabel
	Friend WithEvents AdminEditBookGenreTextBox As MyTextBox
	Friend WithEvents MyLabel22 As MyLabel
	Friend WithEvents AdminAddBookCopies As MyTextBox
	Friend WithEvents MyLabel23 As MyLabel
	Friend WithEvents AdminAddAccDropDown As MyComboBox
	Friend WithEvents MyLabel24 As MyLabel
	Friend WithEvents MyLabel25 As MyLabel
	Friend WithEvents SearchBookGenreTextBox As MyTextBox
	Friend WithEvents MyTextBox1 As MyTextBox
	Friend WithEvents MyTextBox2 As MyTextBox
	Friend WithEvents MyLabel26 As MyLabel
	Friend WithEvents MyLabel27 As MyLabel
End Class
