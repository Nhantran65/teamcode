Imports System.Web.Mvc

Namespace Controllers
    Public Class ShopController
        Inherits Controller

        ' GET: Shop
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace