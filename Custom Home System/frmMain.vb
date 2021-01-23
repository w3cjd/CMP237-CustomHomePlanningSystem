Public Class frmMain
    Private blnHelpEnabled As Boolean = False
    ' Exits The Application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
    ' Clears The Form
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text boxes
        txtFirstName.Clear()
        txtLastName.Clear()
        txtCity.Clear()
        txtSquareFootage.Clear()
        txtFinalPrice.Clear()
        ' Clear Summary ListBox
        txtSummary.Clear()
        ' Clear Number of Bedrooms
        rad1Bedroom.Checked = False
        rad2Bedrooms.Checked = False
        rad3Bedrooms.Checked = False
        rad4Bedrooms.Checked = False
        ' Clear Number of Bathrooms
        rad1Bathroom.Checked = False
        rad2Bathrooms.Checked = False
        rad3Bathrooms.Checked = False
        rad4Bathrooms.Checked = False
        ' Clear Exterior
        radSiding.Checked = False
        radBrick.Checked = False
        radStucco.Checked = False
        radStone.Checked = False
        ' Clear Floor
        radCarpeting.Checked = False
        radHardwood.Checked = False
        ' Clear Garage
        rad1Car.Checked = False
        rad2Car.Checked = False
        radAttached.Checked = False
        ' Clear Other Options
        chkAirConditioning.Checked = False
        chkBasement.Checked = False
        chkFireplace.Checked = False
        chkKitchen.Checked = False
        ' Disable Save Button & Summary
        btnSave.Enabled = False
        grpSummary.Enabled = False
    End Sub
    ' Calculates the final home price and displays it along with the summary
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare Variables & Enable Summary Group
        Dim intSquareFootage As Integer, intHomePrice As Int64 = 100000, strSummary = ""
        grpSummary.Enabled = True
        ' Validate that the user entered stuff in the text boxes
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtCity.Text = "" Or txtSquareFootage.Text = "" Then
            MsgBox("Please fill out all text fields!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        End If
        ' Validate that the square footage is numeric and greater than zero
        If Not IsNumeric(txtSquareFootage.Text) Then
            MsgBox("Please enter a numeric square footage!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        Else
            Try
                intSquareFootage = CInt(txtSquareFootage.Text)
            Catch ex As System.OverflowException
                MsgBox("Please enter a smaller amount of square feet!", MsgBoxStyle.Critical, "Custom Home Planning System")
            End Try
            If intSquareFootage <= 0 Then
                MsgBox("You must enter a positive number of square feet!", MsgBoxStyle.Critical, "Custom Home Planning System")
                Exit Sub
            End If
        End If
        ' Make Sure That One RadioButton Is Checked In Each Section
        If rad1Bedroom.Checked = False And rad2Bedrooms.Checked = False And rad3Bedrooms.Checked = False And rad4Bedrooms.Checked = False Then
            MsgBox("Please select a number of bedrooms!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        End If
        If rad1Bathroom.Checked = False And rad2Bathrooms.Checked = False And rad3Bathrooms.Checked = False And rad4Bathrooms.Checked = False Then
            MsgBox("Please select a number of bathrooms!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        End If
        If radSiding.Checked = False And radBrick.Checked = False And radStucco.Checked = False And radStone.Checked = False Then
            MsgBox("Please select an option for the home exterior!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        End If
        If radCarpeting.Checked = False And radHardwood.Checked = False Then
            MsgBox("Please select an option for flooring!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        End If
        If rad1Car.Checked = False And rad2Car.Checked = False And radAttached.Checked = False Then
            MsgBox("Please select an option for the garage!", MsgBoxStyle.Critical, "Custom Home Planning System")
            Exit Sub
        End If
        ' Calculate The Price Of The Home and Build the Summary String
        strSummary = "CUSTOMER INFORMATION: " + vbCrLf + txtFirstName.Text + " " + txtLastName.Text
        strSummary += vbCrLf + "City: " + txtCity.Text
        strSummary += vbCrLf + vbCrLf + "HOME INFORMATION: " + vbCrLf
        Dim intSquareFootCost = intSquareFootage * 50
        strSummary += "Square Footage: " + intSquareFootage.ToString("N0") + " - " + intSquareFootCost.ToString("C0")
        intHomePrice += intSquareFootCost
        ' Bedrooms
        strSummary += vbCrLf
        If rad1Bedroom.Checked Then
            strSummary += "1 Bedroom - $5,000"
            intHomePrice += 5000
        ElseIf rad2Bedrooms.Checked Then
            strSummary += "2 Bedrooms - $10,000"
            intHomePrice += 10000
        ElseIf rad3Bedrooms.Checked Then
            strSummary += "3 Bedrooms - $15,000"
            intHomePrice += 15000
        Else
            strSummary += "4 Bedrooms - $20,000"
            intHomePrice += 20000
        End If
        ' Bathrooms
        strSummary += vbCrLf
        If rad1Bathroom.Checked Then
            strSummary += "1 Bathroom - $3,000"
            intHomePrice += 3000
        ElseIf rad2Bathrooms.Checked Then
            strSummary += "2 Bathrooms - $6,000"
            intHomePrice += 6000
        ElseIf rad3Bathrooms.Checked Then
            strSummary += "3 Bathrooms - $9,000"
            intHomePrice += 9000
        Else
            strSummary += "4 Bathrooms - $12,000"
            intHomePrice += 12000
        End If
        ' Exterior
        strSummary += vbCrLf
        If radSiding.Checked Then
            strSummary += "Exterior: Siding - $20,000"
            intHomePrice += 20000
        ElseIf radBrick.Checked Then
            strSummary += "Exterior: Brick - $40,000"
            intHomePrice += 40000
        ElseIf radStucco.Checked Then
            strSummary += "Exterior: Stucco - $30,000"
            intHomePrice += 30000
        Else
            strSummary += "Exterior: Stone - $35,000"
            intHomePrice += 35000
        End If
        ' Floor
        strSummary += vbCrLf
        If radCarpeting.Checked Then
            strSummary += "Wall-to-Wall Carpeting - $30,000"
            intHomePrice += 30000
        Else
            strSummary += "Hardwood Floors - $20,000"
            intHomePrice += 20000
        End If
        ' Garage
        strSummary += vbCrLf
        If rad1Car.Checked Then
            strSummary += "One-Car Garage - Standard"
        ElseIf rad2Car.Checked Then
            strSummary += "Two-Car Garage - $12,000"
            intHomePrice += 12000
        Else
            strSummary += "Attached Garage - $1,000"
            intHomePrice += 1000
        End If
        ' Other Options
        strSummary += vbCrLf
        If chkBasement.Checked Then
            strSummary += "12-Course Basement - $15,000" + vbCrLf
            intHomePrice += 15000
        End If
        If chkAirConditioning.Checked Then
            strSummary += "Central Air Conditioning - $10,000" + vbCrLf
            intHomePrice += 10000
        End If
        If chkFireplace.Checked Then
            strSummary += "Fireplace - $1,500" + vbCrLf
            intHomePrice += 1500
        End If
        If chkKitchen.Checked Then
            strSummary += "Gourmet Kitchen - $20,000" + vbCrLf
            intHomePrice += 20000
        End If
        ' Display Final Information
        txtSummary.Text = strSummary
        txtFinalPrice.Text = intHomePrice.ToString("C0")
        ' Enable Save Button
        btnSave.Enabled = True
    End Sub
    ' Delays Form Displaying (for Splash Screen) and Sets Up HelpProvider
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup HelpProvider
        HelpProvider.SetShowHelp(grpPersonalInfo, True)
        HelpProvider.SetHelpString(grpPersonalInfo, "Please enter your information in these text fields.  All text fields are required.  Please enter a numeric square footage that is greater than zero.")
        HelpProvider.SetShowHelp(grpSummary, True)
        HelpProvider.SetHelpString(grpSummary, "Displays a summary of your selections and the final price of the custom home")
        HelpProvider.SetShowHelp(grpBedrooms, True)
        HelpProvider.SetHelpString(grpBedrooms, "Choose the number of bedrooms you would like in the custom home.  You must choose one of the presented options.")
        HelpProvider.SetShowHelp(grpBathrooms, True)
        HelpProvider.SetHelpString(grpBedrooms, "Choose the number of bathrooms you would like in the custom home.  You must choose one of the presented options.")
        HelpProvider.SetShowHelp(grpExterior, True)
        HelpProvider.SetHelpString(grpExterior, "Select an option for the home's exterior.  You must choose one of the presented options.")
        HelpProvider.SetShowHelp(grpFloor, True)
        HelpProvider.SetHelpString(grpFloor, "Select an option for flooring throughout the home.  You must select one of the presented options.")
        HelpProvider.SetShowHelp(grpGarage, True)
        HelpProvider.SetHelpString(grpGarage, "Select an option for the type of garage with the home.  You must choose one of the presented options.")
        HelpProvider.SetShowHelp(grpOtherOptions, True)
        HelpProvider.SetHelpString(grpOtherOptions, "Presented in this section are other optional additions to the custom home.  Check any of these as wanted.")
        HelpProvider.SetShowHelp(btnCalculate, True)
        HelpProvider.SetHelpString(btnCalculate, "Calculates the final price of the home and displays it, along with a review of the user's selections, in the Summary area.")
        HelpProvider.SetShowHelp(btnSave, True)
        HelpProvider.SetHelpString(btnSave, "Saves the chosen options and the home's final price to a text file")
        HelpProvider.SetShowHelp(btnClear, True)
        HelpProvider.SetHelpString(btnClear, "Clears all entered text and chosen selections on the form")
        HelpProvider.SetShowHelp(btnExit, True)
        HelpProvider.SetHelpString(btnExit, "Exits the application")
        ' Pause Form Loading For Splash Screen
        Threading.Thread.Sleep(3000)
    End Sub
    ' Save the selected home options into a text file
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strSummary As String = txtSummary.Text
        strSummary += vbCrLf + "FINAL PRICE: " + txtFinalPrice.Text
        Dim save As New SaveFileDialog()
        save.Filter = "Text Files | *.txt"
        save.Title = "Save Home Options"
        save.ShowDialog()
        If save.FileName <> "" Then
            Dim fileWriter As New IO.StreamWriter(save.FileName)
            fileWriter.WriteLine(strSummary)
            fileWriter.WriteLine("")
            fileWriter.WriteLine("")
            fileWriter.Close()
        End If
    End Sub

    Private Sub radSiding_CheckedChanged(sender As Object, e As EventArgs) Handles radSiding.CheckedChanged

    End Sub
End Class
