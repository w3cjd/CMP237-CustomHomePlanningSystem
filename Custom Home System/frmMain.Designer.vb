<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.lblSquareFootage = New System.Windows.Forms.Label()
        Me.txtSquareFootage = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.grpHouseOptions = New System.Windows.Forms.GroupBox()
        Me.grpFloor = New System.Windows.Forms.GroupBox()
        Me.radHardwood = New System.Windows.Forms.RadioButton()
        Me.radCarpeting = New System.Windows.Forms.RadioButton()
        Me.grpExterior = New System.Windows.Forms.GroupBox()
        Me.radStone = New System.Windows.Forms.RadioButton()
        Me.radStucco = New System.Windows.Forms.RadioButton()
        Me.radBrick = New System.Windows.Forms.RadioButton()
        Me.radSiding = New System.Windows.Forms.RadioButton()
        Me.grpBathrooms = New System.Windows.Forms.GroupBox()
        Me.rad4Bathrooms = New System.Windows.Forms.RadioButton()
        Me.rad3Bathrooms = New System.Windows.Forms.RadioButton()
        Me.rad2Bathrooms = New System.Windows.Forms.RadioButton()
        Me.rad1Bathroom = New System.Windows.Forms.RadioButton()
        Me.grpGarage = New System.Windows.Forms.GroupBox()
        Me.radAttached = New System.Windows.Forms.RadioButton()
        Me.rad2Car = New System.Windows.Forms.RadioButton()
        Me.rad1Car = New System.Windows.Forms.RadioButton()
        Me.grpOtherOptions = New System.Windows.Forms.GroupBox()
        Me.chkKitchen = New System.Windows.Forms.CheckBox()
        Me.chkFireplace = New System.Windows.Forms.CheckBox()
        Me.chkAirConditioning = New System.Windows.Forms.CheckBox()
        Me.chkBasement = New System.Windows.Forms.CheckBox()
        Me.grpBedrooms = New System.Windows.Forms.GroupBox()
        Me.rad4Bedrooms = New System.Windows.Forms.RadioButton()
        Me.rad3Bedrooms = New System.Windows.Forms.RadioButton()
        Me.rad2Bedrooms = New System.Windows.Forms.RadioButton()
        Me.rad1Bedroom = New System.Windows.Forms.RadioButton()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.txtFinalPrice = New System.Windows.Forms.TextBox()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.grpPersonalInfo.SuspendLayout()
        Me.grpHouseOptions.SuspendLayout()
        Me.grpFloor.SuspendLayout()
        Me.grpExterior.SuspendLayout()
        Me.grpBathrooms.SuspendLayout()
        Me.grpGarage.SuspendLayout()
        Me.grpOtherOptions.SuspendLayout()
        Me.grpBedrooms.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(357, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(490, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Custom Home Planning System"
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.Controls.Add(Me.lblSquareFootage)
        Me.grpPersonalInfo.Controls.Add(Me.txtSquareFootage)
        Me.grpPersonalInfo.Controls.Add(Me.txtCity)
        Me.grpPersonalInfo.Controls.Add(Me.lblCity)
        Me.grpPersonalInfo.Controls.Add(Me.txtLastName)
        Me.grpPersonalInfo.Controls.Add(Me.lblLastName)
        Me.grpPersonalInfo.Controls.Add(Me.txtFirstName)
        Me.grpPersonalInfo.Controls.Add(Me.lblFirstName)
        Me.grpPersonalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpPersonalInfo, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.grpPersonalInfo.Location = New System.Drawing.Point(10, 51)
        Me.grpPersonalInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.HelpProvider.SetShowHelp(Me.grpPersonalInfo, True)
        Me.grpPersonalInfo.Size = New System.Drawing.Size(422, 185)
        Me.grpPersonalInfo.TabIndex = 0
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Customer Info:"
        '
        'lblSquareFootage
        '
        Me.lblSquareFootage.AutoSize = True
        Me.lblSquareFootage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.lblSquareFootage, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.lblSquareFootage.Location = New System.Drawing.Point(19, 143)
        Me.lblSquareFootage.Name = "lblSquareFootage"
        Me.HelpProvider.SetShowHelp(Me.lblSquareFootage, True)
        Me.lblSquareFootage.Size = New System.Drawing.Size(137, 20)
        Me.lblSquareFootage.TabIndex = 7
        Me.lblSquareFootage.Text = "Square Footage: "
        '
        'txtSquareFootage
        '
        Me.txtSquareFootage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.txtSquareFootage, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.txtSquareFootage.Location = New System.Drawing.Point(162, 140)
        Me.txtSquareFootage.Name = "txtSquareFootage"
        Me.HelpProvider.SetShowHelp(Me.txtSquareFootage, True)
        Me.txtSquareFootage.Size = New System.Drawing.Size(245, 26)
        Me.txtSquareFootage.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.txtCity, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.txtCity.Location = New System.Drawing.Point(162, 102)
        Me.txtCity.Name = "txtCity"
        Me.HelpProvider.SetShowHelp(Me.txtCity, True)
        Me.txtCity.Size = New System.Drawing.Size(245, 26)
        Me.txtCity.TabIndex = 3
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.lblCity, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.lblCity.Location = New System.Drawing.Point(107, 105)
        Me.lblCity.Name = "lblCity"
        Me.HelpProvider.SetShowHelp(Me.lblCity, True)
        Me.lblCity.Size = New System.Drawing.Size(48, 20)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City: "
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.txtLastName, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.txtLastName.Location = New System.Drawing.Point(162, 63)
        Me.txtLastName.Name = "txtLastName"
        Me.HelpProvider.SetShowHelp(Me.txtLastName, True)
        Me.txtLastName.Size = New System.Drawing.Size(245, 26)
        Me.txtLastName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.lblLastName, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.lblLastName.Location = New System.Drawing.Point(54, 66)
        Me.lblLastName.Name = "lblLastName"
        Me.HelpProvider.SetShowHelp(Me.lblLastName, True)
        Me.lblLastName.Size = New System.Drawing.Size(101, 20)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.txtFirstName, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.txtFirstName.Location = New System.Drawing.Point(162, 27)
        Me.txtFirstName.Name = "txtFirstName"
        Me.HelpProvider.SetShowHelp(Me.txtFirstName, True)
        Me.txtFirstName.Size = New System.Drawing.Size(245, 26)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.lblFirstName, "Please enter your information in these text fields.  All text fields are required" &
        ".  Please enter a numeric square footage that is greater than zero.")
        Me.lblFirstName.Location = New System.Drawing.Point(54, 30)
        Me.lblFirstName.Name = "lblFirstName"
        Me.HelpProvider.SetShowHelp(Me.lblFirstName, True)
        Me.lblFirstName.Size = New System.Drawing.Size(102, 20)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name: "
        '
        'grpHouseOptions
        '
        Me.grpHouseOptions.Controls.Add(Me.grpFloor)
        Me.grpHouseOptions.Controls.Add(Me.grpExterior)
        Me.grpHouseOptions.Controls.Add(Me.grpBathrooms)
        Me.grpHouseOptions.Controls.Add(Me.grpGarage)
        Me.grpHouseOptions.Controls.Add(Me.grpOtherOptions)
        Me.grpHouseOptions.Controls.Add(Me.grpBedrooms)
        Me.grpHouseOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHouseOptions.Location = New System.Drawing.Point(446, 51)
        Me.grpHouseOptions.Name = "grpHouseOptions"
        Me.grpHouseOptions.Size = New System.Drawing.Size(727, 405)
        Me.grpHouseOptions.TabIndex = 2
        Me.grpHouseOptions.TabStop = False
        Me.grpHouseOptions.Text = "House Options: "
        '
        'grpFloor
        '
        Me.grpFloor.Controls.Add(Me.radHardwood)
        Me.grpFloor.Controls.Add(Me.radCarpeting)
        Me.grpFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpFloor, "Select an option for flooring throughout the home.  You must select one of the pr" &
        "esented options.")
        Me.grpFloor.Location = New System.Drawing.Point(16, 325)
        Me.grpFloor.Name = "grpFloor"
        Me.HelpProvider.SetShowHelp(Me.grpFloor, True)
        Me.grpFloor.Size = New System.Drawing.Size(705, 64)
        Me.grpFloor.TabIndex = 8
        Me.grpFloor.TabStop = False
        Me.grpFloor.Text = "Floor: "
        '
        'radHardwood
        '
        Me.radHardwood.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radHardwood, "Select an option for flooring throughout the home.  You must select one of the pr" &
        "esented options.")
        Me.radHardwood.Location = New System.Drawing.Point(378, 28)
        Me.radHardwood.Name = "radHardwood"
        Me.HelpProvider.SetShowHelp(Me.radHardwood, True)
        Me.radHardwood.Size = New System.Drawing.Size(233, 24)
        Me.radHardwood.TabIndex = 8
        Me.radHardwood.TabStop = True
        Me.radHardwood.Text = "Hardwood Floors ($40,000)"
        Me.radHardwood.UseVisualStyleBackColor = True
        '
        'radCarpeting
        '
        Me.radCarpeting.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radCarpeting, "Select an option for flooring throughout the home.  You must select one of the pr" &
        "esented options.")
        Me.radCarpeting.Location = New System.Drawing.Point(25, 28)
        Me.radCarpeting.Name = "radCarpeting"
        Me.HelpProvider.SetShowHelp(Me.radCarpeting, True)
        Me.radCarpeting.Size = New System.Drawing.Size(274, 24)
        Me.radCarpeting.TabIndex = 8
        Me.radCarpeting.TabStop = True
        Me.radCarpeting.Text = "Wall-to-Wall Carpeting ($30,000)"
        Me.radCarpeting.UseVisualStyleBackColor = True
        '
        'grpExterior
        '
        Me.grpExterior.Controls.Add(Me.radStone)
        Me.grpExterior.Controls.Add(Me.radStucco)
        Me.grpExterior.Controls.Add(Me.radBrick)
        Me.grpExterior.Controls.Add(Me.radSiding)
        Me.grpExterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpExterior, "Select an option for the home's exterior.  You must choose one of the presented o" &
        "ptions.")
        Me.grpExterior.Location = New System.Drawing.Point(16, 165)
        Me.grpExterior.Name = "grpExterior"
        Me.HelpProvider.SetShowHelp(Me.grpExterior, True)
        Me.grpExterior.Size = New System.Drawing.Size(358, 154)
        Me.grpExterior.TabIndex = 7
        Me.grpExterior.TabStop = False
        Me.grpExterior.Text = "Exterior: "
        '
        'radStone
        '
        Me.radStone.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radStone, "Select an option for the home's exterior.  You must choose one of the presented o" &
        "ptions.")
        Me.radStone.Location = New System.Drawing.Point(25, 118)
        Me.radStone.Name = "radStone"
        Me.HelpProvider.SetShowHelp(Me.radStone, True)
        Me.radStone.Size = New System.Drawing.Size(148, 24)
        Me.radStone.TabIndex = 7
        Me.radStone.TabStop = True
        Me.radStone.Text = "Stone ($35,000)"
        Me.radStone.UseVisualStyleBackColor = True
        '
        'radStucco
        '
        Me.radStucco.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radStucco, "Select an option for the home's exterior.  You must choose one of the presented o" &
        "ptions.")
        Me.radStucco.Location = New System.Drawing.Point(25, 88)
        Me.radStucco.Name = "radStucco"
        Me.HelpProvider.SetShowHelp(Me.radStucco, True)
        Me.radStucco.Size = New System.Drawing.Size(157, 24)
        Me.radStucco.TabIndex = 7
        Me.radStucco.TabStop = True
        Me.radStucco.Text = "Stucco ($30,000)"
        Me.radStucco.UseVisualStyleBackColor = True
        '
        'radBrick
        '
        Me.radBrick.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radBrick, "Select an option for the home's exterior.  You must choose one of the presented o" &
        "ptions.")
        Me.radBrick.Location = New System.Drawing.Point(25, 58)
        Me.radBrick.Name = "radBrick"
        Me.HelpProvider.SetShowHelp(Me.radBrick, True)
        Me.radBrick.Size = New System.Drawing.Size(144, 24)
        Me.radBrick.TabIndex = 7
        Me.radBrick.TabStop = True
        Me.radBrick.Text = "Brick ($40,000)"
        Me.radBrick.UseVisualStyleBackColor = True
        '
        'radSiding
        '
        Me.radSiding.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radSiding, "Select an option for the home's exterior.  You must choose one of the presented o" &
        "ptions.")
        Me.radSiding.Location = New System.Drawing.Point(25, 28)
        Me.radSiding.Name = "radSiding"
        Me.HelpProvider.SetShowHelp(Me.radSiding, True)
        Me.radSiding.Size = New System.Drawing.Size(151, 24)
        Me.radSiding.TabIndex = 7
        Me.radSiding.TabStop = True
        Me.radSiding.Text = "Siding ($20,000)"
        Me.radSiding.UseVisualStyleBackColor = True
        '
        'grpBathrooms
        '
        Me.grpBathrooms.Controls.Add(Me.rad4Bathrooms)
        Me.grpBathrooms.Controls.Add(Me.rad3Bathrooms)
        Me.grpBathrooms.Controls.Add(Me.rad2Bathrooms)
        Me.grpBathrooms.Controls.Add(Me.rad1Bathroom)
        Me.grpBathrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpBathrooms, "Choose the number of bathrooms you would like in the custom home.  You must choos" &
        "e one of the presented options.")
        Me.grpBathrooms.Location = New System.Drawing.Point(16, 95)
        Me.grpBathrooms.Name = "grpBathrooms"
        Me.HelpProvider.SetShowHelp(Me.grpBathrooms, True)
        Me.grpBathrooms.Size = New System.Drawing.Size(358, 64)
        Me.grpBathrooms.TabIndex = 6
        Me.grpBathrooms.TabStop = False
        Me.grpBathrooms.Text = "Number of Bathrooms ($3,000 each): "
        '
        'rad4Bathrooms
        '
        Me.rad4Bathrooms.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad4Bathrooms, "Choose the number of bathrooms you would like in the custom home.  You must choos" &
        "e one of the presented options.")
        Me.rad4Bathrooms.Location = New System.Drawing.Point(275, 28)
        Me.rad4Bathrooms.Name = "rad4Bathrooms"
        Me.HelpProvider.SetShowHelp(Me.rad4Bathrooms, True)
        Me.rad4Bathrooms.Size = New System.Drawing.Size(64, 24)
        Me.rad4Bathrooms.TabIndex = 6
        Me.rad4Bathrooms.TabStop = True
        Me.rad4Bathrooms.Text = "Four"
        Me.rad4Bathrooms.UseVisualStyleBackColor = True
        '
        'rad3Bathrooms
        '
        Me.rad3Bathrooms.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad3Bathrooms, "Choose the number of bathrooms you would like in the custom home.  You must choos" &
        "e one of the presented options.")
        Me.rad3Bathrooms.Location = New System.Drawing.Point(186, 28)
        Me.rad3Bathrooms.Name = "rad3Bathrooms"
        Me.HelpProvider.SetShowHelp(Me.rad3Bathrooms, True)
        Me.rad3Bathrooms.Size = New System.Drawing.Size(73, 24)
        Me.rad3Bathrooms.TabIndex = 6
        Me.rad3Bathrooms.TabStop = True
        Me.rad3Bathrooms.Text = "Three"
        Me.rad3Bathrooms.UseVisualStyleBackColor = True
        '
        'rad2Bathrooms
        '
        Me.rad2Bathrooms.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad2Bathrooms, "Choose the number of bathrooms you would like in the custom home.  You must choos" &
        "e one of the presented options.")
        Me.rad2Bathrooms.Location = New System.Drawing.Point(105, 28)
        Me.rad2Bathrooms.Name = "rad2Bathrooms"
        Me.HelpProvider.SetShowHelp(Me.rad2Bathrooms, True)
        Me.rad2Bathrooms.Size = New System.Drawing.Size(61, 24)
        Me.rad2Bathrooms.TabIndex = 6
        Me.rad2Bathrooms.TabStop = True
        Me.rad2Bathrooms.Text = "Two"
        Me.rad2Bathrooms.UseVisualStyleBackColor = True
        '
        'rad1Bathroom
        '
        Me.rad1Bathroom.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad1Bathroom, "Choose the number of bathrooms you would like in the custom home.  You must choos" &
        "e one of the presented options.")
        Me.rad1Bathroom.Location = New System.Drawing.Point(25, 28)
        Me.rad1Bathroom.Name = "rad1Bathroom"
        Me.HelpProvider.SetShowHelp(Me.rad1Bathroom, True)
        Me.rad1Bathroom.Size = New System.Drawing.Size(61, 24)
        Me.rad1Bathroom.TabIndex = 6
        Me.rad1Bathroom.TabStop = True
        Me.rad1Bathroom.Text = "One"
        Me.rad1Bathroom.UseVisualStyleBackColor = True
        '
        'grpGarage
        '
        Me.grpGarage.Controls.Add(Me.radAttached)
        Me.grpGarage.Controls.Add(Me.rad2Car)
        Me.grpGarage.Controls.Add(Me.rad1Car)
        Me.grpGarage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpGarage, "Select an option for the type of garage with the home.  You must choose one of th" &
        "e presented options.")
        Me.grpGarage.Location = New System.Drawing.Point(380, 183)
        Me.grpGarage.Name = "grpGarage"
        Me.HelpProvider.SetShowHelp(Me.grpGarage, True)
        Me.grpGarage.Size = New System.Drawing.Size(341, 136)
        Me.grpGarage.TabIndex = 9
        Me.grpGarage.TabStop = False
        Me.grpGarage.Text = "Car Garage: "
        '
        'radAttached
        '
        Me.radAttached.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.radAttached, "Select an option for the type of garage with the home.  You must choose one of th" &
        "e presented options.")
        Me.radAttached.Location = New System.Drawing.Point(25, 94)
        Me.radAttached.Name = "radAttached"
        Me.HelpProvider.SetShowHelp(Me.radAttached, True)
        Me.radAttached.Size = New System.Drawing.Size(222, 24)
        Me.radAttached.TabIndex = 9
        Me.radAttached.TabStop = True
        Me.radAttached.Text = "Attached Garage ($1,000)"
        Me.radAttached.UseVisualStyleBackColor = True
        '
        'rad2Car
        '
        Me.rad2Car.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad2Car, "Select an option for the type of garage with the home.  You must choose one of th" &
        "e presented options.")
        Me.rad2Car.Location = New System.Drawing.Point(25, 64)
        Me.rad2Car.Name = "rad2Car"
        Me.HelpProvider.SetShowHelp(Me.rad2Car, True)
        Me.rad2Car.Size = New System.Drawing.Size(229, 24)
        Me.rad2Car.TabIndex = 9
        Me.rad2Car.TabStop = True
        Me.rad2Car.Text = "Two-Car Garage ($12,000)"
        Me.rad2Car.UseVisualStyleBackColor = True
        '
        'rad1Car
        '
        Me.rad1Car.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad1Car, "Select an option for the type of garage with the home.  You must choose one of th" &
        "e presented options.")
        Me.rad1Car.Location = New System.Drawing.Point(25, 34)
        Me.rad1Car.Name = "rad1Car"
        Me.HelpProvider.SetShowHelp(Me.rad1Car, True)
        Me.rad1Car.Size = New System.Drawing.Size(238, 24)
        Me.rad1Car.TabIndex = 9
        Me.rad1Car.Text = "One-Car Garage (Standard)"
        Me.rad1Car.UseVisualStyleBackColor = True
        '
        'grpOtherOptions
        '
        Me.grpOtherOptions.Controls.Add(Me.chkKitchen)
        Me.grpOtherOptions.Controls.Add(Me.chkFireplace)
        Me.grpOtherOptions.Controls.Add(Me.chkAirConditioning)
        Me.grpOtherOptions.Controls.Add(Me.chkBasement)
        Me.grpOtherOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpOtherOptions, "Presented in this section are other optional additions to the custom home.  Check" &
        " any of these as wanted.")
        Me.grpOtherOptions.Location = New System.Drawing.Point(380, 25)
        Me.grpOtherOptions.Name = "grpOtherOptions"
        Me.HelpProvider.SetShowHelp(Me.grpOtherOptions, True)
        Me.grpOtherOptions.Size = New System.Drawing.Size(341, 152)
        Me.grpOtherOptions.TabIndex = 10
        Me.grpOtherOptions.TabStop = False
        Me.grpOtherOptions.Tag = "0"
        '
        'chkKitchen
        '
        Me.chkKitchen.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.chkKitchen, "Presented in this section are other optional additions to the custom home.  Check" &
        " any of these as wanted.")
        Me.chkKitchen.Location = New System.Drawing.Point(17, 115)
        Me.chkKitchen.Name = "chkKitchen"
        Me.HelpProvider.SetShowHelp(Me.chkKitchen, True)
        Me.chkKitchen.Size = New System.Drawing.Size(232, 24)
        Me.chkKitchen.TabIndex = 13
        Me.chkKitchen.Text = "Gourmet Kitchen ($20,000)"
        Me.chkKitchen.UseVisualStyleBackColor = True
        '
        'chkFireplace
        '
        Me.chkFireplace.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.chkFireplace, "Presented in this section are other optional additions to the custom home.  Check" &
        " any of these as wanted.")
        Me.chkFireplace.Location = New System.Drawing.Point(17, 85)
        Me.chkFireplace.Name = "chkFireplace"
        Me.HelpProvider.SetShowHelp(Me.chkFireplace, True)
        Me.chkFireplace.Size = New System.Drawing.Size(166, 24)
        Me.chkFireplace.TabIndex = 12
        Me.chkFireplace.Text = "Fireplace ($1,500)"
        Me.chkFireplace.UseVisualStyleBackColor = True
        '
        'chkAirConditioning
        '
        Me.chkAirConditioning.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.chkAirConditioning, "Presented in this section are other optional additions to the custom home.  Check" &
        " any of these as wanted.")
        Me.chkAirConditioning.Location = New System.Drawing.Point(17, 55)
        Me.chkAirConditioning.Name = "chkAirConditioning"
        Me.HelpProvider.SetShowHelp(Me.chkAirConditioning, True)
        Me.chkAirConditioning.Size = New System.Drawing.Size(283, 24)
        Me.chkAirConditioning.TabIndex = 11
        Me.chkAirConditioning.Text = "Central Air Conditioning ($10,000)"
        Me.chkAirConditioning.UseVisualStyleBackColor = True
        '
        'chkBasement
        '
        Me.chkBasement.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.chkBasement, "Presented in this section are other optional additions to the custom home.  Check" &
        " any of these as wanted.")
        Me.chkBasement.Location = New System.Drawing.Point(17, 25)
        Me.chkBasement.Name = "chkBasement"
        Me.HelpProvider.SetShowHelp(Me.chkBasement, True)
        Me.chkBasement.Size = New System.Drawing.Size(264, 24)
        Me.chkBasement.TabIndex = 10
        Me.chkBasement.Text = "12 Course Basement ($15,000)"
        Me.chkBasement.UseVisualStyleBackColor = True
        '
        'grpBedrooms
        '
        Me.grpBedrooms.Controls.Add(Me.rad4Bedrooms)
        Me.grpBedrooms.Controls.Add(Me.rad3Bedrooms)
        Me.grpBedrooms.Controls.Add(Me.rad2Bedrooms)
        Me.grpBedrooms.Controls.Add(Me.rad1Bedroom)
        Me.grpBedrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpBedrooms, "Choose the number of bedrooms you would like in the custom home.  You must choose" &
        " one of the presented options.")
        Me.grpBedrooms.Location = New System.Drawing.Point(16, 25)
        Me.grpBedrooms.Name = "grpBedrooms"
        Me.HelpProvider.SetShowHelp(Me.grpBedrooms, True)
        Me.grpBedrooms.Size = New System.Drawing.Size(358, 64)
        Me.grpBedrooms.TabIndex = 5
        Me.grpBedrooms.TabStop = False
        Me.grpBedrooms.Text = "Number of Bedrooms ($5,000 each): "
        '
        'rad4Bedrooms
        '
        Me.rad4Bedrooms.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad4Bedrooms, "Choose the number of bedrooms you would like in the custom home.  You must choose" &
        " one of the presented options.")
        Me.rad4Bedrooms.Location = New System.Drawing.Point(275, 28)
        Me.rad4Bedrooms.Name = "rad4Bedrooms"
        Me.HelpProvider.SetShowHelp(Me.rad4Bedrooms, True)
        Me.rad4Bedrooms.Size = New System.Drawing.Size(64, 24)
        Me.rad4Bedrooms.TabIndex = 5
        Me.rad4Bedrooms.TabStop = True
        Me.rad4Bedrooms.Text = "Four"
        Me.rad4Bedrooms.UseVisualStyleBackColor = True
        '
        'rad3Bedrooms
        '
        Me.rad3Bedrooms.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad3Bedrooms, "Choose the number of bedrooms you would like in the custom home.  You must choose" &
        " one of the presented options.")
        Me.rad3Bedrooms.Location = New System.Drawing.Point(186, 28)
        Me.rad3Bedrooms.Name = "rad3Bedrooms"
        Me.HelpProvider.SetShowHelp(Me.rad3Bedrooms, True)
        Me.rad3Bedrooms.Size = New System.Drawing.Size(73, 24)
        Me.rad3Bedrooms.TabIndex = 5
        Me.rad3Bedrooms.TabStop = True
        Me.rad3Bedrooms.Text = "Three"
        Me.rad3Bedrooms.UseVisualStyleBackColor = True
        '
        'rad2Bedrooms
        '
        Me.rad2Bedrooms.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad2Bedrooms, "Choose the number of bedrooms you would like in the custom home.  You must choose" &
        " one of the presented options.")
        Me.rad2Bedrooms.Location = New System.Drawing.Point(105, 28)
        Me.rad2Bedrooms.Name = "rad2Bedrooms"
        Me.HelpProvider.SetShowHelp(Me.rad2Bedrooms, True)
        Me.rad2Bedrooms.Size = New System.Drawing.Size(61, 24)
        Me.rad2Bedrooms.TabIndex = 5
        Me.rad2Bedrooms.TabStop = True
        Me.rad2Bedrooms.Text = "Two"
        Me.rad2Bedrooms.UseVisualStyleBackColor = True
        '
        'rad1Bedroom
        '
        Me.rad1Bedroom.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.rad1Bedroom, "Choose the number of bedrooms you would like in the custom home.  You must choose" &
        " one of the presented options.")
        Me.rad1Bedroom.Location = New System.Drawing.Point(25, 28)
        Me.rad1Bedroom.Name = "rad1Bedroom"
        Me.HelpProvider.SetShowHelp(Me.rad1Bedroom, True)
        Me.rad1Bedroom.Size = New System.Drawing.Size(61, 24)
        Me.rad1Bedroom.TabIndex = 5
        Me.rad1Bedroom.TabStop = True
        Me.rad1Bedroom.Text = "One"
        Me.rad1Bedroom.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.txtSummary)
        Me.grpSummary.Controls.Add(Me.txtFinalPrice)
        Me.grpSummary.Controls.Add(Me.lblFinalPrice)
        Me.grpSummary.Enabled = False
        Me.grpSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.grpSummary, "Displays a summary of your selections and the final price of the custom home")
        Me.grpSummary.Location = New System.Drawing.Point(10, 244)
        Me.grpSummary.Name = "grpSummary"
        Me.HelpProvider.SetShowHelp(Me.grpSummary, True)
        Me.grpSummary.Size = New System.Drawing.Size(422, 285)
        Me.grpSummary.TabIndex = 0
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary: "
        '
        'txtSummary
        '
        Me.txtSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.txtSummary, "Displays a summary of your selections and the final price of the custom home")
        Me.txtSummary.Location = New System.Drawing.Point(6, 24)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider.SetShowHelp(Me.txtSummary, True)
        Me.txtSummary.Size = New System.Drawing.Size(410, 219)
        Me.txtSummary.TabIndex = 6
        '
        'txtFinalPrice
        '
        Me.txtFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.txtFinalPrice, "Displays a summary of your selections and the final price of the custom home")
        Me.txtFinalPrice.Location = New System.Drawing.Point(120, 249)
        Me.txtFinalPrice.Name = "txtFinalPrice"
        Me.txtFinalPrice.ReadOnly = True
        Me.HelpProvider.SetShowHelp(Me.txtFinalPrice, True)
        Me.txtFinalPrice.Size = New System.Drawing.Size(296, 26)
        Me.txtFinalPrice.TabIndex = 5
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.lblFinalPrice, "Displays a summary of your selections and the final price of the custom home")
        Me.lblFinalPrice.Location = New System.Drawing.Point(9, 252)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.HelpProvider.SetShowHelp(Me.lblFinalPrice, True)
        Me.lblFinalPrice.Size = New System.Drawing.Size(99, 20)
        Me.lblFinalPrice.TabIndex = 4
        Me.lblFinalPrice.Text = "Final Price: "
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnCalculate, "Calculates the final price of the home and displays it, along with a review of th" &
        "e user's selections, in the Summary area.")
        Me.btnCalculate.Location = New System.Drawing.Point(446, 462)
        Me.btnCalculate.Name = "btnCalculate"
        Me.HelpProvider.SetShowHelp(Me.btnCalculate, True)
        Me.btnCalculate.Size = New System.Drawing.Size(258, 67)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnSave, "Saves the chosen options and the home's final price to a text file")
        Me.btnSave.Location = New System.Drawing.Point(710, 462)
        Me.btnSave.Name = "btnSave"
        Me.HelpProvider.SetShowHelp(Me.btnSave, True)
        Me.btnSave.Size = New System.Drawing.Size(193, 67)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnClear, "Clears all entered text and chosen selections on the form")
        Me.btnClear.Location = New System.Drawing.Point(909, 462)
        Me.btnClear.Name = "btnClear"
        Me.HelpProvider.SetShowHelp(Me.btnClear, True)
        Me.btnClear.Size = New System.Drawing.Size(129, 67)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnExit, "Exits the application")
        Me.btnExit.Location = New System.Drawing.Point(1044, 462)
        Me.btnExit.Name = "btnExit"
        Me.HelpProvider.SetShowHelp(Me.btnExit, True)
        Me.btnExit.Size = New System.Drawing.Size(129, 67)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pic2
        '
        Me.pic2.Image = Global.Custom_Home_System.My.Resources.Resources.home2
        Me.pic2.Location = New System.Drawing.Point(1179, 274)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(481, 283)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 5
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.Custom_Home_System.My.Resources.Resources.home
        Me.pic1.Location = New System.Drawing.Point(1179, -2)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(481, 283)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 4
        Me.pic1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1658, 544)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpHouseOptions)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.HelpProvider.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Home Planning System"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.grpHouseOptions.ResumeLayout(False)
        Me.grpFloor.ResumeLayout(False)
        Me.grpFloor.PerformLayout()
        Me.grpExterior.ResumeLayout(False)
        Me.grpExterior.PerformLayout()
        Me.grpBathrooms.ResumeLayout(False)
        Me.grpBathrooms.PerformLayout()
        Me.grpGarage.ResumeLayout(False)
        Me.grpGarage.PerformLayout()
        Me.grpOtherOptions.ResumeLayout(False)
        Me.grpOtherOptions.PerformLayout()
        Me.grpBedrooms.ResumeLayout(False)
        Me.grpBedrooms.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpPersonalInfo As GroupBox
    Friend WithEvents lblSquareFootage As Label
    Friend WithEvents txtSquareFootage As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents grpHouseOptions As GroupBox
    Friend WithEvents grpExterior As GroupBox
    Friend WithEvents radStone As RadioButton
    Friend WithEvents radStucco As RadioButton
    Friend WithEvents radBrick As RadioButton
    Friend WithEvents radSiding As RadioButton
    Friend WithEvents grpBathrooms As GroupBox
    Friend WithEvents rad4Bathrooms As RadioButton
    Friend WithEvents rad3Bathrooms As RadioButton
    Friend WithEvents rad2Bathrooms As RadioButton
    Friend WithEvents rad1Bathroom As RadioButton
    Friend WithEvents grpGarage As GroupBox
    Friend WithEvents radAttached As RadioButton
    Friend WithEvents rad2Car As RadioButton
    Friend WithEvents rad1Car As RadioButton
    Friend WithEvents grpOtherOptions As GroupBox
    Friend WithEvents chkKitchen As CheckBox
    Friend WithEvents chkFireplace As CheckBox
    Friend WithEvents chkAirConditioning As CheckBox
    Friend WithEvents chkBasement As CheckBox
    Friend WithEvents grpBedrooms As GroupBox
    Friend WithEvents rad4Bedrooms As RadioButton
    Friend WithEvents rad3Bedrooms As RadioButton
    Friend WithEvents rad2Bedrooms As RadioButton
    Friend WithEvents rad1Bedroom As RadioButton
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtFinalPrice As TextBox
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents grpFloor As GroupBox
    Friend WithEvents radHardwood As RadioButton
    Friend WithEvents radCarpeting As RadioButton
    Friend WithEvents HelpProvider As HelpProvider
    Friend WithEvents txtSummary As TextBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
End Class
