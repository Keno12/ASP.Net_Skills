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
            $.ajax({

                dataType: 'HTML',
                contentType: 'application/json;charset=utf-8',
                url: "SaveFileDialog.aspx/GetData",
                type: "get",
                success: function () {

                },
                error: function (data) {
                    console.log(data)
                    alert(2);
                }
            });

        }
    </script>
</body>
</html>
