<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="MakeReview.aspx.cs" Inherits="Systems_Development.MakeReview" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form"  >

            <h2>Write Review</h2>
       
         <div class="space">
        <asp:Label ID="starLabel" runat="server" Text="Rating:" Width="15%"></asp:Label>
       &nbsp;
            <asp:DropDownList CssClass="textboxspace" ID="starsDropDown" runat="server" Height="35px" style="Width:40%">
             <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
           <asp:ListItem>2</asp:ListItem>
           <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
             <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
          &nbsp; 
          <asp:Label ID="Label1" runat="server" Text="" Width="3%"></asp:Label>
       </div>
         <div class="space">
            <asp:Label ID="enquiryLbl"  runat="server" Text="Review:" Width="20%"></asp:Label>
            </div>
         <div class="space">

            <asp:TextBox CssClass="textboxspace" Rows="4" ID="ReviewTxtBox" runat="server" Width="95%"  TextMode="MultiLine" MaxLength="200"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator1" controltovalidate="ReviewTxtBox" errormessage="*" />
        </div>
        <div class="space">
            <asp:Label ID="Label2"  runat="server" Text="" Width="70%"></asp:Label>
            </div>

          <div class="space" >
             <asp:Button ID="reviewBtn" CssClass="button" width="40%" style="margin-right:10px;"  runat="server" Text="Submit Review" OnClick="reviewBtn_Click"   />

        </div>

        </div>
</asp:Content>
