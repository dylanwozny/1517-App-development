﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NaitSearch.aspx.cs" Inherits="WebApp.SamplePages.NaitSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <fieldset class="form-horizontal">
                <legend>Fill out the form below to add information on the movie for your movie library</legend>
                <div class="col-md-2">
                    <asp:Label ID="Label1" runat="server" Text="Rating" AssociatedControlID="Rating"></asp:Label>  
                </div>
                <div class="col-md-10 pb-5">
                    <asp:CheckBoxList ID="Rating" runat="server">
                        <asp:ListItem>General</asp:ListItem>
                        <asp:ListItem>Parental Guidance</asp:ListItem>
                        <asp:ListItem>14A</asp:ListItem>
                        <asp:ListItem>18A</asp:ListItem>
                        <asp:ListItem>Restricted</asp:ListItem>
                    </asp:CheckBoxList>
                </div>    
                <div class="col-md-2">
                    <asp:Label ID="Label2" runat="server" Text="Review(1-5) stars"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:DropDownList ID="CollectionList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="Label3" runat="server" Text="ISBN"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="ISBN" runat="server"></asp:TextBox>                    
                </div>
                <div class="col-md-2">
                    <asp:Label ID="Label4" runat="server" Text="Premuim Memeber ?"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:RadioButtonList ID="Membership" runat="server">
                        <asp:ListItem Value="0">Premuim</asp:ListItem>
                        <asp:ListItem Value="1">Regular</asp:ListItem>
                        <asp:ListItem Value="2">non-member</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="Message" runat="server"></asp:Label>
                </div>
                
            </fieldset>
        <div class="col-md-3 text-right">
            <asp:Button ID="Submit" runat="server" Text="Submit" CssClass="btn btn-alert" OnClick="Submit_Click" />
            <asp:Button ID="Clear" runat="server" Text="Clear" CssClass="btn btn-success" OnClick="Clear_Click" />
        </div>

    </div>
</asp:Content>
