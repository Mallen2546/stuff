﻿Class Villains
    Dim Villains As ArrayList = New ArrayList()
    Private _Name As String
    Private _Quote As String
    Private _Move As String
    Private _Status As String
    Private _HP As Integer
    Private _DMG As Integer

    Sub Venom(Lvl As Integer)
        Dim name = "Venom"
        _Name = name

        Dim quote() As String
        Dim Rdmquote As Random = New Random
        quote = {"Venom wants to play!", "You are mine!", "Can you think of a better place --- to die!", "The liver? Good choice! We'll have it first! With a nice Chianti..."}
        _Quote = quote(Rdmquote.Next(0, 4))


        Dim rn As Random = New Random

        Dim move As String
        Dim dmg As Integer
        Dim status As String
        Dim attack = rn.Next(0, 5)

        Select Case attack

            Case 0
                move = "Bite"
                _Move = move
                dmg = 30 * Lvl
                _DMG = dmg

            Case 1
                move = "Tendril latch"
                _Move = move
                dmg = 15 * Lvl
                status = "Grapple"
                _DMG = dmg
                _Status = status

            Case 2
                move = "Slash"
                _Move = move
                dmg = 25 * Lvl
                _DMG = dmg

            Case 3
                move = "Slam"
                _Move = move
                dmg = 35 * Lvl
                _DMG = dmg

            Case 4
                move = "Symbiotic Power Attack"
                _Move = move
                Dim rdmdmg As Random = New Random
                dmg = (rdmdmg.next(25, 50) * Lvl)
                _DMG = dmg

            Case 5
                move = "Miss"
                _Move = move

        End Select

    End Sub
End Class
