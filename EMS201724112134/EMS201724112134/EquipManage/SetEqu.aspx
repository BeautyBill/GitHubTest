<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="SetEqu.aspx.cs" Inherits="EMS201724112134.EquipManage.CreateEqu" %>
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
                            <div class="col-sm-3 col-md-2 text-right">设备编号：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="txtBCaseID" runat="server" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">设备名称：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="txtBCaseName" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                          <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">设备规格：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox1" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                         <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">设备图片：</div>
                            <div class="col-sm-6 col-md-6">  文件序号
<asp:TextBox ID="txtrollno" runat="server">
</asp:TextBox>
<br />

选择文件
<asp:FileUpload ID="FileUpload1" runat="server" />
<br />

<asp:Button ID="Button1" runat="server"
Text="上传" OnClick="Button1_Click" />
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="删除" />
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="修改" />
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                             </div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">价格：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox3" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">购入日期：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox4" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">存放位置：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox5" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                          <div class="row">
                            <div class="col-sm-3 col-md-2 text-right">设备负责人：</div>
                            <div class="col-sm-6 col-md-6"><asp:TextBox ID="TextBox6" runat="server" Width="149px" CssClass="form-control"></asp:TextBox></div>
                            <div class="col-sm-3 col-md-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3 col-md-2 text-right"></div>
                            <div class="col-sm-6 col-md-6">
                                <asp:Button ID="btnAdd" runat="server" Text="添加"  CssClass="form-control custom-btn" OnClick="btnAdd_Click"/>
                                  &nbsp;
                                <asp:Button ID="btnChange" runat="server"  CssClass="form-control custom-btn"  Text="修改" OnClick="btnChange_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="删除" CausesValidation="False"  CssClass="form-control custom-btn" OnClick="btnCancel_Click"/>
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

