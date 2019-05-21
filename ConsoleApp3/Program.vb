Imports System
Imports System.IO
Imports Microsoft.AspNetCore.Hosting

Module Program
    Sub Main(args As String())
        Dim host = New WebHostBuilder().
            UseContentRoot(Directory.GetCurrentDirectory()).
            UseKestrel().
            UseStartup(Of Startup)().
            Build()

        host.Run()
    End Sub
End Module
