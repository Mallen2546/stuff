Module HeroArray
    Dim HeroQuotes As ArrayList = New ArrayList()
    Sub Quote()

        Dim HQ = HeroQuotes

        Dim Thor = "Touch my hammer."
        Dim Hulk = "Omaha smash."
        Dim CaptainAmerica = "Should loan out my shield."
        Dim BlackWidow = "I have special skills acquired over a long and lustrious "
        Dim Hawkeye = "I am a hero too."
        Dim IronMan = "Cap and I are very close."
        HQ.Add(Thor)
        HQ.Add(Hulk)
        HQ.Add(CaptainAmerica)
        HQ.Add(BlackWidow)
        HQ.Add(Hawkeye)
        HQ.Add(IronMan)
    End Sub
End Module
