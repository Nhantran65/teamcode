Imports System.Web.Mvc

Namespace Controllers
    Public Class ServicesController
        Inherits Controller

        ' GET: Services
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace