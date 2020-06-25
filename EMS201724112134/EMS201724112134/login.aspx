<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EMS201724112134.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
       <script src="js/jquery-3.5.0.slim.js"></script>
     <script src="js/bootstrap.min.js"></script>
    
     <link href="css/bootstrap.min.css" rel="stylesheet" />
 
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            max-width: 1140px;
            min-width: 992px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="auto-style1" >
  <div class="card" >
    <div class=" card-header bg-success" >
         <img alt="" class="auto-style1" src="images/logo.png" /></div>
    
    <div class=" card-body "style="background:#28a745;opacity:0.8" >
      <div class="container" style="width:50%;margin-top:50px;">
            <div class="row">
               <div class ="col">
                <div class="card">
                    <div class="card-header bg-success" style="text-align:center;font-size:20px;color:#fff">登录</div>
                    <div class="card-body">
                        <!--群1-->
                        <div class="form-group">
                            <label for="txtName">账号</label>
                            <asp:TextBox ID="txtName" runat="server" class="form-control" Width="400px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="账号不能为空"></asp:RequiredFieldValidator>
                        </div>
                        <!--群2-->
                        <div class="form-group">
                              <label for="txtName">密码</label>
                            <asp:TextBox ID="txtPwd" runat="server" class="form-control" Width="400px"></asp:TextBox>
                              <br />
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>
                        </div>
                        
                        <!--群3-->
                        <div class="form-group" style="text-align:center">
                              <label for="txtPos">身份</label>
                              <br />
                              <asp:DropDownList ID="DropDownList1" runat="server">
                                  <asp:ListItem Value="01">系统管理员</asp:ListItem>
                                  <asp:ListItem Value="02">部门主管</asp:ListItem>
                                  <asp:ListItem Value="03">员工</asp:ListItem>
                              </asp:DropDownList>
                            
                        </div>
                        
                        
                        
                        <br />
                        <p style="text-align:center;font-size:20px">
                            <asp:Button ID="Button1" runat="server" Text="登陆" class="btn btn-success" OnClick="Button1_Click"/>
                        </p>
                    </div>
                </div>
                  </div>
</div>
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
