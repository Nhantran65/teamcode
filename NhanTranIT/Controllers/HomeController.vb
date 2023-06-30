Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home



        Function TrangChu() As ActionResult

            Return View()


        End Function

        Function GioiThieu() As ActionResult
            Return View()
        End Function

        Function DangNhap() As ActionResult
            Return View()
        End Function
    End Class
End Namespace