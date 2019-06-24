<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewPet.aspx.cs" Inherits="friendsWithPaws.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formAp" style="padding:0px 5%;">
    <div class="space">
 <asp:TextBox ID="petInput" runat="server"></asp:TextBox>&nbsp;
        <asp:Label ID="serachLbl" runat="server" Text="Search By"></asp:Label>
       <asp:DropDownList CssClass="textboxspace" ID="searchDropDown" runat="server" Height="25px" Width="92px">
           <asp:ListItem></asp:ListItem>
           <asp:ListItem>Species</asp:ListItem>
           <asp:ListItem>Breed</asp:ListItem>
            <asp:ListItem>Country</asp:ListItem>
            </asp:DropDownList>&nbsp;
         <asp:Button ID="search"  runat="server" Text="Search" OnClick="search_Click" />
        &nbsp;
         <asp:Button ID="showAll"  runat="server" Text="Show All" OnClick="showAll_Click" />
      </div>
         <div class="space" style="width:100%;">

            
        <h2><asp:Label ID="checkSearch" runat="server" Text=""></asp:Label> </h2>

        </div>
      <div class="content" id="content" runat="server">
          
    </div>
        
    </div>
    
</asp:Content>
