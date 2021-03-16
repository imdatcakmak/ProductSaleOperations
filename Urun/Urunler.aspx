<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="WebSite2.Urun.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">

        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN AD</th>
            <th>ÜRÜN MARKA</th>
            <th>ÜRÜN KATEGORİ</th>
            <th>ÜRÜN FİYAT</th>
            <th>ÜRÜN STOK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("URUNMARKA") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td><%#Eval("URUNFIYAT") %></td>
                    <td><%#Eval("URUNSTOK") %></td>
                    <td> <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/Urun/UrunSil.aspx?URUNID="+Eval("URUNID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td> <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/Urun/UrunGuncelle.aspx?URUNID="+Eval("URUNID") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="UrunEkle.aspx" class="btn btn-primary">Yeni Ürün</a>
</asp:Content>
