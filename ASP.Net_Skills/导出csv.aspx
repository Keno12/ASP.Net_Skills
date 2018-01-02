<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="导出csv.aspx.cs" Inherits="ASP.Net_Skills.导出csv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="JS/jquery-3.1.1.min.js"></script>
</head>
<body>
    <button onclick="getdata()">下载数据</button>

    <script type="text/javascript">
        function getdata() {
            $('body').append("<iframe src = 'http://localhost:22519/SaveFileDialog.aspx' style='display:none'></iframe>")

            //$.ajax({
            //    dataType: 'HTML',
            //    contentType: 'application/json;charset=utf-8',
            //    url: "SaveFileDialog.aspx/GetData",
            //    type: "get",
            //    success: function () {},
            //    error: function (data) {}
            //});

        }
    </script>
</body>
</html>
