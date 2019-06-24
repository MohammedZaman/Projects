<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Systems_Development.ViewProfile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
      <div class="form">
              <h2>My Account</h2>
       
           
        <button class="accordion" onclick="return false;" >General</button>
<div class="panel">


        <div class="space">
            <asp:Label ID="uNameLbl" runat="server" Text="User Name" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="uNameTxtBox" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator1" controltovalidate="uNameTxtBox" errormessage="*" />
        </div>

        <div class="space">
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="passwordTxtBox" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" CssClass="error" runat="server" id="RequiredFieldValidator2" controltovalidate="passwordTxtBox" errormessage="*" />
        </div>

        <div class="space">
            <asp:Label ID="fNameLbl" runat="server" Text="FirstName" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="fNameTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator3" controltovalidate="fNameTxt" errormessage="*" />
        </div>

           <div class="space">
            <asp:Label ID="lNameLbl" runat="server" Text="LastName" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="lNameTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator4" controltovalidate="lNameTxt" errormessage="*" />
        </div>

        
           <div class="space">
            <asp:Label ID="emailLbl" runat="server" Text="E-Mail" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="emailTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator5" controltovalidate="emailTxt" errormessage="*" />
      
               </div>
        
           <div class="space">
            <asp:Label ID="mobileLbl" runat="server" Text="Mobile Number" Width="30%"></asp:Label>
            &nbsp;
               

            <asp:TextBox CssClass="textboxspace" ID="mobileTxt" onkeypress= "return (!(event.keyCode>=65) && event.keyCode!=32 && this.value.length<=10);" runat="server" Width="60%" Enabled="False"></asp:TextBox>
               <asp:requiredfieldvalidator style="color: red;" runat="server" id="RequiredFieldValidator6" controltovalidate="mobileTxt" errormessage="*" />
        </div>

            </div>





            <button class="accordion" onclick="return false;" >Address</button>
<div class="panel">
     <div class="space">
            <asp:Label ID="address1Lbl" runat="server" Text="Address Line 1" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="address1Txt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator7" controltovalidate="address1Txt" errormessage="*" />

        </div>
         
                       <div class="space">
            <asp:Label ID="address2Lbl" runat="server" Text="Address Line 2" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="address2Txt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             

        </div>
                                <div class="space">
            <asp:Label ID="cityLbl" runat="server" Text="City" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="cityTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator9" controltovalidate="cityTxt" errormessage="*" />

        </div>

        <div class="space">
            <asp:Label ID="postCodelbl" runat="server" Text="PostCode" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="postCodeTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator10" controltovalidate="postCodeTxt" errormessage="*" />

        </div>
</div>

            <button class="accordion" onclick="return false;" >Card</button>
<div class="panel">
     <div class="space">
            <asp:Label ID="nocLbl" runat="server" Text="Name On Card" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="nocTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator11" controltovalidate="nocTxt" errormessage="*" />

        </div>

            <div class="space">
            <asp:Label ID="cardNumLbl" runat="server" Text="Card Number" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="cardNumTxt" onkeypress= "return (!(event.keyCode>=65) && event.keyCode!=32 && this.value.length<=15);" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator12" controltovalidate="cardNumTxt" errormessage="*" />

        </div>

    <div class="space">
            <asp:Label ID="expiaryLbl" runat="server" Text="Expiration Date" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="expiaryTxt" runat="server" Width="60%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator8" controltovalidate="nocTxt" errormessage="*" />

        </div>

       

    <div class="space"> 
         <asp:Label ID="cvcLbl" runat="server" Text="CVC" Width="30%"></asp:Label>
            &nbsp;

            <asp:TextBox CssClass="textboxspace"  ID="cvcTxt" onkeypress= "return (!(event.keyCode>=65) && event.keyCode!=32 && this.value.length<=2);" runat="server" Width="20%" Enabled="False"></asp:TextBox>
             <asp:RequiredFieldValidator style="color:red;" runat="server" id="RequiredFieldValidator13" controltovalidate="cvcTxt" errormessage="*" />

    </div>


    </div>

               
             <asp:Button autopostback="false" ID="delAccount"  CssClass="button" width="30%" style=" margin:20px;"  runat="server" Text="Delete Account" OnClick="delAccount_Click"  />
        


          </div>
          

    <style>
        .accordion {
    background-color: #eee;
    color: #444;
    cursor: pointer;
    padding: 18px;
    width: 100%;
    border: none;
    text-align: left;
    outline: none;
    font-size: 15px;
    transition: 0.4s;
}

    .active, .accordion:hover {
        background-color: #ccc;
    }

    .accordion:after {
        content: '\002B';
        color: #777;
        font-weight: bold;
        float: right;
        margin-left: 5px;
    }

.active:after {
    content: "\2212";
}

.panel {
    padding: 0 18px;
    background-color: white;
    max-height: 0;
    overflow: hidden;
    transition: max-height 0.2s ease-out;
}


</style>

       <script>
           var acc = document.getElementsByClassName("accordion");
           var i;
           

           for (i = 0; i < acc.length; i++) {
               acc[i].addEventListener("click", function () {
               
                  
                   this.classList.toggle("active");
                   var panel = this.nextElementSibling;
                   if (panel.style.maxHeight) {
                       panel.style.maxHeight = null;
                   } else {
                       panel.style.maxHeight = panel.scrollHeight + "px";
                   }
               });
           }
</script>
</asp:Content>
