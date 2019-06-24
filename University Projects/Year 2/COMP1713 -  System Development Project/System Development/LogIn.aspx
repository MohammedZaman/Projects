<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Systems_Development.LogIn" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="form">
   
            <h2>Sign In</h2>
       


        <div class="space">
            <asp:Label ID="uNameLbl" runat="server" Text="User Name" Width="20%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="uNameTxtBox" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator1" controltovalidate="uNameTxtBox" errormessage="*" />
        </div>

        <div class="space">
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" Width="20%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="passwordTxtBox"  TextMode="Password" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" CssClass="error" runat="server" id="RequiredFieldValidator2" controltovalidate="passwordTxtBox" errormessage="*" />
        </div>
         <div class="space" >
           <p>Don't have a account <a href="SignUp.aspx">click me</a></p>

        </div>
        <div class="space" >
             <asp:Button ID="logInBtn" CssClass="button" width="20%"  runat="server" Text="Sign in" OnClick="logInBtn_Click" />

        </div>
        <div class="space">
            <asp:Label ID="Label1" runat="server"  Width="20%"></asp:Label>
        </div>

    </div>


</asp:Content>
