<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniSatis.aspx.cs" Inherits="WebSite2.Satis.YeniSatis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        Ürün Seçin
         <div>
              <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />

         Müşteri Seçin
         <div>
              <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />

         Personel Seçin
         <div>
              <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />

         Fiyat
         <div>
             <asp:TextBox ID="Textbox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Satış Yap" CssClass="btn btn-primary" OnClick="Button1_Click" />
    </form>

</asp:Content>
