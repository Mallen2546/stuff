Class MainWindow
    'Private _Move As String
    'Private _DMG As Integer
    Dim Lvl = 10
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Randomize()
        Dim move = "We Are Legion"
        '_Move = move

        Dim HitorMiss As Random = New Random
        Dim Hit As Integer
        Dim dmg = 0
        Dim inidmg As Integer
        Dim rdmdmg As Random = New Random

        For attacks As Integer = 1 To 5
            Hit = HitorMiss.Next(0, 100)
            If Hit Mod 8 Then
                inidmg = (rdmdmg.Next(10, 20))
                inidmg = inidmg + inidmg * (0.1 * (Lvl - 1))
            Else
                inidmg = 0

            End If

            dmg = dmg + inidmg

        Next
        _DMG = dmg
    End Sub
End Class
