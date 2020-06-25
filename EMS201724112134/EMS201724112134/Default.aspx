<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EMS201724112134.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <script src="js/jquery-3.5.0.slim.js"></script>
     <link href="css/bootstrap.min.css" rel="stylesheet" />
 
    <script src="js/bootstrap.min.js"></script>
    <style type="text/css">
        *{
            margin:0;
            padding:0;
        }
     body{

     }
        .auto-style2 {
            width: 402px;
            height: 77px;
        }
        .auto-style3 {
            width: 623px;
            height: 150px;
        }
        .title{
            margin-top:50px;
            margin-left:100px;
        }
       .submit{
           margin:150px auto;
           text-align:center;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="auto-style1" >
  <div class="card" >
    <div class=" card-header bg-success" >
       <img src="images/logo2.png" class="auto-style3" />

            <img src="images/logo3.png" class="auto-style2" />

    </div>
    
    <div class=" card-body "style="background:#28a745;opacity:0.8" >
     
        <div class="submit">



             <asp:Button ID="Button1" runat="server" BackColor="#E6373E" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" Height="80px" Text="登录" Width="150px" OnClick="Button1_Click" />
        </div>
           

     
    </div>


    <div class=" card-footer bg-warning" style="text-align:center" >  
            地址：肇庆市端州区迎宾大道肇庆学院 <br />
            邮政编码：526061</div>
  </div>
</div>





































       
       
    </form>
</body>
</html>
