@code
    Dim myVariable As Integer = 10
    myVariable = myVariable + 5

End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
</head>
<body>
    <div>
        @RenderBody()
        <p>The value of myVariable is: @myVariable</p>
    </div>
</body>
</html>


