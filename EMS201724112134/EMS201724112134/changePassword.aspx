<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="EMS201724112134.changePasseord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:500px;margin-top:50px;">
            <div class="row">
               <div class ="col">
                <div class="card">
                    <div class="card-header " style="text-align:center;font-size:20px;color:#fff;background:#038d8d">修改密码</div>
                    <div class="card-body">
                        <!--群1-->
                        <div class="form-group">
                            <label for="txtName">旧密码</label>
                            <asp:TextBox ID="oldPwd" runat="server" class="form-control" Width="400px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="oldPwd" Display="Dynamic" ErrorMessage="旧密码不能为空"></asp:RequiredFieldValidator>
                        </div>
                        <!--群2-->
                        <div class="form-group">
                              <label for="txtName">新密码</label>
                            <asp:TextBox ID="newPwd" runat="server" class="form-control" Width="400px"></asp:TextBox>
                              <br />
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="newPwd" Display="Dynamic" ErrorMessage="新密码不能为空"></asp:RequiredFieldValidator>
                        </div>
                        
                        <!--群3-->
                        <div class="form-group" >
                           <label for="txtName">重复新密码</label>
                            <asp:TextBox ID="TextBox1" runat="server" class="form-control" Width="400px"></asp:TextBox>
                              <br />
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="新密码不能为空"></asp:RequiredFieldValidator>
                            
                            <br />
                              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="newPwd" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="两次密码输入不一致"></asp:CompareValidator>
                            
                        </div>
                        
                        
                        
                        <br />
                        <p style="text-align:center;font-size:20px">
                            <asp:Button ID="Button1" runat="server" Text="提交" class="btn " OnClick="Button1_Click" style="background:#038d8d ;color:white"/>
                        </p>
                    </div>
                </div>
                  </div>
</div>
     </div>  
</asp:Content>
