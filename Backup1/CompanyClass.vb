Public Class CompanyClass

    'This class stores all the information of a company.

    Private Name_ As String 'The name of the company.
    Private PayDay_ As String 'Which day of the week payroll is submitted.
    Private FaxNumber_ As String 'The fax number of the company.
    Private MOTD_ As String 'The current message of the day.
    Private PayrollContact_ As String 'The name of the contact at the payroll office
    Private OwnerName_ As String 'The companies owners name
    Private Phone_ As String ' The companies phone number
    Private BreakMinutes_ As Integer = 20 'How many minutes employees are paid for breaks each day.

    'constructor from information
    Public Sub New(ByVal NameNew As String, ByVal PayDayNew As String, ByVal FaxNumberNew As String, ByVal MOTDNew As String, ByVal PayrollContactNew As String, ByVal OwnerNameNew As String, ByVal PhoneNew As String)
        Name_ = NameNew
        PayDay_ = PayDayNew
        FaxNumber_ = FaxNumberNew
        MOTD_ = MOTDNew
        PayrollContact_ = PayrollContactNew
        OwnerName_ = OwnerNameNew
        Phone_ = PhoneNew
    End Sub

    'default constructor
    Public Sub New()
        Name_ = ""
        PayDay_ = ""
        FaxNumber_ = ""
        MOTD_ = ""
        PayrollContact_ = ""
        OwnerName_ = ""
        Phone_ = ""
    End Sub

    'constructor from database
    Public Sub New(ByVal CompanyName As String)
        'This constructor looks up the company by name in the database and retrieves its information
        Dim daCompany As New TTDataSetTableAdapters.CompanyTableTableAdapter
        Dim dtCompany As New TTDataSet.CompanyTableDataTable
        daCompany.FillByName(dtCompany, CompanyName)

        If dtCompany.Rows.Count = 0 Then
            MsgBox("Company has not been setup!")
            End
        End If

        Dim CompanyRow As TTDataSet.CompanyTableRow = DirectCast(dtCompany.Rows(0), TTDataSet.CompanyTableRow)

        Name_ = CompanyRow.CompanyName
        PayDay_ = CompanyRow.PayDay
        FaxNumber_ = CompanyRow.PayrollFaxNumber
        MOTD_ = CompanyRow.MOTD
        PayrollContact_ = CompanyRow.PayrollContact
        OwnerName_ = CompanyRow.OwnerName
        Phone_ = CompanyRow.CompanyPhone
    End Sub

    'Name accessor/mutator
    Public Property Name() As String
        Get
            Return Name_
        End Get

        Set(ByVal Value As String)
            Name_ = Value
        End Set
    End Property

    'PayDay accessor/mutator
    Public Property PayDay() As String
        Get
            Return PayDay_
        End Get

        Set(ByVal Value As String)
            PayDay_ = Value
        End Set
    End Property

    'FaxNumber accessor/mutator
    Public Property FaxNumber() As String
        Get
            Return FaxNumber_
        End Get

        Set(ByVal Value As String)
            FaxNumber_ = Value
        End Set
    End Property

    'Message of the day accessor/mutator
    Public Property MOTD() As String
        Get
            Return MOTD_
        End Get

        Set(ByVal Value As String)
            MOTD_ = Value
        End Set
    End Property

    'Payroll contact accessor/mutator
    Public Property PayrollContact() As String
        Get
            Return PayrollContact_
        End Get

        Set(ByVal Value As String)
            PayrollContact_ = Value
        End Set
    End Property

    'Owner's Name accessor/mutator
    Public Property OwnerName() As String
        Get
            Return OwnerName_
        End Get

        Set(ByVal Value As String)
            OwnerName_ = Value
        End Set
    End Property

    'Phone number accessor/mutator
    Public Property Phone() As String
        Get
            Return Phone_
        End Get

        Set(ByVal Value As String)
            Phone_ = Value
        End Set
    End Property

    'Break minutes accessor/mutator
    Public Property BreakMinutes() As Integer
        Get
            Return BreakMinutes_
        End Get

        Set(ByVal Value As Integer)
            BreakMinutes_ = Value
        End Set
    End Property

    Public Sub WriteCompany()
        'This function saves the companies information to the database
        Dim daCompany As New TTDataSetTableAdapters.CompanyTableTableAdapter
        Dim dtCompany As New TTDataSet.CompanyTableDataTable
        daCompany.FillByName(dtCompany, Name_)

        Dim CompanyRow As TTDataSet.CompanyTableRow = DirectCast(dtCompany.Rows(0), TTDataSet.CompanyTableRow)

        CompanyRow.CompanyName = Name_
        CompanyRow.PayDay = PayDay_
        CompanyRow.PayrollFaxNumber = FaxNumber_
        CompanyRow.MOTD = MOTD_
        CompanyRow.PayrollContact = PayrollContact_
        CompanyRow.OwnerName = OwnerName_
        CompanyRow.CompanyPhone = Phone_

        daCompany.Update(dtCompany)
    End Sub

End Class
