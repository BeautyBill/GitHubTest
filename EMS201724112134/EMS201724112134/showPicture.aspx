<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="showPicture.aspx.cs" Inherits="EMS201724112134.showPicture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <div class="custom-col-content-s">
                <div class="custom-col-content-s-list">
                    <div class="container">
                        <div class="row">



    <asp:Image ID="Image1" runat="server" Height="273px" Width="342px"   />

    <br />
    <asp:GridView ID="GridView1" runat="server" >
    </asp:GridView>
    <br />
                            </div>
                        </div>
                      </div>
                        </div>
                    

</asp:Content>
