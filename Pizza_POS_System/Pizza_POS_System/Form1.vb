Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbDineIn.Checked = True

        Me.Width = 889
        Me.Height = 704
    End Sub
    Private Sub btnClearToppings_Click(sender As Object, e As EventArgs) Handles btnClearToppings.Click
        clearToppings()
        clearSummary()
        extraToppings.Clear()
        pizzaDetails.Clear()
    End Sub
    Private Sub clearToppings()
        For Each xObject As Object In gbToppings.Controls
            If TypeOf xObject Is CheckBox Then
                xObject.Checked = False
            End If
        Next
    End Sub
    Private Sub clearSummary()
        tbTotalPizza.Text = "0"
        tbTotalToppings.Text = "0"
        tbTotal.Text = "0"
        tbCash.Text = "0"
        tbChange.Text = "0"
    End Sub

    Dim totalPizza, totalToppings, total As Double
    Dim extraToppings As New List(Of String)
    Dim pizzaDetails As New List(Of String)
    Private Sub btnComputeOrder_Click(sender As Object, e As EventArgs) Handles btnComputeOrder.Click
        totalPizza = 0
        totalToppings = 0
        total = 0

        If cbCheese.Checked Then
            extraToppings.Add("Extra Cheese                                    ₱135")
            totalToppings += 135
        End If
        If cbGarlic.Checked Then
            extraToppings.Add("Garlic                                                ₱40")
            totalToppings += 40
        End If
        If cbPineapple.Checked Then
            extraToppings.Add("Pineapple                                          ₱50")
            totalToppings += 50
        End If
        If cbMashroom.Checked Then
            extraToppings.Add("Mashroom                                         ₱40")
            totalToppings += 40
        End If
        If cbHam.Checked Then
            extraToppings.Add("Ham                                                  ₱75")
            totalToppings += 75
        End If
        If cbBacon.Checked Then
            extraToppings.Add("Bacon                                               ₱135")
            totalToppings += 135
        End If
        If cbOnion.Checked Then
            extraToppings.Add("Onion                                                ₱50")
            totalToppings += 50
        End If

        tbTotalToppings.Text = Convert.ToString(totalToppings)

        ' Pepperoni Pizza
        If pepperoniSolo.Value > 0 Then
            Dim pepperoniSoloTotal = pepperoniSolo.Value * 169
            totalPizza += pepperoniSoloTotal
            pizzaDetails.Add(pepperoniSolo.Value.ToString() & " - Pepperoni(Solo)                          ₱" & pepperoniSoloTotal)
        End If
        If pepperoniReg.Value > 0 Then
            Dim pepperoniRegTotal = pepperoniReg.Value * 219
            totalPizza += pepperoniRegTotal
            pizzaDetails.Add(pepperoniReg.Value.ToString() & " - Pepperoni(Regular)                     ₱" & pepperoniRegTotal)
        End If
        If pepperoniFam.Value > 0 Then
            Dim pepperoniFamTotal = pepperoniFam.Value * 279
            totalPizza += pepperoniFamTotal
            pizzaDetails.Add(pepperoniFam.Value.ToString() & " - Pepperoni(Family)                        ₱" & pepperoniFamTotal)
        End If

        'Hawaiian Style
        If hawaiianSolo.Value > 0 Then
            Dim hawaiianSoloTotal = hawaiianSolo.Value * 169
            totalPizza += hawaiianSoloTotal
            pizzaDetails.Add(hawaiianSolo.Value.ToString() & " - Hawaiian(Solo)                           ₱" & hawaiianSoloTotal)
        End If
        If hawaiianReg.Value > 0 Then
            Dim hawaiianRegTotal = hawaiianReg.Value * 219
            totalPizza += hawaiianRegTotal
            pizzaDetails.Add(hawaiianReg.Value.ToString() & " - Hawaiian(Regular)                      ₱" & hawaiianRegTotal)
        End If
        If hawaiianFam.Value > 0 Then
            Dim hawaiianFamTotal = hawaiianFam.Value * 279
            totalPizza += hawaiianFamTotal
            pizzaDetails.Add(hawaiianFam.Value.ToString() & " - Hawaiian(Family)                         ₱" & hawaiianFamTotal)
        End If

        'Ham & Cheese
        If hamSolo.Value > 0 Then
            Dim hamSoloTotal = hamSolo.Value * 169
            totalPizza += hamSoloTotal
            pizzaDetails.Add(hamSolo.Value.ToString() & " - Ham & Cheese(Solo)                   ₱" & hamSoloTotal)
        End If
        If hamReg.Value > 0 Then
            Dim hamRegTotal = hamReg.Value * 219
            totalPizza += hamRegTotal
            pizzaDetails.Add(hamReg.Value.ToString() & " - Ham & Cheese(Regular)             ₱" & hamRegTotal)
        End If
        If hamFam.Value > 0 Then
            Dim hamFamTotal = hamFam.Value * 279
            totalPizza += hamFamTotal
            pizzaDetails.Add(hamFam.Value.ToString() & " - Ham & Cheese(Family)                 ₱" & hamFamTotal)
        End If

        'Bacon & Mashroom
        If baconSolo.Value > 0 Then
            Dim baconSoloTotal = baconSolo.Value * 169
            totalPizza += baconSoloTotal
            pizzaDetails.Add(baconSolo.Value.ToString() & " -  Bacon & Mashroom(Solo)           ₱" & baconSoloTotal)
        End If
        If baconReg.Value > 0 Then
            Dim baconRegTotal = baconReg.Value * 219
            totalPizza += baconRegTotal
            pizzaDetails.Add(baconReg.Value.ToString() & " -  Bbacon & Mashroom(Regula)    ₱" & baconRegTotal)
        End If
        If baconFam.Value > 0 Then
            Dim baconFamTotal = baconFam.Value * 279
            totalPizza += baconFamTotal
            pizzaDetails.Add(baconFam.Value.ToString() & " -  Bbacon & Mashroom(Family)      ₱" & baconFamTotal)
        End If

        'Cheese Mania
        If cheeseSolo.Value > 0 Then
            Dim cheeseSoloTotal = cheeseSolo.Value * 169
            totalPizza += cheeseSoloTotal
            pizzaDetails.Add(cheeseSolo.Value.ToString() & " -  Cheese Mania(Solo)                   ₱" & cheeseSoloTotal)
        End If
        If cheeseReg.Value > 0 Then
            Dim cheeseRegTotal = cheeseReg.Value * 219
            totalPizza += cheeseRegTotal
            pizzaDetails.Add(cheeseReg.Value.ToString() & " -  Cheese Mania(Regular)             ₱" & cheeseRegTotal)
        End If
        If cheeseFam.Value > 0 Then
            Dim cheeseFamTotal = cheeseFam.Value * 279
            totalPizza += cheeseFamTotal
            pizzaDetails.Add(cheeseFam.Value.ToString() & " - Cheese Mania(Family)                 ₱" & cheeseFamTotal)
        End If

        'Pacific Veggei
        If veggeiSolo.Value > 0 Then
            Dim veggeiSoloTotal = veggeiSolo.Value * 169
            totalPizza += veggeiSoloTotal
            pizzaDetails.Add(veggeiSolo.Value.ToString() & " -  Pacific Veggei(Solo)                  ₱" & veggeiSoloTotal)
        End If
        If veggeiReg.Value > 0 Then
            Dim veggeiRegTotal = veggeiReg.Value * 219
            totalPizza += veggeiRegTotal
            pizzaDetails.Add(veggeiReg.Value.ToString() & " -  Pacific Veggei(Regular)             ₱" & veggeiRegTotal)
        End If
        If veggeiFam.Value > 0 Then
            Dim veggeiFamTotal = veggeiFam.Value * 279
            totalPizza += veggeiFamTotal
            pizzaDetails.Add(veggeiFam.Value.ToString() & " - Pacific Veggei(Family)                 ₱" & veggeiFamTotal)
        End If

        'Italian Style
        If italianSolo.Value > 0 Then
            Dim italianSoloTotal = italianSolo.Value * 169
            totalPizza += italianSoloTotal
            pizzaDetails.Add(italianSolo.Value.ToString() & " -  Italian Style(Solo)                       ₱" & italianSoloTotal)
        End If
        If italianReg.Value > 0 Then
            Dim italianRegTotal = italianReg.Value * 219
            totalPizza += italianRegTotal
            pizzaDetails.Add(italianReg.Value.ToString() & " -  Italian Style(Regular)                  ₱" & italianRegTotal)
        End If
        If italianFam.Value > 0 Then
            Dim italianFamTotal = italianFam.Value * 279
            totalPizza += italianFamTotal
            pizzaDetails.Add(italianFam.Value.ToString() & " - Italian Style(Family)                      ₱" & italianFamTotal)
        End If

        tbTotalPizza.Text = Convert.ToString(totalPizza)

        total = totalPizza + totalToppings
        tbTotal.Text = total
    End Sub
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click

        Dim serviceType As String
        If rbTakeOut.Checked Then
            serviceType = "Take Out"
        End If
        If rbDineIn.Checked Then
            serviceType = "Dine In"
        End If
        If rbDeliver.Checked Then
            serviceType = "Deliver"
        End If

        Dim pizzaText As String = String.Join(vbCrLf & "    ", pizzaDetails)
        Dim extraToppingsText As String = String.Join(vbCrLf & "    ", extraToppings)
        rtbReceipt.Text = "                               (Order Receipt)" & vbCrLf &
                          "   -------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                          "Pizzas Ordered: " & vbCrLf & "    " & pizzaText & vbCrLf & vbCrLf &
                          "Extra Toppings: " & vbCrLf & "    " & extraToppingsText & vbCrLf & vbCrLf &
                          "   -------------------------------------------------------------------------" & vbCrLf &
                          "Total:                                                  ₱" & total & vbCrLf &
                          "   -------------------------------------------------------------------------" & vbCrLf &
                          "Cash:                                                  ₱" & cash & vbCrLf &
                          "Change:                                              ₱" & change & vbCrLf &
                          "   -------------------------------------------------------------------------" & vbCrLf & vbCrLf &
                          "                        Service type:" & serviceType
    End Sub

    Dim cash, change As Double
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        rtbReceipt.Clear()
        clearToppings()
        clearSummary()
        extraToppings.Clear()
        pizzaDetails.Clear()

        pepperoniSolo.Value = 0
        pepperoniReg.Value = 0
        pepperoniFam.Value = 0
        hawaiianSolo.Value = 0
        hawaiianReg.Value = 0
        hawaiianFam.Value = 0
        hamSolo.Value = 0
        hamReg.Value = 0
        hamFam.Value = 0
        baconSolo.Value = 0
        baconReg.Value = 0
        baconFam.Value = 0
        cheeseSolo.Value = 0
        cheeseReg.Value = 0
        cheeseFam.Value = 0
        veggeiSolo.Value = 0
        veggeiReg.Value = 0
        veggeiFam.Value = 0
        italianSolo.Value = 0
        italianReg.Value = 0
        italianFam.Value = 0

    End Sub
    Private Sub btnComputePayment_Click(sender As Object, e As EventArgs) Handles btnComputePayment.Click
        cash = Convert.ToDouble(tbCash.Text)
        change = cash - total
        tbChange.Text = change

        If cash < total Then
            MsgBox("You need to enter a higher Amount", MsgBoxStyle.Exclamation)
        End If
    End Sub

End Class
