<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="ReadDep.aspx.cs" Inherits="EMS201724112134.DepartmentManage.ReadDep1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-12">
                  
            <div class="custom-col-content-s">
                <div class="custom-col-content-s-list">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-4 col-md-2 text-right">部门名称：</div>
                            <div class="col-sm-4 col-md-6"><asp:TextBox ID="txtBCaseID" runat="server" CssClass="form-control"></asp:TextBox></div>
                             <div class="col-sm-4 col-md-4">
                                 <asp:Button ID="btnSearch" runat="server" CssClass="form-control custom-btn" Text="查询" BorderStyle="Solid" OnClick="btnSearch_Click1" /></div>
                        
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-3"></div>
                            <div class="col-sm-6 col-md-6">

                                <asp:GridView ID="GridView1" runat="server">
                                </asp:GridView>

                            </div>
                             <div class="col-sm-3 col-md-3"></div>
                        </div>
                       
                        
                       
                
                    </div>
                </div>
            </div>
            <div class="custom-col-foot-bg-s"></div>
        </div>
    </div>
</asp:Content>
