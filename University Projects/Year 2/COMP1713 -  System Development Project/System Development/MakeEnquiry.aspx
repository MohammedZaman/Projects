<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="MakeEnquiry.aspx.cs" Inherits="Systems_Development.MakeEnquiry" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form"  >

            <h2>Make Enquiry</h2>
       
         <div class="space">
        <asp:Label ID="carLbl" runat="server" Text="Subject:" Width="15%"></asp:Label>
       &nbsp;
            <asp:DropDownList CssClass="textboxspace" ID="SubDropDown" runat="server" Height="35px" style="Width:75%">
            <asp:ListItem>Select Option</asp:ListItem>
           <asp:ListItem>General Questions about PH</asp:ListItem>
           <asp:ListItem>My Account</asp:ListItem>
            <asp:ListItem>Payments</asp:ListItem>
             <asp:ListItem>A Trip i took</asp:ListItem>
             <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
          &nbsp; 
          <asp:Label ID="Label1" runat="server" Text="" Width="3%"></asp:Label>
       </div>
         <div class="space">
            <asp:Label ID="enquiryLbl"  runat="server" Text="Enquiry:" Width="20%"></asp:Label>
            </div>
         <div class="space">

            <asp:TextBox CssClass="textboxspace" Rows="4" ID="enquiryTxtBox" runat="server" Width="95%"  TextMode="MultiLine" MaxLength="200"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator1" controltovalidate="enquiryTxtBox" errormessage="*" />
        </div>
        <div class="space">
            <asp:Label ID="Label2"  runat="server" Text="" Width="70%"></asp:Label>
            </div>

          <div class="space" >
             <asp:Button ID="enquiryBtn" CssClass="button" width="40%" style="margin-right:10px;"  runat="server" Text="Make Enquiry" OnClick="enquiryBtn_Click"  />

        </div>

        </div>
   
</asp:Content>
