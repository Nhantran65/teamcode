
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Trang Chu</title>
    <style>
        *{
            padding: 0;
            margin: 0 auto ;
        }
        body{
            width: 100%;
            color: white;   
        }
        .menu{
            display: inline-block;
            margin-left: 10px;
        }
        .menu li {
            display: inline-block;
            text-decoration: none;
            padding: 10px 20px;
            background-color: red; 
            margin: 0px -2px;
        }
        .menu li:hover{
            background-color: #ff6a00;
            cursor: pointer;
        }
        .menu li a{
            font-weight: bold;
            text-decoration: none;
            color: white;
        }
    </style>
</head>
    
<body>
    <div> 
        @* Menu *@
        <ul class="menu">
            <li><a class="text-without-underline" href="~/Home/TrangChu">Trang Chu</a></li>
            <li><a href="~/Home/GioiThieu">Gioi Thieu</a></li>
            <li><a href="~/TinTuc/DanhSachTinTuc">Tin Tuc</a></li>
          

        </ul>
        <h1>
            Trang Chu
        </h1>
    </div>
</body>
</html>
