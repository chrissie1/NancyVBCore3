Namespace Modules
    Public Class HomeModule
        Inherits Nancy.NancyModule

        Public Sub New()
            [Get]("/",
                  Function(args)
                      Return "Hello world from VB.Net!"
                  End Function)
        End Sub

    End Class
End Namespace