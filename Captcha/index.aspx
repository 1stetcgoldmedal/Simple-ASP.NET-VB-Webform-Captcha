<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="Captcha.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Simple Captcha</title>
</head>
<body>
    <form id="form1" action="index.aspx" method="post">
        <div>
            <center>
                <img src="/Captcha.aspx" />
                <br />
                <input type="text" name="captcha" />
                <input type="button" name=""
                <input type="submit" name="submit" value="submit" />
                <br />
                <asp:Literal ID="L1" runat="server"></asp:Literal>
            </center>
        </div>
    </form>
</body>
</html>
