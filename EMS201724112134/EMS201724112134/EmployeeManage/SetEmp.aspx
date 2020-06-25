<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="SetEmp.aspx.cs" Inherits="EMS201724112134.EmployeeManage.CreateEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="custom-col-content-img-s s1"></div>        
            <div class="custom-col-content-s">
                <div class="custom-col-content-s-list">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">员工编号：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="txtBCaseID" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBCaseID" Display="Dynamic" ErrorMessage="编号不能为空"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">密码：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="txtBCaseName" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtBCaseName" Display="Dynamic" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                          <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">姓名：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox1" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="姓名不能为空"></asp:RequiredFieldValidator>
                              </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                         <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">电话：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox2" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="电话不能为空"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="输入合格电话号码格式如０１０８２３１６８３３" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
                             </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">部门编号：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox3" runat="server" Width="200px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">身份：</div>
                            <div class="col-sm-6 col-md-6">
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                                    <asp:ListItem Value="01">管理员</asp:ListItem>
                                    <asp:ListItem Value="02">部门主管</asp:ListItem>
                                    <asp:ListItem Value="03">员工</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right"></div>
                            <div class="col-sm-6 col-md-6">
                                <asp:Button ID="btnAdd" runat="server" Text="添加"  CssClass="form-control custom-btn" OnClick="btnAdd_Click"/>
                                  &nbsp;
                                <asp:Button ID="btnChange" runat="server" Text="修改" CausesValidation="False"  CssClass="form-control custom-btn" OnClick="btnChange_Click"/>
                                <asp:Button ID="btnDelete" runat="server" CssClass="form-control custom-btn" OnClick="btnDelete_Click" Text="删除" />
                            </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="custom-col-foot-bg-s"></div>
        </div>
    </div>
</asp:Content>
