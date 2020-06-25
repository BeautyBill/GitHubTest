<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="SetDep.aspx.cs" Inherits="EMS201724112134.DepartmentManage.CreateDep" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-12">
           
            <div class="custom-col-content-s">
                <div class="custom-col-content-s-list">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">部门编号：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="txtBCaseID" runat="server" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">部门名称：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="txtBCaseName" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                          <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">部门主管：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox1" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                       
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right"></div>
                            <div class="col-sm-6 col-md-6">
                                <asp:Button ID="btnAdd" runat="server" Text="添加"  CssClass="form-control custom-btn" OnClick="btnAdd_Click"/>
                                  &nbsp;
                                <asp:Button ID="btnCancel" runat="server" Text="修改" CausesValidation="False"  CssClass="form-control custom-btn" OnClick="btnCancel_Click"/>
                                <asp:Button ID="btn_delete" runat="server"  CssClass="form-control custom-btn" OnClick="btn_delete_Click" Text="删除" />
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

