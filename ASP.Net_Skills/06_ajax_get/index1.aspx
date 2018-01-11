<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index1.aspx.cs" Inherits="ASP.Net_Skills._06_ajax_get.index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../JS/jquery-3.1.1.min.js"></script>
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/lazyload@2.0.0-beta.2/lazyload.js"></script>
</head>
<body>
    <div id="container">
    </div>
</body>

<script>
    $(document).ready(function () {
        $.ajax({
            type: 'get',
            url: '../06_ajax_get/index2.aspx',
            success: function (response, status) {
                var data = $.parseJSON(response);
                $.each(data.res.news, function (key, value) {
                    //recommend_content

                    var source_img = value['Img'];
                    var link = value['Url'];
                    var title = value['Title'];
                    html = "";

                    html = ' <section id="123" class="news-item news-img1">';
                    html += '<a data-type="tiyu" data-subtype="shuishangyundong" href="' + link + '" class="news-link">';
                    html += '<div class="info">';
                    html += ' <h3 class="title dotdot line3">' + title + '</h3>';
                    html += ' </div>';
                    html += ' <div class="img"><div class="img-wrap img-bg"  style="width: 100%;height: 100%;">';
                    html += ' <img class="image" src="' + source_img + '"/>';
                    html += '</div></div></a></section>';
                    console.log($("#123"));
                    $("img.image").lazyload();
                    $("#container").append(html);
                });
                
            },
            error: function () {
                console.log('error');
            }
        });
    });
</script>

</html>
