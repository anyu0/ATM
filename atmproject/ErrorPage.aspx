<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="atmproject.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color:red;">Invalid Account Number! Please try again!</h2>
        </div>
        <div class="jumbotron">
            <h1>Bank of 3101</h1>
            <p class="lead">
                Thanks for using Bank of 3101's ATM.

                <h4> Click The Image To Begin Transaction! </h4>
                <a href="Views/Home/Index.cshtml">
                    <img src="./Images/ATM.jpg" />
                </a>
        </div>
    </form>
</body>
</html>
