﻿Imports System.Web.Mvc

Namespace Controllers
    Public Class AboutController
        Inherits Controller

        ' GET: About
        Function Index() As ActionResult

            Return View()
        End Function
    End Class
End Namespace