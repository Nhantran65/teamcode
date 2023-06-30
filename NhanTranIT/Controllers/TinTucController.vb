Imports System.Web.Mvc

Namespace Controllers
    Public Class TinTucController
        Inherits Controller

        ' GET: TinTuc
        Function DanhSachTinTuc() As ActionResult
            Return View()
        End Function
        Function NoiDungTin() As ActionResult
            Return View()
        End Function
    End Class
End Namespace