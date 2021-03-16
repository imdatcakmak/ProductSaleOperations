<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="WebSite2.KategoriGuncelle" %>

<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">

              <div>
                  <asp:Label ID="Label1" runat="server" Text="KATEGORI ID" CssClass="form-group"></asp:Label>
                  <br />
            <asp:TextBox ID="Txtid" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="KATEGORİ ADI" CssClass="form-group"></asp:Label>
            <asp:TextBox ID="TxtAd" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kategori Güncelle"  CssClass="btn btn-success" OnClick="Button1_Click" />
        </div>
    </form>

</asp:Content>
