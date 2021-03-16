﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="WebSite2.Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">

        <tr>
            <th>KATEGORİ ID</th>
            <th>KATEGORİ AD</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KATEGORIID") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td> <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/Kategori/KategoriSil.aspx?KATEGORIID="+Eval("KATEGORIID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td> <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/Kategori/KategoriGuncelle.aspx?KATEGORIID="+Eval("KATEGORIID") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="KategoriEkle.aspx" class="btn btn-primary">Yeni Kategori</a>

</asp:Content>
