<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="EMS201724112134.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
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

        </div>
    </form>
</body>
</html>
