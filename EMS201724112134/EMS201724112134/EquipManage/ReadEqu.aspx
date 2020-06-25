<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="ReadEqu.aspx.cs" Inherits="EMS201724112134.EquipManage.ReadEqu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
                  
           
                    <div class="container">
                        <div class="row">
                             <div class="col-sm- col-md-1"></div>  
                            <div class="col-sm-2 col-md-2 text-right">设备编号</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="txtBCaseID" runat="server" CssClass="form-control"></asp:TextBox></div>
                             <div class="col-sm- col-md-2  text-left ">设备名称</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>
                            
                           
                        </div>


                        <div class="row">
                              <div class="col-sm- col-md-1"></div>  
                              <div class="col-sm-2 col-md-2 text-right">购入日期</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>
                             <div class="col-sm-2 col-md-2  text-left ">存放位置</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></div>
                        </div>
                          <div class="row">
                               <div class="col-sm- col-md-1"></div>  
                              <div class="col-sm-2 col-md-2 text-right">负责人</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></div>
                             <div class="col-sm-2 col-md-2  text-left ">部门名称</div>
                            <div class="col-sm-3 col-md-3"><asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox></div>


                         
                               
                        </div>
                        <div class="row">
                             <div class="col-sm-4 col-md-4"></div>
                             <div class="col-sm-3 col-md-3 text-center">
                                 <asp:Button ID="btnSearch" runat="server" CssClass="form-control custom-btn" Text="查询" BorderStyle="Solid" OnClick="btnSearch_Click1"  />
                               
                             </div>
                        </div>



                     
                       
                        <div class="row">
                            
                            <div class="col-sm-12 col-md-12">

                                <asp:GridView ID="GridView1" runat="server" >
                                    <Columns>
                                        <asp:TemplateField>
                                             <ItemTemplate> 
                <asp:Button ID="RowSelector" runat="server"  
                    GroupName="SuppliersGroup" Text="查看图片" onclick="RowSelector_Click"/> 
            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                  
                                </asp:GridView>

                           
                                <br />

                                <br />

                            </div>
                           
                        </div>
                       
                        
                       
           
                 
            </div>
            <div class="custom-col-foot-bg-s"></div>
        </div>
    </div>
</asp:Content>
