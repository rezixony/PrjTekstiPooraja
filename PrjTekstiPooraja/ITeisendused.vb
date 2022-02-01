Public Interface ITeisendused

    Property intAlgus As Integer 'teksti esimese sumboli ASCII kodi jaoks
    Property intLopp As Integer  'teksti viimase sumboli ASCII kodi jaoks
    Property strTekst As String 'kasutaja sisestatud teksti jaoks

    Function pooraTekst() As String 'liidese meetodid kodi ei oma
    Sub teisendaTekst(ByRef strSisendTekst As String)

End Interface
