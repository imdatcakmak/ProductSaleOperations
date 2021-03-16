<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="WebSite2.Urun.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="TxtUrunad" runat="server" placeholder="Ürün Adını Girin" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TxtMarka" runat="server" placeholder="Marka Girin" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
              <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyatı Girin" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok Sayısı" CssClass="form-control"></asp:TextBox>
        </div>
        <br />


        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Ekle"  CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
