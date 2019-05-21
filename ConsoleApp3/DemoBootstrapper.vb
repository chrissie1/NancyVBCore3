Imports Nancy

Public Class DemoBootstrapper
    Inherits DefaultNancyBootstrapper

    Private ReadOnly appConfig As IAppConfiguration

    Public Sub New()

    End Sub

    Public Sub New(appConfig As IAppConfiguration)
        Me.appConfig = appConfig
    End Sub

    Protected Overrides Sub ConfigureApplicationContainer(container As TinyIoc.TinyIoCContainer)
        MyBase.ConfigureApplicationContainer(container)

        container.Register(Of IAppConfiguration)(appConfig)
    End Sub

End Class
