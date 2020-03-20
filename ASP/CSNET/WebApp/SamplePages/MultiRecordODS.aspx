﻿<%@ Page Title="MultiRecord ODS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MultiRecordODS.aspx.cs" Inherits="WebApp.SamplePages.MultiRecordODS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="page-header">
        <h1>Product MultiRecord Object DataSource</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-warning">
            <blockquote style="font-style: italic">
                This illustrates a display of multiple records from a query.
                The parameter will be submitted from either a drop down list
                or a textbox. The resulting dataset is of the enity Product.
                The output will be displayed in a customer GridView.
            </blockquote>
        </div>
    </div>
    <div class="row">
        <asp:Literal ID="Literal1" runat="server" Text="Categories:"></asp:Literal>
        &nbsp;&nbsp;
        <asp:DropDownList ID="CategoryList" runat="server" >
            
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:LinkButton ID="FetchCategoryProducts" runat="server">Fetch</asp:LinkButton>
        <br />
    </div>
   
    <div class="row">
        <asp:GridView ID="ProductList" runat="server"
            AutoGenerateColumns="False" OnSelectedIndexChanged="ProductList_SelectedIndexChanged"
             >
              <Columns>
                <asp:CommandField SelectText="View" ShowSelectButton="True"></asp:CommandField>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="ProductID" runat="server" 
                            Text='<%# Eval("ProductID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product">
                    <ItemTemplate>
                        <asp:Label ID="ProductName" runat="server" 
                            Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supplier">
                    <ItemTemplate>
                       <asp:Label ID="SupplierID" runat="server" 
                            Text='<%# Eval("SupplierID") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Category">
                    <ItemTemplate>
                         <asp:Label ID="CategoryID" runat="server" 
                            Text='<%# Eval("CategoryID") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="($)">
                    <ItemTemplate>
                        <asp:Label ID="UnitPrice" runat="server"
                            Text='<%# string.Format("{0:0.00}",Eval("UnitPrice")) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Disc.">
                    <ItemTemplate>
                        <asp:CheckBox ID="Discontinued" runat="server"
                             Checked='<%# Eval("Discontinued") %>' 
                             Enabled="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

          
        </asp:GridView>
        <br /><br />
        <asp:Label ID="Message" runat="server" ></asp:Label>
    </div>
</asp:Content>
