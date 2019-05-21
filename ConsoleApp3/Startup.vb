Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Nancy.Owin

Public Class Startup

    Private ReadOnly config As IConfiguration

    Public Sub New(env As IHostingEnvironment)

        Dim builder = New ConfigurationBuilder().
            AddJsonFile("appsettings.json").
            SetBasePath(env.ContentRootPath)

        config = builder.Build()
    End Sub

    Public Sub Configure(app As IApplicationBuilder)

        Dim appConfig = New AppConfiguration()
        ConfigurationBinder.Bind(config, appConfig)

        app.UseOwin(
            Function(x)
                Return x.UseNancy(
                Sub(opt)
                    opt.Bootstrapper = New DemoBootstrapper(appConfig)
                End Sub)
            End Function)
    End Sub

End Class
