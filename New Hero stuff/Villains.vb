Class Villains
    Dim Villains As ArrayList = New ArrayList()
    Private _Name As String
    Private _Quote As String
    Private _Move As String
    Private _Status As String
    Private _DMG As Interger

    Sub Venom()
        Dim name = "Venom"
        _Name = name

        Dim quote As ArrayList = New ArrayList()
        quote = ("Venom wants to play!", "You are mine!", "Can you think of a better place --- to die!", "The liver? Good choice! We'll have it first! With a nice Chianti...")
        _Quote = quote

        Dim rn As New Random

        Dim move As String
        Dim dmg As Interger
        Dim status As String
        Dim attackoption = rn.Next(0, 4)

        Select Case attackoption

            Case 0
                move = "Bite"
                _Move = move
                dmg = 30
                _DMG = dmg

            Case 1
                move = "Tendril latch"
                _Move = move
                dmg = 15
                status = "Grapple"
                _DMG = dmg
                _Status = status

            Case 2
                move = "Slash"
                _Move = move
                dmg = 25
                _DMG = dmg

            Case 3
                move = "Slam"
                _Move = move
                dmg = 35
                _DMG = dmg

            Case 4
                move = "Symbiotic Power Attack"
                _Move = move
                Dim rdmdmg As New Random
                dmg = rdmdmg.next(25, 50)
                _DMG = dmg

        End Select

    End Sub
End Class
