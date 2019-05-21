Imports ConsoleApp3
Imports Microsoft.Extensions

Public Class AppConfiguration
    Implements IAppConfiguration

    Public Sub New()
    End Sub

    Public Property Logging As Logging Implements IAppConfiguration.Logging
    Public Property Smtp As Smtp Implements IAppConfiguration.Smtp

End Class
