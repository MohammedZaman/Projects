<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Systems_Development.SignUp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
   
          
       
        <div class="form">
              <h2>Sign Up</h2>
        <div style="border:solid black 3px;">
              <div class="space">
            <span class="fa-stack">
    <!-- The icon that will wrap the number -->
    <span class="fa fa-circle-o fa-stack-2x"></span>
    <!-- a strong element with the custom content, in this case a number -->
    <strong class="fa-stack-1x">
        1    
    </strong>
</span>
            <p style="display:inline-block;  margin-left:5px;">Add Profile </p>

        </div>


        <div class="space">
            <asp:Label ID="uNameLbl" runat="server" Text="User Name" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="uNameTxtBox" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator1" controltovalidate="uNameTxtBox" errormessage="*" />
        </div>

        <div class="space">
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="passwordTxtBox"  TextMode="Password" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" CssClass="error" runat="server" id="RequiredFieldValidator2" controltovalidate="passwordTxtBox" errormessage="*" />
        </div>

        <div class="space">
            <asp:Label ID="fNameLbl" runat="server" Text="FirstName" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="fNameTxt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator3" controltovalidate="fNameTxt" errormessage="*" />
        </div>

           <div class="space">
            <asp:Label ID="lNameLbl" runat="server" Text="LastName" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="lNameTxt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator4" controltovalidate="lNameTxt" errormessage="*" />
        </div>

        
           <div class="space">
            <asp:Label ID="emailLbl" runat="server" Text="E-Mail" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="emailTxt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator5" controltovalidate="emailTxt" errormessage="*" />
      
               </div>
        
           <div class="space">
            <asp:Label ID="mobileLbl" runat="server" Text="Mobile Number" Width="30%"></asp:Label>
            &nbsp;
               

            <asp:TextBox CssClass="textboxspace" ID="mobileTxt" onkeypress= "return (!(event.keyCode>=65) && event.keyCode!=32 && this.value.length<=10);" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator6" controltovalidate="mobileTxt" errormessage="*" />
        </div>
          


              
              <div class="space">
            <span class="fa-stack">
    <!-- The icon that will wrap the number -->
    <span class="fa fa-circle-o fa-stack-2x"></span>
    <!-- a strong element with the custom content, in this case a number -->
    <strong class="fa-stack-1x">
        2    
    </strong>
</span>
            <p style="display:inline-block; margin-left:5px;">Address </p>

        </div>
                          
           <div class="space">
            <asp:Label ID="address1Lbl" runat="server" Text="Address Line 1" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="address1Txt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator7" controltovalidate="address1Txt" errormessage="*" />

        </div>
         
                       <div class="space">
            <asp:Label ID="address2Lbl" runat="server" Text="Address Line 2" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="address2Txt" runat="server" Width="60%"></asp:TextBox>
             

        </div>
                                <div class="space">
            <asp:Label ID="cityLbl" runat="server" Text="City" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="cityTxt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator9" controltovalidate="cityTxt" errormessage="*" />

        </div>

        <div class="space">
            <asp:Label ID="postCodelbl" runat="server" Text="PostCode" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="postCodeTxt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator10" controltovalidate="postCodeTxt" errormessage="*" />

        </div>
          

                     <div class="space">
            <span class="fa-stack">
    <!-- The icon that will wrap the number -->
    <span class="fa fa-circle-o fa-stack-2x"></span>
    <!-- a strong element with the custom content, in this case a number -->
    <strong class="fa-stack-1x">
        3    
    </strong>
</span>
            <p style="display:inline-block; margin-left:5px;">Billing </p>

        </div>

          <div class="space">
            <asp:Label ID="nocLbl" runat="server" Text="Name On Card" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="nocTxt" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator11" controltovalidate="nocTxt" errormessage="*" />

        </div>

            <div class="space">
            <asp:Label ID="cardNumLbl" runat="server" Text="Card Number" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="cardNumTxt" onkeypress= "return (!(event.keyCode>=65) && event.keyCode!=32 && this.value.length<=15);" runat="server" Width="60%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator12" controltovalidate="cardNumTxt" errormessage="*" />

        </div>

        <div class="space">
          <asp:Label ID="Label1" style="margin-right:70px;" runat="server" Text="Expiry Date"></asp:Label>&nbsp;
       <asp:DropDownList CssClass="textboxspace" ID="mounthDD" Value="1" runat="server" Height="35px" Width="70px">
           <asp:ListItem>MM</asp:ListItem> 
           <asp:ListItem>01</asp:ListItem>
            <asp:ListItem>02</asp:ListItem>
           <asp:ListItem>03</asp:ListItem>
            <asp:ListItem>04</asp:ListItem>
           <asp:ListItem>05</asp:ListItem>
            <asp:ListItem>06</asp:ListItem>
           <asp:ListItem>07</asp:ListItem>
            <asp:ListItem>08</asp:ListItem>
           <asp:ListItem>09</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
           <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
            <asp:requiredfieldvalidator id="RequiredFieldValidator14" style="color:red;" runat="server" text="*" controltovalidate="mounthDD" errormessage="*" initialvalue="MM" xmlns:asp="#unknown"></asp:requiredfieldvalidator>
            &nbsp;
              <asp:DropDownList CssClass="textboxspace" ID="yearDD" Value="0" runat="server" Height="35px" Width="80px">
             <asp:ListItem>YYYY</asp:ListItem>
                  <asp:ListItem>2018</asp:ListItem>
            <asp:ListItem>2019</asp:ListItem>
           <asp:ListItem>2020</asp:ListItem>
            <asp:ListItem>2021</asp:ListItem>
           <asp:ListItem>2022</asp:ListItem>
            <asp:ListItem>2023</asp:ListItem>
           <asp:ListItem>2024</asp:ListItem>
            <asp:ListItem>2025</asp:ListItem>
           <asp:ListItem>2026</asp:ListItem>
            <asp:ListItem>2027</asp:ListItem>
           <asp:ListItem>2028</asp:ListItem>
            <asp:ListItem>2029</asp:ListItem>
            </asp:DropDownList>&nbsp;
             <asp:requiredfieldvalidator  id="RequiredFieldValidator15" style="color:red;" runat="server" text="*" controltovalidate="yearDD" errormessage="*" initialvalue="YYYY" xmlns:asp="#unknown"></asp:requiredfieldvalidator>
        </div>

    <div class="space"> 
         <asp:Label ID="cvcLbl" runat="server" Text="CVC" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace"  ID="cvcTxt" onkeypress= "return (!(event.keyCode>=65) && event.keyCode!=32 && this.value.length<=2);" runat="server" Width="20%"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator13" controltovalidate="cvcTxt" errormessage="*" />

    </div>
   <div class="space" style="padding-bottom:50px;" >
             <asp:Button ID="SignUpBtn" CssClass="button" width="25%"  runat="server" Text="Sign Up" Style="margin-right:20px;" OnClick="SignUpBtn_Click" />

        </div>





                 </div>
      

 </div>
     




</asp:Content>
