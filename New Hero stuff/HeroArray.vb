Module HeroArray
    Dim HeroQuotes As ArrayList = New ArrayList()
    Dim Thor As Hero = New Hero("Thor", "Touch my hammer.", "Lightning Bolt", "Hammer Throw", "Thunder Punch", "Hammer Storm", "Storm Breaker", "Miss")
    Dim Hulk As Hero = New Hero("Hulk", "HULK SMASH!", "Smash", "Smash Wave", "Ground Smash", "Double Smash", "Raging Smash", "Miss")
    Dim CaptainAmerica = New Hero("CaptainAmerican", "Language!", "Shield Bash", "Shield Slam", "Shield Toss", "Patriot Punch", "Star Spangled Slammer", "Miss")
    Dim Hawkeye As Hero = New Hero("Hawkeye", "Nobody would know.", "Trap Shot", "Full draw", "Triple Shot", "Quick shot", "Nuclear Arrow", "Miss")

    Sub Quote()

        Dim HQ = HeroQuotes

        Dim Thor = "Touch my hammer."
        Dim Hulk = "HULK SMASH!"
        Dim CaptainAmerica = "Language!"
        Dim BlackWidow = "I have special skills acquired over a long and lustrious "
        Dim Hawkeye = "Nobody would know."
        Dim IronMan = "Cap and I are very close."
        HQ.Add(Thor)
        HQ.Add(Hulk)
        HQ.Add(CaptainAmerica)
        HQ.Add(BlackWidow)
        HQ.Add(Hawkeye)
        HQ.Add(IronMan)
    End Sub

    ReadOnly HeroMoves As ArrayList = New ArrayList()
    Sub Moves()
        Randomize()
        Dim generate As New Random
        Dim move = generate.Next(0, 5)
        HeroMoves.Add(Thor.M1)
        HeroMoves.Add(Thor.M2)
        HeroMoves.Add(Thor.M3)
        HeroMoves.Add(Thor.M4)
        HeroMoves.Add(Thor.Power)
        HeroMoves.Add(Thor.Miss)

        Dim result = HeroMoves.Item(move)

        Select Case result
            Case Thor.M1


        End Select

    End Sub


    Sub Moves(Hulk)
        Randomize()
        Dim generate As New Random
        Dim move = generate.Next(0, 5)
        HeroMoves.Add(Hulk)
        HeroMoves.Add(Hulk)
        HeroMoves.Add(Hulk)
        HeroMoves.Add(Hulk)
        HeroMoves.Add(Hulk)
        HeroMoves.Add(Hulk)




    End Sub




End Module
