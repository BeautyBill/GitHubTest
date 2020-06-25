<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EMS201724112134.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            文件序号
<asp:TextBox ID="txtrollno" runat="server">
</asp:TextBox>
<br />

选择文件
<asp:FileUpload ID="FileUpload1" runat="server" />
<br />

<asp:Button ID="Button1" runat="server"
Text="上传" OnClick="Button1_Click" />

            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="显示" />

        </div>
    </form>
</body>
</html>
