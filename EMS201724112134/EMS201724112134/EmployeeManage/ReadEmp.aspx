<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="ReadEmp.aspx.cs" Inherits="EMS201724112134.EmployeeManage.ReadEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
                  
            <div class="custom-col-content-s">
                <div class="custom-col-content-s-list">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-2 col-md-2 text-right">员工编号</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="txtBCaseID" runat="server" CssClass="form-control"></asp:TextBox></div>
                             <div class="col-sm- col-md-2  text-left ">名字</div>
                            <div class="col-sm-3 col-md-2"><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>
                            
                             <div class="col-sm-3 col-md-3">
                                 <asp:Button ID="btnSearch" runat="server" CssClass="form-control custom-btn" Text="查询" BorderStyle="Solid" OnClick="btnSearch_Click1"  />
                               
                             </div>
                        </div>
                     
                       
                        <div class="row">
                             <div class="col-sm-2 col-md-1"></div>
                            <div class="col-sm-10 col-md-11">

                                <asp:GridView ID="GridView1" runat="server">
                                </asp:GridView>

                            </div>
                           
                        </div>
                       
                        
                       
           
                    </div>
                </div>
            </div>
            <div class="custom-col-foot-bg-s"></div>
        </div>
    </div>
</asp:Content>
