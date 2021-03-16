<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="WebSite2.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">

           <div>
              <asp:Label ID="Label1" runat="server" Text="ÜRÜN ID" CssClass="form-group"></asp:Label>
            <asp:TextBox ID="TxtUrunid" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
             <asp:Label ID="Label2" runat="server" Text="ÜRÜN ADI" CssClass="form-group"></asp:Label>
            <asp:TextBox ID="TxtUrunad" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
               <asp:Label ID="Label3" runat="server" Text="MARKA" CssClass="form-group"></asp:Label>
            <asp:TextBox ID="TxtMarka" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
               <asp:Label ID="Label4" runat="server" Text="KATEGORİ" CssClass="form-group"></asp:Label>
              <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
          <div>
               <asp:Label ID="Label5" runat="server" Text="FİYAT" CssClass="form-group"></asp:Label>
            <asp:TextBox ID="TxtFiyat" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
          <div>
               <asp:Label ID="Label6" runat="server" Text="STOK SAYISI" CssClass="form-group"></asp:Label>
            <asp:TextBox ID="TxtStok" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />


        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle"  CssClass="btn btn-success" OnClick="Button1_Click"  />
        </div>
    </form>

</asp:Content>
