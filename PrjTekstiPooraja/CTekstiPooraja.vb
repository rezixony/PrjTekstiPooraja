Public Class CTekstiPooraja
    Implements ITeisendused

    'Klassi CTekstiPooraja atribuudid(muutujad)
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String

    'Liidese omaduste (atribuude) seadistamine
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol 'atribuudi kusimisel tagasta intAlgusSymbol
        End Get
        Set(ByVal value As Integer)
            intAlgusSymbol = value 'atribuudi vaartuse seadistamine
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol 'atribuudi kusimisel tagasta intLoppSymbol
        End Get
        Set(ByVal value As Integer)
            intLoppSymbol = value 'atribuudi vaartuse seadistamine
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst 'atribuudi kusimisel tagasta strPooratavTekst
        End Get
        Set(ByVal value As String)
            strPooratavTekst = value 'atribuudi vaartuse seadistamine
        End Set
    End Property

    'Meetod (Protseduur), mis poorab tagurpidi sisendparametrina strSisendTekst antud avaldise ja salvestab vaartuse atribuuti strPooratavTekst
    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    'Meetod (Funktsioon), mis votab atribuudist strSisendTekst vaartuse ja poorab selle stringi tagurpidi
    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Return StrReverse(strPooratavTekst)
    End Function
End Class
